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
    public partial class Form11 : Form
    {
        public Form11()
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
            string sex = rb_man.Checked == true ? "1" : "0";
            string age = nud_age.Value.ToString();
            string telephone = txt_tel.Text.Trim();
            string type = txt_type.Text.Trim();
            string time = txt_time.Text.ToString();
            string posi = txt_position.Text.Trim();
            string reg = @"[1-9][0-9]{10}";
            Regex r = new Regex(reg);
            if (name == "")
            {//用户名不能为空
                lb_sta.Text = "用户名不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_name.Focus();
            }
            else if (type == "")
            {//密码不能为空
                lb_sta.Text = "密码不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_type.Focus();
            }
            else if (telephone == "")
            {//联系电话不能为空
                lb_sta.Text = "联系电话不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_tel.Focus();
            }//工作职位和时间可以为空
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
                string str = string.Format("insert into controller_info values(null,'{0}',{1},{2},'{3}','{4}','{5}','{6}')" ,
                    name,sex,age,posi,telephone,time,type);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，管理员信息添加成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，管理员信息添加失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
            else if(lb_statue.Text == "修改" && txt_name.ReadOnly==false)
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update controller_Info set Cname='{0}',sex={1},age={2},position='{3}',ctelephone='{4}',worktime='{5}',Password='{6}'" +
                    "where cid={7}", name, sex, age, posi, telephone, time, type,cid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    Form2.userName = name;
                    tssl_username.Text = Form2.userName;
                    lb_sta.Text = "恭喜您，管理员信息修改成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，管理员信息修改失败";
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
            txt_position.Text = "";
            rb_man.Checked = true;
            nud_age.Value = 0;
            lb_statue.Text = "添加";
            txt_name.ReadOnly = false;
            nud_age.ReadOnly = false;
            txt_position.ReadOnly = false;
            txt_tel.ReadOnly = false;
            txt_time.ReadOnly = false;
            txt_type.ReadOnly = false;
        }

        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from controller_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_reader.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["Cid"].ToString());
                myitem.SubItems.Add(dr["Cname"].ToString());
                myitem.SubItems.Add(dr["sex"].ToString());
                myitem.SubItems.Add(dr["age"].ToString());
                myitem.SubItems.Add(dr["position"].ToString());
                myitem.SubItems.Add(dr["ctelephone"].ToString());
                myitem.SubItems.Add(dr["worktime"].ToString());
                myitem.SubItems.Add(dr["Password"].ToString());
                lv_reader.Items.Add(myitem);
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            rb_man.Checked = true;
            tssl_username.Text = Form2.userName;
            DataBind_Customer();
        }

        string cid = "";
        private void lv_reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_reader.SelectedItems.Count > 0)
            {
                txt_name.ReadOnly = false;
                nud_age.ReadOnly = false;
                txt_position.ReadOnly = false;
                txt_tel.ReadOnly = false;
                txt_time.ReadOnly = false;
                txt_type.ReadOnly = false;
                ListViewItem myitem = lv_reader.SelectedItems[0];
                cid = myitem.SubItems[0].Text;
                txt_name.Text = myitem.SubItems[1].Text;
                rb_man.Checked = myitem.SubItems[2].Text == "1" ? true : false;
                rb_woman.Checked = myitem.SubItems[2].Text == "0" ? true : false;
                nud_age.Text = myitem.SubItems[3].Text;
                txt_position.Text = myitem.SubItems[4].Text;
                txt_tel.Text = myitem.SubItems[5].Text;
                txt_time.Text = myitem.SubItems[6].Text;
                txt_type.Text = myitem.SubItems[7].Text;
                lb_statue.Text = "修改";
            }
            if(txt_name.Text!= Form2.userName)
            {
                txt_name.ReadOnly = true;
                nud_age.ReadOnly = true;
                txt_position.ReadOnly = true;
                txt_tel.ReadOnly = true;
                txt_time.ReadOnly = true;
                txt_type.ReadOnly = true;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (cid == "")
            {
                MessageBox.Show("请先选中要删除的信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的管理员信息？", "删除提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from Controller_Info where Cid={0}", cid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lb_sta.Text = "恭喜您，管理员信息删除成功！";
                        lb_sta.ForeColor = Color.Blue;
                        ClearTexBox();
                        DataBind_Customer();
                    }
                    else
                    {
                        lb_sta.Text = "对不起，管理员信息删除失败";
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
