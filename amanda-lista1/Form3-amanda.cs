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
    public partial class Form3_amanda : Form
    {
        public Form3_amanda()
        {
            InitializeComponent();
        }
        double ht, vh, pd, sb, td, sl;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            label6.Text = "";
            label4.Text = "";
            label9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            ht = Convert.ToDouble(textBox1.Text);
            vh = Convert.ToDouble(textBox4.Text);
            pd = Convert.ToDouble(textBox2.Text);
            sb = ht * vh;
            label6.Text = sb.ToString("F2");

            pd = Convert.ToDouble(textBox2.Text);
            td = (pd / 100) * sb;
            label4.Text = td.ToString("F2");

            sl = sb - td;
            label9.Text = sl.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira um valor válido nos campos.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
