using System;
using System.Windows.Forms;
namespace WinFormLm
{
    partial class FormStaff
    {
        /// <summary>
        /// C# 无边框窗体移动
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="msg"></param>
        /// <param name="wparam"></param>
        /// <param name="lparam"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wparam, int lparam);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键  
            {
                Capture = false;//释放鼠标，使能够手动操作  
                SendMessage(this.Handle, 0x00A1, 2, 0);//拖动窗体  
            }
        }  


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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtEmployee_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblSNBegin = new System.Windows.Forms.Label();
            this.lblSNEnd = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtReNewPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.lblReNewPwd = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdoPublic = new System.Windows.Forms.RadioButton();
            this.rdoPersonal = new System.Windows.Forms.RadioButton();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.lblcheckOut = new System.Windows.Forms.Label();
            this.lblcheckIn = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblMix = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.帮助ToolStripMenuItem.Text = "帮助(H)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.helpToolStripMenuItem.Text = "查看帮助(H)";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.txtEmployee_id);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dgvStatistics);
            this.tabPage3.Controls.Add(this.dTP1);
            this.tabPage3.Controls.Add(this.dTP2);
            this.tabPage3.Controls.Add(this.btnQuery);
            this.tabPage3.Controls.Add(this.lblSNBegin);
            this.tabPage3.Controls.Add(this.lblSNEnd);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(778, 599);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "黑色异常查询";
            // 
            // txtEmployee_id
            // 
            this.txtEmployee_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmployee_id.Location = new System.Drawing.Point(523, 58);
            this.txtEmployee_id.MaxLength = 8;
            this.txtEmployee_id.Name = "txtEmployee_id";
            this.txtEmployee_id.Size = new System.Drawing.Size(160, 22);
            this.txtEmployee_id.TabIndex = 13;
            this.txtEmployee_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployee_id_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "按工号查询：";
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AllowUserToAddRows = false;
            this.dgvStatistics.AllowUserToDeleteRows = false;
            this.dgvStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvStatistics.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStatistics.GridColor = System.Drawing.Color.Black;
            this.dgvStatistics.Location = new System.Drawing.Point(29, 101);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvStatistics.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStatistics.RowTemplate.Height = 23;
            this.dgvStatistics.Size = new System.Drawing.Size(716, 471);
            this.dgvStatistics.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "SN";
            this.Column1.FillWeight = 90F;
            this.Column1.HeaderText = "SN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "SNCheckIn";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.FillWeight = 70F;
            this.Column2.HeaderText = "SNCheckIn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "SNCheckOut";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.FillWeight = 70F;
            this.Column3.HeaderText = "SNCheckOut";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Minute";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.FillWeight = 28F;
            this.Column4.HeaderText = "Minute";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "employee_id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "employee_id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dTP1
            // 
            this.dTP1.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP1.Location = new System.Drawing.Point(109, 18);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(196, 22);
            this.dTP1.TabIndex = 6;
            // 
            // dTP2
            // 
            this.dTP2.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP2.Location = new System.Drawing.Point(109, 55);
            this.dTP2.Name = "dTP2";
            this.dTP2.Size = new System.Drawing.Size(196, 22);
            this.dTP2.TabIndex = 5;
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.Location = new System.Drawing.Point(702, 60);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(43, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblSNBegin
            // 
            this.lblSNBegin.AutoSize = true;
            this.lblSNBegin.Location = new System.Drawing.Point(26, 21);
            this.lblSNBegin.Name = "lblSNBegin";
            this.lblSNBegin.Size = new System.Drawing.Size(77, 13);
            this.lblSNBegin.TabIndex = 1;
            this.lblSNBegin.Text = "开始时间：";
            // 
            // lblSNEnd
            // 
            this.lblSNEnd.AutoSize = true;
            this.lblSNEnd.Location = new System.Drawing.Point(26, 58);
            this.lblSNEnd.Name = "lblSNEnd";
            this.lblSNEnd.Size = new System.Drawing.Size(77, 13);
            this.lblSNEnd.TabIndex = 0;
            this.lblSNEnd.Text = "结束时间：";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.txtOldPwd);
            this.tabPage2.Controls.Add(this.txtReNewPwd);
            this.tabPage2.Controls.Add(this.txtNewPwd);
            this.tabPage2.Controls.Add(this.txtAccount);
            this.tabPage2.Controls.Add(this.lblOldPwd);
            this.tabPage2.Controls.Add(this.lblReNewPwd);
            this.tabPage2.Controls.Add(this.lblNewPwd);
            this.tabPage2.Controls.Add(this.lblAccount);
            this.tabPage2.Controls.Add(this.btnModifyPwd);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改密码";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(198, 125);
            this.txtOldPwd.MaxLength = 20;
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(100, 22);
            this.txtOldPwd.TabIndex = 6;
            // 
            // txtReNewPwd
            // 
            this.txtReNewPwd.Location = new System.Drawing.Point(198, 227);
            this.txtReNewPwd.MaxLength = 20;
            this.txtReNewPwd.Name = "txtReNewPwd";
            this.txtReNewPwd.PasswordChar = '*';
            this.txtReNewPwd.Size = new System.Drawing.Size(100, 22);
            this.txtReNewPwd.TabIndex = 3;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(198, 176);
            this.txtNewPwd.MaxLength = 20;
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(100, 22);
            this.txtNewPwd.TabIndex = 2;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(198, 77);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(100, 22);
            this.txtAccount.TabIndex = 1;
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.AutoSize = true;
            this.lblOldPwd.Location = new System.Drawing.Point(87, 125);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(57, 13);
            this.lblOldPwd.TabIndex = 5;
            this.lblOldPwd.Text = "原密码:";
            // 
            // lblReNewPwd
            // 
            this.lblReNewPwd.AutoSize = true;
            this.lblReNewPwd.Location = new System.Drawing.Point(87, 230);
            this.lblReNewPwd.Name = "lblReNewPwd";
            this.lblReNewPwd.Size = new System.Drawing.Size(85, 13);
            this.lblReNewPwd.TabIndex = 4;
            this.lblReNewPwd.Text = "确认新密码:";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(87, 176);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(57, 13);
            this.lblNewPwd.TabIndex = 4;
            this.lblNewPwd.Text = "新密码:";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(87, 77);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(57, 13);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "原账号:";
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.ForeColor = System.Drawing.Color.Black;
            this.btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPwd.Location = new System.Drawing.Point(130, 303);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(139, 41);
            this.btnModifyPwd.TabIndex = 0;
            this.btnModifyPwd.Text = "修改密码";
            this.btnModifyPwd.UseVisualStyleBackColor = true;
            this.btnModifyPwd.Click += new System.EventHandler(this.btnModifyPwd_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.rdoPublic);
            this.tabPage1.Controls.Add(this.rdoPersonal);
            this.tabPage1.Controls.Add(this.dgvReport);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblReport);
            this.tabPage1.Controls.Add(this.btnUpload);
            this.tabPage1.Controls.Add(this.txtCheckOut);
            this.tabPage1.Controls.Add(this.txtCheckIn);
            this.tabPage1.Controls.Add(this.lblcheckOut);
            this.tabPage1.Controls.Add(this.lblcheckIn);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "黑色异常录入";
            // 
            // rdoPublic
            // 
            this.rdoPublic.AutoSize = true;
            this.rdoPublic.Location = new System.Drawing.Point(142, 129);
            this.rdoPublic.Name = "rdoPublic";
            this.rdoPublic.Size = new System.Drawing.Size(97, 17);
            this.rdoPublic.TabIndex = 10;
            this.rdoPublic.Text = "SN公共录入";
            this.rdoPublic.UseVisualStyleBackColor = true;
            this.rdoPublic.Click += new System.EventHandler(this.rdoPublic_Click);
            // 
            // rdoPersonal
            // 
            this.rdoPersonal.AutoSize = true;
            this.rdoPersonal.Checked = true;
            this.rdoPersonal.Location = new System.Drawing.Point(39, 129);
            this.rdoPersonal.Name = "rdoPersonal";
            this.rdoPersonal.Size = new System.Drawing.Size(97, 17);
            this.rdoPersonal.TabIndex = 9;
            this.rdoPersonal.TabStop = true;
            this.rdoPersonal.Text = "SN个人录入";
            this.rdoPersonal.UseVisualStyleBackColor = true;
            this.rdoPersonal.Click += new System.EventHandler(this.rdoPersonal_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvReport.GridColor = System.Drawing.Color.White;
            this.dgvReport.Location = new System.Drawing.Point(39, 152);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.dgvReport.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvReport.RowTemplate.Height = 23;
            this.dgvReport.Size = new System.Drawing.Size(690, 420);
            this.dgvReport.TabIndex = 8;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "SN";
            this.Column10.HeaderText = "SN";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "SNCheckIn";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.FillWeight = 78F;
            this.Column6.HeaderText = "SNCheckIn";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "SNCheckOut";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column7.FillWeight = 78F;
            this.Column7.HeaderText = "SNCheckInOut";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "Minute";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column8.FillWeight = 30F;
            this.Column8.HeaderText = "Minute";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "employee_id";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column9.FillWeight = 50F;
            this.Column9.HeaderText = "employee_id";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(36, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(36, 109);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(35, 13);
            this.lblReport.TabIndex = 5;
            this.lblReport.Text = "汇报";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpload.ForeColor = System.Drawing.Color.Red;
            this.btnUpload.Location = new System.Drawing.Point(671, 114);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(58, 32);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "上传";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.AcceptsReturn = true;
            this.txtCheckOut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCheckOut.Location = new System.Drawing.Point(504, 55);
            this.txtCheckOut.MaxLength = 23;
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(225, 22);
            this.txtCheckOut.TabIndex = 2;
            this.txtCheckOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckOut_KeyDown);
            this.txtCheckOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckOut_KeyPress);
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.AcceptsReturn = true;
            this.txtCheckIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCheckIn.Location = new System.Drawing.Point(129, 52);
            this.txtCheckIn.MaxLength = 23;
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(225, 22);
            this.txtCheckIn.TabIndex = 2;
            this.txtCheckIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckIn_KeyDown);
            this.txtCheckIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckIn_KeyPress);
            // 
            // lblcheckOut
            // 
            this.lblcheckOut.AutoSize = true;
            this.lblcheckOut.Location = new System.Drawing.Point(403, 58);
            this.lblcheckOut.Name = "lblcheckOut";
            this.lblcheckOut.Size = new System.Drawing.Size(95, 13);
            this.lblcheckOut.TabIndex = 1;
            this.lblcheckOut.Text = "SNCheckOut:";
            // 
            // lblcheckIn
            // 
            this.lblcheckIn.AutoSize = true;
            this.lblcheckIn.Location = new System.Drawing.Point(36, 55);
            this.lblcheckIn.Name = "lblcheckIn";
            this.lblcheckIn.Size = new System.Drawing.Size(87, 13);
            this.lblcheckIn.TabIndex = 0;
            this.lblcheckIn.Text = "SNCheckIn:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 626);
            this.tabControl1.TabIndex = 2;
            // 
            // lblMix
            // 
            this.lblMix.AutoSize = true;
            this.lblMix.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMix.ForeColor = System.Drawing.Color.Transparent;
            this.lblMix.Location = new System.Drawing.Point(708, 8);
            this.lblMix.Name = "lblMix";
            this.lblMix.Size = new System.Drawing.Size(25, 16);
            this.lblMix.TabIndex = 3;
            this.lblMix.Text = "—";
            this.lblMix.Click += new System.EventHandler(this.lblMix_Click);
            this.lblMix.MouseLeave += new System.EventHandler(this.lblMix_MouseLeave);
            this.lblMix.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMix_MouseMove);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExit.ForeColor = System.Drawing.Color.Transparent;
            this.lblExit.Location = new System.Drawing.Point(757, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(25, 16);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "×";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblExit_MouseMove);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(787, 668);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblMix);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工界面";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.Shown += new System.EventHandler(this.FormStaff_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.TextBox txtReNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblOldPwd;
        private System.Windows.Forms.Label lblReNewPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.Label lblcheckOut;
        private System.Windows.Forms.Label lblcheckIn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblSNBegin;
        private System.Windows.Forms.Label lblSNEnd;
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.DateTimePicker dTP2;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployee_id;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblMix;
        private System.Windows.Forms.Label lblExit;
        private RadioButton rdoPublic;
        private RadioButton rdoPersonal;
    }
}