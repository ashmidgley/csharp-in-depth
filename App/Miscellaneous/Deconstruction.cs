namespace App
{
    public class Deconstruction
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        public Deconstruction(double x, double y) => (X, Y) = (x, y);

        public void Deconstruct(out double x, out double y) => (x, y) = (X, Y);
    }
}
