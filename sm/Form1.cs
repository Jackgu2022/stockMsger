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
using System.IO;
using System.Net;
using System.Threading;
using System.Media;
using Newtonsoft.Json.Linq;
namespace sm
{
    public partial class MForm : Form
    {
        
        public static DataTable dt = new DataTable("my_code");
        public static bool stop_flag = true;
        public static bool sql_locked = false;
        public static bool timer_started = false;
        private Icon myicon = Properties.Resources.bird;
        private static Stream  sound = Properties.Resources.alert;
        private static SoundPlayer player = new SoundPlayer(sound);
        private Icon myblankicon = Properties.Resources.Bird_Blank;//透明的图标 
        private bool _status = true;
        static string db_dir = AppDomain.CurrentDomain.BaseDirectory + "\\db";
        static string db_path = AppDomain.CurrentDomain.BaseDirectory + "\\db\\code.db";
        //public Thread[] ths ;
        public static SQLiteConnection cn;
        public static string[] sz_prefix_list = new string[] { "00","200","300"};
        public static string[] sh_prefix_list = new string[] { "60", "900" };


        public MForm()
        {
            InitializeComponent();
        }

        private void MForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // e.Cancel = true;           //取消关闭操作 表现为不关闭窗体  
                //this.Hide();               //隐藏窗体
                if (MessageBox.Show("确定要退出程序?", "安全提示",
                  System.Windows.Forms.MessageBoxButtons.YesNo,
                   System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)

                {
                    //nf.Visible = false;   //设置图标不可见  
                    //this.Close();                  //关闭窗体  
                    this.Dispose();                //释放资源  
                    Application.Exit();            //关闭应用程序窗体  
                }
                else {
                    e.Cancel = true;
                    this.Hide();
                    nf.Visible = true;
                }
            }
            
        }

        private void nf_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;                        //窗体可见  
                this.WindowState = FormWindowState.Normal;  //窗体默认大小  
                this.nf.Visible = true;            //设置图标可见  */
                this.nf.Visible = true;
               

            }
        }

        
        private void MForm_Load(object sender, EventArgs e)
        {
            
            statusStrip.BackColor = Color.LightGray;
            dt.Columns.Add("StockNum", typeof(String));
            dt.Columns.Add("TodayLow", typeof(Decimal));
            dt.Columns.Add("TodayUpper", typeof(Decimal));
            dt.Columns.Add("Price", typeof(Decimal));
            dt.Columns.Add("UpperLimit", typeof(Decimal));
            dt.Columns.Add("LowLimit", typeof(Decimal));
            dt.Columns.Add("MyName", typeof(String));
            dt.Columns.Add("UpTime", typeof(String));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["StockNum"] };
            dgV.AutoGenerateColumns = false;
            if (!Directory.Exists(db_dir))
            {
                Directory.CreateDirectory(db_dir);
                cn = new SQLiteConnection("data source=" + db_path);
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "CREATE TABLE my_code(code varchar(6) primary key,current_price DECIMAL(10,5),low_limit DECIMAL(10,5),upper_limit DECIMAL(10,5),code_name varchar(64))";

                cmd.ExecuteNonQuery();
                //创建历史记录表
                /*
                 string current_buy1_hand_qty  = tmp.Split(',')[10]; //买1入手数
                        string current_buy2_hand_qty = tmp.Split(',')[12]; //买2入手数
                        string current_buy3_hand_qty = tmp.Split(',')[14]; //买3入手数
                        string current_buy4_hand_qty = tmp.Split(',')[16]; //买4入手数
                        string current_buy5_hand_qty = tmp.Split(',')[18]; //买5入手数
                        string current_sale1_hand_qty = tmp.Split(',')[20]; //卖1出手数
                        string current_sale2_hand_qty = tmp.Split(',')[22]; //卖2出手数
                        string current_sale3_hand_qty = tmp.Split(',')[24]; //卖3出手数
                        string current_sale4_hand_qty = tmp.Split(',')[26]; //卖4出手数
                        string current_sale5_hand_qty = tmp.Split(',')[28]; //卖5出手数
                        string current_buy1_price =tmp.Split(',')[11]; //买1价
                        string current_buy2_price = tmp.Split(',')[13]; //买2价
                        string current_buy3_price = tmp.Split(',')[15]; //买3价
                        string current_buy4_price = tmp.Split(',')[17]; //买4价
                        string current_buy5_price = tmp.Split(',')[19]; //买5价
                        string current_sale1_price = tmp.Split(',')[21]; //卖1价
                        string current_sale2_price = tmp.Split(',')[23]; //卖2价
                        string current_sale3_price = tmp.Split(',')[25]; //卖3价
                        string current_sale4_price = tmp.Split(',')[27]; //卖4价
                        string current_sale5_price = tmp.Split(',')[29]; //卖5价
                        string total_trades_qty = tmp.Split(',')[20]; //当天交易总量
                        string total_trades_price = tmp.Split(',')[20]; //当天交易总金额
                 */
                cmd.CommandText = "Create table history(id integer PRIMARY KEY autoincrement,code varchar(6),sale1_price DECIMAL(10,5),sale2_price DECIMAL(10,5),sale3_price DECIMAL(10,5),sale4_price DECIMAL(10,5),sale5_price DECIMAL(10,5),buy1_price DECIMAL(10,5),buy2_price DECIMAL(10,5),buy3_price DECIMAL(10,5),buy4_price DECIMAL(10,5),buy5_price DECIMAL(10,5),sale1_hands integer,sale2_hands integer,sale3_hands integer,sale4_hands integer,sale5_hands integer,buy1_hands integer,buy2_hands integer,buy3_hands integer,buy4_hands integer,buy5_hands integer,today_total_qty integer,today_total_price integer,acdt TIMESTAMP default CURRENT_TIMESTAMP)";
                //cmd.CommandText = "insert into my_code(code,type,current_price,low_limit,upper_limit,code_name) values(601919,'sh',17.60,16.80,18.80,'中海控')";
                cmd.ExecuteNonQuery();
                Thread.Sleep(100);
                cmd.CommandText = "CREATE INDEX k1 ON history(code); ";
                cmd.ExecuteNonQuery();
                Thread.Sleep(100);
                cn.Close();
            }
            else
            {
                cn = new SQLiteConnection("data source=" + db_path);
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;

                cmd.CommandText = "SELECT code,current_price,upper_limit,low_limit,code_name FROM my_code";
                SQLiteDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {

                    dt.Rows.Add(sr.GetString(0), 0, 0, sr.GetDecimal(1), sr.GetDecimal(2), sr.GetDecimal(3), sr.GetString(4), DateTime.Now.ToString("hh:mm:ss"));
                }
                cn.Close();
            }

            dgV.DataSource = dt;
        }

        private void UpateBtn_Click(object sender, EventArgs e)
        {
            //更新sqlite数据
            string name = nameText.Text.ToString().Trim();
            string code = codeText.Text.ToString();
            string lower = lowerText.Text.ToString();
            string upper = upperText.Text.ToString();
            try
            {
                int len = code.Length;
                if (len != 6)
                {
                    MessageBox.Show("GP代码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int code_int = Convert.ToInt32(code);
                decimal tmp, tmp1;
                tmp = Convert.ToDecimal(lower);
                tmp1 = Convert.ToDecimal(upper);
                if (name.Length == 0)
                {
                    MessageBox.Show("别名为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                if (tmp > tmp1)
                {
                    MessageBox.Show("上限必须大于下限", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //更新sqlite数据库
                if (!sql_locked)
                {

                    sql_locked = true;
                    cn = new SQLiteConnection("data source=" + db_path);
                    cn.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = cn;
                    //cmd.CommandText = "CREATE TABLE my_code(code int primary key,type varchar(4),current_price DECIMAL(10,5),low_limit DECIMAL(10,5),upper_limit DECIMAL(10,5),code_name varchar(64))";

                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into my_code(code,type,current_price,low_limit,upper_limit,code_name) values(601919,'sh',17.60,16.80,18.80,'中海控')";
                    //cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT code FROM my_code where code = '" + code + "'";
                    SQLiteDataReader sr = cmd.ExecuteReader();
                    if (sr.HasRows)
                    {
                        sr.Close();
                        cmd.CommandText = "update my_code set code_name='" + name + "', low_limit=" + lower + ",upper_limit =" + upper + "  where code='" + code + "'";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        sr.Close();
                        cmd.CommandText = "insert into my_code(code,current_price,low_limit,upper_limit,code_name) values('" + code + "',0," + lower + "," + upper + ",'" + name + "')";
                        _ = cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                    sql_locked = false;
                    DataRow dr = dt.Rows.Find(code);

                    if (dr != null) //此记录已存
                    {
                        
                        dr.SetField<string>("MyName", name);
                        dr.SetField<decimal>("LowLimit", tmp);
                        dr.SetField<decimal>("UpperLimit", tmp1);
                        dr.SetField<string>("UpTime", DateTime.Now.ToString("hh:mm:ss"));
                    }
                    else
                    {
                        dt.Rows.Add(code, 0.00, 0.00, 0, tmp1, tmp, name, DateTime.Now.ToString("hh:mm:ss"));
                    }

                    dgV.ClearSelection();
                    dgV.DataSource = dt;
                    nameText.Clear();
                    codeText.Clear();
                    lowerText.Clear();
                    upperText.Clear();
                    MessageBox.Show("数据已更新");

                }
                else
                {
                    MessageBox.Show("数据库使用中", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }



            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
                MessageBox.Show("代码或者价格非数字或者小数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (stop_flag && !sql_locked)
            {
                sql_locked = true;
                string code = codeText.Text.ToString().Trim();
                if (code.Length != 0)
                {
                    DataRow dr = dt.Rows.Find(code);
                    if (dr != null)
                    {
                        dt.Rows.Remove(dr);
                        //dgV.DataSource = dt;
                    }
                    //删除
                    cn = new SQLiteConnection("data source=" + db_path);
                    cn.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "delete from  my_code where  code='" + code + "'";
                    cmd.ExecuteNonQuery();
                    cn.Close();

                }
                sql_locked = false;
                nameText.Clear();
                codeText.Clear();
                lowerText.Clear();
                upperText.Clear();

            }
            else
            {
                MessageBox.Show("请先停止后台监控");
            }
        }

        private void dgV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            codeText.Text = dgV.Rows[e.RowIndex].Cells["StockNum"].Value.ToString();
            nameText.Text = dgV.Rows[e.RowIndex].Cells["MyName"].Value.ToString();
            lowerText.Text = dgV.Rows[e.RowIndex].Cells["lowLimit"].Value.ToString();
            upperText.Text = dgV.Rows[e.RowIndex].Cells["UpperLimit"].Value.ToString();
        }
        public static void QueryAPI(object o)
        {
           
            //int t1, t2;

            string st_code = (string)o;
            Console.WriteLine(st_code);
            string st_type = "" ;
            for (var i = 0; i < sh_prefix_list.Length; i++) {
                if (st_code.Substring(0, sh_prefix_list[i].Length) == sh_prefix_list[i]) {
                    st_type = "sh";
                    break;
                }
            }
            if (st_type == "") {
                for (var i = 0; i < sz_prefix_list.Length; i++)
                {
                    if (st_code.Substring(0, sz_prefix_list[i].Length) == sz_prefix_list[i])
                    {
                        st_type = "sz";
                        break;
                    }
                }
            }
            if (st_type == "") {
                Console.WriteLine("stock_type is not defined");
                return;
            }
            Console.WriteLine(st_type);
            string url = "http://hq.sinajs.cn/list=" + st_type + st_code;
            while (true)
            {
                if (stop_flag)
                {
                    
                    Console.WriteLine("st_code:" + st_code + " stopped!");
                    break;

                }
                else
                {
                    Console.WriteLine("st_code:" + st_code + " api querying");
                    HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                    req.Method = "GET";
                    try
                    {
                        WebResponse wr = (HttpWebResponse)req.GetResponse();
                        Stream getStream = wr.GetResponseStream();
                        StreamReader streamreader = new StreamReader(getStream);
                        String result = streamreader.ReadToEnd();
                        Console.WriteLine(result);
                        string tmp = result.Split('"')[1];
                        Console.WriteLine(tmp);
                        string current_price = tmp.Split(',')[6]; //当前买价
                        string buy1_hands  = tmp.Split(',')[10]; //买1入手数
                        string buy2_hands = tmp.Split(',')[12]; //买2入手数
                        string buy3_hands = tmp.Split(',')[14]; //买3入手数
                        string buy4_hands = tmp.Split(',')[16]; //买4入手数
                        string buy5_hands = tmp.Split(',')[18]; //买5入手数
                        string sale1_hands = tmp.Split(',')[20]; //卖1出手数
                        string sale2_hands = tmp.Split(',')[22]; //卖2出手数
                        string sale3_hands = tmp.Split(',')[24]; //卖3出手数
                        string sale4_hands = tmp.Split(',')[26]; //卖4出手数
                        string sale5_hands = tmp.Split(',')[28]; //卖5出手数
                        string buy1_price =tmp.Split(',')[11]; //买1价
                        string buy2_price = tmp.Split(',')[13]; //买2价
                        string buy3_price = tmp.Split(',')[15]; //买3价
                        string buy4_price = tmp.Split(',')[17]; //买4价
                        string buy5_price = tmp.Split(',')[19]; //买5价
                        string sale1_price = tmp.Split(',')[21]; //卖1价
                        string sale2_price = tmp.Split(',')[23]; //卖2价
                        string sale3_price = tmp.Split(',')[25]; //卖3价
                        string sale4_price = tmp.Split(',')[27]; //卖4价
                        string sale5_price = tmp.Split(',')[29]; //卖5价
                        string total_qty = tmp.Split(',')[8]; //当天交易总量
                        string total_price = tmp.Split(',')[9]; //当天交易总金额
                        string today_low = tmp.Split(',')[5];
                        string today_upper = tmp.Split(',')[4];
                        //更新数据库
                        if (!sql_locked)
                        {

                            sql_locked = true;
                            cn = new SQLiteConnection("data source=" + db_path);
                            cn.Open();
                            SQLiteCommand cmd = new SQLiteCommand();
                            cmd.Connection = cn;

                            cmd.CommandText = "update my_code set current_price=" + current_price + "  where code='" + st_code + "'";
                            cmd.ExecuteNonQuery();
                            Thread.Sleep(100);
                            cmd.CommandText= "insert into history(code ,sale1_price,sale2_price,sale3_price ,sale4_price ,sale5_price,buy1_price,buy2_price,buy3_price,buy4_price,buy5_price,sale1_hands,sale2_hands,sale3_hands ,sale4_hands,sale5_hands,buy1_hands,buy2_hands,buy3_hands,buy4_hands,buy5_hands,today_total_qty,today_total_price ) values" + 
                                            "('"+st_code+ "'," + sale1_price+"," + sale2_price + "," + sale3_price + "," + sale4_price + "," + sale5_price + "," + buy1_price + "," + buy2_price + "," + buy3_price + "," + buy4_price + "," + buy5_price + "," + sale1_hands + "," + sale2_hands + "," + sale3_hands + "," + sale4_hands + "," + sale4_hands + "," + buy1_hands + "," + buy2_hands + "," + buy3_hands + "," + buy4_hands + "," + buy5_hands + "," + total_qty + "," + total_price + ");";
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            sql_locked = false;


                        }
                        DataRow dr = dt.Rows.Find(st_code);

                        if (dr != null) //此记录存在
                        {

                            dr.SetField<decimal>("Price", Convert.ToDecimal(current_price));
                            dr.SetField<decimal>("TodayLow", Convert.ToDecimal(today_low));
                            dr.SetField<decimal>("TodayUpper", Convert.ToDecimal(today_upper));
                            dr.SetField<string>("UpTime", DateTime.Now.ToString("hh:mm:ss"));

                        }
                    }
                    catch (Exception e) {
                        Console.WriteLine(e.ToString());
                    }
                    
                }
                Console.WriteLine("sleep 20 seconds");
                Thread.Sleep(20000);


            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!stop_flag)
            {
                MessageBox.Show("后台监控已启动", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            stop_flag = false;
            int i = 0;
            string st_code;
            Thread[] ths = new Thread[dt.Rows.Count];
            while (i < dt.Rows.Count)
            {

                st_code = dt.Rows[i]["StockNum"].ToString();
                //st_type = dt.Rows[i]["CodeType"].ToString();
                Console.WriteLine(st_code);
                
                
                ths[i] = new Thread(new ParameterizedThreadStart(QueryAPI));
                ths[i].Start(st_code);
                Random ran = new Random();
                int RandKey = ran.Next(1000, 2500);
                Thread.Sleep(RandKey);
                i++;
            }

            
            statusStrip.BackColor = Color.CadetBlue;
            statusLabel.Text = "监控中";
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stop_flag = true;
            sql_locked = false;
            statusStrip.BackColor = Color.LightGray;
            statusLabel.Text = "已停止";
        }

        private void dgV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //dgV数据更新触发事件
            //dgV.Rows[0].DefaultCellStyle.BackColor = Color.Red;
            //遍历dt数据
            if (e.ListChangedType == ListChangedType.ItemDeleted) {
                return;
            }
            int rowCount = dt.Rows.Count;
            Console.WriteLine(rowCount);
            bool if_blink = false;
            for (int i = 0; i < rowCount; i++)
            {
                decimal current = (decimal)dt.Rows[i]["Price"];
                decimal low = (decimal)dt.Rows[i]["LowLimit"];
                decimal up = (decimal)dt.Rows[i]["UpperLimit"];
                Console.WriteLine(low);
                Console.WriteLine(current);
                Console.WriteLine(up);
                if (current >= up)
                {
                    dgV.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    if_blink = true;
                }
                else if (current <= low)
                {
                    dgV.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    if_blink = true;
                }
                else
                {
                    dgV.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }
            
            dgV.ClearSelection();
            if (if_blink && !timer_started )
            {
                timer1.Start();
                timer_started = true;
            }
            else if (!if_blink && timer_started) {
                timer1.Stop();
                timer_started = false;
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_status)
                nf.Icon = myicon;
            else
                nf.Icon = myblankicon;
            player.Play();

            _status = !_status;
        }

        private void MForm_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                nf.Visible = true;
                nf.Icon = myicon;
            }
        }

        private void checkStatusTimer_Tick(object sender, EventArgs e)
        {
            /*if (stop_flag)
            {
                statusStrip.BackColor = Color.LightGray;
                statusLabel.Text = "已停止";
            }
            else {
                statusStrip.BackColor = Color.CadetBlue;
                statusLabel.Text = "监控中";
            }*/
            //判断时间是否超过下午3点 停止监控
            //Console.WriteLine(Convert.ToInt16(DateTime.Now.DayOfWeek));
            //判断今日是否为节假日
            


            if (AutoStopCheckBox.Checked)
            {
                DateTime currentTime = DateTime.Now;
                int hours = currentTime.Hour;
                //int weekday = Convert.ToInt16(DateTime.Now.DayOfWeek);
                String today = DateTime.Now.Date.ToString("yyyy-MM-dd");
                string url = "https://timor.tech/api/holiday/info/" + today;
                int is_holiday = 0;
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                req.Method = "GET";
                try
                {
                    WebResponse wr = (HttpWebResponse)req.GetResponse();
                    Stream getStream = wr.GetResponseStream();
                    StreamReader streamreader = new StreamReader(getStream);
                    String result = streamreader.ReadToEnd();
                    JObject o = JObject.Parse(result);
                    //Console.WriteLine(result);
                    is_holiday = (int)o["type"]["type"];
                    Console.WriteLine(is_holiday);

                } catch(Exception a) {
                    Console.WriteLine(a.ToString());


                }
                if (hours >= 15 )
                {  //停止运行
                    Console.WriteLine("已到下午15点，自动停止监控");
                    stop_flag = true;
                    sql_locked = false;
                    statusStrip.BackColor = Color.LightGray;
                    statusLabel.Text = "已停止";
                }
                else if (hours >= 9 && hours <15 && is_holiday==0) {
                    if (stop_flag) {
                        //自动启动后台
                        stop_flag = false;
                        int i = 0;
                        string st_code;
                        Thread[] ths = new Thread[dt.Rows.Count];
                        while (i < dt.Rows.Count)
                        {

                            st_code = dt.Rows[i]["StockNum"].ToString();
                            //st_type = dt.Rows[i]["CodeType"].ToString();
                            Console.WriteLine(st_code);
                            ths[i] = new Thread(new ParameterizedThreadStart(QueryAPI));
                            ths[i].Start(st_code);
                            Random ran = new Random();
                            int RandKey = ran.Next(1000, 2500);
                            Thread.Sleep(RandKey);
                            i++;
                        }


                        statusStrip.BackColor = Color.CadetBlue;
                        statusLabel.Text = "监控中";

                    }
                }
            }


        }
    }
}
