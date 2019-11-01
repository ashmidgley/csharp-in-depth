namespace App
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}
