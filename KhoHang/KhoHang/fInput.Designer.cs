namespace KhoHang
{
    partial class fInput
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDrop = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.NumericUpDown();
            this.tbQtt = new System.Windows.Forms.NumericUpDown();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQtt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtp);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 249);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 73);
            this.panel4.TabIndex = 9;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(158, 21);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(397, 27);
            this.dtp.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày nhập:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbQtt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 73);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lượng nhập:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 73);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá nhập:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 73);
            this.panel2.TabIndex = 6;
            // 
            // cb
            // 
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(158, 20);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(397, 28);
            this.cb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên mặt hàng:";
            // 
            // btDrop
            // 
            this.btDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDrop.Location = new System.Drawing.Point(420, 391);
            this.btDrop.Name = "btDrop";
            this.btDrop.Size = new System.Drawing.Size(150, 50);
            this.btDrop.TabIndex = 11;
            this.btDrop.Text = "Hủy";
            this.btDrop.UseVisualStyleBackColor = true;
            this.btDrop.Click += new System.EventHandler(this.btDrop_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(264, 391);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(150, 50);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Ghi nhận";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(158, 21);
            this.tbPrice.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(397, 27);
            this.tbPrice.TabIndex = 2;
            // 
            // tbQtt
            // 
            this.tbQtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQtt.Location = new System.Drawing.Point(158, 21);
            this.tbQtt.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.tbQtt.Name = "tbQtt";
            this.tbQtt.Size = new System.Drawing.Size(397, 27);
            this.tbQtt.TabIndex = 3;
            // 
            // fInput
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btDrop);
            this.Controls.Add(this.btAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập kho";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQtt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDrop;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.NumericUpDown tbPrice;
        private System.Windows.Forms.NumericUpDown tbQtt;
    }
}