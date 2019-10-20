using System;

namespace App
{
    public static class LocalMethods
    {
        public static void Usage()
        {
            int x = 10;
            PrintAndIncrementX();
            PrintAndIncrementX(); 

            void PrintAndIncrementX()
            {
                Console.WriteLine($"x={x}");
                x++;
            }
        }
    }
}
