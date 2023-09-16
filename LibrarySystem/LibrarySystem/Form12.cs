using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using MySqlConnector;

namespace LibrarySystem
{
    public partial class Form12 : Form
    {
        public Form12()
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
            string money = txt_money.Text;
            string book=txt_book.Text;
            string rid=txt_rid.Text;
            string cid= Form2.uid;
            DateTime datetime = DateTime.Now;
            string time = datetime.ToString();
            string kk = rb_is.Checked == true ? "超期" : "损毁";
            if (money == "")
            {
                lb_sta.Text = "罚款金额不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_money.Focus();
            }
            else if (book == "")
            {
                lb_sta.Text = "损毁/超期书籍编号不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_book.Focus();
            }
            else if (rid == "")
            {
                lb_sta.Text = "用户借阅编号不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_rid.Focus();
            }
            else if (lb_statue.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                int ta = 0;
                string stt = string.Format("select * from reader_info where Rid={0}", rid);
                MySqlDataAdapter da = new MySqlDataAdapter(stt, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ta = Convert.ToInt32(dr["againstTime"].ToString());
                }
                MySqlTransaction myt = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = myt;
                try
                {
                    string str = "";
                    if (kk == "损毁")
                    {
                        str = string.Format("update book_info set statue='丢失损坏' where bid={0}", book);
                        cmd.CommandText = str;
                        cmd.ExecuteNonQuery();
                    }
                    str = string.Format("update reader_info set againstTime={0} where Rid={1}",ta+1, rid);
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    str = string.Format("insert into fine_info values(null,{0},'{1}',{2},{3},{4},'{5}')",money,time,book,rid,cid,kk);
                    cmd.CommandText = str;
                    int i=cmd.ExecuteNonQuery();
                    lb_sta.Text = "恭喜您，罚款信息添加成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    myt.Commit();
                    conn.Close();
                }
                catch
                {
                    lb_sta.Text = "对不起，罚款信息添加失败";
                    lb_sta.ForeColor = Color.Red;
                    myt.Rollback();
                    conn.Close();
                }
                DataBind_Customer();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                if(kk== "损毁")
                {
                    string stt = string.Format("update book_info set statue='丢失损坏' where bid={0}", book);
                    MySqlCommand cmmd = new MySqlCommand(stt, conn);
                    int j = cmmd.ExecuteNonQuery();
                }
                else
                {
                    string stt = string.Format("update book_info set statue='在馆' where bid={0}", book);
                    MySqlCommand cmmd = new MySqlCommand(stt, conn);
                    int j = cmmd.ExecuteNonQuery();
                }
                string str = string.Format("update fine_info set money={0},kind='{1}' where fineid={2}",money,kk, fineid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，罚款信息修改成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，罚款信息修改失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTexBox()
        {
            txt_money.Text = "";
            txt_rid.Text = "";
            txt_book.Text = "";
            txt_book.ReadOnly = false;
            txt_rid.ReadOnly = false;
            rb_is.Checked = true;
            lb_statue.Text = "添加";
        }
        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from fine_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_reader.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["fineid"].ToString());
                myitem.SubItems.Add(dr["Money"].ToString());
                myitem.SubItems.Add(dr["FineTime"].ToString());
                myitem.SubItems.Add(dr["bid"].ToString());
                myitem.SubItems.Add(dr["Rid"].ToString());
                myitem.SubItems.Add(dr["Cid"].ToString());
                myitem.SubItems.Add(dr["kind"].ToString());
                lv_reader.Items.Add(myitem);
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            tssl_username.Text = Form2.userName;
            DataBind_Customer();
            rb_is.Checked = true;
        }
        string fineid = "";
        private void lv_reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_reader.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_reader.SelectedItems[0];
                fineid = myitem.SubItems[0].Text;
                txt_money.Text = myitem.SubItems[1].Text;
                txt_book.Text = myitem.SubItems[3].Text;
                txt_rid.Text = myitem.SubItems[4].Text;
                if (myitem.SubItems[6].Text == "超期") rb_is.Checked = true;
                else rb_not.Checked = true;
                txt_book.ReadOnly = true;
                txt_rid.ReadOnly = true;
                lb_statue.Text = "修改";
            }
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            ClearTexBox();
            lb_sta.Text = "";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (fineid == "")
            {
                MessageBox.Show("请先选中要删除的信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的归还信息？", "删除提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from fine_Info where fineid={0}", fineid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lb_sta.Text = "恭喜您，罚款信息删除成功！";
                        lb_sta.ForeColor = Color.Blue;
                        ClearTexBox();
                        DataBind_Customer();
                    }
                    else
                    {
                        lb_sta.Text = "对不起，罚款信息删除失败";
                        lb_sta.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
