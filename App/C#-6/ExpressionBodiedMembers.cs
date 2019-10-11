using System;

namespace App
{
    public class ExpressionBodiedMembers {}

    public struct Point
    {
        public double X { get; }
        public double Y { get; }
        
        // Simpler read-only props.
        public double DistanceFromOriginOld
        {
            get {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
        public double DistanceFromOriginNew => Math.Sqrt(X * X + Y * Y);

        // No expression-bodied constructors.
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Simpler methods.
        public static Point AddOld(Point left, Point right)
        {
            return left + right;
        }

        public static Point operator+(Point left, Point right)
        {
            return new Point(left.X + right.X, left.Y + right.Y);
        }

        public static Point AddNew(Point left, Point right) => left + right;

        public static Point operator-(Point left, Point right) => new Point(left.X + right.X, left.Y + right.Y);
    }
}
