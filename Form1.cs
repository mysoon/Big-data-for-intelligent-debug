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

using System.Collections;
using System.Configuration;
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

       // string connectionString = ConfigurationManager.AppSettings["DBConnStr"];
        // string serverIPAddress = "'" + serverIP.text;
        //string connectionString = "Server="+serverIPAddress+";User ID=root;Password=;Database=fae_weekly;CharSet=utf8;";
        //DataSet localDataSet;

        // string connectionString = "Server=10.114.113.10;User ID=fae;Password=fae2018;Database=fae_weekly;CharSet=utf8;";

        public Form1()
        {
            InitializeComponent();
            //this.pictureBox1.MouseWheel += new MouseEventHandler(PictureBox1_MouseWheel);   
            //localDataSet = null;
        }

        /* private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
         {
             this.pictureBox1.Focus();
             System.Drawing.Size t = pictureBox1.Size;
             t.Width += e.Delta;
             t.Height += e.Delta;
             pictureBox1.Width = t.Width;
             pictureBox1.Height = t.Height;
         }*/
        /*private override void OnMouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if ((VScrollBar.Value - 10) < vScrollBar1.Minimum)
                {
                    vScrollBar1.Value = vScrollBar1.Minimum;
                }
                else
                {
                    this.VScrollBar.Value -= 10;
               // }
            }
            else
            {
                if ((VScrollBar.Value + 10) > vScrollBar1.Maximum)
                {
                    vScrollBar1.Value = vScrollBar1.Maximum;
                }
                else
                {
                    vScrollBar1.Value += 10;
                }
            }

        }*/
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataSet report;
            string faeQueryStr=null;
            string mesQueryStr=null;
            if (cbbProductName.Text == "--请输入产品名--")
            {
                cbbProductName.Text = null;
            }
            if (cbbTestItem.Text == "--请输入关键字--")
            {
                cbbTestItem.Text = null;
            }
            string productName=cbbProductName.Text;
            string testItem=cbbTestItem.Text;
           
          
               if (!string.IsNullOrEmpty(productName)&&!string.IsNullOrEmpty(testItem))
                 {
                    //1.get 20 letters from left;2.get letters before '('or'['.
                    faeQueryStr = string.Concat(new string[]
                       {
                          "select Product,Test_code,Analysis_method,Root_cause,count(*) from faereport ",
                         "where product Rlike \"",
                         productName,
                         "\" and Test_code Rlike \"",
                         testItem,
                         "\" ",
                         "GROUP BY Product,Test_code,Analysis_method,Root_cause ORDER by Analysis_method DESC"
                       });
                    /*mesQueryStr= "select Product,Test_code,Root_cause,count(*) from mesreport "
                         + "where product Rlike \""
                         +productName
                         +"\" and Test_code Rlike substring_index(left(\""
                         +testItem
                         +"\",20),'('or'[',1)  "
                         + "GROUP BY Product,Test_code,Root_cause ORDER by count(*) DESC";*/

                    mesQueryStr = "SELECT T1.Product,T1.Test_code,T1.Root_cause,T1.co as Total,case when T2.totalCo=0 then CONCAT(0.00,'%') else concat(ROUND(T1.co/T2.totalCo*100,1),'','%') end as Percent from "
                        + "(SELECT Product,Test_code,Root_cause,COUNT(*) AS co from mesreport "
                        + "where product Rlike \""
                        +productName
                        +"\" and Test_code Rlike \""
                   
                           + testItem
                           + "\" "
                           + "GROUP BY Product,Test_code,Root_cause)as T1,"
                           + "(SELECT Product,Test_code,COUNT(*) AS totalCo from mesreport "
                           + "where product Rlike \""
                           + productName
                           + "\" and Test_code Rlike \""
                           + testItem
                           + "\" "
                           + "group by Product,Test_code)as T2 WHERE T1.Product=T2.Product and T1.Test_code=T2.Test_code order by T1.co desc, T1.Test_code";
                 }
                else if(!string.IsNullOrEmpty(testItem))
                {
                   //include the string
                   faeQueryStr = "select Product,Test_code,Analysis_method,Root_cause,count(*) from faereport "
                            + "where Test_code Rlike \""
                            +testItem
                            +"\" "
                            + "GROUP BY Product,Test_code,Analysis_method,Root_cause ORDER by Analysis_method DESC";
                   /*mesQueryStr = "select Product,Test_code,Remark,Root_cause,count(*) from mesreport "
                           + "where Test_code Rlike substring_index(left(\""
                           +testItem
                           +"\",20),'('or'[',1)  "
                           + "GROUP BY Product,Test_code,Remark,Root_cause ORDER by count(*) DESC";*/
                    mesQueryStr = "SELECT T1.Product,T1.Test_code,T1.Root_cause,T1.co as Total,case when T2.totalCo=0 then CONCAT(0.00,'%') else concat(ROUND(T1.co/T2.totalCo*100,1),'','%') end as Percent from "
                        +"(SELECT Product,Test_code,Root_cause,COUNT(*) AS co from mesreport "
                        + "where Test_code Rlike \""
                           +testItem
                           +"\" "
                           + "GROUP BY Product,Test_code,Root_cause)as T1,"
                           +"(SELECT Product,Test_code,COUNT(*) AS totalCo from mesreport "
                           + "where Test_code Rlike \""
                           +testItem
                           +"\" "
                           +"group by Product,Test_code)as T2 WHERE T1.Product=T2.Product and T1.Test_code=T2.Test_code order by T1.co desc" ;

                   
                }
               else if (!string.IsNullOrEmpty(productName))
               {
                   faeQueryStr = string.Concat(new string[]
                       {
                          "select Product,Test_code,Analysis_method,Root_cause,count(*) from faereport ",
                         "where product Rlike \"",
                         productName,
                         "\" ",
                         "GROUP BY Product,Test_code,Analysis_method,Root_cause ORDER by Analysis_method DESC"
                       });
                   /*mesQueryStr = "select Product,Test_code,Root_cause,count(*) from mesreport "
                        + "where product Rlike \""
                        + productName
                        + "\" "
                        + "GROUP BY Product,Test_code,Root_cause ORDER by count(*) DESC";*/
                   mesQueryStr = "SELECT T1.Product,T1.Test_code,T1.Root_cause,T1.co as Total,case when T2.totalCo=0 then CONCAT(0.00,'%') else concat(ROUND(T1.co/T2.totalCo*100,1),'','%') end as Percent from "
                                          + "(SELECT Product,Test_code,Root_cause,COUNT(*) AS co from mesreport "
                                          + "where product Rlike \""
                                           + productName
                                           + "\" "                                    
                                             + "GROUP BY Product,Test_code,Root_cause)as T1,"
                                             + "(SELECT Product,Test_code,COUNT(*) AS totalCo from mesreport "
                                             + "where product Rlike \""
                                             + productName
                                             + "\" "
                                             + "group by Product,Test_code)as T2 WHERE T1.Product=T2.Product and T1.Test_code=T2.Test_code order by T1.co desc";
               }

               else
               {
                   MessageBox.Show("测试项为空，请重新输入");
                   return;
               }
           // dgvRootCauseFAE.DataSource = null;
           // dgvRootCauseMES.DataSource = null;
               report = new DataSet();
               report = GetQueryResult(faeQueryStr, mesQueryStr);
               
                dgvRootCauseFAE.DataSource = report.Tables["User1"];
                dgvRootCauseMES.DataSource = report.Tables["User2"];
          
            //call pie chart function
                DataTable dt = report.Tables["User2"];
                //List<string> xData = new List<string>();
                //List<double> yData = new List<double>();
                /*for (int i = 0; i < dt.Rows.Count; i++)
                {
                    xData.Add(dt.Rows[i][2].ToString());
                    yData.Add(dt.Rows[i][3].ToString());
                }*/

                chart1.Series[0]["PieLabelStyle"]="Outside";
                chart1.Series[0]["PieLineColor"]="Black";
                //chart1.Series[0].Points.DataBindXY(xData,yData);
               
                chart1.DataSource = dt;
                chart1.Series[0].YValueMembers = "Total";
                chart1.Series[0].XValueMember = "Root_cause";
                //chart1.Series[0].XValueType = ChartValueTpype.String();
                chart1.Series[0].Label = "#PERCENT{P}";

                chart1.Series[0].LegendText = "#VALX";
              
                chart1.DataBind();
                //DataView dv = new DataView(dt);
          
        }
        public static MySqlConnection myGetConnection()
        {
            string connectionString = string.Empty;
            MySqlConnection mySQLConnection;
            //connectionString = "Server=10.114.113.10;User ID=fae;Password=fae2018;Database=fae_weekly;CharSet=utf8;";
            if (ConfigurationManager.AppSettings["DBConnStr"] != null)
            {
                connectionString = ConfigurationManager.AppSettings["DBConnStr"];
            }
            else
            {
                connectionString = "Server=10.114.113.10;User ID=fae;Password=fae2018;Database=fae_weekly;CharSet=utf8;";

            }
            mySQLConnection = new MySqlConnection(connectionString);
            //MessageBox.Show(connectionString);
            return mySQLConnection;
        }

        private DataSet GetQueryResult(string queryStr1, string queryStr2)
        {
            //string connectionString = "Server=127.0.0.1;User ID=root;Password=;Database=fae_weekly;CharSet=utf8;";

            MySqlConnection myConnection;
            myConnection = myGetConnection();
           
            DataSet myDataSet = null;


            MySqlCommand mySqlCommandQuery1 = new MySqlCommand(queryStr1, myConnection);
            MySqlCommand mySqlCommandQuery2 = new MySqlCommand(queryStr2, myConnection);
            try
            {
                myConnection.Open();
                mySqlCommandQuery1.Prepare();
                mySqlCommandQuery2.Prepare();
                //MessageBox.Show(faeQueryStr);
                myDataSet = new DataSet();
                //myDataSet2 = new DataSet();
                MySqlDataAdapter myDataAdapter1 = new MySqlDataAdapter(mySqlCommandQuery1);
                MySqlDataAdapter myDataAdapter2 = new MySqlDataAdapter(mySqlCommandQuery2);


                myDataAdapter1.Fill(myDataSet, "User1");
                myDataAdapter2.Fill(myDataSet, "User2");
                //myDataTable = myDataSet.Tables[0];

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Error " + ex.Number + " 数据库连接失败，请与系统管理员联系");
                        break;
                    case 1045:
                        MessageBox.Show("Error " + ex.Number + " 无效的用户名/密码，请重试");
                        break;
                }
            }
            finally
            {
                myConnection.Close();
                
            }
            return myDataSet;
        }

        private DataSet GetProductDoc(string queryStr)
        {
            //string connectionString = "Server=127.0.0.1;User ID=root;Password=;Database=fae_weekly;CharSet=utf8;";

            MySqlConnection myConnection;
            myConnection = myGetConnection();

            DataSet myDataSet = null;


            MySqlCommand mySqlCommandQuery = new MySqlCommand(queryStr, myConnection);
         
            try
            {
                myConnection.Open();
                mySqlCommandQuery.Prepare();
            
                //MessageBox.Show(faeQueryStr);
                myDataSet = new DataSet();
                //myDataSet2 = new DataSet();
                MySqlDataAdapter myDataAdapter= new MySqlDataAdapter(mySqlCommandQuery);
              


                myDataAdapter.Fill(myDataSet, "User3");
             
                //myDataTable = myDataSet.Tables[0];

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Error " + ex.Number + " 数据库连接失败，请与系统管理员联系");
                        break;
                    case 1045:
                        MessageBox.Show("Error " + ex.Number + " 无效的用户名/密码，请重试");
                        break;
                }
            }
            finally
            {
                myConnection.Close();

            }
            return myDataSet;
        }
        //upload Defect Analysis result tables

        public int UploadTable(string cmdString)
        {
            int affectedLines;
            MySqlConnection myUploadConnection = myGetConnection();
            MySqlCommand mySqlCommandUpload = new MySqlCommand(cmdString, myUploadConnection);
            try
            {
                myUploadConnection.Open();
                affectedLines=mySqlCommandUpload.ExecuteNonQuery();
                return affectedLines;
                //return err or warning info...
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Error " + ex.Number + " 数据库连接失败，请与系统管理员联系");
                        break;
                    case 1045:
                        MessageBox.Show("Error " + ex.Number + " 无效的用户名/密码，请重试");
                        break;
                }
                
            }
            finally
            {
                myUploadConnection.Close();
                
            }
            return 0;
        }
        

        /*private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            // get screen point
            Point mousePoint = Form1.PointToScreen(e.Location);
            // whether in panel
            if (this.pnlImage.RectangleToScreen(this.pnlImage.ClientRectangle).Contains(mousePoint))
            {
                this.pnlImage.AutoScrollPosition = new Point(this.pnlImage.HorizontalScroll.Value, pnlImage.VerticalScroll.Value - e.Delta);
            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            defectCatalog.Items.Clear();


        }

      /* private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dataBind.Checked)
            {
            string queryString1, queryString2;
            DataSet myDataSet;
            DataTable myDataTable1,myDataTable2;
                queryString1 = "select Product from product_testcode Group by product";
                queryString2 = "select Test_code,Count(*) from product_testcode Group by Test_code";
                myDataSet=new DataSet();
                myDataSet=GetQueryResult(queryString1,queryString2);
                myDataTable1=new DataTable();
                myDataTable2=new DataTable();
                myDataTable1=myDataSet.Tables["User1"];
                myDataTable2=myDataSet.Tables["User2"];
        
                DataRow dr1 = myDataTable1.NewRow();
                DataRow dr2 = myDataTable2.NewRow();
                dr1["Product"] = "--请输入产品名--";
                //dr2["Test_code"] = "--请输入关键字--";
                myDataTable1.Rows.InsertAt(dr1, 0);
                //myDataSet2.Tables["USER2"].Rows.InsertAt(dr2,0);

                cbbProductName.DataSource = myDataTable1;
                //cbbProductName.SelectedIndex = -1;
                cbbProductName.DisplayMember = "Product";
                //cbbProductName.ValueMember = "Product";
                cbbTestItem.DataSource = myDataTable2;
                //cbbTestItem.SelectedIndex = -1;
                cbbTestItem.DisplayMember = "Test_code";
                cbbTestItem.Text = "--请输入关键字--";
                //cbbTestItem.ValueMember = "Test_code";
            }
            else
            {
                cbbProductName.DataSource = null;
                cbbTestItem.DataSource = null;
                // this.InitializeComponent();

                this.cbbProductName.Items.AddRange(new object[] {
            "A1000",
            "A2016",
            "A6000",
            "A6001",
            "A6002",
            "A6020",
            "A6090",
            "A6091",
            "A6092",
            "A6093",
            "A6095",
            "A6096",
            "A6097",
            "A6505",
            "AFFINITY",
            "ALEXA",
            "ANDY 4",
            "ANDY NA",
            "ANDY ROW",
            "BLADE3",
            "BLAINE",
            "COPPERFIELD",
            "D52",
            "DANTE",
            "GEORGE NA",
            "GEORGE ROW",
            "GODEN EAGLE",
            "GOLF LITE",
            "HOUDINI",
            "IBIS",
            "JUDO",
            "K33",
            "K52",
            "K53",
            "K9 NOTE",
            "K9 X",
            "KUNTAO",
            "LCS",
            "LENOVO YB1-X90",
            "LENOVO YB1-X91",
            "MODS",
            "P3588",
            "P3G",
            "P4G",
            "PB2-690",
            "PHINNY",
            "Q6003",
            "ROSSION",
            "RUGBY",
            "RUGBY NA",
            "SHELBY",
            "SPEAKER",
            "SPIDER",
            "TELLER",
            "TV CAST",
            "VECTOR",
            "VECTOR MAXX",
            "VECTOR THIN",
            "VERTEX",
            "X30",
            "XT1789",
            "YETI",
            "YETI2",
            "Z2",
            "ZACH",
            "ZACH NA"});
                this.cbbTestItem.Items.AddRange(new object[] {
            "GPS",
            "SD卡",
            "SIM",
            "SN",
            "WIFI",
            "充电",
            "触屏",
            "传感器",
            "灯",
            "电流",
            "耳机",
            "光感",
            "话",
            "机",
            "键",
            "开机",
            "蓝牙",
            "漏电",
            "麦克",
            "拍",
            "屏",
            "摄像",
            "声",
            "跳口",
            "下载",
            "显示",
            "音",
            "指纹"});
            }

        }*/





        private void productName_SelectedIndexChanged(object sender, EventArgs e)
          {


              //show troubleshooting catalog list by seleted product;
              //need study case clause
              //get source from database
              string queryString3=null;
              DataSet myDataSet=new DataSet();
              
             
              string productName1=productName.Text;
              queryString3 = "select Debug_doc from product_doc where product=\""
                              +productName1
                              +"\" ORDER by Debug_doc ASC";
              myDataSet = GetProductDoc(queryString3);
              try
              {
                  defectCatalog.DisplayMember = "Debug_doc";
                  defectCatalog.ValueMember = "Debug_doc";

                  defectCatalog.DataSource = myDataSet.Tables["USER3"].DefaultView;

                  defectCatalog.SelectedIndex = 0;
              }
              catch (ArgumentException ex)
              {
                  MessageBox.Show("Error " + ex + " 维修指南数据库为空，请与系统管理员联系");
              }
          }


        private void buttonUpload_Click(object sender, EventArgs e)
        {
            int result=1;
           
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
                result = UploadTable(upLoadCommandString);
            }
            else
            {
                MessageBox.Show("请选择要上传的csv文件及对应的数据库表名");
                     return;
            }

                
                MessageBox.Show("上传影响的行数:"+result.ToString());
                
        }

        private void uploadTableName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFileBrowser_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV文件|*.csv|所有文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                localCsvFile.Text = path;
            }

        }

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
          
            Process.Start(Application.StartupPath + @"\大数据辅助分析系统v2.2安装使用说明.txt");
        }

       

        /*private void 帮助F1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = Application.StartupPath + "大数据辅助分析系统v2.2安装使用说明.txt";
            helpProvider1.HelpNamespace = filepath;
        }*/

        

        
    }
}







