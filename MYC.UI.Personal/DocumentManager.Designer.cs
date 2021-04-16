
namespace MYC.UI.Personal
{
    partial class DocumentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentManager));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gd_List = new Control.MYCGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbTitle = new System.Windows.Forms.Label();
            this.gd_Doc = new Control.MYCGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboDocType = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbModelSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            this.PlMainBody.SuspendLayout();
            this.PlSearchBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Doc)).BeginInit();
            this.panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMainBody
            // 
            this.PlMainBody.Controls.Add(this.splitContainer1);
            // 
            // PlSearchBody
            // 
            this.PlSearchBody.Controls.Add(this.Panel2);
            this.PlSearchBody.Controls.Add(this.LbModelSearch);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gd_List);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gd_Doc);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(814, 595);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 0;
            // 
            // gd_List
            // 
            this.gd_List.AllowUserToAddRows = false;
            this.gd_List.AllowUserToDeleteRows = false;
            this.gd_List.AllowUserToResizeRows = false;
            this.gd_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_List.Location = new System.Drawing.Point(0, 42);
            this.gd_List.MultiSelect = false;
            this.gd_List.Name = "gd_List";
            this.gd_List.RowHeadersVisible = false;
            this.gd_List.RowTemplate.Height = 23;
            this.gd_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_List.Size = new System.Drawing.Size(814, 228);
            this.gd_List.TabIndex = 9;
            this.gd_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewDocumentList);
            this.gd_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DocumentInsert);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LbTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 42);
            this.panel3.TabIndex = 8;
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbTitle.Location = new System.Drawing.Point(3, 11);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(96, 15);
            this.LbTitle.TabIndex = 126;
            this.LbTitle.Text = "■ 문서 목록";
            // 
            // gd_Doc
            // 
            this.gd_Doc.AllowUserToAddRows = false;
            this.gd_Doc.AllowUserToDeleteRows = false;
            this.gd_Doc.AllowUserToResizeRows = false;
            this.gd_Doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_Doc.Location = new System.Drawing.Point(0, 42);
            this.gd_Doc.MultiSelect = false;
            this.gd_Doc.Name = "gd_Doc";
            this.gd_Doc.RowHeadersVisible = false;
            this.gd_Doc.RowTemplate.Height = 23;
            this.gd_Doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gd_Doc.Size = new System.Drawing.Size(814, 279);
            this.gd_Doc.TabIndex = 10;
            this.gd_Doc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExcelExport);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 42);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 126;
            this.label7.Text = "■ 상세 정보";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.dtTo);
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.dtFrom);
            this.Panel2.Controls.Add(this.label18);
            this.Panel2.Controls.Add(this.btnSearch);
            this.Panel2.Controls.Add(this.cboDocType);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 28);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(220, 137);
            this.Panel2.TabIndex = 88;
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Location = new System.Drawing.Point(78, 42);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(134, 21);
            this.dtTo.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 97;
            this.label3.Text = "~";
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "";
            this.dtFrom.Location = new System.Drawing.Point(78, 6);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(134, 21);
            this.dtFrom.TabIndex = 96;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(1, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 12);
            this.label18.TabIndex = 95;
            this.label18.Text = "조회 기간";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(0, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 27);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // cboDocType
            // 
            this.cboDocType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDocType.DisplayMember = "ITEM_NM";
            this.cboDocType.DropDownHeight = 1;
            this.cboDocType.FormattingEnabled = true;
            this.cboDocType.IntegralHeight = false;
            this.cboDocType.Location = new System.Drawing.Point(78, 76);
            this.cboDocType.Margin = new System.Windows.Forms.Padding(0);
            this.cboDocType.MultiSelection = true;
            this.cboDocType.Name = "cboDocType";
            this.cboDocType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboDocType.Params")));
            this.cboDocType.Size = new System.Drawing.Size(134, 20);
            this.cboDocType.Sql = "CommonSearch#getCommonItems";
            this.cboDocType.TabIndex = 82;
            this.cboDocType.Text = "[SELECT]";
            this.cboDocType.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "문서명";
            // 
            // LbModelSearch
            // 
            this.LbModelSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.LbModelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbModelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbModelSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbModelSearch.Location = new System.Drawing.Point(0, 0);
            this.LbModelSearch.Name = "LbModelSearch";
            this.LbModelSearch.Size = new System.Drawing.Size(220, 28);
            this.LbModelSearch.TabIndex = 87;
            this.LbModelSearch.Text = "조회 조건";
            this.LbModelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DocumentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DocumentManager";
            this.Load += new System.EventHandler(this.DocumentManager_load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            this.PlMainBody.ResumeLayout(false);
            this.PlSearchBody.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gd_List)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Doc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSearch;
        private Control.CheckComboBox cboDocType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbModelSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbTitle;
        private Control.MYCGrid gd_List;
        private Control.MYCGrid gd_Doc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}
