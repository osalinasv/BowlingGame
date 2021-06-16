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

    public class SpareBonusEarned : Event { }
    public class SpareBonusAssigned : ScoreEvent { }

    public class StrikeBonusEarned : Event { }
    public class StrikeBonusAssigned : ScoreEvent { }
}
