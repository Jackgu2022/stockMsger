namespace sm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ForumBtn = new System.Windows.Forms.Button();
            this.DataQueryBtn = new System.Windows.Forms.Button();
            this.stopDtPick = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.startDtPick = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeCombox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.queryDataPager = new Fhzy.WinForm.Pager.Pager();
            this.HisDV = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy1Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy1Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale1Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale1Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy2Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy2Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale2Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale2Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy5Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy5Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale5Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale5Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HisDV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ForumBtn);
            this.groupBox1.Controls.Add(this.DataQueryBtn);
            this.groupBox1.Controls.Add(this.stopDtPick);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.startDtPick);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CodeCombox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1334, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // ForumBtn
            // 
            this.ForumBtn.Location = new System.Drawing.Point(1122, 21);
            this.ForumBtn.Name = "ForumBtn";
            this.ForumBtn.Size = new System.Drawing.Size(75, 23);
            this.ForumBtn.TabIndex = 7;
            this.ForumBtn.Text = "论坛小道";
            this.ForumBtn.UseVisualStyleBackColor = true;
            this.ForumBtn.Click += new System.EventHandler(this.ForumBtn_Click);
            // 
            // DataQueryBtn
            // 
            this.DataQueryBtn.Location = new System.Drawing.Point(1244, 19);
            this.DataQueryBtn.Name = "DataQueryBtn";
            this.DataQueryBtn.Size = new System.Drawing.Size(75, 23);
            this.DataQueryBtn.TabIndex = 6;
            this.DataQueryBtn.Text = "查询";
            this.DataQueryBtn.UseVisualStyleBackColor = true;
            this.DataQueryBtn.Click += new System.EventHandler(this.DataQueryBtn_Click);
            // 
            // stopDtPick
            // 
            this.stopDtPick.Location = new System.Drawing.Point(550, 24);
            this.stopDtPick.Name = "stopDtPick";
            this.stopDtPick.Size = new System.Drawing.Size(150, 21);
            this.stopDtPick.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "截止时间";
            // 
            // startDtPick
            // 
            this.startDtPick.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDtPick.Location = new System.Drawing.Point(269, 25);
            this.startDtPick.Name = "startDtPick";
            this.startDtPick.Size = new System.Drawing.Size(150, 21);
            this.startDtPick.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "开始时间";
            // 
            // CodeCombox
            // 
            this.CodeCombox.FormattingEnabled = true;
            this.CodeCombox.Location = new System.Drawing.Point(60, 28);
            this.CodeCombox.Name = "CodeCombox";
            this.CodeCombox.Size = new System.Drawing.Size(121, 20);
            this.CodeCombox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "代码";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.queryDataPager);
            this.groupBox2.Controls.Add(this.HisDV);
            this.groupBox2.Location = new System.Drawing.Point(15, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1334, 709);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "历史数据";
            // 
            // queryDataPager
            // 
            this.queryDataPager.Location = new System.Drawing.Point(7, 678);
            this.queryDataPager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queryDataPager.Name = "queryDataPager";
            this.queryDataPager.PageSize = 30;
            this.queryDataPager.RecordCount = 10000;
            this.queryDataPager.Size = new System.Drawing.Size(1316, 26);
            this.queryDataPager.TabIndex = 1;
            this.queryDataPager.PageIndexChanged += new Fhzy.WinForm.Pager.Pager.EventHandler(this.queryDataPager_PageIndexChanged);
            // 
            // HisDV
            // 
            this.HisDV.AllowUserToAddRows = false;
            this.HisDV.AllowUserToDeleteRows = false;
            this.HisDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HisDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Buy1Price,
            this.Buy1Qty,
            this.Sale1Price,
            this.Sale1Qty,
            this.Buy2Price,
            this.Buy2Qty,
            this.Sale2Price,
            this.Sale2Qty,
            this.Buy5Price,
            this.Buy5Qty,
            this.Sale5Price,
            this.Sale5Qty,
            this.TotalPrice,
            this.TotalQty,
            this.Code});
            this.HisDV.Location = new System.Drawing.Point(6, 13);
            this.HisDV.Name = "HisDV";
            this.HisDV.ReadOnly = true;
            this.HisDV.RowTemplate.Height = 23;
            this.HisDV.Size = new System.Drawing.Size(1322, 663);
            this.HisDV.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 140;
            // 
            // Buy1Price
            // 
            this.Buy1Price.DataPropertyName = "Buy1Price";
            this.Buy1Price.HeaderText = "Buy1Price";
            this.Buy1Price.Name = "Buy1Price";
            this.Buy1Price.Width = 80;
            // 
            // Buy1Qty
            // 
            this.Buy1Qty.DataPropertyName = "Buy1Qty";
            this.Buy1Qty.HeaderText = "Buy1Qty";
            this.Buy1Qty.Name = "Buy1Qty";
            this.Buy1Qty.Width = 80;
            // 
            // Sale1Price
            // 
            this.Sale1Price.DataPropertyName = "Sale1Price";
            this.Sale1Price.HeaderText = "Sale1Price";
            this.Sale1Price.Name = "Sale1Price";
            this.Sale1Price.Width = 80;
            // 
            // Sale1Qty
            // 
            this.Sale1Qty.DataPropertyName = "Sale1Qty";
            this.Sale1Qty.HeaderText = "Sale1Qty";
            this.Sale1Qty.Name = "Sale1Qty";
            this.Sale1Qty.Width = 80;
            // 
            // Buy2Price
            // 
            this.Buy2Price.DataPropertyName = "Buy2Price";
            this.Buy2Price.HeaderText = "Buy2Price";
            this.Buy2Price.Name = "Buy2Price";
            this.Buy2Price.Width = 80;
            // 
            // Buy2Qty
            // 
            this.Buy2Qty.DataPropertyName = "Buy2Qty";
            this.Buy2Qty.HeaderText = "Buy2Qty";
            this.Buy2Qty.Name = "Buy2Qty";
            this.Buy2Qty.Width = 80;
            // 
            // Sale2Price
            // 
            this.Sale2Price.DataPropertyName = "Sale2Price";
            this.Sale2Price.HeaderText = "Sale2Price";
            this.Sale2Price.Name = "Sale2Price";
            this.Sale2Price.Width = 80;
            // 
            // Sale2Qty
            // 
            this.Sale2Qty.DataPropertyName = "Sale2Qty";
            this.Sale2Qty.HeaderText = "Sale2Qty";
            this.Sale2Qty.Name = "Sale2Qty";
            this.Sale2Qty.Width = 80;
            // 
            // Buy5Price
            // 
            this.Buy5Price.DataPropertyName = "Buy5Price";
            this.Buy5Price.HeaderText = "Buy5Price";
            this.Buy5Price.Name = "Buy5Price";
            this.Buy5Price.Width = 80;
            // 
            // Buy5Qty
            // 
            this.Buy5Qty.DataPropertyName = "Buy5Qty";
            this.Buy5Qty.HeaderText = "Buy5Qty";
            this.Buy5Qty.Name = "Buy5Qty";
            this.Buy5Qty.Width = 80;
            // 
            // Sale5Price
            // 
            this.Sale5Price.DataPropertyName = "Sale5Price";
            this.Sale5Price.HeaderText = "Sale5Price";
            this.Sale5Price.Name = "Sale5Price";
            this.Sale5Price.Width = 80;
            // 
            // Sale5Qty
            // 
            this.Sale5Qty.DataPropertyName = "Sale5Qty";
            this.Sale5Qty.HeaderText = "Sale5Qty";
            this.Sale5Qty.Name = "Sale5Qty";
            this.Sale5Qty.Width = 80;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 80;
            // 
            // TotalQty
            // 
            this.TotalQty.DataPropertyName = "TotalQty";
            this.TotalQty.HeaderText = "TotalQty";
            this.TotalQty.Name = "TotalQty";
            this.TotalQty.Width = 80;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.Width = 80;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1361, 796);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "数据分析";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HisDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView HisDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker stopDtPick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDtPick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CodeCombox;
        private System.Windows.Forms.Button DataQueryBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy1Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy1Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale1Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale1Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy2Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy2Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale2Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale2Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy5Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy5Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale5Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale5Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.Button ForumBtn;
        private Fhzy.WinForm.Pager.Pager queryDataPager;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}