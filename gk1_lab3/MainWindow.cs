using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        BinaryFormatter xs = new BinaryFormatter();

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
        
        private void savePictureBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Filter = "Bitmap File | *.bmp";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(imagePictureBox.Image);
                bitmap.Save(theDialog.FileName + ".bmp", ImageFormat.Bmp);
            }
        }

        private void showPicturesBut_Click(object sender, EventArgs e)
        {
            Bitmap baseImage = new Bitmap(imagePictureBox.Image);
            Bitmap blackImage = new Bitmap(baseImage.Width, baseImage.Height);
            Bitmap cyanImage = new Bitmap(baseImage.Width, baseImage.Height);
            Bitmap magentaImage = new Bitmap(baseImage.Width, baseImage.Height);
            Bitmap yellowImage = new Bitmap(baseImage.Width, baseImage.Height);
            byte[] Fc = cyanCurve.calcValues();
            byte[] Fm = magentaCurve.calcValues();
            byte[] Fy = yellowCurve.calcValues();
            byte[] Fk = blackCurve.calcValues();
            byte C, M, Y, K;

            for (int i = 0; i < baseImage.Width; i++)
                for (int j = 0; j < baseImage.Height; j++)
                {
                    Color c = baseImage.GetPixel(i, j);
                    C = (byte)(byte.MaxValue - c.R);
                    M = (byte)(byte.MaxValue - c.G);
                    Y = (byte)(byte.MaxValue - c.B);
                    K = Math.Min(Math.Min(C, M), Y);

                    cyanImage.SetPixel(i, j, Color.FromArgb(correct(255 - C + K - Fc[K]), 255, 255));
                    magentaImage.SetPixel(i, j, Color.FromArgb(255, correct(255 - M + K - Fm[K]), 255));
                    yellowImage.SetPixel(i, j, Color.FromArgb(255, 255, correct(255 - Y + K - Fy[K])));
                    blackImage.SetPixel(i, j, Color.FromArgb(255 - Fk[K], 255 - Fk[K], 255 - Fk[K]));
                }
            pictureWindow pictures = new pictureWindow(cyanImage, magentaImage, 
                yellowImage, blackImage);
            pictures.ShowDialog();
        }

        byte correct(int x)
        {
            if (x > 255)
                return 255;
            else if (x < 0)
                return 0;
            else
                return (byte)x;
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

        private void saveCurveBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Filter = "Curve File | *.curve";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(theDialog.FileName, FileMode.Create);
                CurveAggregate aggregator = new CurveAggregate(blackCurve, cyanCurve,
                    magentaCurve, yellowCurve);
                xs.Serialize(fs, aggregator);
                fs.Close();
            }
        }

        private void loadCurveBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Load Curve File";
            theDialog.Filter = "Curve File | *.curve";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = theDialog.FileName;
                loadCurve(fileName);
            }
        }

        private void loadCurve(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            CurveAggregate aggregate = (CurveAggregate)xs.Deserialize(fs);
            fs.Close();
            blackCurve = aggregate.blackCurve;
            cyanCurve = aggregate.cyanCurve;
            magentaCurve = aggregate.magentaCurve;
            yellowCurve = aggregate.yellowCurve;
            radioButtons_CheckedChanged(this, new EventArgs());
            curvePictureBox.Refresh();
        }

        private void blackWhiteBut_Click(object sender, EventArgs e)
        {
            Bitmap baseImage = new Bitmap(imagePictureBox.Image);
            Bitmap newBitmap = new Bitmap(imagePictureBox.Image);
            for (int i = 0; i < baseImage.Width; i++)
                for (int j = 0; j < baseImage.Height; j++)
                {
                    Color c = baseImage.GetPixel(i, j);
                    byte white = (byte)(0.229 * c.R + 0.587 * c.G + 0.114 * c.B);
                    newBitmap.SetPixel(i, j, Color.FromArgb(white, white, white));
                }
            imagePictureBox.Image = newBitmap;
        }


        private void ucrBut_Click(object sender, EventArgs e) => 
            loadCurve("../../ucr.curve");

        private void gcrBut_Click(object sender, EventArgs e) =>
            loadCurve("../../gcr.curve");
        
        private void back0But_Click(object sender, EventArgs e)
        {
            cyanCurve = new Curve(Color.Cyan);
            magentaCurve.setPoint(181, 322, 1);
            magentaCurve.setPoint(308, 197, 2);
            magentaCurve.setPoint(436, 10, 3);
            yellowCurve.setPoint(197, 324, 1);
            yellowCurve.setPoint(345, 179, 2);
            yellowCurve.setPoint(436, 10, 3);
            blackCurve.setPoint(10, 394, 1);
            blackCurve.setPoint(10, 394, 2);
            blackCurve.setPoint(10, 394, 3);
            curvePictureBox.Refresh();

        }

        private void back100But_Click(object sender, EventArgs e)
        {
            blackCurve = new Curve(Color.Black);
            cyanCurve.setPoint(10, 394, 1);
            cyanCurve.setPoint(10, 394, 2);
            cyanCurve.setPoint(10, 394, 3);
            magentaCurve.setPoint(10, 394, 1);
            magentaCurve.setPoint(10, 394, 2);
            magentaCurve.setPoint(10, 394, 3);
            yellowCurve.setPoint(10, 394, 1);
            yellowCurve.setPoint(10, 394, 2);
            yellowCurve.setPoint(10, 394, 3);
            curvePictureBox.Refresh();
        }
    }
}
