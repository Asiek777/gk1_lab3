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
        Point p1, p2, p3, p4;

        public Curve(Color color)
        {
            Color = color;
            p1 = new Point(left, down);
            p2 = new Point(left + (right - left) / 3, up + 2 * (down - up) / 3);
            p3 = new Point(left + 2 * (right - left) / 3, up + (down - up) / 3);
            p4 = new Point(right, up);
        }
        public IEnumerable<Point> GetPoints()
        {
            yield return P1;
            yield return P2;
            yield return P3;
            yield return P4;
        }

        public Point P1 { get => p1; set => p1 = value; }
        public Point P2 { get => p2; set => p2 = value; }
        public Point P3 { get => p3; set => p3 = value; }
        public Point P4 { get => p4; set => p4 = value; }
        public Color Color { get; set; }

        public class Point
        {
            internal int X, Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public static implicit operator System.Drawing.Point(Point v) => 
                new System.Drawing.Point(v.X, v.Y);
        }
    }
}
