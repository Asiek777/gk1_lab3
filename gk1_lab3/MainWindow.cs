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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void curvePictureBox_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawBezier(Pens.Black, 100, 100,
                200, 300,
                100, 400,
                400, 400);
        }
    }
}
