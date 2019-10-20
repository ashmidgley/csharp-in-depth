using System;

namespace App
{
    public static class BitwiseOperators
    {
        public static void And()
        {
            int even = 12;
            int odd = 13;
            Console.WriteLine((even & 1) == 0);
            Console.WriteLine((odd & 1) == 0);
        }
    }
}
