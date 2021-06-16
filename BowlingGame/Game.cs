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

        private void EmitEvent(Event @event)
        {
            events.Add(@event);
        }
    }
}
