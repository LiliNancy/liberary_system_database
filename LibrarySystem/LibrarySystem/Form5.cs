using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibrarySystem
{
    public partial class Form5 : Form
    {
        public Form5()
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
            string name = txt_name.Text.Trim();
            string ISBN=txt_type.Text.Trim();
            string wid = cbb_writer.SelectedValue.ToString();//txt_wid.Text.ToString();
            string price = txt_tel.Text.Trim();
            string pid = cbb_press.SelectedValue.ToString();///txt_pid.Text.Trim();
            string kind = txt_kind.Text.Trim();
            string edition=txt_edtion.Text.Trim();
            string time = txt_time.Text.Trim();
            DateTime dtDate;
            if (ISBN == "")
            {
                lb_sta.Text = "ISBN不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_name.Focus();
            }
            else if (name == "")
            {
                lb_sta.Text = "书名不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_type.Focus();
            }
            else if (time == "")
            {
                lb_sta.Text = "出版时间不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_time.Focus();
            }
            else if(!Regex.IsMatch(time, "^(?<year>\\d{2,4})-(?<month>\\d{1,2})-(?<day>\\d{1,2})$"))
            {
                lb_sta.Text = "出版时间格式错误";
                lb_sta.ForeColor = Color.Red;
                txt_time.Focus();
            }
            else if (price == "")
            {
                lb_sta.Text = "价格不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_tel.Focus();
            }
            else if (lb_statue.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("insert into booktype_info values('{0}',{1},'{2}',{3},'{4}','{5}','{6}',{7})",ISBN,wid,name,price,kind,time,edition,pid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，图书类型信息添加成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，图书类型信息添加失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update booktype_info set ISBN='{0}',wid={1},bname='{2}',price={3},kind='{4}'" +
                    ",publishTime='{5}',edition='{6}',pid={7} where ISBN='{8}'", ISBN, wid, name, price, kind, time, edition, pid,ISBNt);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，图书类型信息修改成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，图书类型信息修改失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTexBox()
        {
            txt_name.Text = "";
            txt_tel.Text = "";
            txt_time.Text = "";
            txt_type.Text = "";
            txt_edtion.Text = "";
            txt_kind.Text = "";
            txt_time.Text = "";
            lb_statue.Text = "添加";
        }
        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from booktype_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lv_reader.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["ISBN"].ToString());
                string stt = string.Format("select * from book_info where ISBN='{0}' and statue='在馆'", dr["ISBN"].ToString());
                MySqlDataAdapter dda = new MySqlDataAdapter(stt, conn);
                DataTable dtt = new DataTable();
                dda.Fill(dtt);
                myitem.SubItems.Add(dr["wid"].ToString());
                myitem.SubItems.Add(dr["bname"].ToString());
                myitem.SubItems.Add(dr["price"].ToString());
                myitem.SubItems.Add(dr["kind"].ToString());
                myitem.SubItems.Add(dr["publishTime"].ToString());
                myitem.SubItems.Add(dr["edition"].ToString());
                myitem.SubItems.Add(dr["pid"].ToString());
                myitem.SubItems.Add(dtt.Rows.Count.ToString());
                lv_reader.Items.Add(myitem);
            }
            conn.Close();
        }

        protected void DataBind_Press()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from press_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            cbb_press.DataSource = dt;
            cbb_press.DisplayMember = "pname";
            cbb_press.ValueMember = "pid";
        }
        protected void DataBind_Writer()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from writer_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            cbb_writer.DataSource = dt;
            cbb_writer.DisplayMember = "wname";
            cbb_writer.ValueMember = "wid";
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            tssl_username.Text = Form2.userName;
            DataBind_Customer();
            DataBind_Press();
            DataBind_Writer();
        }
        string ISBNt = "";
        private void lv_reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_reader.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_reader.SelectedItems[0];
                ISBNt = myitem.SubItems[0].Text;
                txt_type.Text = myitem.SubItems[0].Text;
                cbb_writer.SelectedValue = myitem.SubItems[1].Text;
                //txt_wid.Text = myitem.SubItems[1].Text;
                txt_name.Text = myitem.SubItems[2].Text;
                txt_tel.Text = myitem.SubItems[3].Text;
                txt_kind.Text = myitem.SubItems[4].Text;
                txt_time.Text = myitem.SubItems[5].Text;
                txt_edtion.Text = myitem.SubItems[6].Text;
                lb_statue.Text = "修改";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (ISBNt == "")
            {
                MessageBox.Show("请先选中要删除的信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的图书类型信息？", "删除提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from booktype_info where ISBN='{0}'", ISBNt);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lb_sta.Text = "恭喜您，图书类型信息删除成功！";
                        lb_sta.ForeColor = Color.Blue;
                        ClearTexBox();
                        DataBind_Customer();
                    }
                    else
                    {
                        lb_sta.Text = "对不起，图书类型信息删除失败";
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
