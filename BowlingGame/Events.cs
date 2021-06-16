namespace BowlingGame
{
    public abstract class Event { }

    public class Rolled : Event
    {
        public int Pins { get; set; }
    }

    public abstract class ScoreEvent : Event
    {
        public int Pins { get; set; }
    }

    public class FrameCompleted : ScoreEvent
    {
        public int FrameNumber { get; set; }
    }
}
