﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sm
{
    public partial class Form2 : Form
    {
        private  DataTable his_dt = new DataTable("history");
        public static bool data_initilized = false;
        static string db_path = AppDomain.CurrentDomain.BaseDirectory + "\\db\\code.db";
        private static SQLiteConnection cn1 = new SQLiteConnection("data source=" + db_path);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("form2 loading");

            cn1.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn1;
            CodeCombox.Items.Clear();
            cmd.CommandText = "SELECT code FROM my_code";
            SQLiteDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {

                CodeCombox.Items.Add(sr.GetString(0));
            }
            sr.Close();
            
           
                

                //SQLiteCommand cmd = new SQLiteCommand();
                //cmd.Connection = cn1;

                startDtPick.Format = DateTimePickerFormat.Custom;
                startDtPick.CustomFormat = "yyyy-MM-dd HH:mm";
                stopDtPick.Format = DateTimePickerFormat.Custom;
                stopDtPick.CustomFormat = "yyyy-MM-dd HH:mm";
                //填入默认数据

                his_dt.Columns.Add("Code", typeof(String));
                his_dt.Columns.Add("Time", typeof(String));
                his_dt.Columns.Add("Buy1Price", typeof(Decimal));
                his_dt.Columns.Add("Buy1Qty", typeof(Int32));
                his_dt.Columns.Add("Sale1Price", typeof(Decimal));
                his_dt.Columns.Add("Sale1Qty", typeof(Int32));
                his_dt.Columns.Add("Buy2Price", typeof(Decimal));
                his_dt.Columns.Add("Buy2Qty", typeof(Int32));
                his_dt.Columns.Add("Sale2Price", typeof(Decimal));
                his_dt.Columns.Add("Sale2Qty", typeof(Int32));
                his_dt.Columns.Add("Buy5Price", typeof(Decimal));
                his_dt.Columns.Add("Buy5Qty", typeof(Int32));
                his_dt.Columns.Add("Sale5Price", typeof(Decimal));
                his_dt.Columns.Add("Sale5Qty", typeof(Int32));
                his_dt.Columns.Add("TotalPrice", typeof(Decimal));
                his_dt.Columns.Add("TotalQty", typeof(Int64));
                cmd.CommandText = "SELECT id ,code ,acdt,buy1_price ,buy1_hands,sale1_price ,sale1_hands,buy2_price ,buy2_hands,sale2_price ,sale2_hands,buy5_price ,buy5_hands,sale5_price ,sale5_hands,today_total_price,today_total_qty   FROM history order  by acdt desc limit 200;";
                sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    his_dt.Rows.Add(sr.GetString(1), sr.GetString(2), sr.GetDecimal(3), sr.GetInt32(4), sr.GetDecimal(5), sr.GetInt32(6), sr.GetDecimal(7), sr.GetInt32(8), sr.GetDecimal(9), sr.GetInt32(10), sr.GetDecimal(11), sr.GetInt32(12), sr.GetDecimal(13), sr.GetInt32(14), sr.GetDecimal(15), sr.GetInt64(16));
                }
                HisDV.DataSource = his_dt;


                data_initilized = true;
                
            
            cn1.Close();


        }

        private void DataQueryBtn_Click(object sender, EventArgs e)
        {
            string dt1 = startDtPick.Text.ToString();
            string dt2 = stopDtPick.Text.ToString();
            string code = CodeCombox.Text.ToString();
            string now_str = DateTime.Now.ToString("yyyy - MM - dd hh: mm:ss");
            code = code.Trim();
            if (code != "")
            {
                if (string.Compare(dt1, dt2, true) >= 0 && string.Compare(dt2, now_str, true) == 1)
                {
                    MessageBox.Show("错误的日期范围");
                    return;
                }
                else
                {
                    cn1.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = cn1;


                    //填入默认数据


                    cmd.CommandText = "SELECT id ,code ,acdt,buy1_price ,buy1_hands,sale1_price ,sale1_hands,buy2_price ,buy2_hands,sale2_price ,sale2_hands,buy5_price ,buy5_hands,sale5_price ,sale5_hands,today_total_price,today_total_qty   FROM history where code='" + code + "'and acdt between '" + dt1 + "'and '" + dt2 + "' order  by acdt desc;";
                    SQLiteDataReader sr = cmd.ExecuteReader();
                    his_dt.Rows.Clear();
                    while (sr.Read())
                    {
                        his_dt.Rows.Add(sr.GetString(1), sr.GetString(2), sr.GetDecimal(3), sr.GetInt32(4), sr.GetDecimal(5), sr.GetInt32(6), sr.GetDecimal(7), sr.GetInt32(8), sr.GetDecimal(9), sr.GetInt32(10), sr.GetDecimal(11), sr.GetInt32(12), sr.GetDecimal(13), sr.GetInt32(14), sr.GetDecimal(15), sr.GetInt64(16));
                    }
                    HisDV.DataSource = his_dt;

                    cn1.Close();
                }
            }
            else
            {
                MessageBox.Show("未选中gg代码");
            }


        }

        private void ForumBtn_Click(object sender, EventArgs e)
        {
            Common.current_code = CodeCombox.Text.ToString();
            if (Common.current_code == "") {
                Common.current_code = "000995";
            }

            forumForm ff = new forumForm();
            ff.Show();
        }





        /*private void Form2_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("form shown event trigered");
           cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            
            cmd.CommandText = "SELECT code FROM my_code";
            SQLiteDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {

                CodeCombox.Items.Add(sr.GetString(0));
            }
            sr.Close();
            cn.Close();

        }*/
    }
        
}