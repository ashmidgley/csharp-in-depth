using System;

namespace App
{
    public static class LambdaExpressions
    {
        public static void CreateSimpleLambda(string input)
        {
            Action<string> action = message =>
            {
                Console.WriteLine($"In delegate: {message}.");
            };
            action(input);
        }

        public static int CreateReturningLambda()
        {
            Func<int, int, int> multiply = (x, y) => x * y;
            return multiply(2, 5);
        }
    }
}
