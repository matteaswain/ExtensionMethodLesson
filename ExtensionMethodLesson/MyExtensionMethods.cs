using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodLesson
{
   static class MyExtensionMethods
    {

        public static string ToUpperCare(this string s)
        {
            return s.ToUpper();
        }
        public static void ToConsole(this string str)
        {
            Console.WriteLine($"Who runs the world? {str}");
        }

    }
}
