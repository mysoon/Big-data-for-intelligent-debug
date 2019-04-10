using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using WindowsFormsApplication1;

namespace WinFormLm
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }
        //接受登录窗口传值，定义全局变量
        public string employee_id;
        public string ITcode;

        public object Form1BAK { get; private set; }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormStaff_Load(object sender, EventArgs e)
        {
            //修改密码界面账号显示
            txtAccount.Text = employee_id;

            rdoPersonal_Click(null,null);
        }


//----------------------------------------------------------修改密码界面-------------------------------------------------------------------------------------
        /// <summary>
        /// 修改密码界面验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            
            if (txtAccount.Text=="") 
            {
                MessageBox.Show("原账号不能为空！");
                return;
            }

            if (txtOldPwd.Text=="")
            {
                MessageBox.Show("原密码不能为空！");
                return;
            }

            if (txtNewPwd.Text=="")
            {
                MessageBox.Show("新密码不能为空！");
                return;
               
            }

            if (txtReNewPwd.Text=="")
            {
                MessageBox.Show("确认密码不能为空！");
                return;
            }

            fae_analyzer analyzer = new fae_analyzer();
            analyzer.ITcode = txtNewPwd.Text;
            analyzer.employee_id = txtAccount.Text;

            if (txtOldPwd.Text != ITcode) 
            {
                MessageBox.Show("原密码输入错误，请重新输入！");
                return;
            }

            if (txtOldPwd.Text.Trim() == txtNewPwd.Text.Trim()) 
            {
                MessageBox.Show("新密码不能与原密码相同！请重设密码！");
                return;
            }

            if (txtReNewPwd.Text != txtNewPwd.Text) 
            {
                MessageBox.Show("确认密码与新密码不一致，请重新输入！");
                return;
            }

            string sql = string.Format("update fae_analyzer set ITcode='{0}' where employee_id='{1}'"
                                        , analyzer.ITcode, analyzer.employee_id);

            if (SqlHelper.modify(sql))
            {
                MessageBox.Show("修改密码成功,请重新登录！");
                FormLogin fl = new FormLogin();
                fl.Show();
                this.Visible = false;
            }
            else 
            {
                MessageBox.Show("修改密码失败！");
                return;
            }
           
        }





//----------------------------------------------------------录入黑色异常时间界面-------------------------------------------------------------------------------------
        

        /// <summary>
        /// 添加【CkTimeInfo】表中SN，SNCheckIn,employee_id数据
        /// </summary>
        /// <returns></returns>
        private bool InserSNcheckIn()
        {
            CkTimeInfo ck = new CkTimeInfo();
            ck.SN = txtCheckIn.Text.Trim();
            ck.SNCheckIn = DateTime.Now.ToString();

            string sql = string.Format("insert into cktimeinfo(employee_id,SN,SNCheckIn)values ('{0}','{1}','{2}')"
                                        , employee_id, ck.SN, ck.SNCheckIn);
            return SqlHelper.modify(sql);

        }

        
        
        /// <summary>
        /// 删除【CkTimeInfo】表中重复数据
        /// </summary>
        /// <returns></returns>
        private bool DelCkSN() 
        {

            CkTimeInfo ck = new CkTimeInfo();
            ck.SN=txtCheckIn.Text.Trim();
            string sqlCk = string.Format("delete from cktimeinfo where SN='{0}'", ck.SN);
            return SqlHelper.modify(sqlCk);
        }

        /// <summary>
        /// 删除【black_unusual】表中重复数据
        /// </summary>
        /// <returns></returns>
        private bool DelBlackSN() 
        {
            black_unusual black = new black_unusual();
            black.SN = txtCheckIn.Text.Trim();
            string sqlBlack = string.Format("delete from black_unusual where SN='{0}'", black.SN);
            return SqlHelper.modify(sqlBlack);
        }

        /// <summary>
        /// 修改【CkTimeInfo】表中SNcheckOut
        /// </summary>
        /// <returns></returns>
        private bool UpdateSNcheckOut()
        {
            CkTimeInfo ck = new CkTimeInfo();
            ck.SNCheckOut = DateTime.Now.ToString();
            ck.SN = txtCheckOut.Text.Trim();
            string sql = string.Format("update cktimeinfo SET SNCheckOut='{0}',employee_id='{1}' where SN='{2}'", ck.SNCheckOut,employee_id, ck.SN);
            txtCheckIn.Text = string.Empty;
            txtCheckOut.Text = string.Empty;
            return SqlHelper.modify(sql);

        }

        /// <summary>
        /// 从【cktimeinfo】表，添加所有数据到【black_unusual】表中
        /// </summary>
        /// <returns></returns>
        private int InsertBlack() 
        {

            int a =0;
            for (int i = 0; i <dgvReport.Rows.Count; i++) 
            {
                black_unusual black = new black_unusual();
                if (dgvReport.Rows[i].Cells[2].Value.ToString() == "0000/00/00 00:00:00")
                {
                    //MessageBox.Show("表格中有SNCheckOut为空的黑色异常，已终止该部分上传！");
                    continue;
                }
                
                black.SN = dgvReport.Rows[i].Cells[0].Value.ToString();
                black.SNCheckIn = dgvReport.Rows[i].Cells[1].Value.ToString();
                black.SNCheckOut = dgvReport.Rows[i].Cells[2].Value.ToString();
                black.Minute = dgvReport.Rows[i].Cells[3].Value.ToString();
                black.employee_id = dgvReport.Rows[i].Cells[4].Value.ToString();
                string sql = string.Format("insert into black_unusual(SN,SNCheckIn,SNCheckOut,Minute,employee_id)values('{0}','{1}','{2}','{3}','{4}')"
                                            ,black.SN, black.SNCheckIn, black.SNCheckOut,black.Minute,black.employee_id);
                a = SqlHelper.update(sql);
            }
            return a;          
        }

        /// <summary>
        /// 清空【cktimeinfo】中所有数据
        /// </summary>
        /// <returns></returns>
        private bool DelCkTimeInfo() 
        {

            string sql = "delete from cktimeinfo where SNCheckOut not in('0000/00/00 00:00:00')";
            return SqlHelper.modify(sql);
        }

        /// <summary>
        /// 单击SN个人录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void rdoPersonal_Click(object sender, EventArgs e)
        //{
        //    string sql = "select SN,SNCheckIn,SNCheckOut,timestampdiff(MINUTE,SNCheckIn,SNCheckOut)as Minute,employee_id from cktimeinfo where employee_id='" + employee_id + "'";
        //    dgvReport.DataSource = SqlHelper.GetList(sql);
        //}


      /// <summary>
      ///单击SN公共录入
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        //private void rdoPublic_Click(object sender, EventArgs e)
        //{
        //    string sql = "select SN,SNCheckIn,SNCheckOut,timestampdiff(MINUTE,SNCheckIn,SNCheckOut)as Minute,employee_id from cktimeinfo where SNCheckOut='0000/00/00 00:00:00'";
        //    dgvReport.DataSource = SqlHelper.GetList(sql);
        //}


        /// <summary>
        /// 上传按钮，上传【cktimeinfo】表数据到【black_unusual】表中，并删除【cktimeinfo】表中录入完整的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            string sql = "select SN,SNCheckIn,SNCheckOut,timestampdiff(MINUTE,SNCheckIn,SNCheckOut)as Minute,employee_id from cktimeinfo";
            DataTable dt = SqlHelper.GetList(sql);
            if (dt.Rows.Count>0)
            {
                InsertBlack();
                DelCkTimeInfo();

                if (rdoPersonal.Checked == true)
                {
                    rdoPersonal_Click(null,null);
                }
                else if(rdoPublic.Checked==true) 
                {
                    rdoPublic_Click(null,null);
                }
                txtCheckIn.Focus();
                return;
            }
            else 
            {
                MessageBox.Show("上传失败！请检测表中SN，录入时间是否为空！");
                txtCheckIn.Focus();
                return;
            }
            
            
        }


        /// <summary>
        /// SNCheckIn回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCheckIn_KeyDown(object sender, KeyEventArgs e)
        {         
            if(e.KeyCode==Keys.Enter)
            {
                if (txtCheckIn.Text.Trim() != "")
                {
                    //string txtText = txtCheckIn.Text;
                    //string regular1 = @"^[A-Za-z0-9]{10}$";
                    //string regular2 = @"^[A-Za-z0-9]{23}$";
                    //bool a = Regex.IsMatch(txtText, regular2);
                    //bool b=Regex.IsMatch(txtText,regular1);
                    //if (b==false && a==false) 
                    //{
                    //    MessageBox.Show("格式错误!请输入10位或者23位的字母数字组合！");
                    //    txtCheckIn.Text = string.Empty;
                    //    return;
                    //}
           


                    black_unusual black = new black_unusual();
                    black.SN = txtCheckIn.Text.Trim();
                    string sqlBlack = "select*from black_unusual where SN='" + black.SN + "'";
                    DataTable dtBlack = SqlHelper.GetList(sqlBlack);

                    CkTimeInfo ck = new CkTimeInfo();
                    ck.SN = txtCheckIn.Text.Trim();
                    string sqlCk = "select*from cktimeinfo where SN='"+ck.SN+"'";
                    DataTable dtCk = SqlHelper.GetList(sqlCk);

                    if (dtBlack.Rows.Count<= 0 && dtCk.Rows.Count<= 0)
                    {
                        InserSNcheckIn();
                        if (rdoPersonal.Checked == true)
                        {
                            rdoPersonal_Click(null, null);
                        }
                        else if (rdoPublic.Checked == true)
                        {
                            rdoPublic_Click(null, null);
                        }
                       
                        txtCheckIn.Text = string.Empty;
                        txtCheckOut.Text = string.Empty;
                        return;
                    }

                    else
                    {
                        MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                        DialogResult dr = MessageBox.Show("该SN已录入,是否删除?", "删除原纪录!!!", messButton);
                        if (dr == DialogResult.OK)
                        {
                            DelCkSN();
                            DelBlackSN();

                            if (rdoPersonal.Checked == true)
                            {
                                rdoPersonal_Click(null, null);
                            }
                            else if (rdoPublic.Checked == true)
                            {
                                rdoPublic_Click(null, null);
                            }
                        }
                        else 
                        {
                            return;
                        }

                       
                    }
                }
                else 
                {
                    MessageBox.Show("SNCheckIn输入值不能为空！");
                    return;
                }
            }

        }

        /// <summary>
        /// SNCheckOut回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCheckOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (txtCheckOut.Text.Trim() != "")
                {
                    //string txtText = txtCheckOut.Text;
                    //string regular1 = @"^[A-Za-z0-9]{10}$";
                    //string regular2 = @"^[A-Za-z0-9]{23}$";
                    //bool a = Regex.IsMatch(txtText, regular2);
                    //bool b = Regex.IsMatch(txtText, regular1);
                    //if (b == false && a == false)
                    //{
                    //    MessageBox.Show("格式错误!请输入10位或者23位的字母数字组合！");
                    //    txtCheckOut.Text = string.Empty;
                    //    return;
                    //}
                    string sqlCk = "select*from cktimeinfo where SN='" + txtCheckOut.Text.Trim() + "'";
                    if (SqlHelper.GetList(sqlCk).Rows.Count > 0)
                    {
                        string sqlSN = "select*from cktimeinfo where SN='" + txtCheckOut.Text.Trim() + "'and SNCheckOut='0000/00/00 00:00:00'";
                        if (SqlHelper.GetList(sqlSN).Rows.Count > 0)
                        {
                            UpdateSNcheckOut();
                            if (rdoPersonal.Checked == true)
                            {
                                rdoPersonal_Click(null, null);
                            }
                            else if (rdoPublic.Checked == true)
                            {
                                rdoPublic_Click(null, null);
                            }
                        }
                        else
                        {
                            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                            DialogResult dr = MessageBox.Show("该SN已存在SNChekOut,是否更新?", "更新当前SNCheckOut!!!", messButton);
                            if (dr == DialogResult.OK)
                            {
                                UpdateSNcheckOut();
                                if (rdoPersonal.Checked == true)
                                {
                                    rdoPersonal_Click(null, null);
                                }
                                else if (rdoPublic.Checked == true)
                                {
                                    rdoPublic_Click(null, null);
                                }
                            }
                        }
                       
                    }

                    else
                    {
                        MessageBox.Show("当前SN无录入记录！");
                        txtCheckIn.Text = string.Empty;
                        txtCheckOut.Text = string.Empty;
                        return;
                    }        
                }
                else
                {
                    MessageBox.Show("SNCheckOut值输入值不能为空！");
                    return;
                }
            }
        }


//----------------------------------------------------------查询黑色异常处理时间结果界面-------------------------------------------------------------------------------------
        /// <summary>
        /// 查询黑色异常信息按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
                DateTime starCheckIn = Convert.ToDateTime(dTP1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                DateTime endCheckIn = Convert.ToDateTime(dTP2.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                if (DateTime.Compare(starCheckIn,endCheckIn) > 0)
                {
                    MessageBox.Show("结束时间不能小于开始时间！");
                    return;
                }
                else
                {
                    string sql = "select SN,SNCheckIn,SNCheckOut,Minute,fae_analyzer.employee_id,fae_analyzer.Ana_name from fae_analyzer inner join black_unusual where fae_analyzer.employee_id=black_unusual.employee_id and SNCheckIn between '" + dTP1.Text.Trim() + "' and '" + dTP2.Text.Trim() + "' and fae_analyzer.employee_id LIKE '" + txtEmployee_id.Text.Trim() + "%'";
                        dgvStatistics.DataSource = SqlHelper.GetList(sql);
                }       
        }


      

        private void txtCheckIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                this.Focus();
            }
        }
        private void txtCheckOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                this.Focus();
            }
        }

        private void txtEmployee_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btnQuery_Click(null,null);
            }
        }

        private void FormStaff_Shown(object sender, EventArgs e)
        {
            txtCheckIn.Focus();
        }


        private void tabControl1_Click(object sender, EventArgs e)
        {
            txtCheckIn.Focus();
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\help.txt");
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
            lblMix.BackColor = Color.DarkSeaGreen;
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
            lblExit.BackColor = Color.DarkSeaGreen;
        }

        private void 培训检验ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show(this);
        }

        private void rdoPersonal_Click(object sender, EventArgs e)
        {
            string sqlCK = "select SN,SNCheckIn,SNCheckOut,timestampdiff(MINUTE,SNCheckIn,SNCheckOut)as Minute,fae_analyzer.employee_id,fae_analyzer.Ana_name from fae_analyzer inner join cktimeinfo where fae_analyzer.employee_id=cktimeinfo.employee_id and fae_analyzer.employee_id='"+employee_id+"'";
            dgvReport.DataSource = SqlHelper.GetList(sqlCK);
        }

        private void rdoPublic_Click(object sender, EventArgs e)
        {
            string sqlCK = "select SN,SNCheckIn,SNCheckOut,timestampdiff(MINUTE,SNCheckIn,SNCheckOut)as Minute,fae_analyzer.employee_id,fae_analyzer.Ana_name from fae_analyzer inner join cktimeinfo where fae_analyzer.employee_id=cktimeinfo.employee_id";
            dgvReport.DataSource = SqlHelper.GetList(sqlCK);
        }

        private void 分析录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FAEentrance recordInput = new FAEentrance();
            recordInput.Show();
            this.Visible = false;
        }

       
      



        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Modify();

        //}

        //private bool Modify()
        //{

        //    string IP = "0.0.0.0";

        //        //获取当前主机名
        //        string hostname = Dns.GetHostName();

        //        IPAddress[] ipadrlist = Dns.GetHostAddresses(hostname);
        //        foreach (IPAddress ipadr in ipadrlist)
        //        {
        //            //判断是否是ipv4
        //            if (ipadr.AddressFamily == AddressFamily.InterNetwork)
        //            {
        //                IP = ipadr.ToString();
        //            }
        //        }

        //    CodeInfo code = new CodeInfo();
        //    code.Date_NowTime = Convert.ToDateTime(DateTime.Now.ToString());
        //    code.PC_Name = hostname;
        //    code.PC_IP = IP;
        //    string sql = string.Format("insert into codeinfo(employee_id,PC_IP,PC_Name,Date_NowTime)values ('{0}','{1}','{2}','{3}')", employee_id, code.PC_IP, code.PC_Name, code.Date_NowTime);
        //    int i = SqlHelper.update(sql);
        //    return i > 0;
        //}


      

    }
}
