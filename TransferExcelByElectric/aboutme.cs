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
    public partial class aboutme : Form
    {
        public aboutme()
        {
            InitializeComponent();

            lbl_version.Text= "程序集版本：" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\n";
        }
    }
}
