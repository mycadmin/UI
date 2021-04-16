
namespace MYC.UI.Admin.Popup
{
    partial class DocConfirmPopup
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
            this.rdbConfirm = new System.Windows.Forms.RadioButton();
            this.rdbReturn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCrtUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCfm_DESC = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtCrtDate = new System.Windows.Forms.DateTimePicker();
            this.txtDocType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbConfirm
            // 
            this.rdbConfirm.AutoSize = true;
            this.rdbConfirm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdbConfirm.Location = new System.Drawing.Point(14, 20);
            this.rdbConfirm.Name = "rdbConfirm";
            this.rdbConfirm.Size = new System.Drawing.Size(47, 16);
            this.rdbConfirm.TabIndex = 0;
            this.rdbConfirm.TabStop = true;
            this.rdbConfirm.Text = "승인";
            this.rdbConfirm.UseVisualStyleBackColor = true;
            // 
            // rdbReturn
            // 
            this.rdbReturn.AutoSize = true;
            this.rdbReturn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdbReturn.Location = new System.Drawing.Point(77, 20);
            this.rdbReturn.Name = "rdbReturn";
            this.rdbReturn.Size = new System.Drawing.Size(47, 16);
            this.rdbReturn.TabIndex = 1;
            this.rdbReturn.TabStop = true;
            this.rdbReturn.Text = "반려";
            this.rdbReturn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbReturn);
            this.groupBox1.Controls.Add(this.rdbConfirm);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(244, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "승인여부";
            // 
            // txtCrtUser
            // 
            this.txtCrtUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCrtUser.Location = new System.Drawing.Point(99, 18);
            this.txtCrtUser.Name = "txtCrtUser";
            this.txtCrtUser.ReadOnly = true;
            this.txtCrtUser.Size = new System.Drawing.Size(139, 21);
            this.txtCrtUser.TabIndex = 194;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(12, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 193;
            this.label11.Text = "작성자명";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 195;
            this.label1.Text = "문서 종류";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 58);
            this.label2.TabIndex = 197;
            this.label2.Text = "검토사유";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCfm_DESC
            // 
            this.txtCfm_DESC.Location = new System.Drawing.Point(99, 99);
            this.txtCfm_DESC.Multiline = true;
            this.txtCfm_DESC.Name = "txtCfm_DESC";
            this.txtCfm_DESC.Size = new System.Drawing.Size(290, 58);
            this.txtCfm_DESC.TabIndex = 198;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(242, 163);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(63, 27);
            this.btnConfirm.TabIndex = 199;
            this.btnConfirm.Text = "검토";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.Confirm);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(326, 163);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 27);
            this.btnClose.TabIndex = 200;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.FormClose);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 201;
            this.label3.Text = "작성 날짜";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtCrtDate
            // 
            this.dtCrtDate.CustomFormat = "yyyy년 MM월 dd일";
            this.dtCrtDate.Enabled = false;
            this.dtCrtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCrtDate.Location = new System.Drawing.Point(99, 72);
            this.dtCrtDate.Name = "dtCrtDate";
            this.dtCrtDate.Size = new System.Drawing.Size(139, 21);
            this.dtCrtDate.TabIndex = 202;
            // 
            // txtDocType
            // 
            this.txtDocType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDocType.Location = new System.Drawing.Point(99, 45);
            this.txtDocType.Name = "txtDocType";
            this.txtDocType.ReadOnly = true;
            this.txtDocType.Size = new System.Drawing.Size(139, 21);
            this.txtDocType.TabIndex = 203;
            // 
            // DocConfirmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 207);
            this.Controls.Add(this.txtDocType);
            this.Controls.Add(this.dtCrtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtCfm_DESC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCrtUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Name = "DocConfirmPopup";
            this.Text = "문서 검토";
            this.Load += new System.EventHandler(this.DocConfirmPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbConfirm;
        private System.Windows.Forms.RadioButton rdbReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCrtUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCfm_DESC;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtCrtDate;
        private System.Windows.Forms.TextBox txtDocType;
    }
}