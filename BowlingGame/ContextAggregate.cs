﻿using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    public class ContextAggregate
    {
        public ContextAggregate(IEnumerable<Event> events)
        {
            events.ToList().ForEach(Apply);
        }

        private void Apply(Event e)
        {
            switch (e)
            {
                case Rolled re:
                    TotalPinsInCurrentFrame += re.Pins;
                    NumberOfRollsInCurrentFrame++;
                    break;
                case FrameCompleted _:
                    TotalPinsInCurrentFrame = 0;
                    NumberOfRollsInCurrentFrame = 0;
                    FrameNumber++;
                    break;
            }
        }

        public int FrameNumber { get; private set; }
        public int TotalPinsInCurrentFrame { get; set; }
        public int NumberOfRollsInCurrentFrame { get; set; }
    }
}
