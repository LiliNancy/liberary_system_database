using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySqlConnector;

namespace LibrarySystem
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string statue = cbb_type.Text;//txt_tel.Text.Trim();
            string ISBN = txt_type.Text.Trim();
            DateTime datetime = DateTime.Now;
            string time = datetime.ToString();
            if (ISBN == "")
            {
                lb_sta.Text = "ISBN不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_type.Focus();
            }
            else if (lb_statue.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string stt = string.Format("select * from Booktype_info where ISBN='{0}'", ISBN);
                MySqlDataAdapter mda=new MySqlDataAdapter(stt,conn);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                if(dt.Rows.Count <= 0)
                {
                    lb_sta.Text = "ISBN输入错误";
                    lb_sta.ForeColor = Color.Red;
                    txt_type.Focus();
                    conn.Close();
                    return;
                }
                string str = string.Format("insert into Book_info values('{0}',null,'{1}','{2}',null)", ISBN, time, statue);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，图书信息添加成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，图书信息添加失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string stt = string.Format("select * from Booktype_info where ISBN='{0}'", ISBN);
                MySqlDataAdapter mda = new MySqlDataAdapter(stt, conn);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    lb_sta.Text = "ISBN输入错误";
                    lb_sta.ForeColor = Color.Red;
                    txt_type.Focus();
                    conn.Close();
                    return;
                }
                string str = string.Format("update Book_Info set ISBN='{0}',statue='{1}'where bid={2}", ISBN, statue, bid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，图书信息修改成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，图书信息修改失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTexBox()
        {
            txt_type.Text = "";
            lb_statue.Text = "添加";
        }
        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = string.Format("select * from Book_Info");
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_reader.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["Bid"].ToString());
                myitem.SubItems.Add(dr["ISBN"].ToString());
                myitem.SubItems.Add(dr["intime"].ToString());
                myitem.SubItems.Add(dr["statue"].ToString());
                myitem.SubItems.Add(dr["Rid"].ToString());
                lv_reader.Items.Add(myitem);
            }
        }
        protected void DataBind_Type()
        {//图书三种状态
            cbb_type.Items.Add("在馆");
            cbb_type.Items.Add("丢失损坏");
            cbb_type.Items.Add("借出");

        }
        private void Form7_Load(object sender, EventArgs e)
        {
            tssl_username.Text = Form2.userName;
            DataBind_Customer();
            DataBind_Type();
        }
        string bid = "";

        private void lv_reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_reader.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_reader.SelectedItems[0];
                bid = myitem.SubItems[0].Text;
                cbb_type.Text = myitem.SubItems[3].Text;
                txt_type.Text = myitem.SubItems[1].Text;
                lb_statue.Text = "修改";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (bid == "")
            {
                MessageBox.Show("请先选中要删除的信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的图书信息？", "删除提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from Book_Info where bid={0}", bid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lb_sta.Text = "恭喜您，图书信息删除成功！";
                        lb_sta.ForeColor = Color.Blue;
                        ClearTexBox();
                        DataBind_Customer();
                    }
                    else
                    {
                        lb_sta.Text = "对不起，图书信息删除失败";
                        lb_sta.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            ClearTexBox();
            lb_sta.Text = "";
        }
    }
}
