namespace WinFormLm
{
    partial class FormLogin
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
            this.lblEmployee_id = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblITcode = new System.Windows.Forms.Label();
            this.txtTcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_staff = new System.Windows.Forms.RadioButton();
            this.rdo_FAE = new System.Windows.Forms.RadioButton();
            this.txtEmployee_id = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMix = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployee_id
            // 
            this.lblEmployee_id.AutoSize = true;
            this.lblEmployee_id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmployee_id.ForeColor = System.Drawing.Color.Black;
            this.lblEmployee_id.Location = new System.Drawing.Point(172, 35);
            this.lblEmployee_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee_id.Name = "lblEmployee_id";
            this.lblEmployee_id.Size = new System.Drawing.Size(51, 16);
            this.lblEmployee_id.TabIndex = 0;
            this.lblEmployee_id.Text = "工号:";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(254, 178);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 41);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblITcode
            // 
            this.lblITcode.AutoSize = true;
            this.lblITcode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblITcode.ForeColor = System.Drawing.Color.Black;
            this.lblITcode.Location = new System.Drawing.Point(172, 96);
            this.lblITcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblITcode.Name = "lblITcode";
            this.lblITcode.Size = new System.Drawing.Size(51, 16);
            this.lblITcode.TabIndex = 0;
            this.lblITcode.Text = "密码:";
            // 
            // txtTcode
            // 
            this.txtTcode.Font = new System.Drawing.Font("宋体", 18F);
            this.txtTcode.Location = new System.Drawing.Point(231, 96);
            this.txtTcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtTcode.MaxLength = 20;
            this.txtTcode.Multiline = true;
            this.txtTcode.Name = "txtTcode";
            this.txtTcode.PasswordChar = '*';
            this.txtTcode.Size = new System.Drawing.Size(171, 32);
            this.txtTcode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rdo_staff);
            this.groupBox1.Controls.Add(this.rdo_FAE);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.lblITcode);
            this.groupBox1.Controls.Add(this.txtEmployee_id);
            this.groupBox1.Controls.Add(this.lblEmployee_id);
            this.groupBox1.Controls.Add(this.txtTcode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(600, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rdo_staff
            // 
            this.rdo_staff.AutoSize = true;
            this.rdo_staff.Checked = true;
            this.rdo_staff.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_staff.ForeColor = System.Drawing.Color.Black;
            this.rdo_staff.Location = new System.Drawing.Point(354, 143);
            this.rdo_staff.Name = "rdo_staff";
            this.rdo_staff.Size = new System.Drawing.Size(51, 17);
            this.rdo_staff.TabIndex = 4;
            this.rdo_staff.TabStop = true;
            this.rdo_staff.Text = "员工";
            this.rdo_staff.UseVisualStyleBackColor = true;
            // 
            // rdo_FAE
            // 
            this.rdo_FAE.AutoSize = true;
            this.rdo_FAE.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_FAE.ForeColor = System.Drawing.Color.Black;
            this.rdo_FAE.Location = new System.Drawing.Point(234, 143);
            this.rdo_FAE.Name = "rdo_FAE";
            this.rdo_FAE.Size = new System.Drawing.Size(64, 17);
            this.rdo_FAE.TabIndex = 3;
            this.rdo_FAE.Text = "管理员";
            this.rdo_FAE.UseVisualStyleBackColor = true;
            // 
            // txtEmployee_id
            // 
            this.txtEmployee_id.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmployee_id.Location = new System.Drawing.Point(234, 29);
            this.txtEmployee_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployee_id.MaxLength = 8;
            this.txtEmployee_id.Multiline = true;
            this.txtEmployee_id.Name = "txtEmployee_id";
            this.txtEmployee_id.Size = new System.Drawing.Size(171, 33);
            this.txtEmployee_id.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(131, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 29);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "大数据辅助分析维修系统";
            // 
            // lblMix
            // 
            this.lblMix.AutoSize = true;
            this.lblMix.ForeColor = System.Drawing.Color.Transparent;
            this.lblMix.Location = new System.Drawing.Point(522, 9);
            this.lblMix.Name = "lblMix";
            this.lblMix.Size = new System.Drawing.Size(24, 16);
            this.lblMix.TabIndex = 7;
            this.lblMix.Text = "—";
            this.lblMix.Click += new System.EventHandler(this.lblMix_Click);
            this.lblMix.MouseLeave += new System.EventHandler(this.lblMix_MouseLeave);
            this.lblMix.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMix_MouseMove);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(564, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(24, 16);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "×";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblExit_MouseMove);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblMix);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee_id;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblITcode;
        private System.Windows.Forms.TextBox txtTcode;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdo_staff;
        private System.Windows.Forms.RadioButton rdo_FAE;
        private System.Windows.Forms.TextBox txtEmployee_id;
        private System.Windows.Forms.Label lblMix;
        private System.Windows.Forms.Label lblExit;
    }
}