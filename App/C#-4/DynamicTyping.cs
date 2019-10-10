using System;
using System.Collections.Generic;

namespace App
{
    public static class DynamicTyping
    {
        public static void LocalVariableUsage()
        {
            dynamic text = "Hello World.";
            string word = text.Substring(6);
            Console.WriteLine(word);
        }

        public static void ParameterUsage(List<dynamic> collection)
        {
            foreach(dynamic value in collection)
            {
                Console.WriteLine(value);
            }
        }
    }
}
