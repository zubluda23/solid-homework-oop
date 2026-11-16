using System;

namespace Solid_3 
{
    
    public interface IShape
    {
        int GetArea();
    }

    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    
    public class Square : IShape
    {
        public int Side { get; set; }

        public int GetArea()
        {
            return Side * Side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShape rect = new Rectangle { Width = 5, Height = 10 };
            IShape square = new Square { Side = 5 };

            Console.WriteLine($"Area of a rectangle: {rect.GetArea()}"); 
            Console.WriteLine($"Area of a square: {square.GetArea()}");    
            Console.ReadKey();
        }
    }
}
// В.: Порушено принцип підстановки Барбари Лісков.