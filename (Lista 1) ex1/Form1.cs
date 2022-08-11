using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Lista_1__ex1
{
    public partial class Form1 : Form
    {
        int excelentex = 0, bomx = 0, regularx = 0, pessimox = 0, pesquisados = 0, masculino = 0, Feminino = 0, totalfeminino = 0, idade = 0, qtdidade = 0, idadesoma;

        private void textMasculino_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        double Totalmasculino, Porcentagemasculino, Porcentagemfeminino, contaidade, PorcentagemExcelente, PorcentagemBom, PorcentagemRegular, PorcentagemPessimo;
        private void button3_Click(object sender, EventArgs e)
        {
            //calcular a quantidade de pessoas que colocaram a idade
            qtdidade += 1;

            string sexo;
            double exelentedivisao;
            //caluclar idade



            //calcular pesquisados

            pesquisados += 1;
            textpesquisados.Text = pesquisados + "";
            //sexo 
            if (Femininobutton.Checked)
            {
                Feminino += 1;
                Femininotxt.Text = Feminino + "";
            }




            else if (Masculinobutton.Checked)
            {
                masculino += 1;
                textMasculino.Text = masculino + "";
            }



            //OPINIAO//
            if (Exelente.Checked)
            {

                excelentex = excelentex + 1;



            }
            if (Bom.Checked)
            {
                int bom = 0;
                bomx += 1;
            }
            if (Regular.Checked)
            {
                int regular = 0;
                regularx += 1;
            }
            if (pessimo.Checked)
            {
                int pessimo = 0;
                pessimox += 1;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //calcular idade
            idade = int.Parse(idadetxt.Text);
            if (idade > 0)
            {
                
                idade += idade;
                contaidade = idade / qtdidade;
                txtMidades.Text = contaidade + "";
            }
            //porcentagem masculino
            if (masculino < pesquisados)
            {
                Totalmasculino = pesquisados - Feminino;
            }
            else
            {
                Totalmasculino = Feminino - pesquisados;
            }
            if (masculino == 0) { Pmasculino.Text = "0 %"; }
            if (masculino == 1 && Feminino == 0)
            {
                Pmasculino.Text = "100%";
            }
            if (pesquisados > masculino)
            {
                Porcentagemasculino = Totalmasculino * 100 / pesquisados;
                Pmasculino.Text = Porcentagemasculino + "%";
            }
            if (masculino > pesquisados)
            {
                Porcentagemasculino = pesquisados * 100 / Totalmasculino;
                Pmasculino.Text = Porcentagemasculino + "%";
            }
            
            //porcentagem feminino
            if (Feminino == 0)
            {
                Femininotxt.Text = "0%";
            }
            if (Feminino < pesquisados)
            {
                totalfeminino = pesquisados - masculino;
            }
            else
            {
                totalfeminino = masculino - pesquisados;
            }
            // conta

            if (pesquisados > Feminino)
            {
                Porcentagemfeminino = totalfeminino * 100 / pesquisados;
                Pfeminino.Text = Porcentagemfeminino + "%";

            }

            else if (pesquisados > Feminino)
            {
                Porcentagemfeminino = totalfeminino * 100 / pesquisados;
                Pfeminino.Text = Porcentagemfeminino + "";
            }
            
            // verificador de 0
            if (excelentex == 0) { txtexcelente.Text = "0%"; }
            if (bomx == 0) { txtBom.Text = "0%"; }
            if (regularx == 0) { txtregular.Text = "0%"; }
            if (pessimox == 0) { txtpessimo.Text = "0%"; }
            //porcentagens das opinioes
            //exelente
            PorcentagemExcelente = excelentex * 100 / pesquisados;

            txtexcelente.Text = PorcentagemExcelente + "%";

            //bom
            PorcentagemBom = bomx * 100 / pesquisados;
            txtBom.Text = PorcentagemBom + "%";

            //regular
            PorcentagemRegular = regularx * 100 / pesquisados;
            txtregular.Text = PorcentagemRegular + "%";

            //pessimo
            PorcentagemPessimo = pessimox * 100 / pesquisados;
            txtpessimo.Text = PorcentagemPessimo + "%";



        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
