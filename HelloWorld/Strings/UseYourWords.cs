using System;

namespace HelloWorld.Strings
{
    public class UseYourWords
    {
        public static string FormatMadLibString(string a, string b)
        {
            return String.Format("The {0} came close to {1} the end.", a, b);
        }

        public static string ListThePeople(string[] a, int length)
        {
            string concatString = "With for loop: ";
            for (int i = 0; i < length; i++)
            {
                concatString += a[i];
                if (i != length-1)
                {
                    concatString += ", ";
                }
            }
            var b = String.Join(", ", a);
            concatString += "\nWith String.Join: ";
            concatString += b;
            return concatString;
        }
    }
}
