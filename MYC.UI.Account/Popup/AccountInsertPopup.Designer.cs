namespace MYC.UI.Account.Popup
{
    partial class AccountInsertPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInsertPopup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBank = new System.Windows.Forms.RadioButton();
            this.rdoCard = new System.Windows.Forms.RadioButton();
            this.grpCommon = new System.Windows.Forms.GroupBox();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.txtAccInfo = new System.Windows.Forms.TextBox();
            this.txtAccDesc = new System.Windows.Forms.TextBox();
            this.txtAccCash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calAccDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.grpCard = new System.Windows.Forms.GroupBox();
            this.cboCard = new MYC.Control.CheckComboBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.txtOutRegId = new System.Windows.Forms.TextBox();
            this.txtOutName = new System.Windows.Forms.TextBox();
            this.cboType = new MYC.Control.CheckComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpBank = new System.Windows.Forms.GroupBox();
            this.cboBankCode = new MYC.Control.CheckComboBox();
            this.txtInUserName = new System.Windows.Forms.TextBox();
            this.txtInBankNo = new System.Windows.Forms.TextBox();
            this.txtInBankName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpCommon.SuspendLayout();
            this.grpCard.SuspendLayout();
            this.grpBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBank);
            this.groupBox1.Controls.Add(this.rdoCard);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "지출 형태";
            // 
            // rdoBank
            // 
            this.rdoBank.AutoSize = true;
            this.rdoBank.Location = new System.Drawing.Point(137, 22);
            this.rdoBank.Name = "rdoBank";
            this.rdoBank.Size = new System.Drawing.Size(71, 16);
            this.rdoBank.TabIndex = 1;
            this.rdoBank.Text = "계좌이체";
            this.rdoBank.UseVisualStyleBackColor = true;
            this.rdoBank.CheckedChanged += new System.EventHandler(this.SetGroup);
            // 
            // rdoCard
            // 
            this.rdoCard.AutoSize = true;
            this.rdoCard.Checked = true;
            this.rdoCard.Location = new System.Drawing.Point(19, 22);
            this.rdoCard.Name = "rdoCard";
            this.rdoCard.Size = new System.Drawing.Size(77, 16);
            this.rdoCard.TabIndex = 0;
            this.rdoCard.TabStop = true;
            this.rdoCard.Text = "현금/카드";
            this.rdoCard.UseVisualStyleBackColor = true;
            this.rdoCard.CheckedChanged += new System.EventHandler(this.SetGroup);
            // 
            // grpCommon
            // 
            this.grpCommon.Controls.Add(this.btnReceipt);
            this.grpCommon.Controls.Add(this.txtReceipt);
            this.grpCommon.Controls.Add(this.txtAccInfo);
            this.grpCommon.Controls.Add(this.txtAccDesc);
            this.grpCommon.Controls.Add(this.txtAccCash);
            this.grpCommon.Controls.Add(this.label4);
            this.grpCommon.Controls.Add(this.label3);
            this.grpCommon.Controls.Add(this.label2);
            this.grpCommon.Controls.Add(this.label1);
            this.grpCommon.Controls.Add(this.calAccDate);
            this.grpCommon.Controls.Add(this.label8);
            this.grpCommon.Location = new System.Drawing.Point(12, 73);
            this.grpCommon.Name = "grpCommon";
            this.grpCommon.Size = new System.Drawing.Size(352, 167);
            this.grpCommon.TabIndex = 1;
            this.grpCommon.TabStop = false;
            this.grpCommon.Text = "공통항목";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(259, 136);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(86, 21);
            this.btnReceipt.TabIndex = 165;
            this.btnReceipt.Text = "파일첨부";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.FileUpload);
            // 
            // txtReceipt
            // 
            this.txtReceipt.Location = new System.Drawing.Point(102, 136);
            this.txtReceipt.MaxLength = 1000;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.ReadOnly = true;
            this.txtReceipt.Size = new System.Drawing.Size(149, 21);
            this.txtReceipt.TabIndex = 164;
            this.txtReceipt.Click += new System.EventHandler(this.ViewFile);
            // 
            // txtAccInfo
            // 
            this.txtAccInfo.Location = new System.Drawing.Point(102, 109);
            this.txtAccInfo.MaxLength = 1000;
            this.txtAccInfo.Name = "txtAccInfo";
            this.txtAccInfo.Size = new System.Drawing.Size(244, 21);
            this.txtAccInfo.TabIndex = 163;
            // 
            // txtAccDesc
            // 
            this.txtAccDesc.Location = new System.Drawing.Point(102, 82);
            this.txtAccDesc.MaxLength = 1000;
            this.txtAccDesc.Name = "txtAccDesc";
            this.txtAccDesc.Size = new System.Drawing.Size(244, 21);
            this.txtAccDesc.TabIndex = 162;
            // 
            // txtAccCash
            // 
            this.txtAccCash.Location = new System.Drawing.Point(102, 56);
            this.txtAccCash.MaxLength = 1000;
            this.txtAccCash.Name = "txtAccCash";
            this.txtAccCash.Size = new System.Drawing.Size(244, 21);
            this.txtAccCash.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 160;
            this.label4.Text = "증빙서류";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 159;
            this.label3.Text = "비      고";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 158;
            this.label2.Text = "사용내역";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 157;
            this.label1.Text = "지 출 액";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calAccDate
            // 
            this.calAccDate.CustomFormat = "yyyy년 MM월 dd일";
            this.calAccDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calAccDate.Location = new System.Drawing.Point(102, 28);
            this.calAccDate.Name = "calAccDate";
            this.calAccDate.Size = new System.Drawing.Size(244, 21);
            this.calAccDate.TabIndex = 155;
            this.calAccDate.Value = new System.DateTime(2020, 8, 11, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 156;
            this.label8.Text = "지출일자";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCard
            // 
            this.grpCard.Controls.Add(this.cboCard);
            this.grpCard.Controls.Add(this.txtAccNo);
            this.grpCard.Controls.Add(this.txtOutRegId);
            this.grpCard.Controls.Add(this.txtOutName);
            this.grpCard.Controls.Add(this.cboType);
            this.grpCard.Controls.Add(this.label5);
            this.grpCard.Controls.Add(this.label6);
            this.grpCard.Controls.Add(this.label7);
            this.grpCard.Controls.Add(this.label9);
            this.grpCard.Controls.Add(this.label10);
            this.grpCard.Location = new System.Drawing.Point(12, 246);
            this.grpCard.Name = "grpCard";
            this.grpCard.Size = new System.Drawing.Size(352, 167);
            this.grpCard.TabIndex = 2;
            this.grpCard.TabStop = false;
            this.grpCard.Text = "현금/카드";
            // 
            // cboCard
            // 
            this.cboCard.DisplayMember = "ITEM_NM";
            this.cboCard.DropDownHeight = 1;
            this.cboCard.FormattingEnabled = true;
            this.cboCard.IntegralHeight = false;
            this.cboCard.Location = new System.Drawing.Point(102, 56);
            this.cboCard.Margin = new System.Windows.Forms.Padding(0);
            this.cboCard.MultiSelection = false;
            this.cboCard.Name = "cboCard";
            this.cboCard.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCard.Params")));
            this.cboCard.Size = new System.Drawing.Size(244, 20);
            this.cboCard.Sql = "CommonSearch#getCardList";
            this.cboCard.TabIndex = 167;
            this.cboCard.Text = "[SELECT]";
            this.cboCard.ValueMember = "ITEM_CD";
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(102, 137);
            this.txtAccNo.MaxLength = 1000;
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(244, 21);
            this.txtAccNo.TabIndex = 166;
            // 
            // txtOutRegId
            // 
            this.txtOutRegId.Location = new System.Drawing.Point(102, 110);
            this.txtOutRegId.MaxLength = 1000;
            this.txtOutRegId.Name = "txtOutRegId";
            this.txtOutRegId.Size = new System.Drawing.Size(244, 21);
            this.txtOutRegId.TabIndex = 165;
            // 
            // txtOutName
            // 
            this.txtOutName.Location = new System.Drawing.Point(102, 83);
            this.txtOutName.MaxLength = 1000;
            this.txtOutName.Name = "txtOutName";
            this.txtOutName.Size = new System.Drawing.Size(244, 21);
            this.txtOutName.TabIndex = 164;
            // 
            // cboType
            // 
            this.cboType.DisplayMember = "ITEM_NM";
            this.cboType.DropDownHeight = 1;
            this.cboType.FormattingEnabled = true;
            this.cboType.IntegralHeight = false;
            this.cboType.Location = new System.Drawing.Point(102, 29);
            this.cboType.Margin = new System.Windows.Forms.Padding(0);
            this.cboType.MultiSelection = false;
            this.cboType.Name = "cboType";
            this.cboType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboType.Params")));
            this.cboType.Size = new System.Drawing.Size(244, 20);
            this.cboType.Sql = "CommonSearch#getCommonItems";
            this.cboType.TabIndex = 163;
            this.cboType.Text = "[SELECT]";
            this.cboType.ValueMember = "ITEM_CD";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 160;
            this.label5.Text = "승인번호";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 159;
            this.label6.Text = "사업자번호";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 158;
            this.label7.Text = "지 출 처";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 157;
            this.label9.Text = "카드정보";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 156;
            this.label10.Text = "구      분";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBank
            // 
            this.grpBank.Controls.Add(this.cboBankCode);
            this.grpBank.Controls.Add(this.txtInUserName);
            this.grpBank.Controls.Add(this.txtInBankNo);
            this.grpBank.Controls.Add(this.txtInBankName);
            this.grpBank.Controls.Add(this.label11);
            this.grpBank.Controls.Add(this.label12);
            this.grpBank.Controls.Add(this.label13);
            this.grpBank.Controls.Add(this.label15);
            this.grpBank.Location = new System.Drawing.Point(12, 246);
            this.grpBank.Name = "grpBank";
            this.grpBank.Size = new System.Drawing.Size(352, 167);
            this.grpBank.TabIndex = 161;
            this.grpBank.TabStop = false;
            this.grpBank.Text = "계좌이체";
            this.grpBank.Visible = false;
            // 
            // cboBankCode
            // 
            this.cboBankCode.DisplayMember = "ITEM_NM";
            this.cboBankCode.DropDownHeight = 1;
            this.cboBankCode.FormattingEnabled = true;
            this.cboBankCode.IntegralHeight = false;
            this.cboBankCode.Location = new System.Drawing.Point(102, 28);
            this.cboBankCode.Margin = new System.Windows.Forms.Padding(0);
            this.cboBankCode.MultiSelection = false;
            this.cboBankCode.Name = "cboBankCode";
            this.cboBankCode.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboBankCode.Params")));
            this.cboBankCode.Size = new System.Drawing.Size(244, 20);
            this.cboBankCode.Sql = "CommonSearch#getBankList";
            this.cboBankCode.TabIndex = 168;
            this.cboBankCode.Text = "[SELECT]";
            this.cboBankCode.ValueMember = "ITEM_CD";
            // 
            // txtInUserName
            // 
            this.txtInUserName.Location = new System.Drawing.Point(102, 109);
            this.txtInUserName.MaxLength = 1000;
            this.txtInUserName.Name = "txtInUserName";
            this.txtInUserName.Size = new System.Drawing.Size(244, 21);
            this.txtInUserName.TabIndex = 167;
            // 
            // txtInBankNo
            // 
            this.txtInBankNo.Location = new System.Drawing.Point(102, 83);
            this.txtInBankNo.MaxLength = 1000;
            this.txtInBankNo.Name = "txtInBankNo";
            this.txtInBankNo.Size = new System.Drawing.Size(244, 21);
            this.txtInBankNo.TabIndex = 166;
            // 
            // txtInBankName
            // 
            this.txtInBankName.Location = new System.Drawing.Point(102, 55);
            this.txtInBankName.MaxLength = 1000;
            this.txtInBankName.Name = "txtInBankName";
            this.txtInBankName.Size = new System.Drawing.Size(244, 21);
            this.txtInBankName.TabIndex = 165;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(6, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 160;
            this.label11.Text = "입금자명";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(6, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 159;
            this.label12.Text = "입금통장번호";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(6, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 21);
            this.label13.TabIndex = 158;
            this.label13.Text = "입금은행";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(6, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 21);
            this.label15.TabIndex = 156;
            this.label15.Text = "출금통장번호";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 166;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(206, 426);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 167;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.CloseForm);
            // 
            // AccountInsertPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 472);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpCommon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCard);
            this.Controls.Add(this.grpBank);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountInsertPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "지출 추가";
            this.Load += new System.EventHandler(this.AccountInsertPopup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCommon.ResumeLayout(false);
            this.grpCommon.PerformLayout();
            this.grpCard.ResumeLayout(false);
            this.grpCard.PerformLayout();
            this.grpBank.ResumeLayout(false);
            this.grpBank.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBank;
        private System.Windows.Forms.RadioButton rdoCard;
        private System.Windows.Forms.GroupBox grpCommon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker calAccDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpBank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.TextBox txtAccInfo;
        private System.Windows.Forms.TextBox txtAccDesc;
        private System.Windows.Forms.TextBox txtAccCash;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtOutRegId;
        private System.Windows.Forms.TextBox txtOutName;
        private Control.CheckComboBox cboType;
        private System.Windows.Forms.TextBox txtInUserName;
        private System.Windows.Forms.TextBox txtInBankNo;
        private System.Windows.Forms.TextBox txtInBankName;
        private System.Windows.Forms.Button btnReceipt;
        private Control.CheckComboBox cboCard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Control.CheckComboBox cboBankCode;
    }
}