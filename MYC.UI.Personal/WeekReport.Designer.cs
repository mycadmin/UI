namespace MYC.UI.Personal
{
    partial class WeekReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeekReport));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbockMember = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.txtWork = new System.Windows.Forms.RichTextBox();
            this.lbWork = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.txtWork);
            this.PlMainBody.Controls.Add(this.lbWork);
            this.PlMainBody.Controls.Add(this.pnlTop);
            this.PlMainBody.Size = new System.Drawing.Size(885, 686);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(255, 686);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.Panel2);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(241, 654);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnSchedule);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(885, 46);
            this.pnlTop.TabIndex = 0;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.Location = new System.Drawing.Point(785, 8);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(90, 30);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "일정표";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Visible = false;
            this.btnSchedule.Click += new System.EventHandler(this.ViewSchedule);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.cboYear);
            this.Panel2.Controls.Add(this.cboDate);
            this.Panel2.Controls.Add(this.cboPeriod);
            this.Panel2.Controls.Add(this.label19);
            this.Panel2.Controls.Add(this.btnSearch);
            this.Panel2.Controls.Add(this.cbockMember);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 28);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(241, 90);
            this.Panel2.TabIndex = 88;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "M",
            "W"});
            this.cboYear.Location = new System.Drawing.Point(77, 6);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(70, 20);
            this.cboYear.TabIndex = 97;
            // 
            // cboDate
            // 
            this.cboDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Items.AddRange(new object[] {
            "M",
            "W"});
            this.cboDate.Location = new System.Drawing.Point(204, 6);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(28, 20);
            this.cboDate.TabIndex = 96;
            // 
            // cboPeriod
            // 
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Items.AddRange(new object[] {
            "M",
            "W"});
            this.cboPeriod.Location = new System.Drawing.Point(153, 6);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(44, 20);
            this.cboPeriod.TabIndex = 95;
            this.cboPeriod.SelectedIndexChanged += new System.EventHandler(this.SetReportTime);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(1, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 12);
            this.label19.TabIndex = 93;
            this.label19.Text = "조회기간";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(0, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(241, 27);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // cbockMember
            // 
            this.cbockMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbockMember.DisplayMember = "ITEM_NM";
            this.cbockMember.DropDownHeight = 1;
            this.cbockMember.FormattingEnabled = true;
            this.cbockMember.IntegralHeight = false;
            this.cbockMember.Location = new System.Drawing.Point(77, 33);
            this.cbockMember.Margin = new System.Windows.Forms.Padding(0);
            this.cbockMember.MultiSelection = true;
            this.cbockMember.Name = "cbockMember";
            this.cbockMember.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cbockMember.Params")));
            this.cbockMember.Size = new System.Drawing.Size(155, 20);
            this.cbockMember.Sql = "CommonSearch#getUserList";
            this.cbockMember.TabIndex = 82;
            this.cbockMember.Text = "[SELECT]";
            this.cbockMember.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "구 성 원";
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(241, 28);
            this.LbModelSearch.TabIndex = 87;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWork
            // 
            this.txtWork.BackColor = System.Drawing.Color.White;
            this.txtWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWork.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWork.Location = new System.Drawing.Point(0, 77);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(885, 609);
            this.txtWork.TabIndex = 3;
            this.txtWork.Text = "";
            // 
            // lbWork
            // 
            this.lbWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWork.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWork.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbWork.Location = new System.Drawing.Point(0, 46);
            this.lbWork.Name = "lbWork";
            this.lbWork.Size = new System.Drawing.Size(885, 31);
            this.lbWork.TabIndex = 5;
            this.lbWork.Text = "진행 사항";
            this.lbWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeekReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "WeekReport";
            this.Size = new System.Drawing.Size(1144, 686);
            this.Load += new System.EventHandler(this.WeekReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cbockMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.RichTextBox txtWork;
        private System.Windows.Forms.Label lbWork;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.ComboBox cboYear;
    }
}
