using System;

class Program
{
    static void Main()
    {
        Address location1 = new Address("123 Main St", "New York", "NY", "USA");
        Address location2 = new Address("456 Elm St", "Los Angeles", "CA", "USA");
        Address location3 = new Address("789 Oak St", "Seattle", "WA", "USA");

        Event lecture = new Lecture("Tech Talk", "A lecture on AI advancements", "04/15/2025", "10:00 AM", location1, "Dr. Smith", 100);
        Event reception = new Reception("Networking Night", "A chance to meet professionals", "05/20/2025", "6:00 PM", location2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Park Meetup", "Casual social event in the park", "06/10/2025", "2:00 PM", location3, "Sunny and 75°F");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("-----------------------------------");
        }
    }
}
