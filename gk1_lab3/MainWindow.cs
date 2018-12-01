using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gk1_lab3
{
    public partial class MainWindow : Form
    {
        Curve blackCurve = new Curve(Color.Black);
        Curve.Point point;
        const int pointSize = 5;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void curvePictureBox_Paint(object sender, PaintEventArgs e)
        {
            drawCurve(e, blackCurve);
            drawPoints(e, blackCurve);
        }

        private void drawCurve(PaintEventArgs e, Curve curve)
        {
            e.Graphics.DrawBezier(new Pen(curve.Color), curve.P1, curve.P2,
                            curve.P3, curve.P4);
        }
        private void drawPoints(PaintEventArgs e, Curve curve)
        {
            foreach (Curve.Point p in curve.GetPoints())
                e.Graphics.DrawEllipse(new Pen(curve.Color),
                    p.X - pointSize, p.Y - pointSize, 2 * pointSize, 2 * pointSize);
        }
    }
}
