using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sm
{
    public partial class ChartForm : Form
    {
        static string db_path = AppDomain.CurrentDomain.BaseDirectory + "\\db\\code.db";
        private static SQLiteConnection cn2 = new SQLiteConnection("data source=" + db_path);
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("dt");
           
            dt.Columns.Add("price", typeof(decimal));
            dt.Columns.Add("acdt", typeof(string));
            dt.Columns.Add("qty", typeof(int));

            
            //Console.WriteLine(Common.current_code);
            //Console.WriteLine(Common.from_dt);
            //Console.WriteLine(Common.to_dt);
            cn2.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn2;
           
            cmd.CommandText = "SELECT acdt,buy1_price,buy1_hands FROM history where code='" + Common.current_code + "' and acdt between '"+ Common.from_dt + "' and '"+ Common.to_dt + "' order by acdt;";
            SQLiteDataReader sr = cmd.ExecuteReader();

            while (sr.Read())
            {
                //2021-12-21 12:30
                Console.WriteLine(sr.GetString(0));
                dt.Rows.Add(sr.GetDecimal(1), sr.GetString(0).Substring(11,5), sr.GetInt32(2));
                //coldt.Rows.Add(sr.GetInt32(2), sr.GetDateTime(0));
            }
            sr.Close();
            decimal price_max, price_min;
            int qty_min, qty_max;
            if (dt.Rows.Count > 0) {
                cmd.CommandText = "SELECT max(buy1_price),min(buy1_price),max(buy1_hands),min(buy1_hands) from history where code='" + Common.current_code + "' and acdt between '" + Common.from_dt + "' and '" + Common.to_dt + "';";
                sr = cmd.ExecuteReader();
                sr.Read();
                price_max = sr.GetDecimal(0);
                price_max += (decimal)0.05;
                price_min = sr.GetDecimal(1);
                price_min -= (decimal)0.05;
                qty_max = sr.GetInt32(2);
                qty_max += 100;
                qty_min = sr.GetInt32(3);
                qty_min -= 100;



                dataChart.Series["Series1"].Points.Clear();
                dataChart.Series["Series2"].Points.Clear();
                dataChart.ChartAreas["ChartArea1"].AxisY.Minimum = (Double)price_min;
                dataChart.ChartAreas["ChartArea1"].AxisY.Maximum = (Double)price_max;
                dataChart.ChartAreas["ChartArea2"].AxisY.Minimum = (Double)qty_min;
                dataChart.ChartAreas["ChartArea2"].AxisY.Maximum = (Double)qty_max;
                dataChart.Series["Series1"].YValueMembers = "price";
                dataChart.Series["Series2"].YValueMembers = "qty";
                dataChart.Series["Series2"].XValueMember = "acdt";
                dataChart.Series["Series1"].XValueMember = "acdt";
                dataChart.DataSource = dt;
                dataChart.DataBind();
            }
            
           
           

            //求最大和最小值 设置坐标最大和最小

            cn2.Close();
            //dataChart.Series["Series1"].XValueType = ChartValueType.String;
            //dataChart.Series["Series2"].XValueType = ChartValueType.String;
            
            
        }
    }
}
