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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMayTinh_Click(object sender, EventArgs e)
        {
            frmMayTinh f = new frmMayTinh();
            f.MdiParent = this;
            f.Show();
           // f.ShowDialog();
          //  this.Hide();//Phương thức ẩn form


        }
    }
}
