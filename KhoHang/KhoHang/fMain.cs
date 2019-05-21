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
            x.ShowDialog();
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin x = new fLogin();
            x.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fManager x = new fManager();
            x.ShowDialog();
        }

        private void btItems_Click(object sender, EventArgs e)
        {
            fItems x = new fItems();
            x.ShowDialog();
        }

        private void btOutput_Click(object sender, EventArgs e)
        {
            fOutput x = new fOutput();
            x.ShowDialog();
        }

        private void btInput_Click(object sender, EventArgs e)
        {
            fInput x = new fInput();
            x.ShowDialog();
        }

        private void lịchSửNhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHistory x = new fHistory();
            x.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInfor x = new fInfor();
            x.ShowDialog();
        }
    }
}
