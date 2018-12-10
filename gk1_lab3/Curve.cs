using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gk1_lab3
{
    class Curve
    {
        static readonly int margin = 10;
        static int down = 404 - margin, up = margin; 
        static int left = margin, right = 445 - margin;
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

        private void fixPointPosistion(Point p)
        {
            p.X = p.X > right - 3 + p.Num ? right - 3 + p.Num : p.X;
            p.X = p.X < left + p.Num ? left + p.Num : p.X;
            p.Y = p.Y > down ? down : p.Y;
            p.Y = p.Y < up ? up : p.Y;
        }

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
