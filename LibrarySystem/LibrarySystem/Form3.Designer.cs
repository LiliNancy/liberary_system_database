namespace LibrarySystem
{
    partial class Form3
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
            this.btn_return = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.btn_can = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.nud_age = new System.Windows.Forms.NumericUpDown();
            this.rb_woman = new System.Windows.Forms.RadioButton();
            this.rb_man = new System.Windows.Forms.RadioButton();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_statue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_reader = new System.Windows.Forms.ListView();
            this.Rid = new System.Windows.Forms.ColumnHeader();
            this.Rname = new System.Windows.Forms.ColumnHeader();
            this.age = new System.Windows.Forms.ColumnHeader();
            this.sex = new System.Windows.Forms.ColumnHeader();
            this.borrownum = new System.Windows.Forms.ColumnHeader();
            this.againstTime = new System.Windows.Forms.ColumnHeader();
            this.teleohone = new System.Windows.Forms.ColumnHeader();
            this.isLost = new System.Windows.Forms.ColumnHeader();
            this.Typeid = new System.Windows.Forms.ColumnHeader();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.LastTime = new System.Windows.Forms.ColumnHeader();
            this.text = new System.Windows.Forms.ColumnHeader();
            this.btn_del = new System.Windows.Forms.Button();
            this.lb_sta = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_username = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_bx1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_age)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(647, 647);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(112, 34);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_type);
            this.groupBox1.Controls.Add(this.btn_can);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.nud_age);
            this.groupBox1.Controls.Add(this.rb_woman);
            this.groupBox1.Controls.Add(this.rb_man);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_statue);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑读者信息  状态：";
            // 
            // cbb_type
            // 
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.Location = new System.Drawing.Point(434, 30);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(182, 32);
            this.cbb_type.TabIndex = 16;
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(342, 175);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(112, 34);
            this.btn_can.TabIndex = 15;
            this.btn_can.Text = "取消";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(182, 175);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 34);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // nud_age
            // 
            this.nud_age.Location = new System.Drawing.Point(434, 82);
            this.nud_age.Name = "nud_age";
            this.nud_age.Size = new System.Drawing.Size(180, 30);
            this.nud_age.TabIndex = 13;
            // 
            // rb_woman
            // 
            this.rb_woman.AutoSize = true;
            this.rb_woman.Location = new System.Drawing.Point(241, 84);
            this.rb_woman.Name = "rb_woman";
            this.rb_woman.Size = new System.Drawing.Size(53, 28);
            this.rb_woman.TabIndex = 12;
            this.rb_woman.TabStop = true;
            this.rb_woman.Text = "女";
            this.rb_woman.UseVisualStyleBackColor = true;
            // 
            // rb_man
            // 
            this.rb_man.AutoSize = true;
            this.rb_man.Location = new System.Drawing.Point(110, 84);
            this.rb_man.Name = "rb_man";
            this.rb_man.Size = new System.Drawing.Size(53, 28);
            this.rb_man.TabIndex = 11;
            this.rb_man.TabStop = true;
            this.rb_man.Text = "男";
            this.rb_man.UseVisualStyleBackColor = true;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(110, 127);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(184, 30);
            this.txt_tel.TabIndex = 9;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(110, 33);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(184, 30);
            this.txt_name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "联系电话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户类别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_reader);
            this.groupBox2.Location = new System.Drawing.Point(41, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 316);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读者信息列表";
            // 
            // lv_reader
            // 
            this.lv_reader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rid,
            this.Rname,
            this.age,
            this.sex,
            this.borrownum,
            this.againstTime,
            this.teleohone,
            this.isLost,
            this.Typeid,
            this.Time,
            this.LastTime,
            this.text});
            this.lv_reader.FullRowSelect = true;
            this.lv_reader.GridLines = true;
            this.lv_reader.Location = new System.Drawing.Point(19, 41);
            this.lv_reader.MultiSelect = false;
            this.lv_reader.Name = "lv_reader";
            this.lv_reader.Size = new System.Drawing.Size(683, 256);
            this.lv_reader.TabIndex = 0;
            this.lv_reader.UseCompatibleStateImageBehavior = false;
            this.lv_reader.View = System.Windows.Forms.View.Details;
            this.lv_reader.SelectedIndexChanged += new System.EventHandler(this.lv_reader_SelectedIndexChanged);
            // 
            // Rid
            // 
            this.Rid.Text = "用户借阅编号";
            this.Rid.Width = 120;
            // 
            // Rname
            // 
            this.Rname.Text = "用户名";
            this.Rname.Width = 100;
            // 
            // age
            // 
            this.age.Text = "年龄";
            // 
            // sex
            // 
            this.sex.Text = "性别";
            // 
            // borrownum
            // 
            this.borrownum.Text = "已借阅数";
            this.borrownum.Width = 100;
            // 
            // againstTime
            // 
            this.againstTime.Text = "违规次数";
            this.againstTime.Width = 100;
            // 
            // teleohone
            // 
            this.teleohone.Text = "电话号码";
            this.teleohone.Width = 120;
            // 
            // isLost
            // 
            this.isLost.Text = "是/否挂失";
            this.isLost.Width = 120;
            // 
            // Typeid
            // 
            this.Typeid.Text = "用户类型";
            this.Typeid.Width = 120;
            // 
            // Time
            // 
            this.Time.Text = "注册时间";
            this.Time.Width = 120;
            // 
            // LastTime
            // 
            this.LastTime.Text = "有效期截止时间";
            this.LastTime.Width = 120;
            // 
            // text
            // 
            this.text.Text = "备注";
            this.text.Width = 120;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(41, 647);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(112, 34);
            this.btn_del.TabIndex = 0;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // lb_sta
            // 
            this.lb_sta.AutoSize = true;
            this.lb_sta.Location = new System.Drawing.Point(293, 310);
            this.lb_sta.Name = "lb_sta";
            this.lb_sta.Size = new System.Drawing.Size(15, 24);
            this.lb_sta.TabIndex = 6;
            this.lb_sta.Text = " ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_username});
            this.statusStrip1.Location = new System.Drawing.Point(0, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(796, 31);
            this.statusStrip1.TabIndex = 7;
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
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(568, 263);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(112, 34);
            this.btn_select.TabIndex = 8;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_bx1
            // 
            this.txt_bx1.Location = new System.Drawing.Point(184, 265);
            this.txt_bx1.Name = "txt_bx1";
            this.txt_bx1.Size = new System.Drawing.Size(358, 30);
            this.txt_bx1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "用户借阅号";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 724);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_bx1);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lb_sta);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_return);
            this.Name = "Form3";
            this.Text = "读者信息管理";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_age)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_return;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_can;
        private Button btn_save;
        private NumericUpDown nud_age;
        private RadioButton rb_woman;
        private RadioButton rb_man;
        private TextBox txt_tel;
        private TextBox txt_name;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lb_statue;
        private ListView lv_reader;
        private ColumnHeader Rid;
        private ColumnHeader Rname;
        private ColumnHeader age;
        private ColumnHeader sex;
        private ColumnHeader borrownum;
        private ColumnHeader againstTime;
        private ColumnHeader teleohone;
        private ColumnHeader isLost;
        private ColumnHeader Typeid;
        private ColumnHeader Time;
        private ColumnHeader LastTime;
        private ColumnHeader text;
        private Button btn_del;
        private Label lb_sta;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tssl_username;
        private ComboBox cbb_type;
        private Button btn_select;
        private TextBox txt_bx1;
        private Label label7;
    }
}