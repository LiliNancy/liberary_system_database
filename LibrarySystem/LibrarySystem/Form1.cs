using System.Data;
using MySqlConnector;
namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//登陆界面，管理员登录
            string uname = txt_username.Text.Trim();
            string usec = txt_usersecret.Text.Trim();
            Form2.userName = uname;
            if (uname == "")//姓名不能为空
            {
                lb_ts.Text = "请输入用户名！";
                lb_ts.ForeColor = Color.Red;
                txt_username.Focus();
            }
            else if (usec == "")//密码不能为空
            {
                lb_ts.Text = "请输入密码！";
                lb_ts.ForeColor = Color.Red;
                txt_usersecret.Focus();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("select * from controller_info where Cname = '{0}' and Password = '{1}'", uname, usec);
                MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                conn.Close();
                if(dt.Rows.Count > 0)
                {
                    Form2.uid = dt.Rows[0]["Cid"].ToString();
                    this.Hide();
                    Form2 frm = new Form2();
                    frm.Show();
                }
                else
                {
                    lb_ts.Text = "对不起，用户名或密码错误！";
                    lb_ts.ForeColor = Color.Red;
                    txt_usersecret.Focus();

                }
            }
        }

         

         
    }
}