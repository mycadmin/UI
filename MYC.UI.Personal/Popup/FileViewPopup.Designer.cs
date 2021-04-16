namespace MYC.UI.Personal.Popup
{
    partial class FileViewPopup
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
            this.label8 = new System.Windows.Forms.Label();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 131;
            this.label8.Text = "등록 File List";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstFile
            // 
            this.lstFile.FormattingEnabled = true;
            this.lstFile.ItemHeight = 12;
            this.lstFile.Location = new System.Drawing.Point(14, 30);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(412, 244);
            this.lstFile.TabIndex = 132;
            this.lstFile.SelectedIndexChanged += new System.EventHandler(this.LstFile_SelectedIndexChanged);
            this.lstFile.DoubleClick += new System.EventHandler(this.ViewLink);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(11, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 31);
            this.btnAdd.TabIndex = 144;
            this.btnAdd.Text = "등 록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddLink);
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnView.Enabled = false;
            this.btnView.Location = new System.Drawing.Point(125, 288);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(70, 31);
            this.btnView.TabIndex = 145;
            this.btnView.Text = "보 기";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.ViewLink);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDel.Location = new System.Drawing.Point(239, 288);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 31);
            this.btnDel.TabIndex = 146;
            this.btnDel.Text = "삭 제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.RemoveLink);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Location = new System.Drawing.Point(353, 288);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 31);
            this.btnClose.TabIndex = 147;
            this.btnClose.Text = "닫 기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.FormClose);
            // 
            // FileViewPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 337);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstFile);
            this.Controls.Add(this.label8);
            this.Name = "FileViewPopup";
            this.Text = "File List";
            this.Load += new System.EventHandler(this.FileViewPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstFile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
    }
}