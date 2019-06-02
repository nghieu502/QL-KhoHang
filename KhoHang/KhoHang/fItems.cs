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
    public partial class fItems : Form
    {
        BindingSource BS = new BindingSource();

        public fItems()
        {
            InitializeComponent();
            LoadItems();
            LoadCB(cb);
            BindingData();
        }

        void LoadItems()
        {
            dgv.DataSource = BS;
            string query = "select * from MatHang";
            BS.DataSource = Excute.Instance.query(query);
        }

        void BindingData()
        {
            tbID.DataBindings.Add(new Binding("Text", dgv.DataSource, "idMH", true, DataSourceUpdateMode.Never));
            tbName.DataBindings.Add(new Binding("Text", dgv.DataSource, "tenMH", true, DataSourceUpdateMode.Never));
            tbUnit.DataBindings.Add(new Binding("Text", dgv.DataSource, "donVi", true, DataSourceUpdateMode.Never));
        }

        void LoadCB(ComboBox cb)
        {
            List<Supplier> list = new List<Supplier>();
            string query = "select * from NhaCungCap";
            DataTable dt = Excute.Instance.query(query);
            foreach (DataRow item in dt.Rows)
            {
                Supplier x = new Supplier(item);
                list.Add(x);
            }
            cb.DataSource = list;
            cb.DisplayMember = "tenNCC";
        }

        private void fItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khoHangDataSet.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.khoHangDataSet.MatHang);

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            string id = null;
            try
            {
                id = dgv.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
            }
            catch { }
            if (id != null)
            {
                string query = "select * from NhaCungCap where idNCC = " + id;
                DataTable dt = Excute.Instance.query(query);
                Supplier slier = null;
                foreach (DataRow item in dt.Rows)
                {
                    slier = new Supplier(item);
                }
                cb.SelectedItem = slier;
                int i = -1;
                int d = 0;
                foreach (Supplier item in cb.Items)
                {
                    if (item.idNCC == slier.idNCC)
                    {
                        i = d;
                        break;
                    }
                    d++;
                }
                cb.SelectedIndex = i;
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            string tenMH = tbName.Text;
            string donVi = tbUnit.Text;
            int idNCC = -1;
            try
            {
                idNCC = (cb.SelectedItem as Supplier).idNCC;
            }
            catch { }
            string query = string.Format("insert into MatHang(tenMH, donVi, idNCC) values (N'{0}', N'{1}', N'{2}')", tenMH, donVi, idNCC);
            if (Excute.Instance.nonquery(query) > 0)
            {
                MessageBox.Show("Thêm mới mặt hàng thành công", "Thông báo");
                LoadItems();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm mặt hàng", "Thông báo");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string idMH = tbID.Text;
            string tenMH = tbName.Text;
            string donVi = tbUnit.Text;
            int idNCC = (cb.SelectedItem as Supplier).idNCC;
            string query = string.Format("update MatHang set tenMH = N'{0}', donVi = N'{1}', idNCC = N'{2}' where idMH = N'{3}'", tenMH, donVi, idNCC, idMH);
            if (Excute.Instance.nonquery(query) > 0)
            {
                MessageBox.Show("Sửa thông tin mặt hàng thành công", "Thông báo");
                LoadItems();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thông tin mặt hàng", "Thông báo");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string idMH = tbID.Text;
            string query = string.Format("delete from MatHang where idMH = N'{0}'", idMH);
            if (Excute.Instance.nonquery(query) > 0)
            {
                MessageBox.Show("Xóa mặt hàng thành công", "Thông báo");
                LoadItems();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa mặt hàng", "Thông báo");
            }
        }
    }
}
