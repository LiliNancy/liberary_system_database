namespace LibrarySystem
{
    partial class Form10
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
            this.btn_del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_reader = new System.Windows.Forms.ListView();
            this.Backid = new System.Windows.Forms.ColumnHeader();
            this.backTime = new System.Windows.Forms.ColumnHeader();
            this.bid = new System.Windows.Forms.ColumnHeader();
            this.Rid = new System.Windows.Forms.ColumnHeader();
            this.Cid = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rid = new System.Windows.Forms.TextBox();
            this.btn_can = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_statue = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_username = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_sta
            // 
            this.lb_sta.AutoSize = true;
            this.lb_sta.Location = new System.Drawing.Point(311, 214);
            this.lb_sta.Name = "lb_sta";
            this.lb_sta.Size = new System.Drawing.Size(15, 24);
            this.lb_sta.TabIndex = 16;
            this.lb_sta.Text = " ";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(41, 575);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(112, 34);
            this.btn_del.TabIndex = 12;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_reader);
            this.groupBox2.Location = new System.Drawing.Point(41, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 316);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书归还信息列表";
            // 
            // lv_reader
            // 
            this.lv_reader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Backid,
            this.backTime,
            this.bid,
            this.Rid,
            this.Cid});
            this.lv_reader.FullRowSelect = true;
            this.lv_reader.GridLines = true;
            this.lv_reader.Location = new System.Drawing.Point(19, 29);
            this.lv_reader.MultiSelect = false;
            this.lv_reader.Name = "lv_reader";
            this.lv_reader.Size = new System.Drawing.Size(683, 256);
            this.lv_reader.TabIndex = 0;
            this.lv_reader.UseCompatibleStateImageBehavior = false;
            this.lv_reader.View = System.Windows.Forms.View.Details;
            this.lv_reader.SelectedIndexChanged += new System.EventHandler(this.lv_reader_SelectedIndexChanged);
            // 
            // Backid
            // 
            this.Backid.Text = "归还编号";
            this.Backid.Width = 120;
            // 
            // backTime
            // 
            this.backTime.Text = "归还时间";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_rid);
            this.groupBox1.Controls.Add(this.btn_can);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_statue);
            this.groupBox1.Location = new System.Drawing.Point(41, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 180);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑归还信息  状态：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "用户借阅号";
            // 
            // txt_rid
            // 
            this.txt_rid.Location = new System.Drawing.Point(468, 50);
            this.txt_rid.Name = "txt_rid";
            this.txt_rid.Size = new System.Drawing.Size(184, 30);
            this.txt_rid.TabIndex = 16;
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(342, 127);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(112, 34);
            this.btn_can.TabIndex = 15;
            this.btn_can.Text = "取消";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(197, 127);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 34);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(125, 50);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(184, 30);
            this.txt_name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "图书编号";
            // 
            // lb_statue
            // 
            this.lb_statue.AutoSize = true;
            this.lb_statue.Location = new System.Drawing.Point(180, 0);
            this.lb_statue.Name = "lb_statue";
            this.lb_statue.Size = new System.Drawing.Size(46, 24);
            this.lb_statue.TabIndex = 0;
            this.lb_statue.Text = "添加";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(647, 575);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(112, 34);
            this.btn_return.TabIndex = 13;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 636);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 31);
            this.statusStrip1.TabIndex = 17;
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
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lb_sta);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_return);
            this.Name = "Form10";
            this.Text = "图书归还";
            this.Load += new System.EventHandler(this.Form10_Load);
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
        private Button btn_del;
        private GroupBox groupBox2;
        private ListView lv_reader;
        private ColumnHeader Backid;
        private ColumnHeader backTime;
        private ColumnHeader ISBN;
        private ColumnHeader bid;
        private ColumnHeader Rid;
        private ColumnHeader Cid;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txt_rid;
        private Button btn_can;
        private Button btn_save;
        private TextBox txt_name;
        private Label label1;
        private Label lb_statue;
        private Button btn_return;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tssl_username;
    }
}