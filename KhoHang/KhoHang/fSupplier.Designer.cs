namespace KhoHang
{
    partial class fSupplier
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tenNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoHangDataSet = new KhoHang.KhoHangDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.nhaCungCapTableAdapter = new KhoHang.KhoHangDataSetTableAdapters.NhaCungCapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNCCDataGridViewTextBoxColumn,
            this.diaChiNCCDataGridViewTextBoxColumn,
            this.sdtNCCDataGridViewTextBoxColumn,
            this.emailNCCDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.nhaCungCapBindingSource;
            this.dgv.Location = new System.Drawing.Point(13, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(587, 429);
            this.dgv.TabIndex = 0;
            // 
            // tenNCCDataGridViewTextBoxColumn
            // 
            this.tenNCCDataGridViewTextBoxColumn.DataPropertyName = "tenNCC";
            this.tenNCCDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenNCCDataGridViewTextBoxColumn.Name = "tenNCCDataGridViewTextBoxColumn";
            this.tenNCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiNCCDataGridViewTextBoxColumn
            // 
            this.diaChiNCCDataGridViewTextBoxColumn.DataPropertyName = "diaChiNCC";
            this.diaChiNCCDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiNCCDataGridViewTextBoxColumn.Name = "diaChiNCCDataGridViewTextBoxColumn";
            this.diaChiNCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sdtNCCDataGridViewTextBoxColumn
            // 
            this.sdtNCCDataGridViewTextBoxColumn.DataPropertyName = "sdtNCC";
            this.sdtNCCDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sdtNCCDataGridViewTextBoxColumn.Name = "sdtNCCDataGridViewTextBoxColumn";
            this.sdtNCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailNCCDataGridViewTextBoxColumn
            // 
            this.emailNCCDataGridViewTextBoxColumn.DataPropertyName = "emailNCC";
            this.emailNCCDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailNCCDataGridViewTextBoxColumn.Name = "emailNCCDataGridViewTextBoxColumn";
            this.emailNCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.khoHangDataSet;
            // 
            // khoHangDataSet
            // 
            this.khoHangDataSet.DataSetName = "KhoHangDataSet";
            this.khoHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(606, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 51);
            this.panel2.TabIndex = 1;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(147, 21);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(214, 27);
            this.tbID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(606, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 51);
            this.panel1.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(147, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(214, 27);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbAddr);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(606, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 51);
            this.panel3.TabIndex = 3;
            // 
            // tbAddr
            // 
            this.tbAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddr.Location = new System.Drawing.Point(147, 21);
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.Size = new System.Drawing.Size(214, 27);
            this.tbAddr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbPhone);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(606, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 51);
            this.panel4.TabIndex = 4;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(147, 21);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(214, 27);
            this.tbPhone.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbEmail);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(606, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(364, 51);
            this.panel5.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(147, 21);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(214, 27);
            this.tbEmail.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(607, 371);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(117, 70);
            this.btInsert.TabIndex = 6;
            this.btInsert.Text = "Thêm";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(730, 371);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(117, 70);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "Sửa";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(853, 371);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(117, 70);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // fSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv);
            this.Name = "fSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.fSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private KhoHangDataSet khoHangDataSet;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private KhoHangDataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailNCCDataGridViewTextBoxColumn;
    }
}