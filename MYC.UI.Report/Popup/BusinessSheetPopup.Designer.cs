namespace MYC.UI.Report
{
    partial class BusinessSheetPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessSheetPopup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtAcceptTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.btnFileView = new System.Windows.Forms.Button();
            this.btnFileAdd = new System.Windows.Forms.Button();
            this.cboProject = new MYC.Control.CheckComboBox();
            this.cboCompUser = new MYC.Control.CheckComboBox();
            this.cboComp = new MYC.Control.CheckComboBox();
            this.cboUser = new MYC.Control.CheckComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFileDel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtCreateTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "사 업 명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "주관 기관";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(300, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "기관 담당자";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtAcceptTime
            // 
            this.dtAcceptTime.Location = new System.Drawing.Point(143, 103);
            this.dtAcceptTime.Name = "dtAcceptTime";
            this.dtAcceptTime.Size = new System.Drawing.Size(148, 21);
            this.dtAcceptTime.TabIndex = 4;
            this.dtAcceptTime.Value = new System.DateTime(2020, 8, 11, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(30, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "접수 마감";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(143, 22);
            this.txtSubject.MaxLength = 1000;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(418, 21);
            this.txtSubject.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 24);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.InsertData);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(303, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 24);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(300, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 145;
            this.label3.Text = "연계 프로젝트";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(30, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 129);
            this.label6.TabIndex = 146;
            this.label6.Text = "문서 목록";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstFile
            // 
            this.lstFile.DisplayMember = "DIR";
            this.lstFile.FormattingEnabled = true;
            this.lstFile.ItemHeight = 12;
            this.lstFile.Location = new System.Drawing.Point(144, 157);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(417, 100);
            this.lstFile.TabIndex = 6;
            this.lstFile.ValueMember = "DIR";
            // 
            // btnFileView
            // 
            this.btnFileView.Location = new System.Drawing.Point(285, 262);
            this.btnFileView.Name = "btnFileView";
            this.btnFileView.Size = new System.Drawing.Size(135, 24);
            this.btnFileView.TabIndex = 150;
            this.btnFileView.Text = "File 보기";
            this.btnFileView.UseVisualStyleBackColor = true;
            this.btnFileView.Click += new System.EventHandler(this.ProcessFile);
            // 
            // btnFileAdd
            // 
            this.btnFileAdd.Location = new System.Drawing.Point(144, 262);
            this.btnFileAdd.Name = "btnFileAdd";
            this.btnFileAdd.Size = new System.Drawing.Size(135, 24);
            this.btnFileAdd.TabIndex = 149;
            this.btnFileAdd.Text = "File 추가";
            this.btnFileAdd.UseVisualStyleBackColor = true;
            this.btnFileAdd.Click += new System.EventHandler(this.FileAdd);
            // 
            // cboProject
            // 
            this.cboProject.DisplayMember = "ITEM_NM";
            this.cboProject.DropDownHeight = 1;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.IntegralHeight = false;
            this.cboProject.Location = new System.Drawing.Point(413, 104);
            this.cboProject.Margin = new System.Windows.Forms.Padding(0);
            this.cboProject.MultiSelection = false;
            this.cboProject.Name = "cboProject";
            this.cboProject.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProject.Params")));
            this.cboProject.Size = new System.Drawing.Size(148, 20);
            this.cboProject.Sql = "CommonSearch#getProjectList";
            this.cboProject.TabIndex = 5;
            this.cboProject.Text = "[SELECT]";
            this.cboProject.ValueMember = "ITEM_CD";
            // 
            // cboCompUser
            // 
            this.cboCompUser.DisplayMember = "ITEM_NM";
            this.cboCompUser.DropDownHeight = 1;
            this.cboCompUser.FormattingEnabled = true;
            this.cboCompUser.IntegralHeight = false;
            this.cboCompUser.Location = new System.Drawing.Point(413, 50);
            this.cboCompUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboCompUser.MultiSelection = false;
            this.cboCompUser.Name = "cboCompUser";
            this.cboCompUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCompUser.Params")));
            this.cboCompUser.Size = new System.Drawing.Size(148, 20);
            this.cboCompUser.Sql = "CommonSearch#getUserList";
            this.cboCompUser.TabIndex = 2;
            this.cboCompUser.TabStop = false;
            this.cboCompUser.Text = "[SELECT]";
            this.cboCompUser.ValueMember = "ITEM_CD";
            // 
            // cboComp
            // 
            this.cboComp.DisplayMember = "ITEM_NM";
            this.cboComp.DropDownHeight = 1;
            this.cboComp.FormattingEnabled = true;
            this.cboComp.IntegralHeight = false;
            this.cboComp.Location = new System.Drawing.Point(143, 50);
            this.cboComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboComp.MultiSelection = false;
            this.cboComp.Name = "cboComp";
            this.cboComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboComp.Params")));
            this.cboComp.Size = new System.Drawing.Size(148, 20);
            this.cboComp.Sql = "CommonSearch#getCompList";
            this.cboComp.TabIndex = 1;
            this.cboComp.Text = "[SELECT]";
            this.cboComp.ValueMember = "ITEM_CD";
            // 
            // cboUser
            // 
            this.cboUser.DisplayMember = "ITEM_NM";
            this.cboUser.DropDownHeight = 1;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.IntegralHeight = false;
            this.cboUser.Location = new System.Drawing.Point(413, 77);
            this.cboUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboUser.MultiSelection = false;
            this.cboUser.Name = "cboUser";
            this.cboUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboUser.Params")));
            this.cboUser.Size = new System.Drawing.Size(148, 20);
            this.cboUser.Sql = "CommonSearch#getUserList";
            this.cboUser.TabIndex = 3;
            this.cboUser.Text = "[SELECT]";
            this.cboUser.ValueMember = "ITEM_CD";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(300, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 151;
            this.label7.Text = "본사 담당자";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFileDel
            // 
            this.btnFileDel.Location = new System.Drawing.Point(426, 262);
            this.btnFileDel.Name = "btnFileDel";
            this.btnFileDel.Size = new System.Drawing.Size(135, 24);
            this.btnFileDel.TabIndex = 153;
            this.btnFileDel.Text = "File 삭제";
            this.btnFileDel.UseVisualStyleBackColor = true;
            this.btnFileDel.Click += new System.EventHandler(this.FileDelete);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(30, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 21);
            this.label8.TabIndex = 154;
            this.label8.Text = "공 시 일";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtCreateTime
            // 
            this.dtCreateTime.Location = new System.Drawing.Point(144, 76);
            this.dtCreateTime.Name = "dtCreateTime";
            this.dtCreateTime.Size = new System.Drawing.Size(148, 21);
            this.dtCreateTime.TabIndex = 2;
            this.dtCreateTime.Value = new System.DateTime(2020, 8, 11, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(30, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 21);
            this.label11.TabIndex = 160;
            this.label11.Text = "사업비 (천원)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(143, 130);
            this.txtCost.MaxLength = 1000;
            this.txtCost.Name = "txtCost";
            this.txtCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCost.Size = new System.Drawing.Size(418, 21);
            this.txtCost.TabIndex = 161;
            this.txtCost.TextChanged += new System.EventHandler(this.PriceChange);
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyFilter);
            // 
            // BusinessSheetPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(591, 351);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtCreateTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFileDel);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFileView);
            this.Controls.Add(this.btnFileAdd);
            this.Controls.Add(this.lstFile);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCompUser);
            this.Controls.Add(this.cboComp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtAcceptTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessSheetPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사업 추가";
            this.Load += new System.EventHandler(this.BusinessSheetPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtAcceptTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Control.CheckComboBox cboComp;
        private Control.CheckComboBox cboCompUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Control.CheckComboBox cboProject;
        private System.Windows.Forms.ListBox lstFile;
        private System.Windows.Forms.Button btnFileView;
        private System.Windows.Forms.Button btnFileAdd;
        private Control.CheckComboBox cboUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFileDel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtCreateTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCost;
    }
}
