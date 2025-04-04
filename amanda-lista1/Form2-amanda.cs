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
    public partial class Form2_amanda : Form
    {
        public Form2_amanda()
        {
            InitializeComponent();
        }
        int n1, n2, soma ;

        private void Form2_amanda_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label5.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            soma = n1 + n2;
            label5.Text = soma.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira um valor válido nos campos.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
