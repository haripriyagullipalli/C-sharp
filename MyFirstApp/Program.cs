// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

class WeatherSimulator
{
    public static void Main()
    {

        System.Console.WriteLine("enter numbers of days for weather simulator");
        int days = int.Parse(Console.ReadLine());

        int[] temparatures = new int[days];
        string[] conditions = { "snowy", "cloudy", "rainy", "sunny" };
        string[] weatherConditions = new string[days];

        for (int i = 0; i < days; i++)
        {
            Random random = new Random();
            temparatures[i] = random.Next(0, 40);
            weatherConditions[i] = conditions[random.Next(conditions.Length)];
            System.Console.WriteLine("temperature " + temparatures[i] + "conditon i " + weatherConditions[i]);
        }

        System.Console.WriteLine("the average is " + AverageTemperature(temparatures));
        System.Console.WriteLine($"the maximum is {temparatures.Max()} and minimum {temparatures.Min()}");
    }

    static double AverageTemperature(int[] temperatures)
    {
        int sum = temperatures.Aggregate(0, (initial, current) => initial + current);
        return sum / temperatures.Length;
    }
}

