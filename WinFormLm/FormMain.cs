using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormLm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {   
        }

        //获取登录名和登录密码
        public string employee_id;
        public string ITcode;

       

        private void lblExit_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Visible = false;
        }

        /// <summary>
        /// 根据条件统计点击次数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (rdoAllId.Checked == true) 
            {
                //显示数据表dgvTime
                if (cmbTime.Text.Trim() == "年")
                {
                    string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y')triggerTime,count(*)triggerCount FROM  codeinfo where Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                    dgvTime.DataSource = SqlHelper.GetList(sql);
                }
                if (cmbTime.Text.Trim() == "月")
                {
                    string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m')triggerTime,count(*)triggerCount FROM  codeinfo where Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                    dgvTime.DataSource = SqlHelper.GetList(sql);
                }
                if (cmbTime.Text.Trim() == "日")
                {
                    string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m-%d')triggerTime,count(*)triggerCount FROM  codeinfo where Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                    dgvTime.DataSource = SqlHelper.GetList(sql);
                }
                if (cmbTime.Text.Trim() == "小时")
                {
                    string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m-%d %H')triggerTime,count(*)triggerCount FROM  codeinfo where Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                    dgvTime.DataSource = SqlHelper.GetList(sql);
                }
                //显示四张数据表
             
              
                    string sql1 = "select PC_IP as ip地址,count(PC_IP)AS 总数 from codeinfo where  Date_NowTime BETWEEN '" + dateStart.Text.Trim() + "' AND '" + dateEnd.Text.Trim() + "' GROUP BY PC_IP";
                    dgvIPCount.DataSource = SqlHelper.GetList(sql1);
                

                    string sql2 = "select employee_id as 工号,count(employee_id)AS 总数 from codeinfo where  Date_NowTime BETWEEN '"+dateStart.Text.Trim()+"' AND '"+dateEnd.Text.Trim()+"' GROUP BY employee_id";
                    dgvIdCount.DataSource = SqlHelper.GetList(sql2);

                    string sql3 = "select  product as 产品名,count(product)AS 总数 from codeinfo where  Date_NowTime BETWEEN '" + dateStart.Text.Trim() + "' AND '" + dateEnd.Text.Trim() + "' GROUP BY product";
                    dgvProductCount.DataSource = SqlHelper.GetList(sql3);
   

                    string sql4 = "select test_item as 测试项,count(test_item)AS 总数 from codeinfo where  Date_NowTime BETWEEN '" + dateStart.Text.Trim() + "' AND '" + dateEnd.Text.Trim() + "' GROUP BY test_item";
                    dgvTestCount.DataSource = SqlHelper.GetList(sql4);

            }
            else if (rdoId.Checked == true) 
            {

                if (cmbWay.Text.Trim() == "--请选择--" || cmbWay.Text.Trim() == "" || cmbTime.Text.Trim() == "--请选择--" || cmbTime.Text.Trim() == "") 
                {
                    MessageBox.Show("统计类型或时间类型不能为空！");
                    return;
                }

                if (cmbWay.Text.Trim()=="IP地址") 
                {
                    if (cmbTime.Text.Trim() == "年")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y')triggerTime,count(*)triggerCount FROM  codeinfo where PC_IP = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "月")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m')triggerTime,count(*)triggerCount FROM  codeinfo where PC_IP = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "日")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m-%d')triggerTime,count(*)triggerCount FROM  codeinfo where PC_IP = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "小时")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m-%d %H')triggerTime,count(*)triggerCount FROM  codeinfo where PC_IP = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                   
                }
                else if (cmbWay.Text.Trim()=="工号") 
                {
                    if (cmbTime.Text.Trim() == "年")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y')triggerTime,count(*)triggerCount FROM  codeinfo where employee_id = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "月")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m')triggerTime,count(*)triggerCount FROM  codeinfo where employee_id = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "日")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m-%d')triggerTime,count(*)triggerCount FROM  codeinfo where employee_id = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "小时")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m-%d %H')triggerTime,count(*)triggerCount FROM  codeinfo where employee_id = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                   
                }
                else if (cmbWay.Text.Trim() == "产品名")
                {
                    if (cmbTime.Text.Trim() == "年")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y')triggerTime,count(*)triggerCount FROM  codeinfo where product = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "月")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m')triggerTime,count(*)triggerCount FROM  codeinfo where product = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "日")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m-%d')triggerTime,count(*)triggerCount FROM  codeinfo where product = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "小时")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m-%d %H')triggerTime,count(*)triggerCount FROM  codeinfo where product = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }

                }
                else if (cmbWay.Text.Trim() == "测试项")
                {
                    if (cmbTime.Text.Trim() == "年")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y')triggerTime,count(*)triggerCount FROM  codeinfo where test_item = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "月")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m')triggerTime,count(*)triggerCount FROM  codeinfo where test_item = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "日")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m-%d')triggerTime,count(*)triggerCount FROM  codeinfo where test_item = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }
                    if (cmbTime.Text.Trim() == "小时")
                    {
                        string sql = "select employee_id,PC_IP,PC_Name,product,test_item, Date_Format(Date_NowTime,'%Y-%m-%d %H')triggerTime,count(*)triggerCount FROM  codeinfo where test_item = '" + txtID.Text.Trim() + "' and Date_NowTime BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "' GROUP BY triggerTime,employee_id,PC_IP,PC_Name,product,test_item";
                        dgvTime.DataSource = SqlHelper.GetList(sql);
                    }

                }


            }


        }



        /// <summary>
        /// 上传缺陷分析报表
        /// </summary>
        /// <param name="cmdString"></param>
        /// <returns></returns>
        //public int UploadTable(string cmdString)
        //{
        //    int affectedLines;
        //    MySqlConnection myUploadConnection = SqlHelper.myGetConnection();
        //    MySqlCommand mySqlCommandUpload = new MySqlCommand(cmdString, myUploadConnection);
        //    try
        //    {
        //        myUploadConnection.Open();
        //        affectedLines = mySqlCommandUpload.ExecuteNonQuery();
        //        return affectedLines;
        //        //return err or warning info...
        //    }
        //    catch (MySqlException ex)
        //    {
        //        switch (ex.Number)
        //        {
        //            case 0:
        //                MessageBox.Show("Error " + ex.Number + " 数据库连接失败，请与系统管理员联系");
        //                break;
        //            case 1045:
        //                MessageBox.Show("Error " + ex.Number + " 无效的用户名/密码，请重试");
        //                break;
        //        }

        //    }
        //    finally
        //    {
        //        myUploadConnection.Close();

        //    }
        //    return 0;
        //}

        /// <summary>
        /// 上传csv文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            int result = 1;

            string path = localCsvFile.Text.Replace("\\", "/");
            string upLoadCommandString = string.Concat(new string[]
				{
					"LOAD DATA LOCAL INFILE \"",
					path,
					"\" INTO TABLE ",
					tableNameComboBox.Text,
					" character set gb2312 fields terminated by '",
                    ",",
                    "' optionally enclosed by '",
                    "\"",
                     "' escaped by '",
                     "\"",
                     "' lines terminated by '",
                     "\\r\\n",
                     "'"
				});
            //MessageBox.Show(upLoadCommandString);
            if (!string.IsNullOrEmpty(path) && !string.IsNullOrEmpty(tableNameComboBox.Text))
            {
                //result = UploadTable(upLoadCommandString);
            }
            else
            {
                MessageBox.Show("请选择要上传的csv文件及对应的数据库表名");
                return;
            }


            MessageBox.Show("上传影响的行数:" + result.ToString());

        }



        /// <summary>
        /// 选择要上传的csv文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV文件|*.csv|所有文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                localCsvFile.Text = path;
            }

        }




    }
}
