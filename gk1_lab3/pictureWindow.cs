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
    public partial class pictureWindow : Form
    {
        public pictureWindow(Bitmap cyanImage, Bitmap magentaImage, 
            Bitmap yellowImage, Bitmap blackImage)
        {
            InitializeComponent();
            cyanPictureBox.Image = cyanImage;
            magentaPictureBox.Image = magentaImage;
            yellowPictureBox.Image = yellowImage;
            blackPictureBox.Image = blackImage;
        }
    }
}
