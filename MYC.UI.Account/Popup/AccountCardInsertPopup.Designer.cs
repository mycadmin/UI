namespace MYC.UI.Account.Popup
{
    partial class AccountCardInsertPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCardInsertPopup));
            this.cboBank = new MYC.Control.CheckComboBox();
            this.cboType = new MYC.Control.CheckComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCard = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.cboUser = new MYC.Control.CheckComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardDesc = new System.Windows.Forms.TextBox();
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
            this.cboBank.Sql = "CommonSearch#getBankList";
            this.cboBank.TabIndex = 175;
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
            this.cboType.TabIndex = 174;
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
            this.label9.TabIndex = 173;
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
            this.label10.TabIndex = 172;
            this.label10.Text = "항      목";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCard
            // 
            this.cboCard.DisplayMember = "ITEM_NM";
            this.cboCard.DropDownHeight = 1;
            this.cboCard.FormattingEnabled = true;
            this.cboCard.IntegralHeight = false;
            this.cboCard.Location = new System.Drawing.Point(108, 64);
            this.cboCard.Margin = new System.Windows.Forms.Padding(0);
            this.cboCard.MultiSelection = false;
            this.cboCard.Name = "cboCard";
            this.cboCard.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCard.Params")));
            this.cboCard.Size = new System.Drawing.Size(244, 20);
            this.cboCard.Sql = "CommonSearch#getCommonItems";
            this.cboCard.TabIndex = 177;
            this.cboCard.Text = "[SELECT]";
            this.cboCard.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 176;
            this.label1.Text = "카 드 사";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 178;
            this.label2.Text = "카드번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCardCode
            // 
            this.txtCardCode.Location = new System.Drawing.Point(108, 91);
            this.txtCardCode.MaxLength = 1000;
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(244, 21);
            this.txtCardCode.TabIndex = 179;
            // 
            // cboUser
            // 
            this.cboUser.DisplayMember = "ITEM_NM";
            this.cboUser.DropDownHeight = 1;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.IntegralHeight = false;
            this.cboUser.Location = new System.Drawing.Point(108, 118);
            this.cboUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboUser.MultiSelection = false;
            this.cboUser.Name = "cboUser";
            this.cboUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboUser.Params")));
            this.cboUser.Size = new System.Drawing.Size(244, 20);
            this.cboUser.Sql = "CommonSearch#getUserList";
            this.cboUser.TabIndex = 181;
            this.cboUser.Text = "[SELECT]";
            this.cboUser.ValueMember = "ITEM_CD";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 180;
            this.label3.Text = "카드 소시자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCardDesc
            // 
            this.txtCardDesc.Location = new System.Drawing.Point(108, 145);
            this.txtCardDesc.MaxLength = 1000;
            this.txtCardDesc.Name = "txtCardDesc";
            this.txtCardDesc.Size = new System.Drawing.Size(244, 21);
            this.txtCardDesc.TabIndex = 183;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 182;
            this.label4.Text = "비      고";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(202, 185);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 188;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.FormClose);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(79, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 187;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // AccountCardInsertPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 228);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCardDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCardCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBank);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountCardInsertPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "법인카드 추가";
            this.Load += new System.EventHandler(this.AccountCardInsertPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.CheckComboBox cboBank;
        private Control.CheckComboBox cboType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Control.CheckComboBox cboCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardCode;
        private Control.CheckComboBox cboUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCardDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}