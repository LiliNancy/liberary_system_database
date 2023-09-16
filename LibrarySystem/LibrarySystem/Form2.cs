using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form2 : Form
    {
        public static string userName="";
        public static string uid = "";
        public Form2()
        {
            InitializeComponent();
        }
        //功能选择界面，可以在此进行功能选择
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 frm = new Form7();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 frm = new Form5();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 frm = new Form6();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 frm = new Form4();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 frm = new Form8();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 frm = new Form9();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 frm = new Form10();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 frm = new Form11();
            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tssl_username.Text = userName;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Form12 frm = new Form12();
            frm.Show();
        }
    }
}
