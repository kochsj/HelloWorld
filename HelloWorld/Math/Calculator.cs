using System;

namespace HelloWorld.Math
{
    public class Calculator
    {
        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static float Subtract(float a, float b)
        {
            return a - b;
        }
        public static float Divide(float a, float b)
        {
            return (float)a / (float)b;
        }
        public static float Multiply(float a, float b)
        {
            return a * b;
        }
    }

    public class ValueVsReferenceTypes
    {
        public static void ValueAssignment()
        {
            int a = 10;
            int b = a;
            b++;
            Console.WriteLine(String.Format("A: {0}\nB: {1}", a, b));
            // because int32 is a value type, when b is assigned value, a new position in memory is created.
            // therefore, when we increment b, b increases and a does not
        }

        public static void ReferenceAssignment()
        {
            var arr1 = new int[5]{ 1,2,3,4,5 };
            var arr2 = arr1;
            arr2[4] = 100;
            Console.WriteLine(string.Format("arr1[4]: {0}\narr2[4]: {1}", arr1[4], arr2[4]));
            // because Array is a class in the System namespace, a position on the heap is initialized and assigned for arr1
            // when arr2 is assigned arr1, it points to the same reference of the 'new int array', the same as arr1. the same memory-address
            // when a value is reassigned for either, it is assigned for both. reference type
        }
    }
}
