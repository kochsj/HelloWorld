using System;
using Math;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = Math.Calculator.Add(1, 4);
            var b = Math.Calculator.Subtract(401, 404);
            var c = Math.Calculator.Divide(40, 3);
            var d = Math.Calculator.Multiply(10, 405);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
