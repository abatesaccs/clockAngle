using System;

class ClockAngle 
{
    static void Main()
    {
        Console.WriteLine("Please enter an hour");
        int hourInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter minutes");
        int minInput = int.Parse(Console.ReadLine());
    }

    static void convertHours(int hour, int min)
    {
        min = min * .5;
        hour = (hour * 30) + min;
        return hour;
    }

    static void convertMinutes(int min)
    {
        return min * 6;
    }
}