using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace WinFormLm
{
   public class SqlHelper
    {
        public static string MyCon = ConfigurationManager.AppSettings["DBConnStr"];
        
        //public static string MyCon = "server=127.0.0.1;user id=root;password=123456;database=fae_weekly;charset=utf8;";
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static DataTable GetList(string sql, params MySqlParameter[] ps) 
       {
           try
           {  
               MySqlConnection con = new MySqlConnection(MyCon);
               con.Open();
               MySqlDataAdapter apt = new MySqlDataAdapter(sql, con);
               apt.SelectCommand.Parameters.AddRange(ps);
               DataTable dt = new DataTable();
               apt.Fill(dt);
               con.Close();
               return dt;
           }
           catch (Exception err)
           {

               MessageBox.Show("数据绑定数据库失败，原因" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
               return null;
           }

       }
        public static DataSet GetQueryResultSet(string queryStr)
        {
            MySqlConnection myConnection = new MySqlConnection(MyCon);
                //string connectionString = "Server=127.0.0.1;User ID=root;Password=;Database=fae_weekly;CharSet=utf8;";
                //MySqlConnection myConnection;
            //myConnection = SqlHelper.myGetConnection();
            DataSet myDataSet = new DataSet();
            MySqlCommand mySqlCommandQuery = new MySqlCommand(queryStr, myConnection);
            try
            {
                myConnection.Open();
                mySqlCommandQuery.Prepare();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(mySqlCommandQuery);       
                myDataAdapter.Fill(myDataSet);
               
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
                //
            }
            return myDataSet;
        }


        /// <summary>
        /// 添加，修改，删除
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int update(string sql)
       {
           using (MySqlConnection con = new MySqlConnection(MyCon))
           {
               MySqlCommand cmd = new MySqlCommand(sql,con);
                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch(MySqlException ex)
                {
                   // MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
           }
       }

       /// <summary>
       /// 添加，修改，删除
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
       public static bool modify(string sql)
       {
           using (MySqlConnection con = new MySqlConnection(MyCon))
           {
               con.Open();
               MySqlCommand cmd = new MySqlCommand(sql, con);
               int i=cmd.ExecuteNonQuery();
               if (i > 0)
               {
                   return true;
               }
               else 
               {
                   return false;
               }
           }
       }


      
    }
}
