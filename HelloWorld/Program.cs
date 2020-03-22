using System;
using HelloWorld.Math;
using HelloWorld.Strings;
using HelloWorld.ObjectEnum;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ints = new int[5] { 5, 10, 15, 20, 25 };
            for (int i = 0; i < ints.Length; i++)
            {
                CalculateThings(ints[i]);
            }
            LogicThings();
            MadLib();
            ListStringsOut();
            MultiLinePrint();
            KeyValuePair();
        }

        public static void CalculateThings(int i)
        {
            var a = Calculator.Add(i, 4);
            var b = Calculator.Subtract(i, 404);
            var c = Calculator.Divide(i, 3);
            var d = Calculator.Multiply(i, 405);
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

        public static void MadLib()
        {
            string a = UseYourWords.FormatMadLibString("red", "rabbit");
            Console.WriteLine(a);
        }

        public static void ListStringsOut()
        {
            var arr = new string[5] { "John", "Jacob", "Jingle", "Himer", "Smith" };
            string a = UseYourWords.ListThePeople(arr, 5);
            Console.WriteLine(a);
        }

        public static void MultiLinePrint()
        {
            string a = UseYourWords.VerbatimString();
            Console.WriteLine(a);
        }

        public static void KeyValuePair()
        {
            // using value casting () we can get a value or a key from our enum
            var key = EnumerationStation.ColorValues.Red;
            Console.WriteLine((int)key);

            // can convert ToString also 
            string keyString = EnumerationStation.ColorValues.Red.ToString();
            Console.WriteLine(keyString);

            var value = 3;
            Console.WriteLine((EnumerationStation.ColorValues)value);

            // convert string to enum
            var color = "Purple";
            var colorMethod = Enum.Parse(typeof(EnumerationStation.ColorValues), color);
            Console.WriteLine((int)colorMethod);
        }
    }
}
