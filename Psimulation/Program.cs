using Psimulation.Geometry2D;
using System;

namespace Psimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();

            Vector p1 = new Vector();

            p1.Set(1, 2);
            p.GetCordinate(out double x, out double y);
            Console.WriteLine($"{x},{y}");

            Rectangle r = new Rectangle(2, 3);
            r.calrect();

        }
    }
}
