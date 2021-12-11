
namespace sm
{
    partial class MForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MForm));
            this.nf = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgV = new System.Windows.Forms.DataGridView();
            this.MyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TodayLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TodayUpper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AutoStopCheckBox = new System.Windows.Forms.CheckBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.UpateBtn = new System.Windows.Forms.Button();
            this.lowerText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.upperText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nf
            // 
            this.nf.Icon = ((System.Drawing.Icon)(resources.GetObject("nf.Icon")));
            this.nf.Text = "咕咕鸟";
            this.nf.Visible = true;
            this.nf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nf_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgV);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "监控列表";
            // 
            // dgV
            // 
            this.dgV.AllowUserToAddRows = false;
            this.dgV.AllowUserToOrderColumns = true;
            this.dgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MyName,
            this.TodayLow,
            this.Price,
            this.TodayUpper,
            this.LowLimit,
            this.UpperLimit,
            this.UpTime,
            this.StockNum});
            this.dgV.Location = new System.Drawing.Point(5, 12);
            this.dgV.Name = "dgV";
            this.dgV.RowHeadersWidth = 30;
            this.dgV.RowTemplate.Height = 23;
            this.dgV.Size = new System.Drawing.Size(509, 108);
            this.dgV.TabIndex = 0;
            this.dgV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgV_DataBindingComplete);
            this.dgV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgV_RowHeaderMouseDoubleClick);
            // 
            // MyName
            // 
            this.MyName.DataPropertyName = "MyName";
            this.MyName.HeaderText = "别名";
            this.MyName.Name = "MyName";
            this.MyName.Width = 70;
            // 
            // TodayLow
            // 
            this.TodayLow.DataPropertyName = "TodayLow";
            this.TodayLow.HeaderText = "今低";
            this.TodayLow.Name = "TodayLow";
            this.TodayLow.Width = 70;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "当前";
            this.Price.Name = "Price";
            this.Price.Width = 70;
            // 
            // TodayUpper
            // 
            this.TodayUpper.DataPropertyName = "TodayUpper";
            this.TodayUpper.HeaderText = "今高";
            this.TodayUpper.Name = "TodayUpper";
            this.TodayUpper.Width = 70;
            // 
            // LowLimit
            // 
            this.LowLimit.DataPropertyName = "LowLimit";
            this.LowLimit.HeaderText = "下限";
            this.LowLimit.Name = "LowLimit";
            this.LowLimit.Width = 70;
            // 
            // UpperLimit
            // 
            this.UpperLimit.DataPropertyName = "UpperLimit";
            this.UpperLimit.HeaderText = "上限";
            this.UpperLimit.Name = "UpperLimit";
            this.UpperLimit.Width = 70;
            // 
            // UpTime
            // 
            this.UpTime.DataPropertyName = "UpTime";
            this.UpTime.HeaderText = "更新";
            this.UpTime.Name = "UpTime";
            this.UpTime.Width = 70;
            // 
            // StockNum
            // 
            this.StockNum.DataPropertyName = "StockNum";
            this.StockNum.HeaderText = "代码";
            this.StockNum.Name = "StockNum";
            this.StockNum.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AutoStopCheckBox);
            this.groupBox2.Controls.Add(this.delBtn);
            this.groupBox2.Controls.Add(this.UpateBtn);
            this.groupBox2.Controls.Add(this.lowerText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.upperText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.codeText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nameText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "咕咕配置";
            // 
            // AutoStopCheckBox
            // 
            this.AutoStopCheckBox.AutoSize = true;
            this.AutoStopCheckBox.Location = new System.Drawing.Point(10, 61);
            this.AutoStopCheckBox.Name = "AutoStopCheckBox";
            this.AutoStopCheckBox.Size = new System.Drawing.Size(72, 16);
            this.AutoStopCheckBox.TabIndex = 12;
            this.AutoStopCheckBox.Text = "自动启停";
            this.AutoStopCheckBox.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            this.delBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.delBtn.Location = new System.Drawing.Point(308, 57);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(83, 23);
            this.delBtn.TabIndex = 11;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // UpateBtn
            // 
            this.UpateBtn.Location = new System.Drawing.Point(165, 57);
            this.UpateBtn.Name = "UpateBtn";
            this.UpateBtn.Size = new System.Drawing.Size(83, 23);
            this.UpateBtn.TabIndex = 10;
            this.UpateBtn.Text = "更新";
            this.UpateBtn.UseVisualStyleBackColor = true;
            this.UpateBtn.Click += new System.EventHandler(this.UpateBtn_Click);
            // 
            // lowerText
            // 
            this.lowerText.Location = new System.Drawing.Point(419, 20);
            this.lowerText.Name = "lowerText";
            this.lowerText.Size = new System.Drawing.Size(86, 21);
            this.lowerText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "下限";
            // 
            // upperText
            // 
            this.upperText.Location = new System.Drawing.Point(292, 20);
            this.upperText.Name = "upperText";
            this.upperText.Size = new System.Drawing.Size(86, 21);
            this.upperText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "上限";
            // 
            // codeText
            // 
            this.codeText.Location = new System.Drawing.Point(165, 20);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(86, 21);
            this.codeText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "代码";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(38, 20);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(86, 21);
            this.nameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 239);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(525, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "状态";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusLabel.Location = new System.Drawing.Point(270, 245);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 14);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "未开始";
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Gray;
            this.stopBtn.Location = new System.Drawing.Point(102, 216);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "停止监控";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Blue;
            this.startBtn.Location = new System.Drawing.Point(340, 216);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "开始监控";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkStatusTimer
            // 
            this.checkStatusTimer.Enabled = true;
            this.checkStatusTimer.Interval = 400;
            this.checkStatusTimer.Tick += new System.EventHandler(this.checkStatusTimer_Tick);
            // 
            // MForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 261);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 400);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.Name = "MForm";
            this.Text = "咕咕鸟v0.2 316710846@qq.com";
            this.MinimumSizeChanged += new System.EventHandler(this.delBtn_Click);
            this.Deactivate += new System.EventHandler(this.MForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MForm_FormClosing);
            this.Load += new System.EventHandler(this.MForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DataGridView dgV;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button UpateBtn;
        private System.Windows.Forms.TextBox lowerText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox upperText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TodayLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TodayUpper;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockNum;
        private System.Windows.Forms.CheckBox AutoStopCheckBox;
        private System.Windows.Forms.Timer checkStatusTimer;
    }
}

