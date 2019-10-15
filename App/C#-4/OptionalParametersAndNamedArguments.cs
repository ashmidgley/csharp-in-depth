using System;

namespace App
{
    public static class OptionalParametersAndNamedArguments
    {
        public static void Usage(int x, int y = 2, int z = 3)
        {
            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
        }
    }
}
