using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace App 
{
    public static class Generics
    {
        public static ArrayList GenerateNumbersOld() 
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            return numbers;
        }

        public static StringCollection GenerateNamesOld()
        {
            StringCollection names = new StringCollection();
            names.Add("Chandler");
            names.Add("Joey");
            return names;
        }

        public static List<int> GenerateNumbersNew() 
        {
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            return numbers;
        }

        public static List<string> GenerateNamesNew()
        {
            var names = new List<string>();
            names.Add("Chandler");
            names.Add("Joey");
            return names;
        }
    }
}
