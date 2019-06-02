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
    public partial class fOutput : Form
    {
        public fOutput()
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
            int giaX = (int)tbPrice.Value;
            int soLuongX = (int)tbQtt.Value;
            int tonKho = 0;
            string ngayXuat = dtp.Value.ToString("yyyy-MM-dd");
            string query = "select N.idMH, (luongN - ISNULL(luongX,0)) as tonKho from (select idMH, SUM(soLuongN) as luongN from PhieuNhap group by idMH) as N left join (select idMH, SUM(soLuongX) as luongX from PhieuXuat group by idMH) as X on N.idMH = X.idMH, MatHang where MatHang.idMH = N.idMH";
            DataTable dt = Excute.Instance.query(query);
            foreach (DataRow item in dt.Rows)
            {
                if (idMH == (int)item["idMH"])
                {
                    tonKho = (int)item["tonKho"];
                    break;
                }
            }
            if(soLuongX > tonKho)
            {
                MessageBox.Show("Không thể thêm phiếu xuất do tồn kho còn: " + tonKho, "Thông báo");
            }
            else
            {
                query = string.Format("insert into PhieuXuat(idMH, giaX, soLuongX, ngayXuat) values (N'{0}', N'{1}', N'{2}', '{3}')", idMH, giaX, soLuongX, ngayXuat);
                if (Excute.Instance.nonquery(query) > 0)
                {
                    MessageBox.Show("Thêm phiếu xuất thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm phiếu xuất", "Thông báo");
                }
            }
        }

        private void btDrop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
