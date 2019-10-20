using System;

namespace App
{
    public static class NumericLiteralImprovements
    {
        public static void Usage()
        {
            byte b4 = 0b_1000_0111;
            int max = 2_147_483_647;
            Console.WriteLine(b4);
            Console.WriteLine(max);
        }
    }
}
