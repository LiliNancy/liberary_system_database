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
        {//��½���棬����Ա��¼
            string uname = txt_username.Text.Trim();
            string usec = txt_usersecret.Text.Trim();
            Form2.userName = uname;
            if (uname == "")//��������Ϊ��
            {
                lb_ts.Text = "�������û�����";
                lb_ts.ForeColor = Color.Red;
                txt_username.Focus();
            }
            else if (usec == "")//���벻��Ϊ��
            {
                lb_ts.Text = "���������룡";
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
                    lb_ts.Text = "�Բ����û������������";
                    lb_ts.ForeColor = Color.Red;
                    txt_usersecret.Focus();

                }
            }
        }

         

         
    }
}