using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace WinFormLm
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            
            if(txtEmployee_id.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("工号为空，请重新输入！");
                return;
            }
            if (txtTcode.Text.Trim().Equals(string.Empty)) 
            {
                MessageBox.Show("密码为空，请重新输入密码！");
                return;
            }


            if (rdo_FAE.Checked.Equals(true)) 
            {
                fae_analyzer analyzer = new fae_analyzer()
                {
                    employee_id = txtEmployee_id.Text,
                    ITcode = txtTcode.Text.Trim()
                };

                string sql = "select*from fae_analyzer where employee_id=@employee_id and binary ITcode=@ITcode";
                MySqlParameter[] ps =
            {
                new MySqlParameter("@employee_id",analyzer.employee_id),
                new MySqlParameter("@ITcode",analyzer.ITcode)
            };

                if (analyzer.employee_id == "0")
                {
                    DataTable dt = SqlHelper.GetList(sql, ps);
                    if (dt.Rows.Count > 0)
                    {
                      FormMain fm = new FormMain();
                        fm.employee_id = txtEmployee_id.Text;
                        fm.ITcode = txtTcode.Text;
                        fm.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("账号，密码或用户类型错误，请重新登录！！");
                        return;
                    }

                }
                else 
                {
                    MessageBox.Show("账号，密码或用户类型错误，请重新登录！！");
                    return;
                }
               
            }
//-------------------------------------------------------------------------------------
            else if (rdo_staff.Checked.Equals(true))
            {
                fae_analyzer analyzer = new fae_analyzer()
                {
                    employee_id = txtEmployee_id.Text,
                    ITcode = txtTcode.Text.Trim()
                };

                string sql = "select*from fae_analyzer where employee_id=@employee_id and binary ITcode=@ITcode";
                MySqlParameter[] ps =
            {
                new MySqlParameter("@employee_id",analyzer.employee_id),
                new MySqlParameter("@ITcode",analyzer.ITcode)
            };
                if (analyzer.employee_id != "0")
                {
                    DataTable dt = SqlHelper.GetList(sql, ps);
                    if (dt.Rows.Count > 0)
                    {
                        FormStaff fs = new FormStaff();
 
                        fs.employee_id = txtEmployee_id.Text;
                        fs.ITcode = txtTcode.Text;
                        fs.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("账号，密码或用户类型错误，请重新登录！！");
                        return;
                    }
                }
                else 
                {
                    MessageBox.Show("账号，密码或用户类型错误，请重新登录！");
                    return;
                }

            }

          
        }

        private void lblMix_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void lblMix_MouseMove(object sender, MouseEventArgs e)
        {
            lblMix.ForeColor = Color.Black;
            lblMix.BackColor = Color.Transparent;
        }
        private void lblMix_MouseLeave(object sender, EventArgs e)
        {
            lblMix.ForeColor = Color.Transparent;
            lblMix.BackColor = Color.RoyalBlue;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblExit_MouseMove(object sender, MouseEventArgs e)
        {
            lblExit.ForeColor = Color.Transparent;
            lblExit.BackColor = Color.Red;
        }
        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Transparent;
            lblExit.BackColor = Color.RoyalBlue;
        }
    }
}
