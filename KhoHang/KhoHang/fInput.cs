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
    public partial class fInput : Form
    {
        public fInput()
        {
            InitializeComponent();
            LoadCB(cb);
        }

        void LoadCB(ComboBox cb)
        {
            List<Items> list = new List<Items>();
            string query = "select * from MatHang";
            DataTable dt = Excute.Instance.query(query);
            foreach (DataRow item in dt.Rows)
            {
                Items x = new Items(item);
                list.Add(x);
            }
            cb.DataSource = list;
            cb.DisplayMember = "tenMH";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int idMH = (cb.SelectedItem as Items).idMH;
            int giaN = (int)tbPrice.Value;
            int soLuongN = (int)tbQtt.Value;
            string ngayNhap = dtp.Value.ToString("yyyy-MM-dd");
            string query = string.Format("insert into PhieuNhap(idMH, giaN, soLuongN, ngayNhap) values (N'{0}', N'{1}', N'{2}', '{3}')", idMH, giaN, soLuongN, ngayNhap);
            if (Excute.Instance.nonquery(query) > 0)
            {
                MessageBox.Show("Thêm phiếu nhập thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm phiếu nhập", "Thông báo");
            }
        }

        private void btDrop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

