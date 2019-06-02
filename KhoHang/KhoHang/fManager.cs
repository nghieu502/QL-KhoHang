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
    public partial class fManager : Form
    {
        BindingSource BS = new BindingSource();

        public fManager()
        {
            InitializeComponent();
            LoadUsers();
            BindingData();
        }

        void LoadUsers()
        {
            dgv.DataSource = BS;
            string query = "select * from Users";
            BS.DataSource = Excute.Instance.query(query);
        }

        void BindingData()
        {
            tbID.DataBindings.Add(new Binding("Text", dgv.DataSource, "idUS", true, DataSourceUpdateMode.Never));
            tbName.DataBindings.Add(new Binding("Text", dgv.DataSource, "tenUS", true, DataSourceUpdateMode.Never));
            tbUsername.DataBindings.Add(new Binding("Text", dgv.DataSource, "username", true, DataSourceUpdateMode.Never));
            tbPassword.DataBindings.Add(new Binding("Text", dgv.DataSource, "pass", true, DataSourceUpdateMode.Never));
        }

        private void fManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khoHangDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.khoHangDataSet.Users);

        }

        bool PassCheck(string pass)
        {
            if(pass.Length > 8)
            {
                bool thuong, hoa, so;
                thuong = hoa = so = false;
                foreach (char item in pass)
                {
                    if ('a' <= item && item <= 'z')
                    {
                        thuong = true;
                    }
                    else if ('A' <= item && item <= 'Z')
                    {
                        hoa = true;
                    }
                    else if ('0' <= item && item <= '9')
                    {
                        so = true;
                    }
                }
                if (thuong && so && hoa)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 1 chữ thường, 1 chữ hoa, 1 chữ số", "Thông báo");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 kí tự", "Thông báo");
                return false;
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            string tenUS = tbName.Text;
            string username = tbUsername.Text;
            string pass = tbPassword.Text;
            string query = string.Format("insert into Users(tenUS, username, pass) values (N'{0}', N'{1}', N'{2}')", tenUS, username, pass);
            if (Excute.Instance.nonquery(query) > 0)
            {
                MessageBox.Show("Thêm mới người dùng thành công", "Thông báo");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm người dùng", "Thông báo");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string idUS = tbID.Text;
            string tenUS = tbName.Text;
            string username = tbUsername.Text;
            string pass = tbPassword.Text;
            string query = string.Format("update Users set tenUS = N'{0}', username = N'{1}', pass = N'{2}' where idUS = N'{3}'", tenUS, username, pass, idUS);
            if (Excute.Instance.nonquery(query) > 0)
            {
                MessageBox.Show("Sửa thông tin người dùng thành công", "Thông báo");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thông tin người dùng", "Thông báo");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string idUS = tbID.Text;
            string query = string.Format("delete from Users where idUS = N'{0}'", idUS);
            if (Excute.Instance.nonquery(query) > 0)
            {
                MessageBox.Show("Xóa người dùng thành công", "Thông báo");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa người dùng", "Thông báo");
            }
        }
    }
}
