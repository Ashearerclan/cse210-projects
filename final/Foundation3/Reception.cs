public class Reception : Event
{
    public string RSVPEmail { get; }

    public Reception(string title, string description, string date, string time, Address location, string rsvpEmail)
        : base(title, description, date, time, location)
    {
        RSVPEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP Email: {RSVPEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Reception\nTitle: {Title}\nDate: {Date}";
    }
}