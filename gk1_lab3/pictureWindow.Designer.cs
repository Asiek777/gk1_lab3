namespace gk1_lab3
{
    partial class pictureWindow
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
            this.cyanPictureBox = new System.Windows.Forms.PictureBox();
            this.magentaPictureBox = new System.Windows.Forms.PictureBox();
            this.yellowPictureBox = new System.Windows.Forms.PictureBox();
            this.blackPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cyanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magentaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cyanPictureBox
            // 
            this.cyanPictureBox.Location = new System.Drawing.Point(12, 12);
            this.cyanPictureBox.Name = "cyanPictureBox";
            this.cyanPictureBox.Size = new System.Drawing.Size(319, 257);
            this.cyanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cyanPictureBox.TabIndex = 0;
            this.cyanPictureBox.TabStop = false;
            // 
            // magentaPictureBox
            // 
            this.magentaPictureBox.Location = new System.Drawing.Point(469, 12);
            this.magentaPictureBox.Name = "magentaPictureBox";
            this.magentaPictureBox.Size = new System.Drawing.Size(319, 257);
            this.magentaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.magentaPictureBox.TabIndex = 1;
            this.magentaPictureBox.TabStop = false;
            // 
            // yellowPictureBox
            // 
            this.yellowPictureBox.Location = new System.Drawing.Point(12, 305);
            this.yellowPictureBox.Name = "yellowPictureBox";
            this.yellowPictureBox.Size = new System.Drawing.Size(319, 257);
            this.yellowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowPictureBox.TabIndex = 2;
            this.yellowPictureBox.TabStop = false;
            // 
            // blackPictureBox
            // 
            this.blackPictureBox.Location = new System.Drawing.Point(469, 305);
            this.blackPictureBox.Name = "blackPictureBox";
            this.blackPictureBox.Size = new System.Drawing.Size(319, 257);
            this.blackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackPictureBox.TabIndex = 3;
            this.blackPictureBox.TabStop = false;
            // 
            // pictureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.blackPictureBox);
            this.Controls.Add(this.yellowPictureBox);
            this.Controls.Add(this.magentaPictureBox);
            this.Controls.Add(this.cyanPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pictureWindow";
            this.Text = "pictureWindow";
            ((System.ComponentModel.ISupportInitialize)(this.cyanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magentaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cyanPictureBox;
        private System.Windows.Forms.PictureBox magentaPictureBox;
        private System.Windows.Forms.PictureBox yellowPictureBox;
        private System.Windows.Forms.PictureBox blackPictureBox;
    }
}