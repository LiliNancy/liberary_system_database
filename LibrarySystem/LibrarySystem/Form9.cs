using System.Data;
using System.Globalization;
using System.Transactions;
using MySqlConnector;

namespace LibrarySystem
{
    public partial class Form9 : Form
    {
        public Form9()
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
            string again = nud_age.Value.ToString();
            string cid = Form2.uid;//txt_tel.Text.Trim();
            DateTime datetime = DateTime.Now;
            string time = datetime.ToString();
            string ltime="";
            string rid = txt_rid.Text.Trim();
            if (name == "")
            {
                lb_sta.Text = "图书编号不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_name.Focus();
            }
            else if (rid == "")
            {
                lb_sta.Text = "用户借阅号不能为空";
                lb_sta.ForeColor = Color.Red;
                txt_rid.Focus();
            }
            else if (lb_statue.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string stt = string.Format("select * from reader_Info where rid={0}", rid);
                MySqlDataAdapter da = new MySqlDataAdapter(stt, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int tt = 0, topp = 0,againstTime=0,longest=0;
                string oin = "";
                foreach (DataRow dr in dt.Rows)
                {
                    //查看违规次数和借阅书数目
                    tt = Convert.ToInt32(dr["borrowNum"].ToString());
                    againstTime= Convert.ToInt32(dr["againstTime"].ToString());
                    stt = string.Format("select * from readertype_Info where Typeid={0}", dr["Typeid"].ToString());
                }
                da = new MySqlDataAdapter(stt, conn);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    topp = Convert.ToInt32(dr["Biggest"].ToString());
                    longest = Convert.ToInt32(dr["Loggest"].ToString());
                }
                if (againstTime > 3)
                {//违规不能借阅
                    lb_sta.Text = "对不起，该用户违规次数过多，暂时无法借阅";
                    lb_sta.ForeColor = Color.Red;
                    conn.Close();
                    return;
                }
                if (topp - tt <= 0)
                {//查看用户是否还可以借书
                    lb_sta.Text = "对不起，该用户无法再借阅更多图书";
                    lb_sta.ForeColor = Color.Red;
                    conn.Close();
                    return;
                }
                stt = string.Format("select * from book_info where bid='{0}'", name);
                da = new MySqlDataAdapter(stt, conn);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    oin = dr["statue"].ToString();
                }
                if (oin != "在馆")
                {//图书不在图书馆，则无法借出
                    lb_sta.Text = "对不起，该图书无法外借";
                    lb_sta.ForeColor = Color.Red;
                    conn.Close();
                    return;
                }
                //计算还书日期
                ltime = datetime.AddDays(longest+Convert.ToInt32(again)*30).ToString();
                MySqlTransaction myt = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = myt;
                try {
                    string str = string.Format("update book_info set statue='借出',Rid={0} where bid={1}", rid, name);
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    str = string.Format("update reader_info set borrowNum={0} where Rid={1}", tt + 1, rid);
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    str = string.Format("insert into bookborrow_info values(null,'{0}','{1}',{2},{3},{4},{5})",time, ltime, again, name, rid, cid);
                    cmd.CommandText = str;
                    int i = cmd.ExecuteNonQuery();
                    lb_sta.Text = "恭喜您，借阅信息添加成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    myt.Commit();
                    conn.Close();
                }
                catch
                {
                    lb_sta.Text = "对不起，借阅信息添加失败";
                    lb_sta.ForeColor = Color.Red;
                    myt.Rollback();
                    conn.Close();
                }
                DataBind_Customer();
            }
            else
            {//续借直接通过修改续借次数和到期时间完成
                DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy-MM-dd HH:mm:ss";
                DateTime a = Convert.ToDateTime(oriagain,dtFormat);
                ltime = a.AddDays(30*(Convert.ToInt32(again) -oria)).ToString();
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update bookborrow_info set lastTime='{0}',againTime={1} " +
                    "where borrowid={2}", ltime, again, borid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lb_sta.Text = "恭喜您，借阅信息修改成功！";
                    lb_sta.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Customer();
                }
                else
                {
                    lb_sta.Text = "对不起，借阅信息修改失败";
                    lb_sta.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTexBox()
        {
            txt_name.Text = "";
            txt_rid.Text = "";
            nud_age.Value = 0;
            lb_statue.Text = "添加";
            txt_name.ReadOnly = false;
            txt_rid.ReadOnly = false;
        }
        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from bookborrow_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_reader.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["borrowid"].ToString());
                myitem.SubItems.Add(dr["borrowTime"].ToString());
                myitem.SubItems.Add(dr["lastTime"].ToString());
                myitem.SubItems.Add(dr["againTime"].ToString());
                myitem.SubItems.Add(dr["bid"].ToString());
                myitem.SubItems.Add(dr["Rid"].ToString());
                myitem.SubItems.Add(dr["Cid"].ToString());
                lv_reader.Items.Add(myitem);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            tssl_username.Text = Form2.userName;
            DataBind_Customer();
        }

        string borid = "";
        string oriagain = "";
        int oria = 0;

        private void lv_reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_reader.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_reader.SelectedItems[0];
                borid = myitem.SubItems[0].Text;
                nud_age.Text = myitem.SubItems[3].Text;
                txt_name.Text = myitem.SubItems[4].Text;
                txt_rid.Text = myitem.SubItems[5].Text;
                oria=Convert.ToInt32(nud_age.Text);
                oriagain= myitem.SubItems[2].Text;
                lb_statue.Text = "修改";
            }
            txt_name.ReadOnly = true;
            txt_rid.ReadOnly = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (borid == "")
            {
                MessageBox.Show("请先选中要删除的信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的借阅信息？", "删除提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=library_system;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from Reader_Info where borrowid={0}", borid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lb_sta.Text = "恭喜您，借阅信息删除成功！";
                        lb_sta.ForeColor = Color.Blue;
                        ClearTexBox();
                        DataBind_Customer();
                    }
                    else
                    {
                        lb_sta.Text = "对不起，借阅信息删除失败";
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
            string borrid = txt_bx1.Text.Trim();
            txt_bx1.Text = "";
            if (borrid == "")
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
                string str = String.Format("select * from bookborrow_Info where borrowid={0}",borrid);
                MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    nud_age.Text = dr["againTime"].ToString();
                    txt_name.Text = dr["Bid"].ToString();
                    txt_rid.Text = dr["Rid"].ToString();
                    oriagain = dr["lastTime"].ToString();
                    oria = Convert.ToInt32(dr["againTime"].ToString());
                }
                if (txt_name.Text == "")
                {
                    lb_sta.Text = "结果不存在";
                    lb_sta.ForeColor = Color.Red;
                    txt_bx1.Focus();
                    return;
                }
                else
                {
                    borid= borrid;
                    lb_statue.Text = "修改";
                    
                }
            }
        }
    }
}
