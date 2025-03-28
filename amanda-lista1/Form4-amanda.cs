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
    public partial class Form4_amanda : Form
    {
        public Form4_amanda()
        {
            InitializeComponent();
        }
        double cel, fah;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cel = Convert.ToDouble(textBox1.Text);
            fah = (9 * cel + 160)/5;
            label3.Text = fah.ToString();
        }
    }
}
