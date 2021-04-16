namespace MYC.UI.Personal
{
    partial class WorkStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkStatus));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.cboUser = new MYC.Control.CheckComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboProjectId = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.PlSearchBody.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Size = new System.Drawing.Size(870, 662);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(251, 662);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.Panel2);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(237, 630);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.cboYear);
            this.Panel2.Controls.Add(this.label18);
            this.Panel2.Controls.Add(this.cboUser);
            this.Panel2.Controls.Add(this.label19);
            this.Panel2.Controls.Add(this.btnSearch);
            this.Panel2.Controls.Add(this.cboProjectId);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 28);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(237, 118);
            this.Panel2.TabIndex = 86;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(1, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 12);
            this.label18.TabIndex = 95;
            this.label18.Text = "조회년도";
            // 
            // cboUser
            // 
            this.cboUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUser.DisplayMember = "ITEM_NM";
            this.cboUser.DropDownHeight = 1;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.IntegralHeight = false;
            this.cboUser.Location = new System.Drawing.Point(78, 34);
            this.cboUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboUser.MultiSelection = false;
            this.cboUser.Name = "cboUser";
            this.cboUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboUser.Params")));
            this.cboUser.Size = new System.Drawing.Size(151, 20);
            this.cboUser.Sql = "CommonSearch#getUserList";
            this.cboUser.TabIndex = 94;
            this.cboUser.Text = "[SELECT]";
            this.cboUser.ValueMember = "ITEM_CD";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(1, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 12);
            this.label19.TabIndex = 93;
            this.label19.Text = "부 서 명";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(0, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(237, 27);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cboProjectId
            // 
            this.cboProjectId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProjectId.DisplayMember = "ITEM_NM";
            this.cboProjectId.DropDownHeight = 1;
            this.cboProjectId.FormattingEnabled = true;
            this.cboProjectId.IntegralHeight = false;
            this.cboProjectId.Location = new System.Drawing.Point(78, 60);
            this.cboProjectId.Margin = new System.Windows.Forms.Padding(0);
            this.cboProjectId.MultiSelection = false;
            this.cboProjectId.Name = "cboProjectId";
            this.cboProjectId.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProjectId.Params")));
            this.cboProjectId.Size = new System.Drawing.Size(151, 20);
            this.cboProjectId.Sql = "CommonSearch#getProjectList";
            this.cboProjectId.TabIndex = 82;
            this.cboProjectId.Text = "[SELECT]";
            this.cboProjectId.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "직 원 명";
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(237, 28);
            this.LbModelSearch.TabIndex = 85;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboYear
            // 
            this.cboYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(77, 6);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(152, 20);
            this.cboYear.TabIndex = 96;
            // 
            // WorkStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "WorkStatus";
            this.Size = new System.Drawing.Size(1125, 662);
            this.Load += new System.EventHandler(this.WorkStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.PlSearchBody.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label label18;
        private Control.CheckComboBox cboUser;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cboProjectId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.ComboBox cboYear;
    }
}
