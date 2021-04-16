using System.Drawing;

namespace MYC.UI.Machine
{
    partial class ProjectEstimate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEstimate));
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInsp = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboWork = new MYC.Control.CheckComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboProject = new MYC.Control.CheckComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboUser = new MYC.Control.CheckComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.Gd_Eqp = new Control.MYCGrid();
            this.Doc = new System.Windows.Forms.WebBrowser();
            this.cboList = new MYC.Control.CheckComboBox();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gd_Eqp)).BeginInit();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.Gd_Eqp);
            this.PlMainBody.Controls.Add(this.panel1);
            this.PlMainBody.Controls.Add(this.Doc);
            this.PlMainBody.Size = new System.Drawing.Size(867, 600);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(250, 600);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.panel2);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(236, 568);
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(236, 28);
            this.LbModelSearch.TabIndex = 68;
            this.LbModelSearch.Text = "견적서 조회";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboList);
            this.panel2.Controls.Add(this.btnInsp);
            this.panel2.Controls.Add(this.BtnSearch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 79);
            this.panel2.TabIndex = 80;
            // 
            // btnInsp
            // 
            this.btnInsp.Location = new System.Drawing.Point(90, 40);
            this.btnInsp.Name = "btnInsp";
            this.btnInsp.Size = new System.Drawing.Size(78, 29);
            this.btnInsp.TabIndex = 83;
            this.btnInsp.Text = "인 쇄";
            this.btnInsp.UseVisualStyleBackColor = true;
            this.btnInsp.Click += new System.EventHandler(this.BtnInsp_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(5, 40);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(78, 29);
            this.BtnSearch.TabIndex = 82;
            this.BtnSearch.Text = "견적 조회";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 12);
            this.label5.TabIndex = 80;
            this.label5.Text = "견적번호";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboWork);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cboProject);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 63);
            this.panel1.TabIndex = 24;
            // 
            // cboWork
            // 
            this.cboWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboWork.DisplayMember = "ITEM_NM";
            this.cboWork.DropDownHeight = 1;
            this.cboWork.FormattingEnabled = true;
            this.cboWork.IntegralHeight = false;
            this.cboWork.Location = new System.Drawing.Point(676, 8);
            this.cboWork.Margin = new System.Windows.Forms.Padding(0);
            this.cboWork.MultiSelection = true;
            this.cboWork.Name = "cboWork";
            this.cboWork.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboWork.Params")));
            this.cboWork.Size = new System.Drawing.Size(91, 20);
            this.cboWork.Sql = "CommonSearch#getWorkList";
            this.cboWork.TabIndex = 105;
            this.cboWork.Text = "[SELECT]";
            this.cboWork.ValueMember = "ITEM_CD";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(590, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 104;
            this.label9.Text = "세부항목";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboProject
            // 
            this.cboProject.DisplayMember = "ITEM_NM";
            this.cboProject.DropDownHeight = 1;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.IntegralHeight = false;
            this.cboProject.Location = new System.Drawing.Point(376, 8);
            this.cboProject.Margin = new System.Windows.Forms.Padding(0);
            this.cboProject.MultiSelection = true;
            this.cboProject.Name = "cboProject";
            this.cboProject.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboProject.Params")));
            this.cboProject.Size = new System.Drawing.Size(204, 20);
            this.cboProject.Sql = "CommonSearch#getProjectList";
            this.cboProject.TabIndex = 103;
            this.cboProject.Text = "[SELECT]";
            this.cboProject.ValueMember = "ITEM_CD";
            this.cboProject.TextChanged += new System.EventHandler(this.CboProject_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(290, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 102;
            this.label8.Text = "프로젝트";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(90, 35);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(677, 21);
            this.txtDesc.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(4, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 100;
            this.label6.Text = "비 고";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboUser
            // 
            this.cboUser.DisplayMember = "ITEM_NM";
            this.cboUser.DropDownHeight = 1;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.IntegralHeight = false;
            this.cboUser.Location = new System.Drawing.Point(90, 8);
            this.cboUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboUser.MultiSelection = false;
            this.cboUser.Name = "cboUser";
            this.cboUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboUser.Params")));
            this.cboUser.Size = new System.Drawing.Size(190, 20);
            this.cboUser.Sql = "CommonSearch#getUserList";
            this.cboUser.TabIndex = 99;
            this.cboUser.Text = "[SELECT]";
            this.cboUser.ValueMember = "ITEM_CD";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "담당자";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(777, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 48);
            this.btnSave.TabIndex = 88;
            this.btnSave.Text = "입고 확인";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Gd_Eqp
            // 
            this.Gd_Eqp.AllowUserToAddRows = false;
            this.Gd_Eqp.AllowUserToDeleteRows = false;
            this.Gd_Eqp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gd_Eqp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gd_Eqp.Location = new System.Drawing.Point(0, 63);
            this.Gd_Eqp.MultiSelect = false;
            this.Gd_Eqp.Name = "Gd_Eqp";
            this.Gd_Eqp.ReadOnly = true;
            this.Gd_Eqp.RowHeadersVisible = false;
            this.Gd_Eqp.RowTemplate.Height = 23;
            this.Gd_Eqp.Size = new System.Drawing.Size(867, 537);
            this.Gd_Eqp.TabIndex = 25;
            // 
            // Doc
            // 
            this.Doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Doc.Location = new System.Drawing.Point(0, 0);
            this.Doc.MinimumSize = new System.Drawing.Size(20, 20);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(867, 600);
            this.Doc.TabIndex = 26;
            this.Doc.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Doc_DocumentCompleted);
            // 
            // cboList
            // 
            this.cboList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboList.DisplayMember = "ITEM_NM";
            this.cboList.DropDownHeight = 1;
            this.cboList.FormattingEnabled = true;
            this.cboList.IntegralHeight = false;
            this.cboList.Location = new System.Drawing.Point(90, 5);
            this.cboList.Margin = new System.Windows.Forms.Padding(0);
            this.cboList.MultiSelection = false;
            this.cboList.Name = "cboList";
            this.cboList.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboList.Params")));
            this.cboList.Size = new System.Drawing.Size(140, 20);
            this.cboList.Sql = "CommonSearch#getProjectEstimateList";
            this.cboList.TabIndex = 84;
            this.cboList.Text = "[SELECT]";
            this.cboList.ValueMember = "ITEM_CD";
            this.cboList.TextChanged += new System.EventHandler(this.CboList_TextChanged);
            // 
            // ProjectEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "ProjectEstimate";
            this.Size = new System.Drawing.Size(1121, 600);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gd_Eqp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private Control.MYCGrid Gd_Eqp;
        private System.Windows.Forms.Panel panel1;
        private Control.CheckComboBox cboWork;
        private System.Windows.Forms.Label label9;
        private Control.CheckComboBox cboProject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private Control.CheckComboBox cboUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button btnInsp;
        private System.Windows.Forms.WebBrowser Doc;
        private Control.CheckComboBox cboList;
    }
}
