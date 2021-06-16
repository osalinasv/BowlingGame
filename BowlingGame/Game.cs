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
            if (context.FrameNumber >= 10) return;

            SetNextRollForBonusIfEarned(context, pins);
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
            if (pins == 10 || context.NumberOfRollsInCurrentFrame == 2)
                EmitEvent(new FrameCompleted
                {
                    FrameNumber = context.FrameNumber,
                    Pins = context.TotalPinsInCurrentFrame
                });
        }

        private void SetNextRollForBonusIfEarned(ContextAggregate context, int pins)
        {
            if (pins == 10)
                EmitEvent(new StrikeBonusEarned());
            else if (context.TotalPinsInCurrentFrame == 10)
                EmitEvent(new SpareBonusEarned());
        }

        private void AssignRollAsBonusForPendingFrame(ContextAggregate context, int pins)
        {
            if (context.SpareBonusPending)
                EmitEvent(new SpareBonusAssigned { Pins = pins });
            else if (context.StrikeBonusesPending == 1)
                EmitEvent(new StrikeBonusAssigned { Pins = pins });
            // This will handle both the first of the two strike bonuses and also
            // strike bonus accumulation when multiple strikes happen one after another
            else while (context.StrikeBonusesPending-- > 1)
            {
                EmitEvent(new StrikeBonusAssigned { Pins = pins });
            }
        }

        private void EmitEvent(Event @event)
        {
            events.Add(@event);
        }
    }
}
