﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferExcelByElectric.DB;

namespace TransferExcelByElectric
{
    public partial class MainFrm : Form
    {
        String configfile = "";
        String dbfile = "";

        String excelfile = "null";
        String postadd = "null";
        String scanspan = "0";
        int opline = 0;
        String settime = "null";

        String smstitle = "";
        String smsFname = "";
        String fontpath = "";

        String formmaintitle = "";

        SQLiteConnection m_dbConnection;

        public Label Lbl_settime
        {
            get
            {
                return lbl_settime;
            }

            set
            {
                lbl_settime = value;
            }
        }

        public string Settime
        {
            get
            {
                return settime;
            }

            set
            {
                settime = value;
            }
        }

        public MainFrm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            btn_startend.Text = TransferExcelByElectric.Properties.Resources.btn_startend;
            Prob_scanspan.Tag = 1;
            //Load config file path and name
            configfile = Application.StartupPath + "\\DB\\elecon.ini";
            dbfile = Application.StartupPath + "\\DB\\";
            formmaintitle = this.Text;

            //Read ini config
            excelfile =DB.OperateIniFile.ReadIniData("CONFIG", "filepath1", "null", configfile);
            if (excelfile.Equals("null"))
            {
                MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_errconfigfile, TransferExcelByElectric.Properties.Resources.str_errconfigfile_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }else
            {
                try
                {
                    txt_excelfile.Text = excelfile;
                    String filenamesplit = excelfile.Split('\\')[excelfile.Split('\\').Length - 1].Split('.')[0];
                    for(int i=0;i<= excelfile.Split('\\').Length - 2; i++)
                    {
                        fontpath = fontpath + excelfile.Split('\\')[0]+"\\";
                    }
                    smstitle = filenamesplit.Substring(0, filenamesplit.Length - 12);
                    smsFname= filenamesplit.Substring(filenamesplit.Length - 12)+".xls";
                }
                catch
                {
                    MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_errexcelname, TransferExcelByElectric.Properties.Resources.str_errexcelname_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }

                //核对月份文件信息
                String datenowstr = DateTime.Now.Year.ToString() + "年" + DateTime.Now.Month.ToString() + "月";
                if (!datenowstr.Equals(smstitle))
                {
                    MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_errexcelname+"#系统将进行自动更正并搜索文件", TransferExcelByElectric.Properties.Resources.str_errexcelname_title,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    smstitle = datenowstr;
                    txt_excelfile.Text = fontpath + smstitle+ smsFname;

                    DB.OperateIniFile.WriteIniData("CONFIG", "filepath1", txt_excelfile.Text, configfile);
                }

                dbfile = dbfile + smstitle + ".sms";
                Boolean newdb = false;
                if (!System.IO.File.Exists(dbfile))
                {
                    SQLiteConnection.CreateFile(dbfile);
                    newdb = true;
                }
                m_dbConnection = new SQLiteConnection("Data Source=" + dbfile + "; Version=3;");
                m_dbConnection.Open();
                if (newdb) {
                    string sql = "create table smslog (qybm varchar(24), qyname varchar(72),sjhm varchar(16),email varchar(72),fszt varchar(6),fssj varchar(24))";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    sql = "create index searchindex on smslog(qybm,fszt)";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    sql = "create index smslogindex on smslog(qybm)";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    sql = "create table oplog (errinfo text, intime datetime,errcode varchar(8),memo varchar(64))";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    sql = "create index searchopindex on oplog(errcode,intime)";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    sql = "create index oplogindex on oplog(errcode)";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                }
            }
            postadd = DB.OperateIniFile.ReadIniData("CONFIG", "postadd", "null", configfile);
            if (excelfile.Equals("null"))
            {
                MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_errconfigfile, TransferExcelByElectric.Properties.Resources.str_errconfigfile_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                txt_postadd.Text = postadd;
            }
            scanspan = DB.OperateIniFile.ReadIniData("CONFIG", "scanspan", "null", configfile);
            if (excelfile.Equals("null"))
            {
                MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_errconfigfile, TransferExcelByElectric.Properties.Resources.str_errconfigfile_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                txt_scanspan.Text = scanspan;
                Prob_scanspan.Maximum = Convert.ToInt32(scanspan);
                //Prob_scanspan.Value= Convert.ToInt32(scanspan)-30;
            }
            String oplines = DB.OperateIniFile.ReadIniData("CONFIG", "sendcol", "null", configfile);
            if (excelfile.Equals("null"))
            {
                MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_errconfigfile, TransferExcelByElectric.Properties.Resources.str_errconfigfile_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                try
                {
                    opline = Convert.ToInt32(oplines);
                }
                catch
                {
                    MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_errconfigfile, TransferExcelByElectric.Properties.Resources.str_errconfigfile_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
                Console.WriteLine(opline);
            }
            settime = DB.OperateIniFile.ReadIniData("CONFIG", "spantime", "null", configfile);
            if (settime.Equals("null"))
            {
                lbl_settime.Text = TransferExcelByElectric.Properties.Resources.str_notime;
                lbl_settime.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold);
                lbl_settime.ForeColor = Color.Red;
            }
            else
            {
                lbl_settime.Text = settime;
                lbl_settime.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
                lbl_settime.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// 查看报表按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_test_Click(object sender, EventArgs e)
        {
            FrmDataviewer fdv = new FrmDataviewer(dbfile);
        }

        #region
        public DataSet ExcelToDS(string Path)
        {
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties='Excel 8.0;IMEX=1';";
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            try
            {
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                strExcel = "select * from [sheet1$]";
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                ds = new DataSet();
                myCommand.Fill(ds, "table1");
            }
            catch 
            {
                MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_errloadexcel, TransferExcelByElectric.Properties.Resources.str_errexcelname_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            return ds;
        }
        #endregion

        private void btn_msend_Click(object sender, EventArgs e)
        {
            new Thread(()=> { execute_loadfile_sendsms(); }).Start();
        }

        /// <summary>
        /// 运行调用excel文件，发送通知短信
        /// </summary>
        private void execute_loadfile_sendsms()
        {
            DataSet ds = ExcelToDS(excelfile);
            Console.WriteLine(ds.Tables.Count);
            //Console.WriteLine("read rows is:" + txt_readrows.Text);
            Action act = delegate () { btn_msend.Enabled = false; };
            this.Invoke(act);

            prob_send.Maximum = ds.Tables[0].Rows.Count;
            prob_send.Value = 0;
            int sendrows = 0;
            int nonorows = 0;
            int hasrows = 0;
            int errorrows = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                prob_send.Value += 1;
                if (ds.Tables[0].Rows[i][opline].ToString().Equals("已发送"))
                {
                    if (ds.Tables[0].Rows[i][9].ToString().Length != 11)
                    {
                        nonorows += 1;
                    }
                    else
                    {
                        string sendstr = String.Format(TransferExcelByElectric.Properties.Resources.send_port_template, ds.Tables[0].Rows[i][9].ToString(), ds.Tables[0].Rows[i][0].ToString(), ds.Tables[0].Rows[i][1].ToString(), smstitle, ds.Tables[0].Rows[i][10].ToString());
                        Console.WriteLine(sendstr);

                        string sql = "select * from smslog where qybm='" + ds.Tables[0].Rows[i][0].ToString() + "' and fszt='0' order by fssj desc";
                        SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                        SQLiteDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            Console.WriteLine("has sended sms");
                            hasrows += 1;
                        }
                        else
                        {
                            HttpGetPost hgp = new HttpGetPost();
                            //短信发送接口
                            String sreturn = hgp.HttpPost(postadd + sendstr, "");
                            Console.WriteLine(sreturn);
                            ReturnJson1 postback;
                            if (sreturn == null)
                            {
                                postback = new ReturnJson1();
                                postback.Code = 1;
                            }
                            else {
                                postback = JsonConvert.DeserializeObject<DB.ReturnJson1>(sreturn);
                            }
                            String stat = "1";
                            if (postback.Code == 0)
                            {
                                stat = "0";
                                sendrows += 1;
                                sql = "delete from smslog where qybm = '" + ds.Tables[0].Rows[i][0].ToString() + "' and fszt='1'";
                                command = new SQLiteCommand(sql, m_dbConnection);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                errorrows += 1;
                            }
                            sql = "insert into smslog (qybm, qyname,sjhm,email,fszt,fssj) values ('" + ds.Tables[0].Rows[i][0].ToString() + "','" + ds.Tables[0].Rows[i][1].ToString() + "','" + ds.Tables[0].Rows[i][9].ToString() + "','" + ds.Tables[0].Rows[i][10].ToString() + "','" + stat + "','" + DateTime.Now.ToString() + "')";
                            command = new SQLiteCommand(sql, m_dbConnection);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else {
                    writeLine("【" + ds.Tables[0].Rows[i][0].ToString() + "】" + ds.Tables[0].Rows[i][1].ToString() + "(没有已发送标记，略过)", "T111", "------");
                }
                //间歇发送时间间隔
                Thread.Sleep(800);

                act = delegate () { txt_readrows.Text = ds.Tables[0].Rows.Count.ToString(); txt_sendrows.Text = sendrows.ToString(); txt_nono.Text = nonorows.ToString();txt_hassend.Text = hasrows.ToString();tsslbl_errrows.Text = "发送错误："+errorrows.ToString(); };
                this.Invoke(act);
            }

            act = delegate () { btn_msend.Enabled = true; };
            this.Invoke(act);
        }

        private void Tsmi_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_closesys, TransferExcelByElectric.Properties.Resources.str_closesys_title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_closesys, TransferExcelByElectric.Properties.Resources.str_closesys_title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btn_startend_Click(object sender, EventArgs e)
        {
            if (settime.Equals("null"))
            {
                MessageBox.Show("没有设定执行时间无法开启运行！", "停止", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (Prob_scanspan.Tag.Equals(0))
            {
                timer_send.Stop();
                Prob_scanspan.Tag = 1;
                btn_startend.Text = TransferExcelByElectric.Properties.Resources.btn_startend;
            }
            else
            {
                //Prob_scanspan.Value = 0;
                
                timer_send.Start();
                Prob_scanspan.Tag = 0;
                btn_startend.Text = TransferExcelByElectric.Properties.Resources.btn_startend_stop;
            }
        }

        private void timer_send_Tick(object sender, EventArgs e)
        {
            this.Text = formmaintitle + "【" + DateTime.Now.ToLongTimeString() + "】";
            if (rb_status.Checked)
            {
                rb_status.Checked = false;
            }else
            {
                rb_status.Checked = true;
            }

            if (DateTime.Now.ToLongTimeString().Equals(settime))
            {
                //Prob_scanspan.Value = 0;
                new Thread(() => { execute_loadfile_sendsms(); }).Start();
                //Console.WriteLine(DateTime.Now.ToString());
            }
            //Prob_scanspan.Value += 1;
            //Console.WriteLine(Prob_scanspan.Value);
        }

        private void tsmi_aboutme_Click(object sender, EventArgs e)
        {
            new aboutme().ShowDialog();
        }

        private void Tsmi_setsys_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TransferExcelByElectric.Properties.Resources.str_noapp, TransferExcelByElectric.Properties.Resources.str_noapp_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmi_settime_Click(object sender, EventArgs e)
        {
            new FrmSettime(this).ShowDialog();
        }

        private void writeLine(String connect,String errcode,String memo)
        {
            String sql = "insert into oplog (errinfo, intime,errcode,memo) values ('"+ connect + "','"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','"+ errcode + "','"+ memo + "')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

            command.ExecuteNonQuery();
        }
        
    }
}
