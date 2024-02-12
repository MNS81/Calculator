using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 Calc = new Form1();
            Calc.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = new DataTable().Compute(textBox1.Text, null).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
