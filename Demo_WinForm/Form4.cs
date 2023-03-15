using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDTB_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                float pascal = float.Parse(txtPascal.Text);
                float c_Sharp = float.Parse(txtC_Sharp.Text);
                float sql = float.Parse(txtsql.Text);
                SV a = new SVCNTT(1,"Nguyen Van A", new DateTime(2001, 4, 12), true, pascal, c_Sharp, sql);
                txtDTB.Text = a.dTB().ToString();
            }    
        }
    }
}
