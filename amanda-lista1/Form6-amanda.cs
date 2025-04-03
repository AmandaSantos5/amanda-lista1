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
    public partial class Form6_amanda : Form
    {
        public Form6_amanda()
        {
            InitializeComponent();
        }
        double volume, raio, altura, pi;

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

        private void button1_Click(object sender, EventArgs e)
        {
            raio = Convert.ToDouble(textBox1.Text);
            altura = Convert.ToDouble(textBox2.Text);
            pi = Math.PI;
            volume = pi * (raio * raio) * altura;
            label5.Text = volume.ToString();
        }
    }
}
