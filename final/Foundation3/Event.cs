public class Event
{
    public string Title { get; }
    public string Description { get; }
    public string Date { get; }
    public string Time { get; }
    public Address Location { get; }

    public Event(string title, string description, string date, string time, Address location)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Location = location;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nLocation: {Location}";
    }

    public virtual string GetFullDetails() => GetStandardDetails();

    public virtual string GetShortDescription()
    {
        return $"Event Type: General\nTitle: {Title}\nDate: {Date}";
    }
}