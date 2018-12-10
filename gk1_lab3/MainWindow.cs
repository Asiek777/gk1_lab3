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
        Curve cyanCurve = new Curve(Color.Cyan);
        Curve magentaCurve = new Curve(Color.Magenta);
        Curve yellowCurve = new Curve(Color.Goldenrod);
        Curve chosenCurve;
        int movedPoint;
        const int pointSize = 5;
        int posX, posY;

        public MainWindow()
        {
            InitializeComponent();
            chosenCurve = blackCurve;
            imagePictureBox.Image = new Bitmap("../../texture.jpg");
        }

        private void curvePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (showCurvesCheckBox.Checked)
                foreach (Curve curve in getCurves())
                    drawCurve(e, curve);
            drawCurve(e, chosenCurve);
            drawPoints(e, chosenCurve);
        }

        private void drawCurve(PaintEventArgs e, Curve curve)
        {
            e.Graphics.DrawBezier(new Pen(curve.Color), curve.P1, curve.P2,
                            curve.P3, curve.P4);
        }

        private void drawPoints(PaintEventArgs e, Curve curve)
        {
            foreach (Curve.Point p in curve.GetPoints())
                e.Graphics.DrawEllipse(new Pen(curve.Color, 2),
                    p.X - pointSize, p.Y - pointSize, 2 * pointSize, 2 * pointSize);
        }

        private IEnumerable<Curve> getCurves()
        {
            yield return cyanCurve;
            yield return magentaCurve;
            yield return yellowCurve;
            yield return blackCurve;
        }

        private void curvePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Curve.Point p = (chosenCurve.GetPoints().OrderBy(point => point.calcDistance(e.X, e.Y)).First());
            if (p.calcDistance(e.X, e.Y) < 7)
            {
                movedPoint = p.Num;
                posX = e.X;
                posY = e.Y;
                curvePictureBox.MouseMove += pointMove;
            }
        }
        private void pointMove(object sender, MouseEventArgs e)
        {

            chosenCurve.changePointPosition(e.X - posX, e.Y - posY, movedPoint);
            curvePictureBox.Refresh();
            posX = e.X;
            posY = e.Y;
        }

        private void curvePictureBox_MouseUp(object sender, MouseEventArgs e) => 
            curvePictureBox.MouseMove -= pointMove;

        private void showCurvesCheckBox_CheckedChanged(object sender, EventArgs e) => 
            curvePictureBox.Refresh();

        private void changePictureBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = new Bitmap(dlg.FileName);
            }
            imagePictureBox.Refresh();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (cyanRadioBut.Checked)
                chosenCurve = cyanCurve;
            else if (magentaRadioBut.Checked)
                chosenCurve = magentaCurve;
            else if (yellowRadioBut.Checked)
                chosenCurve = yellowCurve;
            else if (blackRadioBut.Checked)
                chosenCurve = blackCurve;
            curvePictureBox.Refresh();
        }
    }
}
