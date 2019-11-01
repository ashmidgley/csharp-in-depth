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

        public static double TypePattern(Shape shape)
        {
            switch(shape)
            {
                case null:
                    throw new ArgumentNullException();
                case Rectangle rectangle:
                    return 2 * (rectangle.Height * rectangle.Width);
                case Circle circle:
                    return 2 * Math.PI * circle.Radius;
                case Triangle triangle:
                    return triangle.SideA + triangle.SideB + triangle.SideC;
                default:
                    throw new ArgumentException("Shape was of unexpected type. Could not calculate perimeter");
            }
        }

        public static double TypePatternOld(Shape shape)
        {
            if(shape == null)
        {
            throw new ArgumentNullException();
        }
        Rectangle rectangle = shape as Rectangle;
        if(rectangle != null)
        {
            return 2 * (rectangle.Height * rectangle.Width);
        }
        Circle circle = shape as Circle;
        if(circle != null)
        {
            return 2 * Math.PI * circle.Radius;
        }
        Triangle triangle = shape as Triangle;
        if(triangle != null)
        {
            return triangle.SideA + triangle.SideB + triangle.SideC;
        }
        throw new ArgumentException("Shape was of unexpected type. Could not calculate perimeter");
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
