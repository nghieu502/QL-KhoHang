using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoHang
{
    public partial class fHistory : Form
    {
        public fHistory()
        {
            InitializeComponent();
        }

        private void fHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khoHangDataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.khoHangDataSet.PhieuXuat);
            // TODO: This line of code loads data into the 'khoHangDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.khoHangDataSet.PhieuNhap);

        }
    }
}
