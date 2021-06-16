using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    public class Game
    {
        // Simulated Event Store
        private readonly List<Event> events =
            new List<Event>();

        // Command and Command handler at the same time for simplicity
        public void Roll(int pins)
        {
            EmitEvent(new Rolled { Pins = pins });
            var context = new ContextAggregate(events);

            AssignRollAsBonusForPendingFrame(context, pins);
            SetNextRollForBonusIfEarned(context);

            EndFrameIfNeededAndAddFrameScore(context, pins);
        }

        // Query example
        public int Score()
        {
            return events.OfType<ScoreEvent>()
                .Select(x => x.Pins)
                .Sum();
        }

        // Helper methods for Command handler

        private void EndFrameIfNeededAndAddFrameScore(ContextAggregate context, int pins)
        {
            if (context.FrameNumber >= 10) return;

            if (pins == 10 || context.NumberOfRollsInCurrentFrame == 2)
                EmitEvent(new FrameCompleted
                {
                    FrameNumber = context.FrameNumber,
                    Pins = context.TotalPinsInCurrentFrame
                });
        }

        private void SetNextRollForBonusIfEarned(ContextAggregate context)
        {
            if (context.FrameNumber >= 10) return;

            if (context.TotalPinsInCurrentFrame == 10)
                EmitEvent(new SpareBonusEarned());
        }

        private void AssignRollAsBonusForPendingFrame(ContextAggregate context, int pins)
        {
            if (context.SpareBonusPending)
                EmitEvent(new SpareBonusAssigned { Pins = pins });
        }

        private void EmitEvent(Event @event)
        {
            events.Add(@event);
        }
    }
}
