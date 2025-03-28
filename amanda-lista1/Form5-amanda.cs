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
    public partial class Form5_amanda : Form
    {
        public Form5_amanda()
        {
            InitializeComponent();
        }
        double cel, fah;

        private void button1_Click(object sender, EventArgs e)
        {
            cel = (fah - 32) - (5 / 9);
        }
    }
}
