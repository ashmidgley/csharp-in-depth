using System;

namespace App
{
    public static class IsOperator
    {
        public static void Usage()
        {
            object input = "input";
            if(input is string text)
            {
                Console.WriteLine($"Input 1 is type string.");
            }

            object input2 = 200;
            if(input2 is int x && x > 100)
            {
                Console.WriteLine($"Input 2 is type int and greater than 100.");
            }

            object input3 = 1000L;
            if((input3 is int x2 && x2 > 100) || (input3 is long l && l > 100L))
            {
                Console.WriteLine($"Input 3 is type int or long and greater than 100.");
            }
        }
    }
}
