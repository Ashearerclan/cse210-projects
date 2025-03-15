public class OutdoorGathering : Event
{
    public string WeatherForecast { get; }

    public OutdoorGathering(string title, string description, string date, string time, Address location, string weatherForecast)
        : base(title, description, date, time, location)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather Forecast: {WeatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {Title}\nDate: {Date}";
    }
}