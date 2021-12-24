using System;
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
            startDtPick.Value = DateTime.Now.AddDays(-7);
            stopDtPick.Value = DateTime.Now;
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
            cmd.CommandText = "SELECT count(1) as cnt   FROM history;";
            sr = cmd.ExecuteReader();
            sr.Read();
            int total_pages = sr.GetInt32(0);
            queryDataPager.RecordCount = total_pages;
            queryDataPager.PageIndex = 1;
            string page_size = queryDataPager.PageSize.ToString();

            sr.Close();
            cmd.CommandText = "SELECT id ,code ,acdt,buy1_price ,buy1_hands,sale1_price ,sale1_hands,buy2_price ,buy2_hands,sale2_price ,sale2_hands,buy5_price ,buy5_hands,sale5_price ,sale5_hands,today_total_price,today_total_qty   FROM history  order  by acdt desc limit 0, " + page_size + ";";
            sr = cmd.ExecuteReader();
            his_dt.Rows.Clear();
           
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
            string sql_cnt;
            string sql_query;
            if (code != "")
            {
                sql_cnt= "SELECT count(1) as cnt   FROM history where code='" + code + "'and acdt between '" + dt1 + "'and '" + dt2 + "';";
            }
            else {
                sql_cnt = "SELECT count(1) as cnt   FROM history where  acdt between '" + dt1 + "'and '" + dt2 + "';";
            }
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

                //获取总条数
                cmd.CommandText = sql_cnt;
                SQLiteDataReader sr = cmd.ExecuteReader();
                sr.Read();
                int total_pages = sr.GetInt32(0);
                queryDataPager.RecordCount = total_pages;
                queryDataPager.PageIndex = 1;
                string page_size = queryDataPager.PageSize.ToString();

                sr.Close();
                if (code != "")
                {
                    sql_query= "SELECT id ,code ,acdt,buy1_price ,buy1_hands,sale1_price ,sale1_hands,buy2_price ,buy2_hands,sale2_price ,sale2_hands,buy5_price ,buy5_hands,sale5_price ,sale5_hands,today_total_price,today_total_qty   FROM history where code='" + code + "'and acdt between '" + dt1 + "'and '" + dt2 + "' order  by acdt desc limit 0, " + page_size + ";";
                }
                else {
                    sql_query = "SELECT id ,code ,acdt,buy1_price ,buy1_hands,sale1_price ,sale1_hands,buy2_price ,buy2_hands,sale2_price ,sale2_hands,buy5_price ,buy5_hands,sale5_price ,sale5_hands,today_total_price,today_total_qty   FROM history where  acdt between '" + dt1 + "'and '" + dt2 + "' order  by acdt desc limit 0, " + page_size + ";";

                }
                cmd.CommandText = sql_query;
                sr = cmd.ExecuteReader();
                his_dt.Rows.Clear();
                while (sr.Read())
                {
                    his_dt.Rows.Add(sr.GetString(1), sr.GetString(2), sr.GetDecimal(3), sr.GetInt32(4), sr.GetDecimal(5), sr.GetInt32(6), sr.GetDecimal(7), sr.GetInt32(8), sr.GetDecimal(9), sr.GetInt32(10), sr.GetDecimal(11), sr.GetInt32(12), sr.GetDecimal(13), sr.GetInt32(14), sr.GetDecimal(15), sr.GetInt64(16));
                }
                HisDV.DataSource = his_dt;

                cn1.Close();
            }
            
            


        }

        private void ForumBtn_Click(object sender, EventArgs e)
        {
            
        }
        /*
         Common.current_code = CodeCombox.Text.ToString();
            if (Common.current_code == "") {
                Common.current_code = "000995";
            }

            forumForm ff = new forumForm();
            ff.Show();
         */
        private void queryDataPager_PageIndexChanged(object sender, EventArgs e)
        {
            string dt1 = startDtPick.Text.ToString();
            string dt2 = stopDtPick.Text.ToString();
            string code = CodeCombox.Text.ToString();
            int page = queryDataPager.PageIndex ;
            int  page_size = queryDataPager.PageSize;
            int start = (page - 1) * page_size;
            
            //string cnt_sql;
            string query_sql;
            string now_str = DateTime.Now.ToString("yyyy - MM - dd HH: mm:ss");
            code = code.Trim();
            cn1.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn1;
            
            if (code != "")
            {
                //cnt_sql = "SELECT count(1) as cnt   FROM history where code='" + code + "'and acdt between '" + dt1 + "'and '" + dt2 + "';";
                query_sql = "SELECT id ,code ,acdt,buy1_price ,buy1_hands,sale1_price ,sale1_hands,buy2_price ,buy2_hands,sale2_price ,sale2_hands,buy5_price ,buy5_hands,sale5_price ,sale5_hands,today_total_price,today_total_qty   FROM history where code='" + code + "'and acdt between '" + dt1 + "'and '" + dt2 + "' order  by acdt desc limit " + start.ToString() + ", " + page_size.ToString() + ";";
            }
            else
            {
                //cnt_sql = "SELECT count(1) as cnt   FROM history where  acdt between '" + dt1 + "'and '" + dt2 + "';";
                query_sql = "SELECT id ,code ,acdt,buy1_price ,buy1_hands,sale1_price ,sale1_hands,buy2_price ,buy2_hands,sale2_price ,sale2_hands,buy5_price ,buy5_hands,sale5_price ,sale5_hands,today_total_price,today_total_qty   FROM history where  acdt between '" + dt1 + "'and '" + dt2 + "' order  by acdt desc limit " + start.ToString() + ", " + page_size.ToString() + ";";
            }
            cmd.CommandText = query_sql;
            SQLiteDataReader sr = cmd.ExecuteReader();
            his_dt.Rows.Clear();
            while (sr.Read())
            {
                his_dt.Rows.Add(sr.GetString(1), sr.GetString(2), sr.GetDecimal(3), sr.GetInt32(4), sr.GetDecimal(5), sr.GetInt32(6), sr.GetDecimal(7), sr.GetInt32(8), sr.GetDecimal(9), sr.GetInt32(10), sr.GetDecimal(11), sr.GetInt32(12), sr.GetDecimal(13), sr.GetInt32(14), sr.GetDecimal(15), sr.GetInt64(16));
            }
            cn1.Close();
        }

        private void chartBtn_Click(object sender, EventArgs e)
        {
            Common.current_code = CodeCombox.Text;
            Common.from_dt = startDtPick.Text;
            Common.to_dt = stopDtPick.Text;
            Console.WriteLine(Common.from_dt);
            Console.WriteLine(Common.start_dt);
            if (Common.current_code == "") {
                MessageBox.Show("代码为空");
                return;
            }
           
            ChartForm cf = new ChartForm();
            cf.Show();
        }
    }
        
}
