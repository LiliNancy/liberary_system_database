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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace LibrarySystem
{
    public partial class Form8 : Form
    {
        public Form8()
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
            string telephone = txt_tel.Text.Trim();
            string type = txt_type.Text.Trim();
            string id = txt_time.Text.Trim();
            string address = txt_address.Text.Trim();
            string reg = @"[1-9][0-9]{10}";
            Regex r = new Regex(reg); 
            if (name == "")
            {//除了姓名，其他信息都不强制
                lb_sta.Text = "作者名不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_name.Focus();
            }
            else if (id == "")
            {
                lb_sta.Text = "身份证号不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_time.Focus();
            }
            else if (telephone != "" && !r.IsMatch(telephone))
            {
                lb_sta.Text = "联系电话格式错误";
                lb_sta.ForeColor = Color.Red;
                txt_tel.Focus();
            }
            else if(lb_statue.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("insert into writer_info values(null,'{0}','{1}','{2}','{3}','{4}')", name, telephone, address, type, id);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，作者信息添加成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，作者信息添加失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update writer_Info set wname='{0}'," +
                    "wtelephone='{1}',waddress='{2}',idType='{3}',idNum='{4}' where wid={5}", name,telephone,address,type,id,wid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，作者信息修改成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，作者信息修改失败";
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
            txt_address.Text = "";
            lb_statue.Text = "添加";
        }
        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from writer_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_reader.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["wid"].ToString());
                myitem.SubItems.Add(dr["wname"].ToString());
                myitem.SubItems.Add(dr["wtelephone"].ToString());
                myitem.SubItems.Add(dr["waddress"].ToString());
                myitem.SubItems.Add(dr["idType"].ToString());
                myitem.SubItems.Add(dr["idNum"].ToString());
                lv_reader.Items.Add(myitem);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            tssl_username.Text = Form2.userName;
            DataBind_Customer();
        }

        string wid = "";
        private void lv_reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_reader.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_reader.SelectedItems[0];
                wid = myitem.SubItems[0].Text;
                txt_name.Text = myitem.SubItems[1].Text;
                txt_tel.Text = myitem.SubItems[2].Text;
                txt_address.Text = myitem.SubItems[3].Text;
                txt_type.Text = myitem.SubItems[4].Text;
                txt_time.Text = myitem.SubItems[5].Text;
                lb_statue.Text = "修改";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (wid == "")
            {
                MessageBox.Show("请先选中要删除的信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的作者信息？", "删除提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from writer_Info where wid={0}", wid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lb_sta.Text = "恭喜您，作者信息删除成功！";
                        lb_sta.ForeColor = Color.Blue;
                        ClearTexBox();
                        DataBind_Customer();
                    }
                    else
                    {
                        lb_sta.Text = "对不起，作者信息删除失败";
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
