
namespace MYC.UI.Personal.Popup
{
    partial class DocInsertPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocInsertPopup));
            this.txtDocDesc = new System.Windows.Forms.TextBox();
            this.labDocDesc = new System.Windows.Forms.Label();
            this.cboType = new MYC.Control.CheckComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLval = new MYC.Control.CheckComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUnload = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.gd_Details = new Control.MYCGrid();
            this.LbTitle = new System.Windows.Forms.Label();
            this.cboItem = new MYC.Control.CheckComboBox();
            this.labItem = new System.Windows.Forms.Label();
            this.labItem2 = new System.Windows.Forms.Label();
            this.txtItem2 = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labAmount = new System.Windows.Forms.Label();
            this.dtSchedule = new System.Windows.Forms.DateTimePicker();
            this.labSchedule = new System.Windows.Forms.Label();
            this.labContent = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.cboDocSlt = new MYC.Control.CheckComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocDesc
            // 
            this.txtDocDesc.Location = new System.Drawing.Point(91, 160);
            this.txtDocDesc.Multiline = true;
            this.txtDocDesc.Name = "txtDocDesc";
            this.txtDocDesc.Size = new System.Drawing.Size(449, 65);
            this.txtDocDesc.TabIndex = 115;
            // 
            // labDocDesc
            // 
            this.labDocDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labDocDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labDocDesc.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labDocDesc.Location = new System.Drawing.Point(15, 160);
            this.labDocDesc.Name = "labDocDesc";
            this.labDocDesc.Size = new System.Drawing.Size(75, 65);
            this.labDocDesc.TabIndex = 116;
            this.labDocDesc.Text = "상세 내용\r\n(비고)";
            this.labDocDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboType
            // 
            this.cboType.DisplayMember = "ITEM_NM";
            this.cboType.DropDownHeight = 1;
            this.cboType.FormattingEnabled = true;
            this.cboType.IntegralHeight = false;
            this.cboType.Location = new System.Drawing.Point(91, 40);
            this.cboType.Margin = new System.Windows.Forms.Padding(0);
            this.cboType.MultiSelection = false;
            this.cboType.Name = "cboType";
            this.cboType.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboType.Params")));
            this.cboType.Size = new System.Drawing.Size(180, 20);
            this.cboType.Sql = "CommonSearch#getCommonItems";
            this.cboType.TabIndex = 137;
            this.cboType.Text = "[SELECT]";
            this.cboType.ValueMember = "ITEM_CD";
            this.cboType.TextChanged += new System.EventHandler(this.EnableControls);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(15, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 136;
            this.label8.Text = "문서 종류";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboLval
            // 
            this.cboLval.DisplayMember = "ITEM_NM";
            this.cboLval.DropDownHeight = 1;
            this.cboLval.FormattingEnabled = true;
            this.cboLval.IntegralHeight = false;
            this.cboLval.Location = new System.Drawing.Point(360, 40);
            this.cboLval.Margin = new System.Windows.Forms.Padding(0);
            this.cboLval.MultiSelection = true;
            this.cboLval.Name = "cboLval";
            this.cboLval.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboLval.Params")));
            this.cboLval.Size = new System.Drawing.Size(180, 20);
            this.cboLval.Sql = "CommonSearch#getUserList";
            this.cboLval.TabIndex = 139;
            this.cboLval.Text = "[SELECT]";
            this.cboLval.ValueMember = "ITEM_CD";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(284, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 138;
            this.label1.Text = "추가 인원";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 140;
            this.label2.Text = "출장 목적";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(284, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 142;
            this.label3.Text = "출장 지역";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 146;
            this.label5.Text = "시작 일시";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "yyyy년 MM월 dd일 dddd";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(91, 70);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(180, 21);
            this.dtStart.TabIndex = 147;
            this.dtStart.ValueChanged += new System.EventHandler(this.DateTimeSet);
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "yyyy년 MM월 dd일 dddd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(360, 70);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(180, 21);
            this.dtEnd.TabIndex = 149;
            this.dtEnd.ValueChanged += new System.EventHandler(this.SetdtEnd);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(284, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 148;
            this.label6.Text = "종료 일시";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(360, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 150;
            this.btnSave.Text = "등 록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveDocument);
            // 
            // btnUnload
            // 
            this.btnUnload.Location = new System.Drawing.Point(465, 240);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(75, 23);
            this.btnUnload.TabIndex = 151;
            this.btnUnload.Text = "취 소";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.FormClose);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(360, 130);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(180, 20);
            this.btnDetails.TabIndex = 152;
            this.btnDetails.Text = "세 부 항 목";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.ShowDetails);
            // 
            // gd_Details
            // 
            this.gd_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_Details.Location = new System.Drawing.Point(560, 40);
            this.gd_Details.Name = "gd_Details";
            this.gd_Details.RowTemplate.Height = 23;
            this.gd_Details.Size = new System.Drawing.Size(271, 152);
            this.gd_Details.TabIndex = 153;
            this.gd_Details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetailItemSelect);
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbTitle.Location = new System.Drawing.Point(555, 15);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(96, 15);
            this.LbTitle.TabIndex = 155;
            this.LbTitle.Text = "■ 세부 항목";
            // 
            // cboItem
            // 
            this.cboItem.DisplayMember = "ITEM_NM";
            this.cboItem.DropDownHeight = 1;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.IntegralHeight = false;
            this.cboItem.Location = new System.Drawing.Point(651, 195);
            this.cboItem.Margin = new System.Windows.Forms.Padding(0);
            this.cboItem.MultiSelection = false;
            this.cboItem.Name = "cboItem";
            this.cboItem.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboItem.Params")));
            this.cboItem.Size = new System.Drawing.Size(180, 20);
            this.cboItem.Sql = "CommonSearch#getCommonItems";
            this.cboItem.TabIndex = 157;
            this.cboItem.Text = "[SELECT]";
            this.cboItem.ValueMember = "ITEM_CD";
            // 
            // labItem
            // 
            this.labItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labItem.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labItem.Location = new System.Drawing.Point(560, 194);
            this.labItem.Name = "labItem";
            this.labItem.Size = new System.Drawing.Size(90, 21);
            this.labItem.TabIndex = 156;
            this.labItem.Text = "항 목";
            this.labItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labItem2
            // 
            this.labItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labItem2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labItem2.Location = new System.Drawing.Point(560, 218);
            this.labItem2.Name = "labItem2";
            this.labItem2.Size = new System.Drawing.Size(90, 21);
            this.labItem2.TabIndex = 158;
            this.labItem2.Text = "세부 항목";
            this.labItem2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItem2
            // 
            this.txtItem2.Location = new System.Drawing.Point(651, 218);
            this.txtItem2.Name = "txtItem2";
            this.txtItem2.Size = new System.Drawing.Size(180, 21);
            this.txtItem2.TabIndex = 159;
            // 
            // txtAmount
            // 
            this.txtAmount.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtAmount.Location = new System.Drawing.Point(651, 242);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 21);
            this.txtAmount.TabIndex = 161;
            // 
            // labAmount
            // 
            this.labAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAmount.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labAmount.Location = new System.Drawing.Point(560, 242);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(90, 21);
            this.labAmount.TabIndex = 160;
            this.labAmount.Text = "금 액";
            this.labAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtSchedule
            // 
            this.dtSchedule.CustomFormat = "";
            this.dtSchedule.Location = new System.Drawing.Point(651, 194);
            this.dtSchedule.Name = "dtSchedule";
            this.dtSchedule.Size = new System.Drawing.Size(180, 21);
            this.dtSchedule.TabIndex = 163;
            // 
            // labSchedule
            // 
            this.labSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labSchedule.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labSchedule.Location = new System.Drawing.Point(560, 194);
            this.labSchedule.Name = "labSchedule";
            this.labSchedule.Size = new System.Drawing.Size(90, 21);
            this.labSchedule.TabIndex = 162;
            this.labSchedule.Text = "일 자";
            this.labSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labContent.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labContent.Location = new System.Drawing.Point(560, 217);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(90, 65);
            this.labContent.TabIndex = 165;
            this.labContent.Text = "업무 내용";
            this.labContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(651, 217);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(180, 65);
            this.txtDesc.TabIndex = 166;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(756, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 167;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.DataUpdate);
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(360, 100);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(180, 21);
            this.txtSite.TabIndex = 170;
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(91, 100);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(180, 21);
            this.txtSub.TabIndex = 171;
            // 
            // cboDocSlt
            // 
            this.cboDocSlt.DisplayMember = "ITEM_NM";
            this.cboDocSlt.DropDownHeight = 1;
            this.cboDocSlt.FormattingEnabled = true;
            this.cboDocSlt.IntegralHeight = false;
            this.cboDocSlt.Location = new System.Drawing.Point(91, 130);
            this.cboDocSlt.Margin = new System.Windows.Forms.Padding(0);
            this.cboDocSlt.MultiSelection = false;
            this.cboDocSlt.Name = "cboDocSlt";
            this.cboDocSlt.Params = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("cboDocSlt.Params")));
            this.cboDocSlt.Size = new System.Drawing.Size(180, 20);
            this.cboDocSlt.Sql = "CommonSearch#getDocList";
            this.cboDocSlt.TabIndex = 173;
            this.cboDocSlt.Text = "[SELECT]";
            this.cboDocSlt.ValueMember = "ITEM_CD";
            this.cboDocSlt.TextChanged += new System.EventHandler(this.DocImport);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 172;
            this.label4.Text = "참고 문서";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(12, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 174;
            this.label7.Text = "■ 문서 내용";
            // 
            // DocInsertPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 291);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboDocSlt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.labContent);
            this.Controls.Add(this.dtSchedule);
            this.Controls.Add(this.labSchedule);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labAmount);
            this.Controls.Add(this.txtItem2);
            this.Controls.Add(this.labItem2);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.labItem);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.gd_Details);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnUnload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDocDesc);
            this.Controls.Add(this.labDocDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DocInsertPopup";
            this.Text = "문서 등록";
            this.Load += new System.EventHandler(this.DocInsertPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gd_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocDesc;
        private System.Windows.Forms.Label labDocDesc;
        private System.Windows.Forms.Label label8;
        private Control.CheckComboBox cboLval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.Button btnDetails;
        private Control.MYCGrid gd_Details;
        private System.Windows.Forms.Label LbTitle;
        private Control.CheckComboBox cboItem;
        private System.Windows.Forms.Label labItem;
        private System.Windows.Forms.Label labItem2;
        private System.Windows.Forms.TextBox txtItem2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.DateTimePicker dtSchedule;
        private System.Windows.Forms.Label labSchedule;
        private System.Windows.Forms.Label labContent;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtSub;
        private Control.CheckComboBox cboDocSlt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Control.CheckComboBox cboType;
    }
}