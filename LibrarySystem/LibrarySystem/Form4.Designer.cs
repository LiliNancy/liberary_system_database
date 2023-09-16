namespace LibrarySystem
{
    partial class Form4
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
            this.Pid = new System.Windows.Forms.ColumnHeader();
            this.Pname = new System.Windows.Forms.ColumnHeader();
            this.controller = new System.Windows.Forms.ColumnHeader();
            this.Ptelephone = new System.Windows.Forms.ColumnHeader();
            this.Paddress = new System.Windows.Forms.ColumnHeader();
            this.fax = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_can = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lb_sta.Location = new System.Drawing.Point(288, 245);
            this.lb_sta.Name = "lb_sta";
            this.lb_sta.Size = new System.Drawing.Size(15, 24);
            this.lb_sta.TabIndex = 11;
            this.lb_sta.Text = " ";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(36, 582);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(112, 34);
            this.btn_del.TabIndex = 7;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_reader);
            this.groupBox2.Location = new System.Drawing.Point(36, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 316);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出版社信息列表";
            // 
            // lv_reader
            // 
            this.lv_reader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pid,
            this.Pname,
            this.controller,
            this.Ptelephone,
            this.Paddress,
            this.fax});
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
            // Pid
            // 
            this.Pid.Text = "出版社编号";
            this.Pid.Width = 120;
            // 
            // Pname
            // 
            this.Pname.Text = "出版社名";
            this.Pname.Width = 100;
            // 
            // controller
            // 
            this.controller.Text = "负责人";
            this.controller.Width = 120;
            // 
            // Ptelephone
            // 
            this.Ptelephone.Text = "联系电话";
            this.Ptelephone.Width = 120;
            // 
            // Paddress
            // 
            this.Paddress.Text = "地址";
            this.Paddress.Width = 100;
            // 
            // fax
            // 
            this.fax.Text = "传真";
            this.fax.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.btn_can);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.txt_fax);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.txt_type);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_statue);
            this.groupBox1.Location = new System.Drawing.Point(36, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 215);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑出版社信息  状态：";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(434, 81);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(184, 30);
            this.txt_address.TabIndex = 16;
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(342, 175);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(112, 34);
            this.btn_can.TabIndex = 15;
            this.btn_can.Text = "取消";
            this.btn_can.UseVisualStyleBackColor = true;
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
            // txt_fax
            // 
            this.txt_fax.Location = new System.Drawing.Point(110, 133);
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(184, 30);
            this.txt_fax.TabIndex = 10;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(110, 81);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(184, 30);
            this.txt_tel.TabIndex = 9;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(434, 33);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(180, 30);
            this.txt_type.TabIndex = 8;
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
            this.label6.Location = new System.Drawing.Point(342, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "传真";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
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
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "负责人";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "出版社名";
            // 
            // lb_statue
            // 
            this.lb_statue.AutoSize = true;
            this.lb_statue.Location = new System.Drawing.Point(200, 0);
            this.lb_statue.Name = "lb_statue";
            this.lb_statue.Size = new System.Drawing.Size(46, 24);
            this.lb_statue.TabIndex = 0;
            this.lb_statue.Text = "添加";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(642, 582);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(112, 34);
            this.btn_return.TabIndex = 8;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 31);
            this.statusStrip1.TabIndex = 12;
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lb_sta);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_return);
            this.Name = "Form4";
            this.Text = "出版社信息管理";
            this.Load += new System.EventHandler(this.Form4_Load);
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
        private ColumnHeader Pid;
        private ColumnHeader Pname;
        private ColumnHeader controller;
        private ColumnHeader Ptelephone;
        private ColumnHeader Paddress;
        private ColumnHeader fax;
        private GroupBox groupBox1;
        private Button btn_can;
        private Button btn_save;
        private TextBox txt_fax;
        private TextBox txt_tel;
        private TextBox txt_type;
        private TextBox txt_name;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lb_statue;
        private Button btn_return;
        private TextBox txt_address;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tssl_username;
    }
}