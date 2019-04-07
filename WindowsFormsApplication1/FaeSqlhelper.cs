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
    class FaeSqlHelper
    {
        //public static string MyCon = "Server=127.0.0.1;database=fae_two;uid=root;pwd=123456;SslMode=none;";
        /// <summary>
        /// 获取配置文件的连接字符串
        /// </summary>
        /// <returns></returns>
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
       // public static string MyCon = ConfigurationManager.AppSettings["DBConnStr"];


        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        //public static DataTable GetList(string sql, params MySqlParameter[] ps)
        //{
        //    using (MySqlConnection con = new MySqlConnection(MyCon))
        //    {
        //        MySqlDataAdapter apt = new MySqlDataAdapter(sql, con);
        //        apt.SelectCommand.Parameters.AddRange(ps);
        //        DataTable dt= new DataTable();
        //        apt.Fill(dt);
        //        return dt;
        //    }
        //}


        //public DataTable UpdateByTable(string sql)
        //{

        //    using (MySqlConnection con = new MySqlConnection(MyCon))
        //    {
        //        //string sql = "select*from cktimeinfo where CheckId='xxxxxxxx'";
        //        MySqlDataAdapter MyDA = new MySqlDataAdapter(sql, con);
        //        MySqlCommandBuilder cmb = new MySqlCommandBuilder(MyDA);
        //        DataTable MyDT = new DataTable();
        //        MyDA.Fill(MyDT);

        //        // apt.Update(MyDT);
        //        return MyDT;

        //    }
        //}
        /// <summary>
        /// 获取查询数据集DataSet
        /// </summary>
        /// <param name="queryStr"></param>
        /// <returns></returns>
        public static DataSet GetQueryResultSet(string queryStr)
        {
            //string connectionString = "Server=127.0.0.1;User ID=root;Password=;Database=fae_weekly;CharSet=utf8;";

            MySqlConnection myConnection;
            myConnection = FaeSqlHelper.myGetConnection();

            DataSet myDataSet = new DataSet();


            MySqlCommand mySqlCommandQuery = new MySqlCommand(queryStr, myConnection);

            try
            {
                myConnection.Open();
                mySqlCommandQuery.Prepare();

                //MessageBox.Show(faeQueryStr);
                //myDataSet = new DataSet();
                //myDataSet2 = new DataSet();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(mySqlCommandQuery);



                //myDataAdapter.Fill(myDataSet, "User4");
                myDataAdapter.Fill(myDataSet);
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
            //myDataAdapter.dispose();
            return myDataSet;
        }

        //public static int update(string sql)
        //{
        //    using (MySqlConnection con = new MySqlConnection(MyCon))
        //    {
        //        MySqlCommand cmd = new MySqlCommand(sql, con);
        //        con.Open();
        //        return cmd.ExecuteNonQuery();
        //    }
        //}

        //public static bool modify(string sql)
        //{
        //    using (MySqlConnection con = new MySqlConnection(MyCon))
        //    {
        //        con.Open();
        //        MySqlCommand cmd = new MySqlCommand(sql, con);
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

    }
}
