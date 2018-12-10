namespace gk1_lab3
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.showCurvesCheckBox = new System.Windows.Forms.CheckBox();
            this.blackRadioBut = new System.Windows.Forms.RadioButton();
            this.yellowRadioBut = new System.Windows.Forms.RadioButton();
            this.magentaRadioBut = new System.Windows.Forms.RadioButton();
            this.cyanRadioBut = new System.Windows.Forms.RadioButton();
            this.savePictureBut = new System.Windows.Forms.Button();
            this.blackWhiteBut = new System.Windows.Forms.Button();
            this.gcrBut = new System.Windows.Forms.Button();
            this.ucrBut = new System.Windows.Forms.Button();
            this.back100But = new System.Windows.Forms.Button();
            this.back0But = new System.Windows.Forms.Button();
            this.loadCurveBut = new System.Windows.Forms.Button();
            this.saveCurveBut = new System.Windows.Forms.Button();
            this.changePictureBut = new System.Windows.Forms.Button();
            this.showPicturesBut = new System.Windows.Forms.Button();
            this.curvePictureBox = new System.Windows.Forms.PictureBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curvePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.showCurvesCheckBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.blackRadioBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.yellowRadioBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.magentaRadioBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.cyanRadioBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.savePictureBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.blackWhiteBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.gcrBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.ucrBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.back100But);
            this.mainSplitContainer.Panel1.Controls.Add(this.back0But);
            this.mainSplitContainer.Panel1.Controls.Add(this.loadCurveBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.saveCurveBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.changePictureBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.showPicturesBut);
            this.mainSplitContainer.Panel1.Controls.Add(this.curvePictureBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.imagePictureBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(1007, 598);
            this.mainSplitContainer.SplitterDistance = 470;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // showCurvesCheckBox
            // 
            this.showCurvesCheckBox.AutoSize = true;
            this.showCurvesCheckBox.Checked = true;
            this.showCurvesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCurvesCheckBox.Location = new System.Drawing.Point(12, 541);
            this.showCurvesCheckBox.Name = "showCurvesCheckBox";
            this.showCurvesCheckBox.Size = new System.Drawing.Size(101, 17);
            this.showCurvesCheckBox.TabIndex = 15;
            this.showCurvesCheckBox.Text = "Show all curves";
            this.showCurvesCheckBox.UseVisualStyleBackColor = true;
            this.showCurvesCheckBox.CheckedChanged += new System.EventHandler(this.showCurvesCheckBox_CheckedChanged);
            // 
            // blackRadioBut
            // 
            this.blackRadioBut.AutoSize = true;
            this.blackRadioBut.Checked = true;
            this.blackRadioBut.Location = new System.Drawing.Point(12, 518);
            this.blackRadioBut.Name = "blackRadioBut";
            this.blackRadioBut.Size = new System.Drawing.Size(65, 17);
            this.blackRadioBut.TabIndex = 14;
            this.blackRadioBut.TabStop = true;
            this.blackRadioBut.Text = "(K)Black";
            this.blackRadioBut.UseVisualStyleBackColor = true;
            this.blackRadioBut.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // yellowRadioBut
            // 
            this.yellowRadioBut.AutoSize = true;
            this.yellowRadioBut.Location = new System.Drawing.Point(12, 495);
            this.yellowRadioBut.Name = "yellowRadioBut";
            this.yellowRadioBut.Size = new System.Drawing.Size(56, 17);
            this.yellowRadioBut.TabIndex = 13;
            this.yellowRadioBut.Text = "Yellow";
            this.yellowRadioBut.UseVisualStyleBackColor = true;
            this.yellowRadioBut.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // magentaRadioBut
            // 
            this.magentaRadioBut.AutoSize = true;
            this.magentaRadioBut.Location = new System.Drawing.Point(12, 472);
            this.magentaRadioBut.Name = "magentaRadioBut";
            this.magentaRadioBut.Size = new System.Drawing.Size(67, 17);
            this.magentaRadioBut.TabIndex = 12;
            this.magentaRadioBut.Text = "Magenta";
            this.magentaRadioBut.UseVisualStyleBackColor = true;
            this.magentaRadioBut.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // cyanRadioBut
            // 
            this.cyanRadioBut.AutoSize = true;
            this.cyanRadioBut.Location = new System.Drawing.Point(12, 449);
            this.cyanRadioBut.Name = "cyanRadioBut";
            this.cyanRadioBut.Size = new System.Drawing.Size(49, 17);
            this.cyanRadioBut.TabIndex = 11;
            this.cyanRadioBut.Text = "Cyan";
            this.cyanRadioBut.UseVisualStyleBackColor = true;
            this.cyanRadioBut.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // savePictureBut
            // 
            this.savePictureBut.Location = new System.Drawing.Point(377, 525);
            this.savePictureBut.Name = "savePictureBut";
            this.savePictureBut.Size = new System.Drawing.Size(68, 52);
            this.savePictureBut.TabIndex = 10;
            this.savePictureBut.Text = "Save Pictures";
            this.savePictureBut.UseVisualStyleBackColor = true;
            // 
            // blackWhiteBut
            // 
            this.blackWhiteBut.Location = new System.Drawing.Point(377, 442);
            this.blackWhiteBut.Name = "blackWhiteBut";
            this.blackWhiteBut.Size = new System.Drawing.Size(68, 68);
            this.blackWhiteBut.TabIndex = 9;
            this.blackWhiteBut.Text = "Black and White";
            this.blackWhiteBut.UseVisualStyleBackColor = true;
            // 
            // gcrBut
            // 
            this.gcrBut.Location = new System.Drawing.Point(129, 554);
            this.gcrBut.Name = "gcrBut";
            this.gcrBut.Size = new System.Drawing.Size(98, 23);
            this.gcrBut.TabIndex = 8;
            this.gcrBut.Text = "GCR";
            this.gcrBut.UseVisualStyleBackColor = true;
            // 
            // ucrBut
            // 
            this.ucrBut.Location = new System.Drawing.Point(129, 525);
            this.ucrBut.Name = "ucrBut";
            this.ucrBut.Size = new System.Drawing.Size(98, 23);
            this.ucrBut.TabIndex = 7;
            this.ucrBut.Text = "UCR";
            this.ucrBut.UseVisualStyleBackColor = true;
            // 
            // back100But
            // 
            this.back100But.Location = new System.Drawing.Point(129, 479);
            this.back100But.Name = "back100But";
            this.back100But.Size = new System.Drawing.Size(98, 31);
            this.back100But.TabIndex = 6;
            this.back100But.Text = "100% back";
            this.back100But.UseVisualStyleBackColor = true;
            // 
            // back0But
            // 
            this.back0But.Location = new System.Drawing.Point(129, 442);
            this.back0But.Name = "back0But";
            this.back0But.Size = new System.Drawing.Size(98, 31);
            this.back0But.TabIndex = 5;
            this.back0But.Text = "0% back";
            this.back0But.UseVisualStyleBackColor = true;
            // 
            // loadCurveBut
            // 
            this.loadCurveBut.Location = new System.Drawing.Point(255, 554);
            this.loadCurveBut.Name = "loadCurveBut";
            this.loadCurveBut.Size = new System.Drawing.Size(98, 23);
            this.loadCurveBut.TabIndex = 4;
            this.loadCurveBut.Text = "Load Curve";
            this.loadCurveBut.UseVisualStyleBackColor = true;
            // 
            // saveCurveBut
            // 
            this.saveCurveBut.Location = new System.Drawing.Point(255, 525);
            this.saveCurveBut.Name = "saveCurveBut";
            this.saveCurveBut.Size = new System.Drawing.Size(98, 23);
            this.saveCurveBut.TabIndex = 3;
            this.saveCurveBut.Text = "Save Curve";
            this.saveCurveBut.UseVisualStyleBackColor = true;
            // 
            // changePictureBut
            // 
            this.changePictureBut.Location = new System.Drawing.Point(255, 479);
            this.changePictureBut.Name = "changePictureBut";
            this.changePictureBut.Size = new System.Drawing.Size(98, 31);
            this.changePictureBut.TabIndex = 2;
            this.changePictureBut.Text = "Change Picture";
            this.changePictureBut.UseVisualStyleBackColor = true;
            this.changePictureBut.Click += new System.EventHandler(this.changePictureBut_Click);
            // 
            // showPicturesBut
            // 
            this.showPicturesBut.Location = new System.Drawing.Point(255, 442);
            this.showPicturesBut.Name = "showPicturesBut";
            this.showPicturesBut.Size = new System.Drawing.Size(98, 31);
            this.showPicturesBut.TabIndex = 1;
            this.showPicturesBut.Text = "Show Pictures";
            this.showPicturesBut.UseVisualStyleBackColor = true;
            // 
            // curvePictureBox
            // 
            this.curvePictureBox.BackColor = System.Drawing.Color.White;
            this.curvePictureBox.Location = new System.Drawing.Point(12, 12);
            this.curvePictureBox.Name = "curvePictureBox";
            this.curvePictureBox.Size = new System.Drawing.Size(445, 404);
            this.curvePictureBox.TabIndex = 0;
            this.curvePictureBox.TabStop = false;
            this.curvePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.curvePictureBox_Paint);
            this.curvePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.curvePictureBox_MouseDown);
            this.curvePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.curvePictureBox_MouseUp);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.Color.White;
            this.imagePictureBox.Location = new System.Drawing.Point(15, 79);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(506, 448);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 0;
            this.imagePictureBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 598);
            this.Controls.Add(this.mainSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.curvePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Button saveCurveBut;
        private System.Windows.Forms.Button changePictureBut;
        private System.Windows.Forms.Button showPicturesBut;
        private System.Windows.Forms.PictureBox curvePictureBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.CheckBox showCurvesCheckBox;
        private System.Windows.Forms.RadioButton blackRadioBut;
        private System.Windows.Forms.RadioButton yellowRadioBut;
        private System.Windows.Forms.RadioButton magentaRadioBut;
        private System.Windows.Forms.RadioButton cyanRadioBut;
        private System.Windows.Forms.Button savePictureBut;
        private System.Windows.Forms.Button blackWhiteBut;
        private System.Windows.Forms.Button gcrBut;
        private System.Windows.Forms.Button ucrBut;
        private System.Windows.Forms.Button back100But;
        private System.Windows.Forms.Button back0But;
        private System.Windows.Forms.Button loadCurveBut;
    }
}

