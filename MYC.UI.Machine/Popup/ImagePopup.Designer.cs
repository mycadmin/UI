namespace MYC.UI.Machine.Popup
{
    partial class ImagePopup
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
            this.PicImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).BeginInit();
            this.SuspendLayout();
            // 
            // PicImg
            // 
            this.PicImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicImg.Location = new System.Drawing.Point(0, 0);
            this.PicImg.Name = "PicImg";
            this.PicImg.Size = new System.Drawing.Size(800, 450);
            this.PicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImg.TabIndex = 0;
            this.PicImg.TabStop = false;
            // 
            // ImagePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicImg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImagePopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ImagePopup";
            this.Load += new System.EventHandler(this.ImagePopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicImg;
    }
}