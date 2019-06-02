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

        void LoadMain()
        {
            string query = "select tenMH as [Tên mặt hàng], donVi as [Đơn vị], (luongN - ISNULL(luongX, 0)) as [Tồn kho] from (select idMH, SUM(soLuongN) as luongN from PhieuNhap group by idMH) as N left join (select idMH, SUM(soLuongX) as luongX from PhieuXuat group by idMH) as X on N.idMH = X.idMH, MatHang where MatHang.idMH = N.idMH and (luongN - ISNULL(luongX, 0)) > 0 order by[Tồn kho] desc";
            dgvMain.DataSource = Excute.Instance.query(query);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khoHangDataSet.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.khoHangDataSet.MatHang);

        }

        private void btInput_Click(object sender, EventArgs e)
        {
            fInput x = new fInput();
            x.ShowDialog();
            LoadMain();
        }

        private void btOutput_Click(object sender, EventArgs e)
        {
            fOutput x = new fOutput();
            x.ShowDialog();
            LoadMain();
        }

        private void btItems_Click(object sender, EventArgs e)
        {
            fItems x = new fItems();
            x.ShowDialog();
            LoadMain();
        }

        private void btSupplier_Click(object sender, EventArgs e)
        {
            fSupplier x = new fSupplier();
            x.ShowDialog();
            LoadMain();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            fManager x = new fManager();
            x.ShowDialog();
            LoadMain();
        }

        private void History_Click(object sender, EventArgs e)
        {
            fHistory x = new fHistory();
            x.ShowDialog();
            LoadMain();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
