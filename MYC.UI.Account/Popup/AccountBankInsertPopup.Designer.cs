namespace MYC.UI.Account.Popup
{
    partial class AccountBankInsertPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountBankInsertPopup));
            this.cboBank = new MYC.Control.CheckComboBox();
            this.cboType = new MYC.Control.CheckComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.cboUser = new MYC.Control.CheckComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankDesc = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtBankImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboBank
            // 
            this.cboBank.DisplayMember = "ITEM_NM";
            this.cboBank.DropDownHeight = 1;
            this.cboBank.FormattingEnabled = true;
            this.cboBank.IntegralHeight = false;
            this.cboBank.Location = new System.Drawing.Point(108, 37);
            this.cboBank.Margin = new System.Windows.Forms.Padding(0);
            this.cboBank.MultiSelection = false;
            this.cboBank.Name = "cboBank";
            this.cboBank.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboBank.Params")));
            this.cboBank.Size = new System.Drawing.Size(244, 20);
            this.cboBank.Sql = "CommonSearch#getCommonItems";
            this.cboBank.TabIndex = 171;
            this.cboBank.Text = "[SELECT]";
            this.cboBank.ValueMember = "ITEM_CD";
            // 
            // cboType
            // 
            this.cboType.DisplayMember = "ITEM_NM";
            this.cboType.DropDownHeight = 1;
            this.cboType.FormattingEnabled = true;
            this.cboType.IntegralHeight = false;
            this.cboType.Location = new System.Drawing.Point(108, 10);
            this.cboType.Margin = new System.Windows.Forms.Padding(0);
            this.cboType.MultiSelection = false;
            this.cboType.Name = "cboType";
            this.cboType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboType.Params")));
            this.cboType.Size = new System.Drawing.Size(244, 20);
            this.cboType.Sql = "CommonSearch#getCommonItems";
            this.cboType.TabIndex = 170;
            this.cboType.Text = "[SELECT]";
            this.cboType.ValueMember = "ITEM_CD";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(12, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 169;
            this.label9.Text = "은      행";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 168;
            this.label10.Text = "항      목";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 172;
            this.label1.Text = "계좌번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBankCode
            // 
            this.txtBankCode.Location = new System.Drawing.Point(108, 63);
            this.txtBankCode.MaxLength = 1000;
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(244, 21);
            this.txtBankCode.TabIndex = 173;
            // 
            // cboUser
            // 
            this.cboUser.DisplayMember = "ITEM_NM";
            this.cboUser.DropDownHeight = 1;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.IntegralHeight = false;
            this.cboUser.Location = new System.Drawing.Point(108, 91);
            this.cboUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboUser.MultiSelection = false;
            this.cboUser.Name = "cboUser";
            this.cboUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboUser.Params")));
            this.cboUser.Size = new System.Drawing.Size(244, 20);
            this.cboUser.Sql = "CommonSearch#getUserList";
            this.cboUser.TabIndex = 175;
            this.cboUser.Text = "[SELECT]";
            this.cboUser.ValueMember = "ITEM_CD";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 174;
            this.label2.Text = "통장 소지자";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 176;
            this.label3.Text = "비      고";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBankDesc
            // 
            this.txtBankDesc.Location = new System.Drawing.Point(108, 118);
            this.txtBankDesc.MaxLength = 1000;
            this.txtBankDesc.Name = "txtBankDesc";
            this.txtBankDesc.Size = new System.Drawing.Size(244, 21);
            this.txtBankDesc.TabIndex = 177;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(265, 144);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(86, 21);
            this.btnFile.TabIndex = 180;
            this.btnFile.Text = "파일첨부";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.FileUpload);
            // 
            // txtBankImage
            // 
            this.txtBankImage.Location = new System.Drawing.Point(108, 144);
            this.txtBankImage.MaxLength = 1000;
            this.txtBankImage.Name = "txtBankImage";
            this.txtBankImage.ReadOnly = true;
            this.txtBankImage.Size = new System.Drawing.Size(149, 21);
            this.txtBankImage.TabIndex = 179;
            this.txtBankImage.Click += new System.EventHandler(this.ViewFile);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 178;
            this.label4.Text = "통장사본";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(202, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 182;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.FormClose);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(79, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 181;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // AccountBankInsertPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 230);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtBankImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBankDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBankCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBank);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountBankInsertPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "통장 추가";
            this.Load += new System.EventHandler(this.AccountBankInsertPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.CheckComboBox cboBank;
        private Control.CheckComboBox cboType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBankCode;
        private Control.CheckComboBox cboUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBankDesc;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtBankImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}