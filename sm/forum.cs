using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sm
{
    public partial class forumForm : Form
    {
        public forumForm()
        {
            InitializeComponent();
        }

        private void forum_Load(object sender, EventArgs e)
        {
            WebKit.WebKitBrowser br = new WebKit.WebKitBrowser();
            br.Dock = DockStyle.Fill;
            string url = "http://guba.eastmoney.com/list," + Common.current_code + ".html?from=BaiduAladdin";
            br.Navigate(url);
            br.AllowNewWindows = true;
            //br.UseDefaultContextMenu = false;
            this.Controls.Add(br);
            
            //br.Navigate(url);

        }
    }
}
