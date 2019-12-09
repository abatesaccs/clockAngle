using System;

class ClockAngle 
{
    static void Main()
    {
        Console.WriteLine("Please enter an hour");
        int hourInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter minutes");
        int minInput = int.Parse(Console.ReadLine());
        
        Console.WriteLine(convertHours(hourInput, minInput));
        Console.WriteLine(convertMinutes(minInput));
        
    }

    static double convertHours(int hour, int min)
    {
        double minDouble = (min * .5);
        double hourDouble = (hour * 30) + minDouble;
        return hourDouble;
    }

    static int convertMinutes(int min)
    {
        return min * 6;
    }
}