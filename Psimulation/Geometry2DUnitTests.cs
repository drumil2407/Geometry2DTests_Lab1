using System;

namespace Psimulation
{

    namespace Geometry2D
    {

        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x = 0, double y = 0)
            {
                X = x;
                Y = y;
            }
            //Alternate way to get coordinates
            /*public double[] Getcordinate()
            {
                double[] gvalue = new double[] { X, Y };
                return gvalue;
            }
            */
            public void GetCordinate(out double x, out double y)
            {

                x = X;
                y = Y;

            }

            public void SetCordinate(double? x, double? y)    // double question checks if it is null or not
            {
                X = x ?? X;
                Y = y ?? Y;

            }

        }

        public class Vector
        {

            public double DX { get; private set; }
            public double DY { get; private set; }

            public Vector(double dX = 0, double dY = 0)
            {

            }

            public void Set(double dx, double dy)
            {
                //bool InRange(double dx) => dx <= -10 || dx >= 10;

                //if (InRange(dx) && InRange(dy))
                if (dx <= -1 && dx >= 1 || dy <= -1 && dy >= 1)
                {
                    dx = DX;
                    dy = DY;
                }
                
            }

            //private bool Inrange(double x)
            //{
            //    return x <= -1 || x >= 1;
            //}


            public override string ToString() => $"({DX},{DY})";

        }

        public class Rectangle
        {
            public  double Length;
            public  double Width;
            public double Area;

            public Rectangle(int v1, int v2)
            {
                Length = v1;
                Width = v2;
                
            }

            //method which calculate area of rectangle
            public void calrect()
            {

                Area = (Length * Width);
                Console.WriteLine(Area);
            
            }
        }



    }


}
