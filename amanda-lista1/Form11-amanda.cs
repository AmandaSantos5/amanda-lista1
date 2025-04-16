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
    public partial class Form11_amanda : Form
    {
        public Form11_amanda()
        {
            InitializeComponent();
        }
        int num, quad, cub;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            num = int.Parse(textBox1.Text);
            quad = num * num;
            cub = num * num * num;
            label5.Text = quad.ToString();
            label6.Text = cub.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira um valor válido nos campos.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
