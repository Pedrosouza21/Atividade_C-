using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia, mes, ano;
            string data;
            data = txtData.Text;
            

            dia = int.Parse(data.Substring(0, 2));
            mes = int.Parse(data.Substring(2, 2));
            ano = int.Parse(data.Substring(4, 4));
            if (dia > 0 && dia < 32 && mes > 0 && mes < 13 && ano > 0)
            { resultxt.Text = dia + "/" + mes + "/" + ano; }
            else{ resultxt.Text = "data inexistente"; }

            
            
            

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtdia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void resultxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
