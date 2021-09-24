using System;

namespace AverageCostBootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var DaysOfCamp = 65;
            var CostOfCamp = 15500m;
            var CostPerDay = CostOfCamp / DaysOfCamp;
            var PreMessage = "The cost of this bootcamp per day is $";
            var Message = $"{ PreMessage} {CostPerDay}";
            Console.WriteLine($"{Message}");
            System.Diagnostics.Debug.WriteLine($"{Message}");
        }
    }
}
