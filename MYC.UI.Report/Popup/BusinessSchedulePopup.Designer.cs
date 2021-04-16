namespace MYC.UI.Report
{
    partial class BusinessSchedulePopup
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessSchedulePopup));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboUser = new MYC.Control.CheckComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtCreateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPlan = new MYC.Control.CheckComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "사 업 명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(105, 22);
            this.txtSubject.MaxLength = 1000;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(465, 21);
            this.txtSubject.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 24);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.InsertData);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(304, 144);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 24);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // cboUser
            // 
            this.cboUser.DisplayMember = "ITEM_NM";
            this.cboUser.DropDownHeight = 1;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.IntegralHeight = false;
            this.cboUser.Location = new System.Drawing.Point(390, 53);
            this.cboUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboUser.MultiSelection = false;
            this.cboUser.Name = "cboUser";
            this.cboUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboUser.Params")));
            this.cboUser.Size = new System.Drawing.Size(180, 20);
            this.cboUser.Sql = "CommonSearch#getUserList";
            this.cboUser.TabIndex = 3;
            this.cboUser.Text = "[SELECT]";
            this.cboUser.ValueMember = "ITEM_CD";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(295, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 151;
            this.label7.Text = "진행 담당자";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(10, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 154;
            this.label8.Text = "공 시 일";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtCreateTime
            // 
            this.dtCreateTime.CustomFormat = "yyyy년 MM월 dd일 HH시 mm분";
            this.dtCreateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreateTime.Location = new System.Drawing.Point(106, 52);
            this.dtCreateTime.Name = "dtCreateTime";
            this.dtCreateTime.Size = new System.Drawing.Size(180, 21);
            this.dtCreateTime.TabIndex = 2;
            this.dtCreateTime.Value = new System.DateTime(2020, 8, 11, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(10, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 146;
            this.label6.Text = "내 용";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPlan
            // 
            this.cboPlan.DisplayMember = "ITEM_NM";
            this.cboPlan.DropDownHeight = 1;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.IntegralHeight = false;
            this.cboPlan.Location = new System.Drawing.Point(106, 86);
            this.cboPlan.Margin = new System.Windows.Forms.Padding(0);
            this.cboPlan.MultiSelection = false;
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboPlan.Params")));
            this.cboPlan.Size = new System.Drawing.Size(464, 20);
            this.cboPlan.Sql = "CommonSearch#getCommonItems";
            this.cboPlan.TabIndex = 155;
            this.cboPlan.Text = "[SELECT]";
            this.cboPlan.ValueMember = "ITEM_CD";
            // 
            // BusinessSchedulePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 185);
            this.Controls.Add(this.cboPlan);
            this.Controls.Add(this.dtCreateTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessSchedulePopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "일정 추가";
            this.Load += new System.EventHandler(this.BusinessSchedulePopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Control.CheckComboBox cboUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtCreateTime;
        private System.Windows.Forms.Label label6;
        private Control.CheckComboBox cboPlan;
    }
}
