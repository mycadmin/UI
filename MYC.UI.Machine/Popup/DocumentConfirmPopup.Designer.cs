namespace MYC.UI.Machine.Popup
{
    partial class DocumentConfirmPopup
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
            this.gd_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.SuspendLayout();
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 0);
            this.gd_List.Name = "gd_List";
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.Size = new System.Drawing.Size(800, 450);
            this.gd_List.TabIndex = 9;
            // 
            // DocumentConfirmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gd_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentConfirmPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DocumentConfirmPopup";
            this.Load += new System.EventHandler(this.DocumentConfirmPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gd_List;
    }
}