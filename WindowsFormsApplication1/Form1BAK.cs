using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using WinFormLm;
using System.Collections;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Text = "2017-12-31";
            dateTimePicker2.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// 按产品或测试项查询分析结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {          
            string startDate = dateTimePicker1.Value.ToShortDateString();
            string endDate = dateTimePicker2.Value.ToShortDateString();
            DataSet report = null;
            string faeQueryStr=null;
            string mesQueryStr=null;
            string multiQueryStr = null;
            string testAndDebugQueryStr = null;
            string productName = null;
            string testItem = null;
            string SN = SnTextBox.Text;
            string mesReportName = "mesreport";
            string processLocation = feOrBe.Text;

           // SN不为空时，只查SN
            if (!string.IsNullOrEmpty(SN))
            {
                faeQueryStr = string.Concat(new string[]
                                      {
                          "select Product,Test_code,Analysis_method,Root_cause from faereport ",
                         "where SN = \"",
                         SN,
                         "\""
                                      });
                mesQueryStr = string.Concat(new string[]
                       {
                          "select Product,Test_code,Root_cause from ",mesReportName,
                         " where SN = \"",
                         SN,
                         "\""
                       });
                testAndDebugQueryStr = string.Concat(new string[]
                       {
                          "select T.Test_explain as Decription,D.Analysis_Guide as Guide from test_explanation as T LEFT JOIN debug_guide as D ON T.Analysis_ID=D.Analysis_ID ",
                         "where T.Testcode like 'QBOOT_BLANK%' limit 1"
                         });
                multiQueryStr = faeQueryStr + ";" + mesQueryStr + ";" + testAndDebugQueryStr;             
                report = SqlHelper.GetQueryResultSet(multiQueryStr);
                dgvRootCauseFAE.DataSource = report.Tables[0];
                dgvRootCauseMES.DataSource = report.Tables[1];
                return;
            }

            if (cbbProductName.Text == "--请输入产品名--")
            {
                cbbProductName.Text = null;
            }
            productName = cbbProductName.Text;

            if (cbbTestItem.Text == "--请输入关键字--")
            {
                cbbTestItem.Text = null;
            }
            testItem = cbbTestItem.Text;

            if (processLocation == "BE")
            {
                mesReportName = "mesreport_be";

            }           

            if (string.IsNullOrEmpty(productName) && string.IsNullOrEmpty(testItem))
            {
                MessageBox.Show("产品名和测试项均为空，请重新输入");
                return;
            }

            if (!string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(testItem))
               {                   
                    faeQueryStr = string.Concat(new string[]
                       {
                          "select Product,Test_code,Analysis_method,Root_cause,count(*) from faereport ",
                         "where product like \"",
                         productName,
                         "%\" and Test_code like \"",
                         testItem,
                         "%\" ",
                          
                         "GROUP BY Product,Test_code,Analysis_method,Root_cause ORDER by length(Analysis_method) DESC"
                       });
                    testAndDebugQueryStr = string.Concat(new string[]
                       {
                          "select T.Test_explain as Decription,D.Analysis_Guide as Guide from test_explanation as T LEFT JOIN debug_guide as D ON T.Analysis_ID=D.Analysis_ID ",
                         "where T.Testcode like \"",
                         testItem,
                         "%\""
                       });

                    mesQueryStr = "SELECT T1.Product,T1.Test_code,T1.Root_cause,T1.co as Total,case when T2.totalCo=0 then CONCAT(0.00,'%') else concat(ROUND(T1.co/T2.totalCo*100,1),'','%') end as Percent from "
                        + "(SELECT Product,Test_code,Root_cause,COUNT(*) AS co from "+ mesReportName
                        + " where product like \""
                        + productName
                        + "%\" and Test_code like \""

                           + testItem
                           + "%\" "
                           + "and Analysis_date between \""
                           + startDate
                           + "\" "
                           + "and \""
                           + endDate
                           + "\" "
                           + "GROUP BY Product,Test_code,Root_cause)as T1,"
                           + "(SELECT Product,Test_code,COUNT(*) AS totalCo from "+ mesReportName
                           + " where product like \""
                           + productName
                           + "%\" and Test_code like \""
                           + testItem
                           + "%\" "
                           + "and Analysis_date between \""
                           + startDate
                           + "\" "
                           + "and \""
                           + endDate
                           + "\" "

                           + "group by Product,Test_code)as T2 WHERE T1.Product=T2.Product and T1.Test_code=T2.Test_code order by T1.co desc";
                   
                }
                else if (!string.IsNullOrEmpty(testItem))
                {
                    
                    faeQueryStr = "select Product,Test_code,Analysis_method,Root_cause,count(*) from faereport "
                             + "where Test_code like \""
                             + testItem
                             + "%\" "
                             + "GROUP BY Product,Test_code,Analysis_method,Root_cause ORDER by length(Analysis_method) DESC";
                   
                    mesQueryStr = "SELECT T1.Product,T1.Test_code,T1.Root_cause,T1.co as Total,case when T2.totalCo=0 then CONCAT(0.00,'%') else concat(ROUND(T1.co/T2.totalCo*100,1),'','%') end as Percent from "
                        + "(SELECT Product,Test_code,Root_cause,COUNT(*) AS co from "+ mesReportName
                        + " where Test_code like \""
                           + testItem
                           + "%\" "
                           + "and Analysis_date between \""
                           + startDate
                           + "\" "
                           + "and \""
                           + endDate
                           + "\" "
                           + "GROUP BY Product,Test_code,Root_cause)as T1,"
                           + "(SELECT Product,Test_code,COUNT(*) AS totalCo from "+ mesReportName
                           + " where Test_code like \""
                           + testItem
                           + "%\" "
                           + "and Analysis_date between \""
                           + startDate
                           + "\" "
                           + "and \""
                           + endDate
                           + "\" "
                           + "group by Product,Test_code)as T2 WHERE T1.Product=T2.Product and T1.Test_code=T2.Test_code order by T1.co desc";
                    testAndDebugQueryStr = string.Concat(new string[]
                       {
                          "select T.Test_explain as Decription,D.Analysis_Guide as Guide from test_explanation as T LEFT JOIN debug_guide as D ON T.Analysis_ID=D.Analysis_ID ",
                         "where T.Testcode like \"",
                         testItem,
                         "%\""
                       });

                }
                else
                {
                    faeQueryStr = string.Concat(new string[]
                       {
                          "select Product,Test_code,Analysis_method,Root_cause,count(*) from faereport ",
                         "where product like \"",
                         productName,
                         "%\" ",
                         "GROUP BY Product,Test_code,Analysis_method,Root_cause ORDER by length(Analysis_method) DESC"
                       });
                    testAndDebugQueryStr = string.Concat(new string[]
                       {
                          "select T.Test_explain as Decription,D.Analysis_Guide as Guide from test_explanation as T LEFT JOIN debug_guide as D ON T.Analysis_ID=D.Analysis_ID ",
                         "where T.Testcode like 'QBOOT_BLANK%' limit 1"
                       });
                   
                    mesQueryStr = "SELECT T1.Product,T1.Test_code,T1.Root_cause,T1.co as Total,case when T2.totalCo=0 then CONCAT(0.00,'%') else concat(ROUND(T1.co/T2.totalCo*100,1),'','%') end as Percent from "
                                           + "(SELECT Product,Test_code,Root_cause,COUNT(*) AS co from "+ mesReportName
                                            + " where product like \""
                                            + productName
                                            + "%\" "
                                            + "and Analysis_date between \""
                                            + startDate
                                            + "\" "
                                            + "and \""
                                            + endDate
                                            + "\" "
                                            + "GROUP BY Product,Test_code,Root_cause)as T1,"
                                              + "(SELECT Product,Test_code,COUNT(*) AS totalCo from "+ mesReportName
                                              + " where product like \""
                                              + productName
                                              + "%\" "
                                              + "and Analysis_date between \""
                                              + startDate
                                              + "\" "
                                              + "and \""
                                              + endDate
                                              + "\" "
                                              + "group by Product,Test_code)as T2 WHERE T1.Product=T2.Product and T1.Test_code=T2.Test_code order by T1.co desc";
                }

                multiQueryStr = faeQueryStr+";"+mesQueryStr+";"+testAndDebugQueryStr;
             
                report = SqlHelper.GetQueryResultSet(multiQueryStr);
                dgvRootCauseFAE.DataSource = report.Tables[0];
                dgvRootCauseMES.DataSource = report.Tables[1];
                int rowsCount = report.Tables[2].Rows.Count;
                if (rowsCount > 0)
                {
                    testDescription.Text = report.Tables[2].Rows[0]["Decription"].ToString();
                    analysisThink.Text = report.Tables[2].Rows[0]["Guide"].ToString();
                }
                else
                {
                    testDescription.Text = null;
                    analysisThink.Text = null;
                }

            //call pie chart function
                DataTable dt = report.Tables[1];
           

                chart1.Series[0]["PieLabelStyle"]="Outside";
                chart1.Series[0]["PieLineColor"]="Black";
                
               
                chart1.DataSource = dt;
                chart1.Series[0].YValueMembers = "Total";
                chart1.Series[0].XValueMember = "Root_cause";
               
                chart1.Series[0].Label = "#PERCENT{P}";

                chart1.Series[0].LegendText = "#VALX";
              
                chart1.DataBind();                                 


        //--------------------------------------------------统计按钮点击次数，并记录相关信息----------------------------------------------------------------------------
           //Modify();
        }

        private bool Modify()
        {

            string IP = "0.0.0.0";

            //获取当前主机名
            string hostname = Dns.GetHostName();

            IPAddress[] ipadrlist = Dns.GetHostAddresses(hostname);
            foreach (IPAddress ipadr in ipadrlist)
            {
                //判断是否是ipv4
                if (ipadr.AddressFamily == AddressFamily.InterNetwork)
                {
                    IP = ipadr.ToString();
                }
            }

            CodeInfo code = new CodeInfo();
            code.Date_NowTime = DateTime.Now.ToString();
            code.PC_Name = hostname;
            code.PC_IP = IP;
            code.product = cbbProductName.Text.Trim();
            code.test_item = cbbTestItem.Text.Trim();
            string sql = string.Format("insert into codeinfo(PC_IP,PC_Name,Date_NowTime,product,test_item)values ('{0}','{1}','{2}','{3}','{4}')", code.PC_IP, code.PC_Name, code.Date_NowTime,code.product,code.test_item);
            int i = WinFormLm.SqlHelper.update(sql);
            return i > 0;
        }

        

       
        ///// <summary>
        ///// 上传缺陷分析报表
        ///// </summary>
        ///// <param name="cmdString"></param>
        ///// <returns></returns>
        //public int UploadTable(string cmdString)
        //{
        //    int affectedLines;
        //    MySqlConnection myUploadConnection = SqlHelper.myGetConnection();
        //    MySqlCommand mySqlCommandUpload = new MySqlCommand(cmdString, myUploadConnection);
        //    try
        //    {
        //        myUploadConnection.Open();
        //        affectedLines=mySqlCommandUpload.ExecuteNonQuery();
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
        

      

        private void Form1_Load(object sender, EventArgs e)
        {
            defectCatalog.Items.Clear();


        }



        /// <summary>
        /// 按选择的产品列出对应的相关分析资料目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productName_SelectedIndexChanged(object sender, EventArgs e)
          {
           
            string queryString3=null;
              DataSet myDataSet=new DataSet();
              
             
              string productName1=productName.Text;
              queryString3 = "select Debug_doc from product_doc where product=\""
                              +productName1
                              +"\" ORDER by Debug_doc ASC";
              myDataSet = SqlHelper.GetQueryResultSet(queryString3);
              try
              {
                  defectCatalog.DisplayMember = "Debug_doc";
                  defectCatalog.ValueMember = "Debug_doc";

                  defectCatalog.DataSource = myDataSet.Tables[0].DefaultView;
                 
                  defectCatalog.SelectedIndex = 0;
              }
              catch (ArgumentException ex)
              {
                  MessageBox.Show("Error " + ex + " 维修指南数据库为空，请与系统管理员联系");
              }
          }


        ///// <summary>
        ///// 上传csv文件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void buttonUpload_Click(object sender, EventArgs e)
        //{
        //    int result=1;
           
        //    string path = localCsvFile.Text.Replace("\\", "/");
        //    string upLoadCommandString = string.Concat(new string[]
        //        {
        //            "LOAD DATA LOCAL INFILE \"",
        //            path,
        //            "\" INTO TABLE ",
        //            tableNameComboBox.Text,
        //            " character set gb2312 fields terminated by '",
        //            ",",
        //            "' optionally enclosed by '",
        //            "\"",
        //             "' escaped by '",
        //             "\"",
        //             "' lines terminated by '",
        //             "\\r\\n",
        //             "'"
        //        });
        //    //MessageBox.Show(upLoadCommandString);
        //    if (!string.IsNullOrEmpty(path) && !string.IsNullOrEmpty(tableNameComboBox.Text))
        //    {
        //        result = UploadTable(upLoadCommandString);
        //    }
        //    else
        //    {
        //        MessageBox.Show("请选择要上传的csv文件及对应的数据库表名");
        //             return;
        //    }

                
        //        MessageBox.Show("上传影响的行数:"+result.ToString());
                
        //}

     

        ///// <summary>
        ///// 选择要上传的csv文件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void buttonFileBrowser_Click_1(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Filter = "CSV文件|*.csv|所有文件|*.*";
        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        string path = ofd.FileName;
        //        localCsvFile.Text = path;
        //    }

        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defectCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            string docName = defectCatalog.Text;
            string picPath = Application.StartupPath + "\\" + productName.Text + "\\" + docName + ".JPG";
            //MessageBox.Show(docName);
            try
            {
                pictureBox1.Image = Image.FromFile(picPath);
                //defectCatalog.Items.Add("blaine 主板简介");
                //defectCatalog.Items.Add("blaine 开机时序图");
            }
            catch (FileNotFoundException ex)
            {

                MessageBox.Show("请把" + "'" + docName + ".jpg" + "'" + "放到" + Application.StartupPath + "\\" + productName.Text + "目录下");


            }
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
            Process.Start(Application.StartupPath + @"\大数据辅助分析系统v4.0安装使用说明.txt");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin flogin = new FormLogin();
            flogin.Show();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FAEentrance recordInput = new FAEentrance();
            recordInput.Show();
            this.Visible = false;
        }



        /*private void 帮助F1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = Application.StartupPath + "大数据辅助分析系统v2.2安装使用说明.txt";
            helpProvider1.HelpNamespace = filepath;
        }*/




    }
}







