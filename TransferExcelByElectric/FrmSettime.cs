using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferExcelByElectric
{
    public partial class FrmSettime : Form
    {
        String configfile = "";
        String dbfile = "";
        String settime = "";

        MainFrm mf = null;
        

        public FrmSettime(MainFrm f)
        {
            InitializeComponent();
            //Load config file path and name
            configfile = Application.StartupPath + "\\DB\\elecon.ini";
            dbfile = Application.StartupPath + "\\DB\\";

            mf = f;
        }

        private void FrmSettime_Load(object sender, EventArgs e)
        {
            settime = DB.OperateIniFile.ReadIniData("CONFIG", "spantime", "null", configfile);
            if (settime.Equals("null"))
            {
                dtp_timeset.Value = DateTime.Now;
            }
            else
            {
                dtp_timeset.Value = Convert.ToDateTime(settime);
            }
        }

        private void btn_settime_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定扫描发送时间为每天：" + dtp_timeset.Value.ToLongTimeString() + "？", "更新时间？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DB.OperateIniFile.WriteIniData("CONFIG", "spantime", dtp_timeset.Value.ToLongTimeString(), configfile);

                mf.Lbl_settime.Text = dtp_timeset.Value.ToLongTimeString();
                mf.Lbl_settime.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
                mf.Lbl_settime.ForeColor = Color.Black;

                mf.Settime = mf.Lbl_settime.Text;

                MessageBox.Show("更新成功！");

                this.Close();
            }
        }
    }
}
