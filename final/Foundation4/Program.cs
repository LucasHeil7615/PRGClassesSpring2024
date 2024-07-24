using System;
using System.Collections.Generic;
using System.Data.Common;

class Program
{
    static void Main()
    {
        // provides a list of the activites 
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 30, 18.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        // prints the activity summaries. 
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
