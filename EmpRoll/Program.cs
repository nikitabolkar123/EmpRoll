using System;

namespace LineComp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int WagePerHr = 20;
            int dailyWage = 0;
            int empHrs = 0;
            Random random = new Random();    //it will generate Random Number
            int value = random.Next(0, 2);   //in between 0 and 1 number will generate

            // 0 value for present and 1 for absent

            if (value == 0)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;

            }

            dailyWage = WagePerHr * empHrs; //Calculate dailywages
            Console.WriteLine("Daily Employee wages:" + dailyWage); // it will print total wages
        }
    }
}
