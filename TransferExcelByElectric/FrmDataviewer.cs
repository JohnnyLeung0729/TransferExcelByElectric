using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferExcelByElectric
{
    public partial class FrmDataviewer : Form
    {
        String dbfile;
        SQLiteConnection m_dbConnection;
        string command = null;
        SQLiteDataAdapter adapter = null;
        DataSet tables = null;


        public FrmDataviewer(String dbf)
        {
            InitializeComponent();

            dbfile = dbf;

            this.Show();

            if (!System.IO.File.Exists(dbfile))
            {
                MessageBox.Show("没有日志文件，或日志文件调用失败", "读取日志失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                this.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return;
            }
            m_dbConnection = new SQLiteConnection("Data Source=" + dbfile + "; Version=3;");
            m_dbConnection.Open();
            command = "select * from smslog";
            adapter = new SQLiteDataAdapter(command, m_dbConnection);
            tables = new DataSet();
            adapter.Fill(tables, "stu1");
            dataGridView1.DataSource = tables;
            dataGridView1.DataMember = "stu1";
            m_dbConnection.Close();

            dataGridView1.Columns["qybm"].HeaderText = "企业编码";
            dataGridView1.Columns["qyname"].HeaderText = "企业名称";
            dataGridView1.Columns["sjhm"].HeaderText = "手机号码";
            dataGridView1.Columns["email"].HeaderText = "邮箱地址";
            dataGridView1.Columns["fszt"].HeaderText = "发送状态";
            dataGridView1.Columns["fssj"].HeaderText = "发送时间";

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            DataTable rentTable = ((DataSet)dataGridView1.DataSource).Tables["stu1"];//获取数据源
            for (int i = 0; i < rentTable.Rows.Count; i++)
            {
                if (rentTable.Rows[i]["qybm"].ToString() == textBox1.Text)
                {
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = i;
                    return;
                }
            }
            MessageBox.Show("企业编码不存在！", "提示");
        }
    }
}
