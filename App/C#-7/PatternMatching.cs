using System;

namespace App
{
    public static class PatternMatching
    {
        public static void ConstantPattern(Object input)
        {
            switch(input)
            {
                case "hello":
                    Console.WriteLine("Input is string hello");
                    break;
                case 5L:
                    Console.WriteLine("Input is long 5");
                    break;
                case 10:
                    Console.WriteLine("Input is int 10");
                    break;
                default:
                    Console.WriteLine("Input didn't match hello, long 5, long 5 or int 10.");
                    break;
            }
        }

        public static void TypePattern(Shape shape)
        {
            switch(shape)
            {
                case null:
                    throw new ArgumentNullException(nameof(shape));
                case Rectangle rectangle:
                    Console.WriteLine($"Input {nameof(shape)} is type Rectangle");
                    break;
                case Circle circle:
                    Console.WriteLine($"Input {nameof(shape)} is type Circle");
                    break;
                case Triangle triangle:
                    Console.WriteLine($"Input {nameof(shape)} is type Triangle");
                    break;
                default:
                    Console.WriteLine($"Input {nameof(shape)} is not a recognised type.");
                    break;
            }
        }

        public static void VarPattern(Shape shape)
        {
            switch(shape ?? CreateSquare())
            {
                case Rectangle rectangle:
                    Console.WriteLine($"Input {nameof(shape)} is type Rectangle");
                    break;
                case Circle circle:
                    Console.WriteLine($"Input {nameof(shape)} is type Circle");
                    break;
                case Triangle triangle:
                    Console.WriteLine($"Input {nameof(shape)} is type Triangle");
                    break;
                case var actualShape:
                    Console.WriteLine($"Shape type is Square");
                    break;
            }
        }

        private static Square CreateSquare()
        {
            return new Square();
        }

        // Guard clause example (using when).
        public static int Fibonacci(int n)
        {
            switch(n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case var _ when n > 1:
                    return Fibonacci(n-2) + Fibonacci(n-1);
                default:
                    throw new ArgumentOutOfRangeException(nameof(n), "Input must be non-negative.");
            }
        }
    }
}
