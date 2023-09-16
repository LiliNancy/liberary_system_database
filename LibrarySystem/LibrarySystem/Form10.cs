using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace LibrarySystem
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {//返回功能选择界面
            this.Close();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string cid = Form2.uid;//txt_tel.Text.Trim();
            DateTime datetime = DateTime.Now;
            string time = datetime.ToString();
            string rid = txt_rid.Text.Trim();
            if (name == "")
            {//图书编号不能为空
                lb_sta.Text = "图书编号不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_name.Focus();
            }
            else if (rid == "")
            {//用户借阅号不能为空
                lb_sta.Text = "用户借阅号不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_rid.Focus();
            }
            else if (lb_statue.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string stt = string.Format("select * from reader_info where Rid={0}",rid);
                string oin = "", owner = "";
                int tt = 0;
                MySqlDataAdapter da = new MySqlDataAdapter(stt, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tt = Convert.ToInt32(dr["borrowNum"].ToString());
                }

                stt = string.Format("select * from book_info where bid='{0}'", name);
                da = new MySqlDataAdapter(stt, conn);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    oin = dr["statue"].ToString();
                    owner = dr["Rid"].ToString();
                }
                if (oin != "借出")
                {//不是借出状态的书无法归还
                    lb_sta.Text = "对不起，该图书无法归还";
                    lb_sta.ForeColor = Color.Red;
                    conn.Close();
                    return;
                }
                else if (rid != owner)
                {
                    lb_sta.Text = "对不起，您不是本书的借阅者";
                    lb_sta.ForeColor = Color.Red;
                    conn.Close();
                    return;
                }

                MySqlTransaction myt = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = myt;
                try
                {
                    string str = string.Format("update book_info set statue='在馆',Rid=null where bid={0}", name);
                    cmd.CommandText=str;
                    cmd.ExecuteNonQuery();
                    str = string.Format("update reader_info set borrowNum={0} where Rid={1}", tt - 1, rid);
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    str = string.Format("insert into bookback_info values(null,'{0}',{1},{2},{3})", time,name,rid,cid);
                    cmd.CommandText = str;
                    int i = cmd.ExecuteNonQuery();
                    lb_sta.Text = "恭喜您，归还信息添加成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    myt.Commit();
                    conn.Close();
                }
                catch
                {
                    lb_sta.Text = "对不起，归还信息添加失败";
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
                string str = string.Format("update bookback_info set bid={0},Rid={1},Cid={2} where backid={3}", name, rid, cid,backid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，归还信息修改成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，归还信息修改失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTexBox()
        {
            txt_name.Text = "";
            txt_rid.Text = "";
            txt_name.ReadOnly = false;
            txt_rid.ReadOnly = false;
            lb_statue.Text = "添加";
        }
        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from bookback_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_reader.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["backid"].ToString());
                myitem.SubItems.Add(dr["backTime"].ToString());
                myitem.SubItems.Add(dr["bid"].ToString());
                myitem.SubItems.Add(dr["Rid"].ToString());
                myitem.SubItems.Add(dr["Cid"].ToString());
                lv_reader.Items.Add(myitem);
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            tssl_username.Text = Form2.userName;
            DataBind_Customer();
        }

        string backid = "";
        private void lv_reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_reader.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_reader.SelectedItems[0];
                backid = myitem.SubItems[0].Text;
                txt_name.Text = myitem.SubItems[3].Text;
                txt_rid.Text = myitem.SubItems[4].Text;
                txt_name.ReadOnly = true;
                txt_rid.ReadOnly = true;
                lb_statue.Text = "修改";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (backid == "")
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
                    string str = string.Format("delete from backbook_Info where backid={0}", backid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lb_sta.Text = "恭喜您，归还信息删除成功！";
                        lb_sta.ForeColor = Color.Blue;
                        ClearTexBox();
                        DataBind_Customer();
                    }
                    else
                    {
                        lb_sta.Text = "对不起，归还信息删除失败";
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
