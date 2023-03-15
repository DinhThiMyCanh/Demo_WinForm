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
    public partial class frmThongTinSV : Form
    {
        public frmThongTinSV()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string st = "Ho va ten:" + txtHoDem.Text + " " + txtTen.Text;
            st = st + "\n Ngày sinh:" + dtpNgaySinh.Text;
            string gt = rdNam.Checked == true ? "Nam" : "Nữ";
            string nn = "";
            if (chkTiengAnh.Checked == true)
                nn = chkTiengAnh.Text;
            if (chkTiengNhat.Checked == true)
                nn = nn + "," + chkTiengNhat.Text;
            string qq = cboQueQuan.Text;
            string mh = "";
            foreach (var item in lstDSMH.SelectedItems)
                mh = mh + item + "\n";

            st = st + "\n" + "Giới tính:" + gt + "\n" + "Ngoại ngữ:" + nn + "\n" + "Quê quán:" + qq + "\n" + "Danh sách môn học:" + mh;

            MessageBox.Show(st);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoDem.Clear();
            txtHoDem.Focus();
            txtTen.Clear();
            rdNam.Checked = true;

            if (chkTiengAnh.Checked == true)
                chkTiengAnh.Checked = false;
            if (chkTiengNhat.Checked == true)
                chkTiengNhat.Checked = false;

            cboQueQuan.SelectedIndex = 0;
            lstDSMH.ClearSelected();
        }
    }
}
