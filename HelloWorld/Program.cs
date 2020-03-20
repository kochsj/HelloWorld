using System;
using HelloWorld.Math;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CalculateThings();
            LogicThings();
        }

        public static void CalculateThings()
        {
            var a = Calculator.Add(1, 4);
            var b = Calculator.Subtract(401, 404);
            var c = Calculator.Divide(40, 3);
            var d = Calculator.Multiply(10, 405);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        public static void LogicThings()
        {
            bool a = LogicalCalculator.And(true, false);
            Console.WriteLine(a);
        }
    }
}
