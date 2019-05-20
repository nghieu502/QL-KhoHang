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
    }
}
