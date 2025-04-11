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
    public partial class Form12_amanda : Form
    {
        public Form12_amanda()
        {
            InitializeComponent();
        }
        int num1, num2, quad, soma;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label5.Text = "";
        }

        private void Form12_amanda_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            soma = num1 + num2;
            quad = soma * soma;
            label5.Text = quad.ToString();
        }
    }
}
