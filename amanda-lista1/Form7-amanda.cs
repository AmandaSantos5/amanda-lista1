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
    public partial class Form7_amanda : Form
    {
        public Form7_amanda()
        {
            InitializeComponent();
        }
        double distancia, tempo, velocidadeMed, LitU;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tempo = Convert.ToDouble(textBox1.Text);
                velocidadeMed = Convert.ToDouble(textBox2.Text);
                distancia = tempo * velocidadeMed;
                LitU = distancia / 12;
                label8.Text = velocidadeMed.ToString();
                label9.Text = tempo.ToString(); 
                label10.Text = distancia.ToString();
                label11.Text = LitU.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira um valor válido nos campos.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
            
        
