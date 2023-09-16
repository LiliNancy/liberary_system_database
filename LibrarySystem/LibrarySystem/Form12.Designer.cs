namespace LibrarySystem
{
    partial class Form12
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
            this.lb_sta = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_reader = new System.Windows.Forms.ListView();
            this.Fineid = new System.Windows.Forms.ColumnHeader();
            this.Money = new System.Windows.Forms.ColumnHeader();
            this.FineTime = new System.Windows.Forms.ColumnHeader();
            this.bid = new System.Windows.Forms.ColumnHeader();
            this.Rid = new System.Windows.Forms.ColumnHeader();
            this.Cid = new System.Windows.Forms.ColumnHeader();
            this.Kind = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_not = new System.Windows.Forms.RadioButton();
            this.txt_rid = new System.Windows.Forms.TextBox();
            this.rb_is = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_book = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_can = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_statue = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_username = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_del = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_sta
            // 
            this.lb_sta.AutoSize = true;
            this.lb_sta.Location = new System.Drawing.Point(286, 219);
            this.lb_sta.Name = "lb_sta";
            this.lb_sta.Size = new System.Drawing.Size(15, 24);
            this.lb_sta.TabIndex = 25;
            this.lb_sta.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_reader);
            this.groupBox2.Location = new System.Drawing.Point(41, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 316);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "罚款缴纳信息列表";
            // 
            // lv_reader
            // 
            this.lv_reader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Fineid,
            this.Money,
            this.FineTime,
            this.bid,
            this.Rid,
            this.Cid,
            this.Kind});
            this.lv_reader.FullRowSelect = true;
            this.lv_reader.GridLines = true;
            this.lv_reader.Location = new System.Drawing.Point(19, 44);
            this.lv_reader.MultiSelect = false;
            this.lv_reader.Name = "lv_reader";
            this.lv_reader.Size = new System.Drawing.Size(683, 256);
            this.lv_reader.TabIndex = 0;
            this.lv_reader.UseCompatibleStateImageBehavior = false;
            this.lv_reader.View = System.Windows.Forms.View.Details;
            this.lv_reader.SelectedIndexChanged += new System.EventHandler(this.lv_reader_SelectedIndexChanged);
            // 
            // Fineid
            // 
            this.Fineid.Text = "罚款编号";
            this.Fineid.Width = 120;
            // 
            // Money
            // 
            this.Money.Text = "罚款金额";
            this.Money.Width = 100;
            // 
            // FineTime
            // 
            this.FineTime.Text = "罚款缴纳时间";
            this.FineTime.Width = 150;
            // 
            // bid
            // 
            this.bid.Text = "图书编号";
            this.bid.Width = 120;
            // 
            // Rid
            // 
            this.Rid.Text = "用户借阅编号";
            this.Rid.Width = 120;
            // 
            // Cid
            // 
            this.Cid.Text = "管理员工号";
            this.Cid.Width = 120;
            // 
            // Kind
            // 
            this.Kind.Text = "类型";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_not);
            this.groupBox1.Controls.Add(this.txt_rid);
            this.groupBox1.Controls.Add(this.rb_is);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_book);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_can);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.txt_money);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_statue);
            this.groupBox1.Location = new System.Drawing.Point(41, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 192);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑罚款缴纳信息  状态：";
            // 
            // rb_not
            // 
            this.rb_not.AutoSize = true;
            this.rb_not.Location = new System.Drawing.Point(608, 97);
            this.rb_not.Name = "rb_not";
            this.rb_not.Size = new System.Drawing.Size(71, 28);
            this.rb_not.TabIndex = 29;
            this.rb_not.TabStop = true;
            this.rb_not.Text = "损毁";
            this.rb_not.UseVisualStyleBackColor = true;
            // 
            // txt_rid
            // 
            this.txt_rid.Location = new System.Drawing.Point(143, 93);
            this.txt_rid.Name = "txt_rid";
            this.txt_rid.Size = new System.Drawing.Size(184, 30);
            this.txt_rid.TabIndex = 19;
            // 
            // rb_is
            // 
            this.rb_is.AutoSize = true;
            this.rb_is.Location = new System.Drawing.Point(477, 97);
            this.rb_is.Name = "rb_is";
            this.rb_is.Size = new System.Drawing.Size(71, 28);
            this.rb_is.TabIndex = 28;
            this.rb_is.TabStop = true;
            this.rb_is.Text = "超期";
            this.rb_is.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "用户借阅编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "违规类型";
            // 
            // txt_book
            // 
            this.txt_book.Location = new System.Drawing.Point(477, 46);
            this.txt_book.Name = "txt_book";
            this.txt_book.Size = new System.Drawing.Size(184, 30);
            this.txt_book.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "图书编号";
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(371, 145);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(112, 34);
            this.btn_can.TabIndex = 15;
            this.btn_can.Text = "取消";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(197, 145);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 34);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_money
            // 
            this.txt_money.Location = new System.Drawing.Point(143, 46);
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(184, 30);
            this.txt_money.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "罚款金额";
            // 
            // lb_statue
            // 
            this.lb_statue.AutoSize = true;
            this.lb_statue.Location = new System.Drawing.Point(214, 0);
            this.lb_statue.Name = "lb_statue";
            this.lb_statue.Size = new System.Drawing.Size(46, 24);
            this.lb_statue.TabIndex = 0;
            this.lb_statue.Text = "添加";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(647, 588);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(112, 34);
            this.btn_return.TabIndex = 22;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_username});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 31);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 24);
            this.toolStripStatusLabel1.Text = "用户：";
            // 
            // tssl_username
            // 
            this.tssl_username.Name = "tssl_username";
            this.tssl_username.Size = new System.Drawing.Size(15, 24);
            this.tssl_username.Text = " ";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(41, 588);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(112, 34);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lb_sta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_return);
            this.Name = "Form12";
            this.Text = "罚款缴纳";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_sta;
        private GroupBox groupBox2;
        private ListView lv_reader;
        private ColumnHeader Fineid;
        private ColumnHeader Money;
        private ColumnHeader FineTime;
        private ColumnHeader bid;
        private ColumnHeader Rid;
        private ColumnHeader Cid;
        private GroupBox groupBox1;
        private Button btn_can;
        private Button btn_save;
        private TextBox txt_money;
        private Label label1;
        private Label lb_statue;
        private Button btn_return;
        private TextBox txt_book;
        private Label label2;
        private TextBox txt_rid;
        private Label label3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tssl_username;
        private ColumnHeader Kind;
        private Button btn_del;
        private RadioButton rb_not;
        private RadioButton rb_is;
        private Label label4;
    }
}