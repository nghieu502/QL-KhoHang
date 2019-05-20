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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            LoadMain();
        }

        private void btSupplier_Click(object sender, EventArgs e)
        {
            fSupplier x = new fSupplier();
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        void LoadMain()
        {
            string query = "select tenMH as [Tên mặt hàng], donVi as [Đơn vị], tonKho as [Tồn kho] from MatHang, (select (SUM(soLuongN)-SUM(soLuongX)) as tonKho, PhieuNhap.idMH from PhieuNhap, PhieuXuat group by PhieuNhap.idMH) as P where MatHang.idMH = P.idMH";
            dgvMain.DataSource = Excute.Instance.query(query);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khoHangDataSet.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.khoHangDataSet.MatHang);

        }
    }
}
