using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amanda_lista1
{
    public partial class Form17_amanda : Form
    {
        public Form17_amanda()
        {
            InitializeComponent();
        }
        int num1, num2, quo, rest;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label6.Text = "";
            label7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            quo = num1 / num2;
            rest = num1 % num2;
            label6.Text = quo.ToString();
            label7.Text = rest.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira um valor válido nos campos.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
