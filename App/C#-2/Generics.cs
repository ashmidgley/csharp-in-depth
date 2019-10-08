using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace App 
{
    public static class Generics
    {
        // C# 1 collection implementation.

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

        // C# 2 onwards collection implementation using generics.

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

        // Match checks for testing.

        public static bool CollectionsMatch(ArrayList listOne, List<int> listTwo)
        {
            if(listOne.Count != listTwo.Count)
                return false; 
            for(int i = 0; i < listOne.Count; i++) {
                if((int)listOne[i] != listTwo[i])
                    return false;
            }
            return true;
        }

        public static bool CollectionsMatch(StringCollection listOne, List<string> listTwo)
        {
            if(listOne.Count != listTwo.Count)
                return false; 
            for(int i = 0; i < listOne.Count; i++) {
                if(!listOne[i].Equals(listTwo[i]))
                    return false;
            }
            return true;
        }
    }
}
