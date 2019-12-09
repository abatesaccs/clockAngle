using System;

class ClockAngle {
    static void Main(){
        Console.WriteLine("Please enter a time in HH:MM format");
        string timeInput = Console.ReadLine();
        int hourInput;
        int minInput;
        if(timeInput.Length == 4){
            hourInput = int.Parse(timeInput.Substring(0,1));
            minInput = int.Parse(timeInput.Substring(2));
        } else {
            hourInput = int.Parse(timeInput.Substring(0,2));
            minInput = int.Parse(timeInput.Substring(3));
        }
        double angle = Math.Abs(convertHours(hourInput, minInput) - convertMinutes(minInput));
        Console.WriteLine("Clock Angle: " + convertAngle(angle) + " degrees.");
    }

    static double convertHours(int hour, int min){
        double minDouble = (min * .5);
        double hourDouble = (hour * 30) + minDouble;
        return hourDouble;
    }

    static int convertMinutes(int min){
        return min * 6;
    }

    static double convertAngle(double angle){
        if(angle > 180){
            return 360 - angle;
        } else {
            return angle;
        }
    }
}