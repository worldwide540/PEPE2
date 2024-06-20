using System;

class TimeConverter
{
    static string Convert12HourTo24Hour(string time12Hour)
    {
        return DateTime.Parse(time12Hour).ToString("HH:mm");
    }

    static string Convert24HourTo12Hour(string time24Hour)
    {
        return DateTime.ParseExact(time24Hour, "HH:mm", null).ToString("hh:mm tt");
    }

    static void Main()
    {
        string timeIn12HourFormat = "03:30 PM"; // Время в формате 12-часового
        string timeIn24HourFormat = Convert12HourTo24Hour(timeIn12HourFormat);
        Console.WriteLine($"{timeIn12HourFormat} в 24-часовом формате: {timeIn24HourFormat}");

        string newTimeIn12HourFormat = Convert24HourTo12Hour(timeIn24HourFormat);
        Console.WriteLine($"{timeIn24HourFormat} в 12-часовом формате: {newTimeIn12HourFormat}");
    }
}
