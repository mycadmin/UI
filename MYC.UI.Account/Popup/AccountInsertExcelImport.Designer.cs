namespace MYC.UI.Account.Popup
{
    partial class AccountInsertExcelImport
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
            this.gd_list = new Control.MYCGrid();
            this.rdoBank = new System.Windows.Forms.RadioButton();
            this.rdoCard = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gd_list)).BeginInit();
            this.SuspendLayout();
            // 
            // gd_list
            // 
            this.gd_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gd_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_list.Location = new System.Drawing.Point(8, 40);
            this.gd_list.Name = "gd_list";
            this.gd_list.RowTemplate.Height = 23;
            this.gd_list.Size = new System.Drawing.Size(1066, 537);
            this.gd_list.TabIndex = 0;
            this.gd_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteSel);
            // 
            // rdoBank
            // 
            this.rdoBank.AutoSize = true;
            this.rdoBank.Location = new System.Drawing.Point(133, 11);
            this.rdoBank.Name = "rdoBank";
            this.rdoBank.Size = new System.Drawing.Size(71, 16);
            this.rdoBank.TabIndex = 3;
            this.rdoBank.Text = "계좌이체";
            this.rdoBank.UseVisualStyleBackColor = true;
            // 
            // rdoCard
            // 
            this.rdoCard.AutoSize = true;
            this.rdoCard.Checked = true;
            this.rdoCard.Location = new System.Drawing.Point(15, 11);
            this.rdoCard.Name = "rdoCard";
            this.rdoCard.Size = new System.Drawing.Size(77, 16);
            this.rdoCard.TabIndex = 2;
            this.rdoCard.TabStop = true;
            this.rdoCard.Text = "현금/카드";
            this.rdoCard.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(988, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 169;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(896, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 168;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // AccountInsertExcelImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 583);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdoBank);
            this.Controls.Add(this.rdoCard);
            this.Controls.Add(this.gd_list);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountInsertExcelImport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ExcelImport";
            this.Load += new System.EventHandler(this.AccountInsertExcelImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.MYCGrid gd_list;
        private System.Windows.Forms.RadioButton rdoBank;
        private System.Windows.Forms.RadioButton rdoCard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}