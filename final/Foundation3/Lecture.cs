public class Lecture : Event
{
    public string Speaker { get; }
    public int Capacity { get; }

    public Lecture(string title, string description, string date, string time, Address location, string speaker, int capacity)
        : base(title, description, date, time, location)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Lecture\nTitle: {Title}\nDate: {Date}";
    }
}