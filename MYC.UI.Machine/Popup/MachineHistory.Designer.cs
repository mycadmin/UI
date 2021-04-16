namespace MYC.UI.Machine.Popup
{
    partial class MachineHistory
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gd_Eqp = new Control.MYCGrid();
            this.tabHistory = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Eqp)).BeginInit();
            this.tabHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gd_Eqp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gd_Eqp
            // 
            this.gd_Eqp.AllowUserToAddRows = false;
            this.gd_Eqp.AllowUserToDeleteRows = false;
            this.gd_Eqp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Eqp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Eqp.Location = new System.Drawing.Point(3, 3);
            this.gd_Eqp.MultiSelect = false;
            this.gd_Eqp.Name = "gd_Eqp";
            this.gd_Eqp.ReadOnly = true;
            this.gd_Eqp.RowHeadersVisible = false;
            this.gd_Eqp.RowTemplate.Height = 23;
            this.gd_Eqp.Size = new System.Drawing.Size(916, 538);
            this.gd_Eqp.TabIndex = 15;
            this.gd_Eqp.DataSourceChanged += new System.EventHandler(this.SetGrid);
            this.gd_Eqp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewHistory);
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.tabPage1);
            this.tabHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHistory.Location = new System.Drawing.Point(0, 0);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.SelectedIndex = 0;
            this.tabHistory.Size = new System.Drawing.Size(930, 570);
            this.tabHistory.TabIndex = 15;
            // 
            // MachineHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 570);
            this.Controls.Add(this.tabHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MachineHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "제품이력조회";
            this.Load += new System.EventHandler(this.MachineHistory_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_Eqp)).EndInit();
            this.tabHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private Control.MYCGrid gd_Eqp;
        private System.Windows.Forms.TabControl tabHistory;
    }
}