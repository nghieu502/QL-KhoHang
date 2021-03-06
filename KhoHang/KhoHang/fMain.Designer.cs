﻿namespace KhoHang
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Manager = new System.Windows.Forms.ToolStripMenuItem();
            this.History = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.btInput = new System.Windows.Forms.Button();
            this.btOutput = new System.Windows.Forms.Button();
            this.btItems = new System.Windows.Forms.Button();
            this.btSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.khoHangDataSet = new KhoHang.KhoHangDataSet();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matHangTableAdapter = new KhoHang.KhoHangDataSetTableAdapters.MatHangTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Manager,
            this.History,
            this.Logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(603, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Manager
            // 
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(138, 24);
            this.Manager.Text = "Quản lý nhân viên";
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // History
            // 
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(135, 24);
            this.History.Text = "Lịch sử nhập xuất";
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(89, 24);
            this.Logout.Text = "Đăng xuất";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btInput
            // 
            this.btInput.Image = ((System.Drawing.Image)(resources.GetObject("btInput.Image")));
            this.btInput.Location = new System.Drawing.Point(12, 31);
            this.btInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(140, 100);
            this.btInput.TabIndex = 2;
            this.btInput.Text = "Nhập kho";
            this.btInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // btOutput
            // 
            this.btOutput.Image = ((System.Drawing.Image)(resources.GetObject("btOutput.Image")));
            this.btOutput.Location = new System.Drawing.Point(157, 31);
            this.btOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOutput.Name = "btOutput";
            this.btOutput.Size = new System.Drawing.Size(140, 100);
            this.btOutput.TabIndex = 3;
            this.btOutput.Text = "Xuất kho";
            this.btOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btOutput.UseVisualStyleBackColor = true;
            this.btOutput.Click += new System.EventHandler(this.btOutput_Click);
            // 
            // btItems
            // 
            this.btItems.Image = ((System.Drawing.Image)(resources.GetObject("btItems.Image")));
            this.btItems.Location = new System.Drawing.Point(304, 31);
            this.btItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btItems.Name = "btItems";
            this.btItems.Size = new System.Drawing.Size(140, 100);
            this.btItems.TabIndex = 4;
            this.btItems.Text = "Mặt hàng";
            this.btItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btItems.UseVisualStyleBackColor = true;
            this.btItems.Click += new System.EventHandler(this.btItems_Click);
            // 
            // btSupplier
            // 
            this.btSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btSupplier.Image")));
            this.btSupplier.Location = new System.Drawing.Point(451, 31);
            this.btSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupplier.Name = "btSupplier";
            this.btSupplier.Size = new System.Drawing.Size(140, 100);
            this.btSupplier.TabIndex = 5;
            this.btSupplier.Text = "Nhà cung cấp";
            this.btSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSupplier.UseVisualStyleBackColor = true;
            this.btSupplier.Click += new System.EventHandler(this.btSupplier_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMain);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 404);
            this.panel1.TabIndex = 1;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(5, 38);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(571, 364);
            this.dgvMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách tồn kho";
            // 
            // khoHangDataSet
            // 
            this.khoHangDataSet.DataSetName = "KhoHangDataSet";
            this.khoHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.khoHangDataSet;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSupplier);
            this.Controls.Add(this.btItems);
            this.Controls.Add(this.btOutput);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Manager;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.Button btOutput;
        private System.Windows.Forms.Button btItems;
        private System.Windows.Forms.Button btSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem History;
        private KhoHangDataSet khoHangDataSet;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private KhoHangDataSetTableAdapters.MatHangTableAdapter matHangTableAdapter;
    }
}