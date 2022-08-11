using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double F, C,K ;
            C = Convert.ToDouble(Ctxt.Text);
            F = C * (9 / 5) + 32;
            Ftxt.Text = F + "";
            K = C + 273.15;
            Ktxt.Text = K + "";







        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ftxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
