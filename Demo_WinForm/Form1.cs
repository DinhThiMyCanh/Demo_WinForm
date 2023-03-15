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
    public partial class frmMayTinh : Form
    {
        public frmMayTinh()
        {
            InitializeComponent();
        }

        private void frmMayTinh_Load(object sender, EventArgs e)
        {
            txtSoThu1.Text = "0";
            txtSoThu2.Text = "0";
        }

        private void frmMayTinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn có muốn đóng không?");
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int x =Convert.ToInt32(txtSoThu1.Text);
            int y = Convert.ToInt32(txtSoThu2.Text);
            int z = x + y;
            txtKQ.Text = z.ToString();

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtSoThu1.Clear();
            txtSoThu2.Clear();
            txtKQ.Clear();
            txtSoThu1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
