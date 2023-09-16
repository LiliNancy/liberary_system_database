namespace LibrarySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_log = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lb_uname = new System.Windows.Forms.Label();
            this.lb_usec = new System.Windows.Forms.Label();
            this.txt_usersecret = new System.Windows.Forms.TextBox();
            this.lb_ts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(307, 320);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(112, 34);
            this.btn_log.TabIndex = 0;
            this.btn_log.Text = "登录";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(307, 136);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(277, 30);
            this.txt_username.TabIndex = 1;
            // 
            // lb_uname
            // 
            this.lb_uname.AutoSize = true;
            this.lb_uname.Location = new System.Drawing.Point(158, 139);
            this.lb_uname.Name = "lb_uname";
            this.lb_uname.Size = new System.Drawing.Size(64, 24);
            this.lb_uname.TabIndex = 2;
            this.lb_uname.Text = "用户名";
            // 
            // lb_usec
            // 
            this.lb_usec.AutoSize = true;
            this.lb_usec.Location = new System.Drawing.Point(158, 210);
            this.lb_usec.Name = "lb_usec";
            this.lb_usec.Size = new System.Drawing.Size(46, 24);
            this.lb_usec.TabIndex = 3;
            this.lb_usec.Text = "密码";
            // 
            // txt_usersecret
            // 
            this.txt_usersecret.Location = new System.Drawing.Point(307, 207);
            this.txt_usersecret.Name = "txt_usersecret";
            this.txt_usersecret.PasswordChar = '*';
            this.txt_usersecret.Size = new System.Drawing.Size(277, 30);
            this.txt_usersecret.TabIndex = 4;
            // 
            // lb_ts
            // 
            this.lb_ts.AutoSize = true;
            this.lb_ts.Location = new System.Drawing.Point(356, 284);
            this.lb_ts.Name = "lb_ts";
            this.lb_ts.Size = new System.Drawing.Size(15, 24);
            this.lb_ts.TabIndex = 5;
            this.lb_ts.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_ts);
            this.Controls.Add(this.txt_usersecret);
            this.Controls.Add(this.lb_usec);
            this.Controls.Add(this.lb_uname);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_log);
            this.Name = "Form1";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_log;
        private TextBox txt_username;
        private Label lb_uname;
        private Label lb_usec;
        private TextBox txt_usersecret;
        private Label lb_ts;
    }
}