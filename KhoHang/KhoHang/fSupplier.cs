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
    public partial class fSupplier : Form
    {
        BindingSource BS = new BindingSource();

        public fSupplier()
        {
            InitializeComponent();
            LoadSupplier();
            BindingData();
        }

        void LoadSupplier()
        {
            dgvSupplier.DataSource = BS;
            string query = "select * from NhaCungCap";
            BS.DataSource = Excute.Instance.query(query);
        }

        void BindingData()
        {
            tbID.DataBindings.Add(new Binding("Text", dgvSupplier.DataSource, "idNCC", true, DataSourceUpdateMode.Never));
            tbName.DataBindings.Add(new Binding("Text", dgvSupplier.DataSource, "tenNCC", true, DataSourceUpdateMode.Never));
            tbAddr.DataBindings.Add(new Binding("Text", dgvSupplier.DataSource, "diaChiNCC", true, DataSourceUpdateMode.Never));
            tbPhone.DataBindings.Add(new Binding("Text", dgvSupplier.DataSource, "sdtNCC", true, DataSourceUpdateMode.Never));
            tbEmail.DataBindings.Add(new Binding("Text", dgvSupplier.DataSource, "emailNCC", true, DataSourceUpdateMode.Never));
        }

        private void fSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khoHangDataSet.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.khoHangDataSet.NhaCungCap);

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            string tenNCC = tbName.Text;
            string diaChiNCC = tbAddr.Text;
            string sdtNCC = tbPhone.Text;
            string emailNCC = tbEmail.Text;
            string query = string.Format("insert into NhaCungCap(tenNCC, diaChiNCC, sdtNCC, emailNCC) values (N'{0}', N'{1}', N'{2}', N'{3}')", tenNCC, diaChiNCC, sdtNCC, emailNCC);
            if (Excute.Instance.nonquery(query) > 0)
            {
                MessageBox.Show("Thêm mới nhà cung cấp thành công", "Thông báo");
                LoadSupplier();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhà cung cấp", "Thông báo");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string idNCC = tbID.Text;
            string tenNCC = tbName.Text;
            string diaChiNCC = tbAddr.Text;
            string sdtNCC = tbPhone.Text;
            string emailNCC = tbEmail.Text;
            string query = string.Format("update NhaCungCap set tenNCC = N'{0}', diaChiNCC = N'{1}', sdtNCC = N'{2}', emailNCC = N'{3}' where idNCC = N'{4}'", tenNCC, diaChiNCC, sdtNCC, emailNCC, idNCC);
            if (Excute.Instance.nonquery(query) > 0)
            {
                MessageBox.Show("Sửa nhà cung cấp thành công", "Thông báo");
                LoadSupplier();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nhà cung cấp", "Thông báo");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string idNCC = tbID.Text;
            string query = string.Format("delete from NhaCungCap where idNCC = N'{0}'", idNCC);
            if (Excute.Instance.nonquery(query) > 0)
            {
                MessageBox.Show("Xóa nhà cung cấp thành công", "Thông báo");
                LoadSupplier();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa nhà cung cấp", "Thông báo");
            }
        }
    }
}
