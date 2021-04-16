namespace MYC.UI.Report
{
    partial class AssignHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignHistory));
            this.LbModelSearch = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboComp = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CalEndTm = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.cboCstUser = new MYC.Control.CheckComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbockVisitUser = new MYC.Control.CheckComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CalStartTm = new System.Windows.Forms.DateTimePicker();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gd_List = new Control.MYCGrid();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.gd_List);
            this.PlMainBody.Controls.Add(this.panel2);
            this.PlMainBody.Controls.Add(this.panel1);
            this.PlMainBody.Size = new System.Drawing.Size(929, 665);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(268, 665);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.panel);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            this.PlSearchBody.Size = new System.Drawing.Size(254, 633);
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(254, 28);
            this.LbModelSearch.TabIndex = 85;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dtTo);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.dtFrom);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.btnSearch);
            this.panel.Controls.Add(this.cboComp);
            this.panel.Controls.Add(this.label1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(254, 139);
            this.panel.TabIndex = 89;
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Location = new System.Drawing.Point(80, 40);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(164, 21);
            this.dtTo.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 91;
            this.label5.Text = "~";
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.Location = new System.Drawing.Point(80, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(164, 21);
            this.dtFrom.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 86;
            this.label4.Text = "조회기간";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(5, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 30);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.GetVisitHistory);
            // 
            // cboComp
            // 
            this.cboComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboComp.DisplayMember = "ITEM_NM";
            this.cboComp.DropDownHeight = 1;
            this.cboComp.FormattingEnabled = true;
            this.cboComp.IntegralHeight = false;
            this.cboComp.Location = new System.Drawing.Point(80, 67);
            this.cboComp.Margin = new System.Windows.Forms.Padding(0);
            this.cboComp.MultiSelection = false;
            this.cboComp.Name = "cboComp";
            this.cboComp.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboComp.Params")));
            this.cboComp.Size = new System.Drawing.Size(164, 20);
            this.cboComp.Sql = "CommonSearch#getCompList";
            this.cboComp.TabIndex = 82;
            this.cboComp.Text = "[SELECT]";
            this.cboComp.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "고객사";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 34);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "■ 장비 사용 신청 이력";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CalEndTm);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtProduct);
            this.panel2.Controls.Add(this.txtSite);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtSubject);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.cboCstUser);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cbockVisitUser);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CalStartTm);
            this.panel2.Controls.Add(this.txtDesc);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(375, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 631);
            this.panel2.TabIndex = 34;
            // 
            // CalEndTm
            // 
            this.CalEndTm.CustomFormat = "yyyy년 MM월 dd일 HH:mm:ss";
            this.CalEndTm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CalEndTm.Location = new System.Drawing.Point(372, 87);
            this.CalEndTm.Name = "CalEndTm";
            this.CalEndTm.Size = new System.Drawing.Size(176, 21);
            this.CalEndTm.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(278, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 150;
            this.label3.Text = "완료 일시";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(372, 60);
            this.txtProduct.MaxLength = 40;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(176, 21);
            this.txtProduct.TabIndex = 148;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(98, 60);
            this.txtSite.MaxLength = 40;
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(176, 21);
            this.txtSite.TabIndex = 147;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(366, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 146;
            this.btnSave.Text = "저 장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SetVisitHistoryItem);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(98, 33);
            this.txtSubject.MaxLength = 40;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(450, 21);
            this.txtSubject.TabIndex = 145;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(4, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 21);
            this.label18.TabIndex = 144;
            this.label18.Text = "제목";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(459, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(90, 25);
            this.btnExcel.TabIndex = 143;
            this.btnExcel.Text = "발 행";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.ExcelExport);
            // 
            // cboCstUser
            // 
            this.cboCstUser.DisplayMember = "ITEM_NM";
            this.cboCstUser.DropDownHeight = 1;
            this.cboCstUser.FormattingEnabled = true;
            this.cboCstUser.IntegralHeight = false;
            this.cboCstUser.Location = new System.Drawing.Point(98, 115);
            this.cboCstUser.Margin = new System.Windows.Forms.Padding(0);
            this.cboCstUser.MultiSelection = false;
            this.cboCstUser.Name = "cboCstUser";
            this.cboCstUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboCstUser.Params")));
            this.cboCstUser.Size = new System.Drawing.Size(176, 20);
            this.cboCstUser.Sql = "CommonSearch#getUserList";
            this.cboCstUser.TabIndex = 142;
            this.cboCstUser.Text = "[SELECT]";
            this.cboCstUser.ValueMember = "ITEM_CD";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(278, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 21);
            this.label16.TabIndex = 138;
            this.label16.Text = "방문 예정자";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbockVisitUser
            // 
            this.cbockVisitUser.DisplayMember = "ITEM_NM";
            this.cbockVisitUser.DropDownHeight = 1;
            this.cbockVisitUser.FormattingEnabled = true;
            this.cbockVisitUser.IntegralHeight = false;
            this.cbockVisitUser.Location = new System.Drawing.Point(372, 115);
            this.cbockVisitUser.Margin = new System.Windows.Forms.Padding(0);
            this.cbockVisitUser.MultiSelection = true;
            this.cbockVisitUser.Name = "cbockVisitUser";
            this.cbockVisitUser.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cbockVisitUser.Params")));
            this.cbockVisitUser.Size = new System.Drawing.Size(176, 20);
            this.cbockVisitUser.Sql = "CommonSearch#getUserList";
            this.cbockVisitUser.TabIndex = 135;
            this.cbockVisitUser.Text = "[SELECT]";
            this.cbockVisitUser.ValueMember = "ITEM_CD";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(4, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 130;
            this.label9.Text = "고객 담당자";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(278, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 128;
            this.label7.Text = "승인 대상";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalStartTm
            // 
            this.CalStartTm.CustomFormat = "yyyy년 MM월 dd일 HH:mm:ss";
            this.CalStartTm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CalStartTm.Location = new System.Drawing.Point(98, 87);
            this.CalStartTm.Name = "CalStartTm";
            this.CalStartTm.Size = new System.Drawing.Size(176, 21);
            this.CalStartTm.TabIndex = 127;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(98, 141);
            this.txtDesc.MaxLength = 4000;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(448, 482);
            this.txtDesc.TabIndex = 125;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(4, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 482);
            this.label13.TabIndex = 114;
            this.label13.Text = "상세 내용";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(4, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 107;
            this.label8.Text = "방문 일시";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(4, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 101;
            this.label10.Text = "장소";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.AllowUserToResizeRows = false;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 34);
            this.gd_List.Name = "gd_List";
            this.gd_List.ReadOnly = true;
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.Size = new System.Drawing.Size(375, 631);
            this.gd_List.TabIndex = 35;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetVisitHistoryItem);
            // 
            // AssignHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AssignHistory";
            this.Size = new System.Drawing.Size(1201, 665);
            this.Load += new System.EventHandler(this.AssignHistory_Load);
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cboComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnExcel;
        private Control.CheckComboBox cboCstUser;
        private System.Windows.Forms.Label label16;
        private Control.CheckComboBox cbockVisitUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker CalStartTm;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtSite;
        private Control.MYCGrid gd_List;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker CalEndTm;
    }
}
