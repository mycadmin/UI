namespace MYC.UI.Personal.Popup
{
    partial class ActionItemInsertPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionItemInsertPopup));
            this.cboActType1 = new MYC.Control.CheckComboBox();
            this.dtActTarget = new System.Windows.Forms.DateTimePicker();
            this.txtActSubject = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboActType2 = new MYC.Control.CheckComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboActMember = new MYC.Control.CheckComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.chkMail = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboActConfirm = new MYC.Control.CheckComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // cboActType1
            // 
            this.cboActType1.DisplayMember = "ITEM_NM";
            this.cboActType1.DropDownHeight = 1;
            this.cboActType1.FormattingEnabled = true;
            this.cboActType1.IntegralHeight = false;
            this.cboActType1.Location = new System.Drawing.Point(76, 32);
            this.cboActType1.Margin = new System.Windows.Forms.Padding(0);
            this.cboActType1.MultiSelection = false;
            this.cboActType1.Name = "cboActType1";
            this.cboActType1.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboActType1.Params")));
            this.cboActType1.Size = new System.Drawing.Size(120, 20);
            this.cboActType1.Sql = "CommonSearch#getCommonItems";
            this.cboActType1.TabIndex = 135;
            this.cboActType1.Text = "[SELECT]";
            this.cboActType1.ValueMember = "ITEM_CD";
            this.cboActType1.TextChanged += new System.EventHandler(this.GetType2);
            // 
            // dtActTarget
            // 
            this.dtActTarget.CustomFormat = "";
            this.dtActTarget.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtActTarget.Location = new System.Drawing.Point(272, 59);
            this.dtActTarget.Name = "dtActTarget";
            this.dtActTarget.Size = new System.Drawing.Size(120, 21);
            this.dtActTarget.TabIndex = 134;
            this.dtActTarget.Value = new System.DateTime(2021, 2, 3, 0, 0, 0, 0);
            // 
            // txtActSubject
            // 
            this.txtActSubject.Location = new System.Drawing.Point(76, 5);
            this.txtActSubject.Name = "txtActSubject";
            this.txtActSubject.Size = new System.Drawing.Size(316, 21);
            this.txtActSubject.TabIndex = 133;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(8, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 12);
            this.label10.TabIndex = 132;
            this.label10.Text = "업무영역";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(204, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 12);
            this.label9.TabIndex = 131;
            this.label9.Text = "목 표 일";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 12);
            this.label8.TabIndex = 130;
            this.label8.Text = "항 목 명";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(204, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 136;
            this.label1.Text = "상세구분";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboActType2
            // 
            this.cboActType2.DisplayMember = "ITEM_NM";
            this.cboActType2.DropDownHeight = 1;
            this.cboActType2.FormattingEnabled = true;
            this.cboActType2.IntegralHeight = false;
            this.cboActType2.Location = new System.Drawing.Point(272, 32);
            this.cboActType2.Margin = new System.Windows.Forms.Padding(0);
            this.cboActType2.MultiSelection = false;
            this.cboActType2.Name = "cboActType2";
            this.cboActType2.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboActType2.Params")));
            this.cboActType2.Size = new System.Drawing.Size(120, 20);
            this.cboActType2.Sql = "CommonSearch#getCommonItems";
            this.cboActType2.TabIndex = 137;
            this.cboActType2.Text = "[SELECT]";
            this.cboActType2.ValueMember = "ITEM_CD";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 138;
            this.label2.Text = "담 당 자";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboActMember
            // 
            this.cboActMember.DisplayMember = "ITEM_NM";
            this.cboActMember.DropDownHeight = 1;
            this.cboActMember.FormattingEnabled = true;
            this.cboActMember.IntegralHeight = false;
            this.cboActMember.Location = new System.Drawing.Point(76, 59);
            this.cboActMember.Margin = new System.Windows.Forms.Padding(0);
            this.cboActMember.MultiSelection = false;
            this.cboActMember.Name = "cboActMember";
            this.cboActMember.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboActMember.Params")));
            this.cboActMember.Size = new System.Drawing.Size(120, 20);
            this.cboActMember.Sql = "CommonSearch#getUserList";
            this.cboActMember.TabIndex = 139;
            this.cboActMember.Text = "[SELECT]";
            this.cboActMember.ValueMember = "ITEM_CD";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(8, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 140;
            this.label3.Text = "업무내용";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(76, 110);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(316, 139);
            this.txtMemo.TabIndex = 141;
            // 
            // chkMail
            // 
            this.chkMail.AutoSize = true;
            this.chkMail.Location = new System.Drawing.Point(76, 255);
            this.chkMail.Name = "chkMail";
            this.chkMail.Size = new System.Drawing.Size(128, 16);
            this.chkMail.TabIndex = 142;
            this.chkMail.Text = "업무협조 메일 발송";
            this.chkMail.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(117, 291);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 21);
            this.btnClose.TabIndex = 143;
            this.btnClose.Text = "취  소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.FormClose);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(219, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 21);
            this.btnSave.TabIndex = 144;
            this.btnSave.Text = "저  장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Confirm);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 145;
            this.label4.Text = "검 토 자";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboActConfirm
            // 
            this.cboActConfirm.DisplayMember = "ITEM_NM";
            this.cboActConfirm.DropDownHeight = 1;
            this.cboActConfirm.FormattingEnabled = true;
            this.cboActConfirm.IntegralHeight = false;
            this.cboActConfirm.Location = new System.Drawing.Point(76, 86);
            this.cboActConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.cboActConfirm.MultiSelection = false;
            this.cboActConfirm.Name = "cboActConfirm";
            this.cboActConfirm.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboActConfirm.Params")));
            this.cboActConfirm.Size = new System.Drawing.Size(120, 20);
            this.cboActConfirm.Sql = "CommonSearch#getUserList";
            this.cboActConfirm.TabIndex = 146;
            this.cboActConfirm.Text = "[SELECT]";
            this.cboActConfirm.ValueMember = "ITEM_CD";
            // 
            // ActionItemInsertPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 324);
            this.Controls.Add(this.cboActConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkMail);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboActMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboActType2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboActType1);
            this.Controls.Add(this.dtActTarget);
            this.Controls.Add(this.txtActSubject);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "ActionItemInsertPopup";
            this.Text = "Action Item 등록";
            this.Load += new System.EventHandler(this.ActionItemInsertPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.CheckComboBox cboActType1;
        private System.Windows.Forms.DateTimePicker dtActTarget;
        private System.Windows.Forms.TextBox txtActSubject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private Control.CheckComboBox cboActType2;
        private System.Windows.Forms.Label label2;
        private Control.CheckComboBox cboActMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.CheckBox chkMail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private Control.CheckComboBox cboActConfirm;
    }
}