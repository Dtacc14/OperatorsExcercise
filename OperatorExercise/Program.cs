using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int quotient  = a / b;
            int remainder = a % b;

            if (a== 17 && b== 4)
            { 
                Console.WriteLine($"17/4 is {quotient} remainder {remainder}");
            }

            AreaOfCircle();
        }
        public static void AreaOfCircle()
        { 
            Console.WriteLine("What is the redius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var r = Math.PI * Math.Pow(radius,2);
            Console.WriteLine($"The area of a circle with radius of {radius} is {r}");
        }
    }
}
