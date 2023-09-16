using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibrarySystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string sex = rb_man.Checked == true ? "1" : "0";
            string age = nud_age.Value.ToString();
            string telephone = txt_tel.Text.Trim();
            string type = cbb_type.SelectedValue.ToString();//txt_type.Text.Trim();
            DateTime datetime = DateTime.Now;
            string time = datetime.ToString();//用短横线"-"隔开
            string reg = @"[1-9][0-9]{10}";
            Regex r = new Regex(reg);
            if (name == "")
            {//用户名不能为空
                lb_sta.Text = "用户名不能为空";
                lb_sta.ForeColor= Color.Red;
                txt_name.Focus();
            }
            else if (telephone == "")
            {//联系电话不能为空
                lb_sta.Text = "联系电话不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_tel.Focus();
            }//表中一些其他信息初始默认为空或0
            else if (!r.IsMatch(telephone))
            {
                lb_sta.Text = "联系电话格式错误";
                lb_sta.ForeColor = Color.Red;
                txt_tel.Focus();
            }
            else if (lb_statue.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("insert into Reader_info values" +
                    "(null,'{0}',{1},{2},0,0,'{3}',0,null,null,'{4}',{5})", name, age, sex, telephone, time, type);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，读者信息添加成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，读者信息添加失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update Reader_Info set Rname='{0}'," +
                    "age={1},sex={2},telephone='{3}',Time='{4}',Typeid={5} where Rid={6}",name,age,sex,telephone,time,type,Ridt);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，读者信息修改成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，读者信息修改失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTexBox()
        {
            txt_name.Text = "";
            txt_tel.Text = "";
            //txt_type.Text = "";
            rb_man.Checked = true;
            nud_age.Value = 0;
            lb_statue.Text = "添加";
        }

        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = string.Format("select * from Reader_Info") ;
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_reader.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["Rid"].ToString());
                myitem.SubItems.Add(dr["Rname"].ToString());
                myitem.SubItems.Add(dr["age"].ToString());
                myitem.SubItems.Add(dr["sex"].ToString());
                myitem.SubItems.Add(dr["borrownum"].ToString());
                myitem.SubItems.Add(dr["againstTime"].ToString());
                myitem.SubItems.Add(dr["telephone"].ToString());
                myitem.SubItems.Add(dr["isLost"].ToString());
                myitem.SubItems.Add(dr["Typeid"].ToString());
                myitem.SubItems.Add(dr["Time"].ToString());
                myitem.SubItems.Add(dr["LastTime"].ToString());
                myitem.SubItems.Add(dr["text"].ToString());
                lv_reader.Items.Add(myitem);
            }
        }
        protected void DataBind_Type()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = string.Format("select * from Readertype_Info");
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            cbb_type.DataSource = dt;
            cbb_type.DisplayMember = "Tname";
            cbb_type.ValueMember = "Typeid";
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            rb_man.Checked = true;
            tssl_username.Text = Form2.userName;
            DataBind_Customer();
            DataBind_Type();
        }
        string Ridt = "";
        private void lv_reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_reader.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_reader.SelectedItems[0];
                Ridt = myitem.SubItems[0].Text;
                txt_name.Text = myitem.SubItems[1].Text;
                nud_age.Text = myitem.SubItems[2].Text;
                rb_man.Checked = myitem.SubItems[3].Text=="1"?true:false;
                rb_woman.Checked = myitem.SubItems[3].Text == "0" ? true:false;
                txt_tel.Text = myitem.SubItems[6].Text;
                cbb_type.SelectedValue = myitem.SubItems[8].Text;
                lb_statue.Text = "修改";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (Ridt == "")
            {
                MessageBox.Show("请先选中要删除的信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的读者信息？", "删除提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from Reader_Info where Rid={0}", Ridt);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lb_sta.Text = "恭喜您，读者信息删除成功！";
                        lb_sta.ForeColor = Color.Blue;
                        ClearTexBox();
                        DataBind_Customer();
                    }
                    else
                    {
                        lb_sta.Text = "对不起，读者信息删除失败";
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

        private void btn_select_Click(object sender, EventArgs e)
        {
            ClearTexBox();
            string userid= txt_bx1.Text.Trim();
            txt_bx1.Text = "";
            if (userid == "")
            {
                lb_sta.Text = "请输入查询条件";
                lb_sta.ForeColor = Color.Red;
                txt_bx1.Focus();
                return;
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = String.Format("select * from reader_Info where Rid={0}", userid);
                MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    txt_name.Text = dr["Rname"].ToString();
                    txt_tel.Text = dr["telephone"].ToString();
                    if(dr["sex"].ToString()=="1")rb_man.Checked = true;
                    else rb_woman.Checked = true;
                    nud_age.Value = Convert.ToInt32(dr["age"].ToString());
                }
                if (txt_name.Text == "")
                {
                    lb_sta.Text = "请输入存在的用户借阅号";
                    lb_sta.ForeColor = Color.Red;
                    txt_bx1.Focus();
                    return;
                }
                else
                {
                    Ridt = userid;
                    lb_statue.Text = "修改";
                }
            }
        }
    }
}
