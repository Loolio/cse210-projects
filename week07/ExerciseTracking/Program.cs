using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>


       {
            new Running("2023-10-01", 30, 5.0),
            new Cycling("2023-10-02", 45, 20.0),
            new Swimming("2023-10-03", 60, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
