using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormLm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            answer aw = new answer();
            string sql = "select*from answer where Id='1'";
            DataTable dt= SqlHelper.GetList(sql);

            aw.A = dt.Rows[0][1].ToString();
            aw.B = dt.Rows[0][2].ToString();
            aw.C = dt.Rows[0][3].ToString();
            aw.D = dt.Rows[0][4].ToString();
            aw.title = dt.Rows[0][5].ToString();
            richtxtTitle.Text = aw.title;
            richtxtA.Text = aw.A;
            richtxtB.Text = aw.B;
            richtxtC.Text = aw.C;
            richtxtD.Text = aw.D;
            lbltopic.Text = "1";
        }

        int i = 1;
        private void button2_Click(object sender, EventArgs e)
        {

            i++;
            answer aw = new answer();
            string sql = "select*from answer where Id='"+i+"'";
            DataTable dt = SqlHelper.GetList(sql);
            if (dt.Rows.Count > 0)
            {
                
                aw.A = dt.Rows[0][1].ToString();
                aw.B = dt.Rows[0][2].ToString();
                aw.C = dt.Rows[0][3].ToString();
                aw.D = dt.Rows[0][4].ToString();
                aw.title = dt.Rows[0][5].ToString();
                richtxtTitle.Text = aw.title;
                richtxtA.Text = aw.A;
                richtxtB.Text = aw.B;
                richtxtC.Text = aw.C;
                richtxtD.Text = aw.D;
                lbltopic.Text = i.ToString();
            }

            else 
            {
                MessageBox.Show("当前页已经是最后一题！");
                i--;
                return;
            }
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {


            i--;
            answer aw = new answer();
            
            string sql = "select*from answer where Id='" + i+ "'";
            DataTable dt = SqlHelper.GetList(sql);
            if (dt.Rows.Count > 0)
            {
                
                aw.A = dt.Rows[0][1].ToString();
                aw.B = dt.Rows[0][2].ToString();
                aw.C = dt.Rows[0][3].ToString();
                aw.D = dt.Rows[0][4].ToString();
                aw.title = dt.Rows[0][5].ToString();
                richtxtTitle.Text = aw.title;
                richtxtA.Text = aw.A;
                richtxtB.Text = aw.B;
                richtxtC.Text = aw.C;
                richtxtD.Text = aw.D;
                lbltopic.Text = i.ToString();
            }
            else 
            {
                MessageBox.Show("当前页已经是第一题！");
                i++;
                return;
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //answer aw = new answer();

            //string sql = "select*from answer where Id='1'";
            //DataTable dt = SqlHelper.GetList(sql);
            //aw.A = dt.Rows[0][1].ToString();
            //aw.B = dt.Rows[0][2].ToString();
            //aw.C = dt.Rows[0][3].ToString();
            //aw.D = dt.Rows[0][4].ToString();
            //aw.title = dt.Rows[0][5].ToString();
            //richtxtTitle.Text = aw.title;
            //richtxtA.Text = aw.A;
            //richtxtB.Text = aw.B;
            //richtxtC.Text = aw.C;
            //richtxtD.Text = aw.D;
            //lbltopic.Text = "1";
        }


    }
}
