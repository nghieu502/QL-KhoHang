namespace KhoHang
{
    partial class fItems
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
            this.tenMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoHangDataSet = new KhoHang.KhoHangDataSet();
            this.matHangTableAdapter = new KhoHang.KhoHangDataSetTableAdapters.MatHangTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tenMHDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.idNCCDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.matHangBindingSource;
            this.dgv.Location = new System.Drawing.Point(13, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(487, 429);
            this.dgv.TabIndex = 0;
            // 
            // tenMHDataGridViewTextBoxColumn
            // 
            this.tenMHDataGridViewTextBoxColumn.DataPropertyName = "tenMH";
            this.tenMHDataGridViewTextBoxColumn.HeaderText = "Tên mặt hàng";
            this.tenMHDataGridViewTextBoxColumn.Name = "tenMHDataGridViewTextBoxColumn";
            this.tenMHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "donVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "Đơn vị";
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            this.donViDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idNCCDataGridViewTextBoxColumn
            // 
            this.idNCCDataGridViewTextBoxColumn.DataPropertyName = "idNCC";
            this.idNCCDataGridViewTextBoxColumn.HeaderText = "Mã NCC";
            this.idNCCDataGridViewTextBoxColumn.Name = "idNCCDataGridViewTextBoxColumn";
            this.idNCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.khoHangDataSet;
            // 
            // khoHangDataSet
            // 
            this.khoHangDataSet.DataSetName = "KhoHangDataSet";
            this.khoHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cb);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(506, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 51);
            this.panel4.TabIndex = 9;
            // 
            // cb
            // 
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(153, 20);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(208, 28);
            this.cb.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà cung cấp:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbUnit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(506, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 51);
            this.panel3.TabIndex = 8;
            // 
            // tbUnit
            // 
            this.tbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnit.Location = new System.Drawing.Point(153, 21);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(208, 27);
            this.tbUnit.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn vị:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(506, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 51);
            this.panel1.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(153, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(208, 27);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên mặt hàng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(506, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 51);
            this.panel2.TabIndex = 6;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(153, 21);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(208, 27);
            this.tbID.TabIndex = 0;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
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
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(753, 371);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(117, 70);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(630, 371);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(117, 70);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "Sửa";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(507, 371);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(117, 70);
            this.btInsert.TabIndex = 9;
            this.btInsert.Text = "Thêm";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // fItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv);
            this.Name = "fItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mặt hàng";
            this.Load += new System.EventHandler(this.fItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private KhoHangDataSet khoHangDataSet;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private KhoHangDataSetTableAdapters.MatHangTableAdapter matHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
    }
}