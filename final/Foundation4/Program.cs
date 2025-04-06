using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 2, 16), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 45, 12.0),
            new Swimming(new DateTime(2027, 6, 11), 40, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
