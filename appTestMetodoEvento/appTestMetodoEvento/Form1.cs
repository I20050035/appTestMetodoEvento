using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTestMetodoEvento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void btn0_Click(object sender, EventArgs e)
        //{
        //    lblNumeros.Text += "0";

        //}

        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    lblNumeros.Text += "1";
        //}

        private void MiMetodo_Click(object sender, EventArgs e)
        {
            lblNumeros.Text += ((Button)sender).Text;
        }
    }
}
