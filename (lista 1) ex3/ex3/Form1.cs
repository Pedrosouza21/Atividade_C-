using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, divisores = 0;
            n =  Convert.ToInt32(txtvalor.Text);
            
            if (n % 2 == 0)
            {
                txtparouimpar.Text = "par";
            }
            else { txtparouimpar.Text = "impar"; }
            
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        divisores++;
                    }

                }

            if (divisores == 2)
            {
                txtprimo.Text = "é primo";
            }
            else { txtprimo.Text = "não é primo"; }
            if (n == 0) { txtparouimpar.Text = "ZERO"; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
