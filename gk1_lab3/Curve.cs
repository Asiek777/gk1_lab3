using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace gk1_lab3
{
    class Curve
    {
        static readonly int margin = 10;
        static int down = 404 - margin, up = margin; 
        static int left = margin, right = 446 - margin;
        Point[] points = new Point[4];

        public Curve(Color color)
        {
            Color = color;
            points[0] = new Point(left, down, 0);
            points[1] = new Point(left + (right - left) / 3, up + 2 * (down - up) / 3, 1);
            points[2] = new Point(left + 2 * (right - left) / 3, up + (down - up) / 3, 2);
            points[3] = new Point(right, up, 3);
        }
        public IEnumerable<Point> GetPoints() =>
            points;

        public byte[] calcValues()
        {
            bool isComplexOk(System.Numerics.Complex c) =>
                c.Real >= -0.1 && c.Real <= 1.1 && Math.Abs(c.Imaginary)<0.0001;

            byte[] result = new byte[256];
            double t3 = P4.X - 3 * P3.X + 3 * P2.X - P1.X;
            double t2 = 3 * (P3.X - 2 * P2.X + P1.X);
            double t1 = 3 * (P2.X - P1.X);
            double y3 = P4.Y - 3 * P3.Y + 3 * P2.Y - P1.Y;
            double y2 = 3 * (P3.Y - 2 * P2.Y + P1.Y);
            double y1 = 3 * (P2.Y - P1.Y);
            double y0 = P1.Y;

            for (int i = 0; i < 256; i++)
            {
                double x = left + i * ((right - left) / (double)255);

                double t0 = P1.X - x;
                double r = -1;
                System.Numerics.Complex r1, r2, r3;
                if (t3 != 0)
                {
                    (r1, r2, r3) = FindRoots.Cubic(t0, t1, t2, t3);
                    r = isComplexOk(r3) ? r3.Real : r;
                    r = isComplexOk(r2) ? r2.Real : r;
                    r = isComplexOk(r1) ? r1.Real : r;
                }
                else if (t2 != 0)
                {
                    (r1, r2) = FindRoots.Quadratic(t0, t1, t2);
                    r = isComplexOk(r2) ? r2.Real : r;
                    r = isComplexOk(r1) ? r1.Real : r;
                }
                else if (t1 != 0)
                {
                    r = -t0 / t1;
                }
                else
                    r = 0;
                //if (r == -1)
                //    throw new System.Exception("cos sie popsulo");
                r = r < 0 ? 0 : r;
                r = r > 1 ? 1 : r;

                double y = y0 + y1 * r + y2 * r * r + y3 * r * r * r;
                result[i] = (byte)((1 - ((y - up) / (down - up))) * 255);
            }
            return result;
        }

        private void fixPointPosistion(Point p)
        {
            p.X = p.X > right - 3 + p.Num ? right - 3 + p.Num : p.X;
            p.X = p.X < left + p.Num ? left + p.Num : p.X;
            p.Y = p.Y > down ? down : p.Y;
            p.Y = p.Y < up ? up : p.Y;
        }

        internal void setPoint(int dx, int dy, int pNum) =>
            changePointPosition(dx - points[pNum].X, dy - points[pNum].Y, pNum);


        internal void changePointPosition(int dx, int dy, int pNum)
        {
            if (pNum > 0)
            {
                points[pNum].Y += dy;
                points[pNum].X += pNum < 3 ? dx : 0;
                fixPointPosistion(points[pNum]);
                if (points[1].X > points[2].X)
                {
                    if (pNum == 1)
                        points[2].X = points[1].X + 1;
                    else
                        points[1].X = points[2].X - 1;
                }
            }
        }

        public Point P1 { get => points[0]; }
        public Point P2 { get => points[1]; }
        public Point P3 { get => points[2]; }
        public Point P4 { get => points[3]; }
        public Color Color { get; set; }

        public class Point
        {
            internal int X, Y, Num;

            public Point(int x, int y, int num)
            {
                X = x;
                Y = y;
                Num = num;
            }

            public static implicit operator System.Drawing.Point(Point v) => 
                new System.Drawing.Point(v.X, v.Y);

            public double calcDistance(int x, int y) =>
                Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y));
        }
    }
}
