using System;

namespace AverageCostBootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var DaysOfCamp = 65;
            var CostOfCamp = 15500m;
            var CostPerDay = CostOfCamp/DaysOfCamp;
            Console.WriteLine($"The cost of this bootcamp per day is ${CostPerDay}");
        }
    }
}
