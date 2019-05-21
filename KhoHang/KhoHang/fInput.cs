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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tong();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            tong();
        }

        private void tong()
        {
            double a = 0, b = 0, demo;
            if (double.TryParse(textBox2.Text, out demo))
                a = double.Parse(textBox2.Text); //textbox 1
            if (double.TryParse(textBox3.Text, out demo))
                b = double.Parse(textBox3.Text); //textbox 2

            double s = a * b;
            textBox5.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}

