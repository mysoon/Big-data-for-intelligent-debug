﻿namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Defect_item = new System.Windows.Forms.Label();
            this.dgvRootCauseFAE = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rootCause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbProductName = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cbbTestItem = new System.Windows.Forms.ComboBox();
            this.dgvRootCauseMES = new System.Windows.Forms.DataGridView();
            this.t1product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1TestCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1RootCause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.服务器设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.feOrBe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SnTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.testDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.analysisThink = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productName = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.defectCatalog = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRootCauseFAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRootCauseMES)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Defect_item
            // 
            this.Defect_item.AutoSize = true;
            this.Defect_item.Location = new System.Drawing.Point(3, 39);
            this.Defect_item.Name = "Defect_item";
            this.Defect_item.Size = new System.Drawing.Size(41, 12);
            this.Defect_item.TabIndex = 1;
            this.Defect_item.Text = "测试项";
            // 
            // dgvRootCauseFAE
            // 
            this.dgvRootCauseFAE.AllowUserToAddRows = false;
            this.dgvRootCauseFAE.AllowUserToDeleteRows = false;
            this.dgvRootCauseFAE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRootCauseFAE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRootCauseFAE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRootCauseFAE.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRootCauseFAE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRootCauseFAE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRootCauseFAE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRootCauseFAE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.testCode,
            this.analysisMethod,
            this.rootCause,
            this.count});
            this.dgvRootCauseFAE.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRootCauseFAE.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRootCauseFAE.GridColor = System.Drawing.SystemColors.Window;
            this.dgvRootCauseFAE.Location = new System.Drawing.Point(2, 11);
            this.dgvRootCauseFAE.Name = "dgvRootCauseFAE";
            this.dgvRootCauseFAE.RowHeadersVisible = false;
            this.dgvRootCauseFAE.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRootCauseFAE.RowTemplate.Height = 23;
            this.helpProvider1.SetShowHelp(this.dgvRootCauseFAE, true);
            this.dgvRootCauseFAE.Size = new System.Drawing.Size(891, 286);
            this.dgvRootCauseFAE.TabIndex = 10;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataPropertyName = "Product";
            this.Product.FillWeight = 10F;
            this.Product.HeaderText = "产品";
            this.Product.Name = "Product";
            // 
            // testCode
            // 
            this.testCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.testCode.DataPropertyName = "Test_code";
            this.testCode.FillWeight = 28F;
            this.testCode.HeaderText = "测试项";
            this.testCode.Name = "testCode";
            // 
            // analysisMethod
            // 
            this.analysisMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.analysisMethod.DataPropertyName = "Analysis_method";
            this.analysisMethod.FillWeight = 45F;
            this.analysisMethod.HeaderText = "分析过程";
            this.analysisMethod.Name = "analysisMethod";
            // 
            // rootCause
            // 
            this.rootCause.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rootCause.DataPropertyName = "Root_cause";
            this.rootCause.FillWeight = 12F;
            this.rootCause.HeaderText = "根本原因";
            this.rootCause.Name = "rootCause";
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count.DataPropertyName = "count(*)";
            this.count.FillWeight = 8F;
            this.count.HeaderText = "数量";
            this.count.Name = "count";
            // 
            // cbbProductName
            // 
            this.cbbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbProductName.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbProductName.FormattingEnabled = true;
            this.cbbProductName.Items.AddRange(new object[] {
            "A1000",
            "A2016",
            "A6000",
            "A6001",
            "A6002",
            "A6003",
            "A6005",
            "A600X",
            "A6020",
            "A6090",
            "A6091",
            "A6092",
            "A6093",
            "A6095",
            "A6096",
            "A6097",
            "A609X",
            "A6505",
            "ACHILLES LITE",
            "ACHILLES PLUS",
            "AFFINITY",
            "ALEXA MOD",
            "ANDY NA",
            "ANDY ROW",
            "ANDY4",
            "AQUA",
            "ASHLEY",
            "ASHLEY LITE",
            "ASHLEY NA",
            "ASHLEY小板",
            "BLADE3",
            "BLADE3-10 REF",
            "BLADE3 REFRESH",
            "BLAINE",
            "BOLT MOD",
            "COPPERFIELD",
            "D52",
            "DANTE",
            "EDSEL MOD",
            "GEORGE NA",
            "GEORGE ROW",
            "GOLDEN EAGLE",
            "GOLF LITE",
            "HEART",
            "HEART小板",
            "HOUDINI",
            "IBIS",
            "JUDO",
            "K33",
            "K52",
            "K53",
            "KUNTAO",
            "LCS MOD",
            "LENOVO YB-J912F",
            "LENOVO YB-J912L",
            "LENOVO YB1-X90F",
            "LENOVO YB1-X90L",
            "LENOVO YB1-X91F",
            "LENOVO YB1-X91L",
            "LYNX",
            "MODS",
            "OSLO H",
            "OSLO H小板",
            "OSLO M",
            "OSLO M小板",
            "P3588",
            "PB2-690Y",
            "PETANQUE 3G",
            "PETANQUE 4G",
            "PHINNY",
            "Q6003",
            "Q6005",
            "Q6006",
            "Q6008",
            "RIO H",
            "RIO M",
            "ROBUSTA",
            "ROBUSTA NOTE",
            "ROBUSTA S",
            "ROBUSTA X",
            "ROBUSTA2",
            "ROBUSTA2小板",
            "ROSSION",
            "RUGBY",
            "RUGBY GO",
            "RUGBY 小板",
            "SHELBY",
            "SHELBY PLUS",
            "SPIDER",
            "STINGRAY",
            "SURF",
            "TAICHI-B",
            "TELLER",
            "TVCAST MOD",
            "V7",
            "V7小板",
            "VECTOR",
            "VECTOR MAXX",
            "VECTOR THIN",
            "VERTEX",
            "VOYAGER",
            "X30",
            "X30L",
            "YETI",
            "YETI2",
            "Z2",
            "Z2 X",
            "ZA6505",
            "ZACH",
            "ZAP",
            "ZAP小板",
            "ZIPPO"});
            this.cbbProductName.Location = new System.Drawing.Point(50, 6);
            this.cbbProductName.Name = "cbbProductName";
            this.cbbProductName.Size = new System.Drawing.Size(157, 20);
            this.cbbProductName.Sorted = true;
            this.cbbProductName.TabIndex = 12;
            this.cbbProductName.Text = "--请输入产品名--";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(679, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(58, 21);
            this.btnQuery.TabIndex = 14;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cbbTestItem
            // 
            this.cbbTestItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbTestItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTestItem.FormattingEnabled = true;
            this.cbbTestItem.Items.AddRange(new object[] {
            "2G",
            "3G",
            "4G",
            "ACC",
            "ADB",
            "AFC",
            "AMPS",
            "ANDROID",
            "ANT",
            "APK",
            "AUDIO",
            "AUX",
            "BAT",
            "BLUE",
            "BT",
            "C1900",
            "C800",
            "CAL",
            "CAMERA",
            "CAP",
            "CDMA",
            "CFC",
            "CHARGE",
            "CHECK",
            "CONNECT",
            "CQA",
            "DCS",
            "DO",
            "ERR",
            "ESC",
            "FAST",
            "FM",
            "FULL",
            "G18",
            "G19",
            "G85",
            "G9",
            "GET",
            "GPS",
            "GSM",
            "HEADSET",
            "HW",
            "LED",
            "LTE",
            "MAGNET",
            "MIC",
            "MMC",
            "MMI",
            "MOD",
            "MTK",
            "NFC",
            "NSFT",
            "OTG",
            "PA",
            "POWER",
            "PROX",
            "QBOOT",
            "QC",
            "QSC",
            "READ",
            "REAR",
            "RF",
            "ROI",
            "SAR",
            "SD",
            "SENSOR",
            "SIM",
            "SUPEND",
            "SWITCH",
            "TD",
            "TP",
            "USB",
            "VERIFY",
            "VIBRATOR",
            "WAIT",
            "WCDMA",
            "WIFI",
            "WLAN",
            "XO",
            "按键",
            "背光",
            "不",
            "充电",
            "触",
            "磁",
            "待机",
            "电池",
            "电流",
            "耳机",
            "关",
            "光",
            "黑",
            "后",
            "加",
            "键",
            "开",
            "喇叭",
            "蓝牙",
            "铃",
            "漏",
            "录",
            "马达",
            "麦克",
            "拍",
            "屏",
            "前",
            "切",
            "闪",
            "射频",
            "摄",
            "天测",
            "听筒",
            "无",
            "下载",
            "显示",
            "小板",
            "校准",
            "写",
            "信号",
            "扬声器",
            "音",
            "右",
            "指",
            "重",
            "主",
            "自动",
            "左"});
            this.cbbTestItem.Location = new System.Drawing.Point(50, 39);
            this.cbbTestItem.Name = "cbbTestItem";
            this.cbbTestItem.Size = new System.Drawing.Size(157, 20);
            this.cbbTestItem.Sorted = true;
            this.cbbTestItem.TabIndex = 19;
            this.cbbTestItem.Text = "--请输入关键字--";
            // 
            // dgvRootCauseMES
            // 
            this.dgvRootCauseMES.AllowUserToAddRows = false;
            this.dgvRootCauseMES.AllowUserToDeleteRows = false;
            this.dgvRootCauseMES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRootCauseMES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRootCauseMES.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRootCauseMES.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRootCauseMES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRootCauseMES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvRootCauseMES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t1product,
            this.t1TestCode,
            this.t1RootCause,
            this.total,
            this.percent});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRootCauseMES.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRootCauseMES.GridColor = System.Drawing.SystemColors.Window;
            this.dgvRootCauseMES.Location = new System.Drawing.Point(3, 6);
            this.dgvRootCauseMES.Name = "dgvRootCauseMES";
            this.dgvRootCauseMES.RowHeadersVisible = false;
            this.dgvRootCauseMES.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRootCauseMES.RowTemplate.Height = 23;
            this.helpProvider1.SetShowHelp(this.dgvRootCauseMES, true);
            this.dgvRootCauseMES.Size = new System.Drawing.Size(890, 299);
            this.dgvRootCauseMES.TabIndex = 23;
            // 
            // t1product
            // 
            this.t1product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t1product.DataPropertyName = "Product";
            this.t1product.FillWeight = 16F;
            this.t1product.HeaderText = "产品";
            this.t1product.Name = "t1product";
            // 
            // t1TestCode
            // 
            this.t1TestCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t1TestCode.DataPropertyName = "Test_code";
            this.t1TestCode.FillWeight = 45F;
            this.t1TestCode.HeaderText = "测试项";
            this.t1TestCode.Name = "t1TestCode";
            // 
            // t1RootCause
            // 
            this.t1RootCause.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t1RootCause.DataPropertyName = "Root_cause";
            this.t1RootCause.FillWeight = 24F;
            this.t1RootCause.HeaderText = "根本原因";
            this.t1RootCause.Name = "t1RootCause";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.DataPropertyName = "Total";
            this.total.FillWeight = 8F;
            this.total.HeaderText = "数量";
            this.total.Name = "total";
            // 
            // percent
            // 
            this.percent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.percent.DataPropertyName = "Percent";
            this.percent.FillWeight = 8F;
            this.percent.HeaderText = "占比";
            this.percent.Name = "percent";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.服务器设置ToolStripMenuItem,
            this.Help,
            this.登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1299, 25);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 服务器设置ToolStripMenuItem
            // 
            this.服务器设置ToolStripMenuItem.Name = "服务器设置ToolStripMenuItem";
            this.服务器设置ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.服务器设置ToolStripMenuItem.Text = "服务器设置";
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(44, 21);
            this.Help.Text = "帮助";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem1.Text = "Help Press F1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.登录ToolStripMenuItem.Text = "登录";
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.登录ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1299, 708);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.feOrBe);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.SnTextBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Controls.Add(this.cbbProductName);
            this.tabPage1.Controls.Add(this.cbbTestItem);
            this.tabPage1.Controls.Add(this.Defect_item);
            this.tabPage1.Controls.Add(this.btnQuery);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1291, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据统计";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 37;
            this.label11.Text = "工艺段";
            // 
            // feOrBe
            // 
            this.feOrBe.FormattingEnabled = true;
            this.feOrBe.Items.AddRange(new object[] {
            "FE",
            "BE"});
            this.feOrBe.Location = new System.Drawing.Point(521, 36);
            this.feOrBe.Name = "feOrBe";
            this.feOrBe.Size = new System.Drawing.Size(130, 20);
            this.feOrBe.TabIndex = 36;
            this.feOrBe.Text = "FE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "FAE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(768, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 20);
            this.button1.TabIndex = 35;
            this.button1.Text = "导出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SnTextBox
            // 
            this.SnTextBox.Location = new System.Drawing.Point(521, 6);
            this.SnTextBox.Name = "SnTextBox";
            this.SnTextBox.Size = new System.Drawing.Size(130, 21);
            this.SnTextBox.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(498, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "SN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "结束日期";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(299, 36);
            this.dateTimePicker2.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 21);
            this.dateTimePicker2.TabIndex = 31;
            this.dateTimePicker2.Value = new System.DateTime(2018, 9, 6, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "开始日期";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 6);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 21);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "产品名";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 65);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvRootCauseFAE);
            this.splitContainer2.Panel1.Controls.Add(this.testDescription);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.analysisThink);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.chart1);
            this.splitContainer2.Panel2.Controls.Add(this.dgvRootCauseMES);
            this.splitContainer2.Size = new System.Drawing.Size(1282, 614);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 27;
            // 
            // testDescription
            // 
            this.testDescription.Location = new System.Drawing.Point(899, 8);
            this.testDescription.Name = "testDescription";
            this.testDescription.Size = new System.Drawing.Size(377, 50);
            this.testDescription.TabIndex = 29;
            this.testDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "测试项解释";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "分析思路";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // analysisThink
            // 
            this.analysisThink.Location = new System.Drawing.Point(899, 64);
            this.analysisThink.Name = "analysisThink";
            this.analysisThink.Size = new System.Drawing.Size(377, 233);
            this.analysisThink.TabIndex = 30;
            this.analysisThink.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "MES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart1.BorderlineColor = System.Drawing.Color.Gray;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.MaximumAutoSize = 33F;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(899, 6);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.ToolTip = "拷贝结果中的产品和测试项的全名，重新查询会得到精确的占比";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(377, 299);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.productName);
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1291, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "分析向导";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productName
            // 
            this.productName.FormattingEnabled = true;
            this.productName.Items.AddRange(new object[] {
            "Blaine",
            "Rossion",
            "Teller"});
            this.productName.Location = new System.Drawing.Point(77, 6);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(78, 20);
            this.productName.TabIndex = 0;
            this.productName.SelectedIndexChanged += new System.EventHandler(this.productName_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(-4, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.defectCatalog);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(922, 572);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.TabIndex = 9;
            // 
            // defectCatalog
            // 
            this.defectCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defectCatalog.FormattingEnabled = true;
            this.defectCatalog.ItemHeight = 12;
            this.defectCatalog.Location = new System.Drawing.Point(0, 0);
            this.defectCatalog.Name = "defectCatalog";
            this.defectCatalog.Size = new System.Drawing.Size(125, 572);
            this.defectCatalog.TabIndex = 1;
            this.defectCatalog.SelectedIndexChanged += new System.EventHandler(this.defectCatalog_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 586);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "按产品分类";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Administrator\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplicat" +
    "ion1\\WindowsFormsApplication1\\bin\\Debug\\大数据辅助分析系统v2.2安装使用说明.txt";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 736);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "大数据辅助分析系统v4.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRootCauseFAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRootCauseMES)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Defect_item;
        private System.Windows.Forms.DataGridView dgvRootCauseFAE;
        private System.Windows.Forms.ComboBox cbbProductName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cbbTestItem, cbbTestItemB;
        private System.Windows.Forms.DataGridView dgvRootCauseMES;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 服务器设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productName;
        private System.Windows.Forms.ListBox defectCatalog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox analysisThink;
        private System.Windows.Forms.RichTextBox testDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn testCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn analysisMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn rootCause;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1product;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1TestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1RootCause;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn percent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SnTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox feOrBe;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
    }
}

