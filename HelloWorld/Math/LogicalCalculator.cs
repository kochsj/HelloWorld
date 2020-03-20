using System;

namespace HelloWorld.Math
{
    public class LogicalCalculator
    {
        public static bool And(bool a, bool b)
        {
            return a && b;
        }
        public static bool Or(bool a, bool b)
        {
            return a || b;
        }
        public static bool StringEquals(string a, string b)
        {
            return a == b;
        }
        public static bool IntEquals(int a, int b)
        {
            return a == b;
        }
        public static bool FloatEquals(float a, float b)
        {
            return a == b;
        }
    }
}
