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
    public partial class Form10_amanda : Form
    {
        public Form10_amanda()
        {
            InitializeComponent();
        }
        double comprimento, largura, altura, volume;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comprimento = Convert.ToDouble(textBox1.Text);
                largura = Convert.ToDouble(textBox2.Text);
                altura = Convert.ToDouble(textBox3.Text);

                volume = comprimento * (largura * altura);
                label5.Text = volume.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira um valor válido nos campos.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
