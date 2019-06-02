namespace KhoHang
{
    partial class fHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.khoHangDataSet = new KhoHang.KhoHangDataSet();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new KhoHang.KhoHangDataSetTableAdapters.PhieuNhapTableAdapter();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.phieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new KhoHang.KhoHangDataSetTableAdapters.PhieuXuatTableAdapter();
            this.idMHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.ItemSize = new System.Drawing.Size(282, 25);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(758, 429);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lịch sử nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvOutput);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lịch sử xuất";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMHDataGridViewTextBoxColumn,
            this.giaNDataGridViewTextBoxColumn,
            this.soLuongNDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phieuNhapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // khoHangDataSet
            // 
            this.khoHangDataSet.DataSetName = "KhoHangDataSet";
            this.khoHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.khoHangDataSet;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AutoGenerateColumns = false;
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMHDataGridViewTextBoxColumn1,
            this.giaXDataGridViewTextBoxColumn,
            this.soLuongXDataGridViewTextBoxColumn,
            this.ngayXuatDataGridViewTextBoxColumn});
            this.dgvOutput.DataSource = this.phieuXuatBindingSource;
            this.dgvOutput.Location = new System.Drawing.Point(7, 6);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowTemplate.Height = 24;
            this.dgvOutput.Size = new System.Drawing.Size(737, 384);
            this.dgvOutput.TabIndex = 0;
            // 
            // phieuXuatBindingSource
            // 
            this.phieuXuatBindingSource.DataMember = "PhieuXuat";
            this.phieuXuatBindingSource.DataSource = this.khoHangDataSet;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // idMHDataGridViewTextBoxColumn1
            // 
            this.idMHDataGridViewTextBoxColumn1.DataPropertyName = "idMH";
            this.idMHDataGridViewTextBoxColumn1.HeaderText = "Mã mặt hàng";
            this.idMHDataGridViewTextBoxColumn1.Name = "idMHDataGridViewTextBoxColumn1";
            this.idMHDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // giaXDataGridViewTextBoxColumn
            // 
            this.giaXDataGridViewTextBoxColumn.DataPropertyName = "giaX";
            this.giaXDataGridViewTextBoxColumn.HeaderText = "Giá xuất";
            this.giaXDataGridViewTextBoxColumn.Name = "giaXDataGridViewTextBoxColumn";
            this.giaXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongXDataGridViewTextBoxColumn
            // 
            this.soLuongXDataGridViewTextBoxColumn.DataPropertyName = "soLuongX";
            this.soLuongXDataGridViewTextBoxColumn.HeaderText = "Lượng xuất";
            this.soLuongXDataGridViewTextBoxColumn.Name = "soLuongXDataGridViewTextBoxColumn";
            this.soLuongXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayXuatDataGridViewTextBoxColumn
            // 
            this.ngayXuatDataGridViewTextBoxColumn.DataPropertyName = "ngayXuat";
            this.ngayXuatDataGridViewTextBoxColumn.HeaderText = "Ngày xuất";
            this.ngayXuatDataGridViewTextBoxColumn.Name = "ngayXuatDataGridViewTextBoxColumn";
            this.ngayXuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMHDataGridViewTextBoxColumn
            // 
            this.idMHDataGridViewTextBoxColumn.DataPropertyName = "idMH";
            this.idMHDataGridViewTextBoxColumn.HeaderText = "Mã mặt hàng";
            this.idMHDataGridViewTextBoxColumn.Name = "idMHDataGridViewTextBoxColumn";
            this.idMHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaNDataGridViewTextBoxColumn
            // 
            this.giaNDataGridViewTextBoxColumn.DataPropertyName = "giaN";
            this.giaNDataGridViewTextBoxColumn.HeaderText = "Giá nhập";
            this.giaNDataGridViewTextBoxColumn.Name = "giaNDataGridViewTextBoxColumn";
            this.giaNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongNDataGridViewTextBoxColumn
            // 
            this.soLuongNDataGridViewTextBoxColumn.DataPropertyName = "soLuongN";
            this.soLuongNDataGridViewTextBoxColumn.HeaderText = "Lượng nhập";
            this.soLuongNDataGridViewTextBoxColumn.Name = "soLuongNDataGridViewTextBoxColumn";
            this.soLuongNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "ngayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            this.ngayNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.tab);
            this.Name = "fHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử nhập xuất";
            this.Load += new System.EventHandler(this.fHistory_Load);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KhoHangDataSet khoHangDataSet;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private KhoHangDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.BindingSource phieuXuatBindingSource;
        private KhoHangDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatDataGridViewTextBoxColumn;
    }
}