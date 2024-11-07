namespace Assignment1._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4.5, 6.3);
            Point p2 = new Point(6.0, 1.3);
            if (p1.x == p2.x)
            {
                Console.WriteLine("P2 and P1 are on the same axis.");
            }

            else if (p1.x < p2.x)
            {
                Console.WriteLine("P2 is to the right of P1.");
            }
            else
            {
                Console.WriteLine("P2 is to the left of P1.");
            }
        }

        public class Point
        {
            public Point(double xCoord, double yCoord)
            {
                x = xCoord;
                y = yCoord;
            }
            public Point()
            {
                y = 0;
                x = 0;
            }
            public double x;
            public double y;
        }
    }
}