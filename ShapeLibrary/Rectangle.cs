namespace ShapeLibrary
{
    public class Rectangle 
    {
        public double Area(double l, double b)
        {
            return l*b;
        }

        public double Perimeter(double l, double b)
        {
            return 2*(l+b);
        }
    }
}