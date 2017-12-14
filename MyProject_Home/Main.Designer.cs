namespace MyProject_Home
{
    partial class frmMain
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
            this.btnCancellation = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtPickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.cboxSearch = new System.Windows.Forms.ComboBox();
            this.lblCurrentUserName = new System.Windows.Forms.Label();
            this.cboxCreateTime = new System.Windows.Forms.CheckBox();
            this.dtPickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFristPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPageIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboxPageSize = new System.Windows.Forms.ComboBox();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblDataCount = new System.Windows.Forms.Label();
            this.linklblAdd = new System.Windows.Forms.LinkLabel();
            this.linklblEdit = new System.Windows.Forms.LinkLabel();
            this.linklblDelete = new System.Windows.Forms.LinkLabel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumptionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancellation
            // 
            this.btnCancellation.Location = new System.Drawing.Point(189, 10);
            this.btnCancellation.Name = "btnCancellation";
            this.btnCancellation.Size = new System.Drawing.Size(75, 23);
            this.btnCancellation.TabIndex = 0;
            this.btnCancellation.Text = "注销";
            this.btnCancellation.UseVisualStyleBackColor = true;
            this.btnCancellation.Click += new System.EventHandler(this.btnCancellation_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1152, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(397, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 21);
            this.txtSearch.TabIndex = 3;
            // 
            // dtPickerEndTime
            // 
            this.dtPickerEndTime.Location = new System.Drawing.Point(946, 9);
            this.dtPickerEndTime.Name = "dtPickerEndTime";
            this.dtPickerEndTime.Size = new System.Drawing.Size(200, 21);
            this.dtPickerEndTime.TabIndex = 4;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToOrderColumns = true;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColUserName,
            this.ColCreateTime,
            this.ColUpdateTime,
            this.ColIsValid,
            this.FullName,
            this.Phone,
            this.Gender,
            this.Account,
            this.ConsumptionTime,
            this.AccountRemarks,
            this.Address,
            this.Remarks});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowTemplate.Height = 23;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1506, 726);
            this.dgvCustomer.TabIndex = 5;
            // 
            // cboxSearch
            // 
            this.cboxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSearch.FormattingEnabled = true;
            this.cboxSearch.Items.AddRange(new object[] {
            "姓名",
            "手机号",
            "备注(模糊)"});
            this.cboxSearch.Location = new System.Drawing.Point(270, 12);
            this.cboxSearch.Name = "cboxSearch";
            this.cboxSearch.Size = new System.Drawing.Size(121, 20);
            this.cboxSearch.TabIndex = 6;
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Location = new System.Drawing.Point(17, 15);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.Size = new System.Drawing.Size(77, 12);
            this.lblCurrentUserName.TabIndex = 8;
            this.lblCurrentUserName.Text = "当前登录用户";
            // 
            // cboxCreateTime
            // 
            this.cboxCreateTime.AutoSize = true;
            this.cboxCreateTime.Location = new System.Drawing.Point(645, 14);
            this.cboxCreateTime.Name = "cboxCreateTime";
            this.cboxCreateTime.Size = new System.Drawing.Size(72, 16);
            this.cboxCreateTime.TabIndex = 9;
            this.cboxCreateTime.Text = "创建日期";
            this.cboxCreateTime.UseVisualStyleBackColor = true;
            // 
            // dtPickerStartTime
            // 
            this.dtPickerStartTime.Location = new System.Drawing.Point(723, 9);
            this.dtPickerStartTime.Name = "dtPickerStartTime";
            this.dtPickerStartTime.Size = new System.Drawing.Size(200, 21);
            this.dtPickerStartTime.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(929, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "-";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.linklblDelete);
            this.splitContainer1.Panel1.Controls.Add(this.linklblEdit);
            this.splitContainer1.Panel1.Controls.Add(this.linklblAdd);
            this.splitContainer1.Panel1.Controls.Add(this.comboxPageSize);
            this.splitContainer1.Panel1.Controls.Add(this.btnGo);
            this.splitContainer1.Panel1.Controls.Add(this.txtPageIndex);
            this.splitContainer1.Panel1.Controls.Add(this.btnLastPage);
            this.splitContainer1.Panel1.Controls.Add(this.btnNextPage);
            this.splitContainer1.Panel1.Controls.Add(this.btnPreviousPage);
            this.splitContainer1.Panel1.Controls.Add(this.btnFristPage);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lblDataCount);
            this.splitContainer1.Panel1.Controls.Add(this.lblPageCount);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.cboxSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancellation);
            this.splitContainer1.Panel1.Controls.Add(this.cboxCreateTime);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentUserName);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.dtPickerEndTime);
            this.splitContainer1.Panel1.Controls.Add(this.dtPickerStartTime);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCustomer);
            this.splitContainer1.Size = new System.Drawing.Size(1506, 801);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "每页";
            // 
            // btnFristPage
            // 
            this.btnFristPage.Location = new System.Drawing.Point(122, 39);
            this.btnFristPage.Name = "btnFristPage";
            this.btnFristPage.Size = new System.Drawing.Size(75, 23);
            this.btnFristPage.TabIndex = 12;
            this.btnFristPage.Text = "第一页";
            this.btnFristPage.UseVisualStyleBackColor = true;
            this.btnFristPage.Click += new System.EventHandler(this.btnFristPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(203, 39);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousPage.TabIndex = 13;
            this.btnPreviousPage.Text = "上一页";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(284, 39);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 13;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(365, 39);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 23);
            this.btnLastPage.TabIndex = 13;
            this.btnLastPage.Text = "末页";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "当前第：";
            // 
            // txtPageIndex
            // 
            this.txtPageIndex.Location = new System.Drawing.Point(505, 41);
            this.txtPageIndex.Name = "txtPageIndex";
            this.txtPageIndex.Size = new System.Drawing.Size(45, 21);
            this.txtPageIndex.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "页";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(579, 39);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(33, 23);
            this.btnGo.TabIndex = 15;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "条记录";
            // 
            // comboxPageSize
            // 
            this.comboxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxPageSize.FormattingEnabled = true;
            this.comboxPageSize.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100",
            "200"});
            this.comboxPageSize.Location = new System.Drawing.Point(653, 41);
            this.comboxPageSize.Name = "comboxPageSize";
            this.comboxPageSize.Size = new System.Drawing.Size(70, 20);
            this.comboxPageSize.TabIndex = 16;
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(776, 44);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(65, 12);
            this.lblPageCount.TabIndex = 11;
            this.lblPageCount.Text = "共[]页记录";
            // 
            // lblDataCount
            // 
            this.lblDataCount.AutoSize = true;
            this.lblDataCount.Location = new System.Drawing.Point(866, 44);
            this.lblDataCount.Name = "lblDataCount";
            this.lblDataCount.Size = new System.Drawing.Size(65, 12);
            this.lblDataCount.TabIndex = 11;
            this.lblDataCount.Text = "共[]条记录";
            // 
            // linklblAdd
            // 
            this.linklblAdd.AutoSize = true;
            this.linklblAdd.Location = new System.Drawing.Point(17, 44);
            this.linklblAdd.Name = "linklblAdd";
            this.linklblAdd.Size = new System.Drawing.Size(29, 12);
            this.linklblAdd.TabIndex = 17;
            this.linklblAdd.TabStop = true;
            this.linklblAdd.Text = "新增";
            this.linklblAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblAdd_LinkClicked);
            // 
            // linklblEdit
            // 
            this.linklblEdit.AutoSize = true;
            this.linklblEdit.Location = new System.Drawing.Point(52, 44);
            this.linklblEdit.Name = "linklblEdit";
            this.linklblEdit.Size = new System.Drawing.Size(29, 12);
            this.linklblEdit.TabIndex = 17;
            this.linklblEdit.TabStop = true;
            this.linklblEdit.Text = "修改";
            this.linklblEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblEdit_LinkClicked);
            // 
            // linklblDelete
            // 
            this.linklblDelete.AutoSize = true;
            this.linklblDelete.Location = new System.Drawing.Point(87, 44);
            this.linklblDelete.Name = "linklblDelete";
            this.linklblDelete.Size = new System.Drawing.Size(29, 12);
            this.linklblDelete.TabIndex = 17;
            this.linklblDelete.TabStop = true;
            this.linklblDelete.Text = "删除";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ColUserName
            // 
            this.ColUserName.DataPropertyName = "UserName";
            this.ColUserName.HeaderText = "UserName";
            this.ColUserName.Name = "ColUserName";
            this.ColUserName.ReadOnly = true;
            this.ColUserName.Visible = false;
            // 
            // ColCreateTime
            // 
            this.ColCreateTime.DataPropertyName = "CreateTime";
            this.ColCreateTime.HeaderText = "CreateTime";
            this.ColCreateTime.Name = "ColCreateTime";
            this.ColCreateTime.ReadOnly = true;
            this.ColCreateTime.Visible = false;
            // 
            // ColUpdateTime
            // 
            this.ColUpdateTime.DataPropertyName = "UpdateTime";
            this.ColUpdateTime.HeaderText = "UpdateTime";
            this.ColUpdateTime.Name = "ColUpdateTime";
            this.ColUpdateTime.ReadOnly = true;
            this.ColUpdateTime.Visible = false;
            // 
            // ColIsValid
            // 
            this.ColIsValid.DataPropertyName = "IsValid";
            this.ColIsValid.HeaderText = "IsValid";
            this.ColIsValid.Name = "ColIsValid";
            this.ColIsValid.ReadOnly = true;
            this.ColIsValid.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "姓名";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "电话";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "Account";
            this.Account.HeaderText = "付款";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // ConsumptionTime
            // 
            this.ConsumptionTime.DataPropertyName = "ConsumptionTime";
            this.ConsumptionTime.HeaderText = "付款时间";
            this.ConsumptionTime.Name = "ConsumptionTime";
            this.ConsumptionTime.ReadOnly = true;
            // 
            // AccountRemarks
            // 
            this.AccountRemarks.DataPropertyName = "AccountRemarks";
            this.AccountRemarks.HeaderText = "付款备注";
            this.AccountRemarks.Name = "AccountRemarks";
            this.AccountRemarks.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "家庭住址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 500;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "备注";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 500;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 801);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "用户信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancellation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtPickerEndTime;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.ComboBox cboxSearch;
        private System.Windows.Forms.Label lblCurrentUserName;
        private System.Windows.Forms.CheckBox cboxCreateTime;
        private System.Windows.Forms.DateTimePicker dtPickerStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFristPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtPageIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboxPageSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblDataCount;
        private System.Windows.Forms.LinkLabel linklblDelete;
        private System.Windows.Forms.LinkLabel linklblEdit;
        private System.Windows.Forms.LinkLabel linklblAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIsValid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumptionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}