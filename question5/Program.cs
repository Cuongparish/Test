using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(ConvertTo12HourFormat("09:53")); // Output: 9:53AM
        Console.WriteLine(ConvertTo12HourFormat("17:29")); // Output: 5:29PM
    }

    static string ConvertTo12HourFormat(string time24)
    {
        // split hour, minute
        string[] parts = time24.Split(':');
        int hour = int.Parse(parts[0]);
        int minute = int.Parse(parts[1]);

        // check PM or AM
        string period = hour >= 12 ? "PM" : "AM";

        // convert 12-hour format
        hour = hour % 12;
        hour = hour == 0 ? 12 : hour;

        return $"{hour}:{minute:D2}{period}";
    }
}
