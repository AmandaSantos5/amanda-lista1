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
    public partial class Form13_amanda : Form
    {
        public Form13_amanda()
        {
            InitializeComponent();
        }
        int num1, num2, soma1, soma2, quad1, quad2;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form13_amanda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1= int.Parse(textBox1.Text);
            num2= int.Parse(textBox2.Text);
            quad1 = num1 * num1;
            quad2 = num2 * num2;
            soma1 = quad1 + quad1;
            soma2 = quad2 + quad2;
            label4.Text = quad1.ToString();
            label7.Text = soma1.ToString();
            label11.Text = quad2.ToString();
            label9.Text = soma2.ToString();
        }
    }
}
