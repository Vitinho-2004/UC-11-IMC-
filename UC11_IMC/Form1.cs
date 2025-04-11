using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_IMC
{
    public partial class Form1 : Form
    {
        string funcao_buttonCALCULAR;
        public Form1()
        {
            InitializeComponent();

            funcao_buttonCALCULAR = "C";
        }

        private void labelALTURA_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCLICK_Click(object sender, EventArgs e)
        {
            if (funcao_buttonCALCULAR == "C") 
            {
                double ALTURA = 0;
                double PESO = 0;
                double Resultado = 0;



                ALTURA = Convert.ToDouble(textBoxNUM1.Text.Replace(".", ","));
                PESO = Convert.ToDouble(textBoxNUM2.Text.Replace(".", ","));

                Resultado = PESO / (ALTURA * ALTURA);

                labelIMC.Text = Resultado.ToString("00.00");

                if (Resultado > 30)
                {
                    labelCategoria2.Text = "VOCE ESTA OBESO ";

                }
                else if (Resultado > 25)
                {
                    labelCategoria2.Text = "VOCE ESTA COM SOBRE PESO";
                }
                else if (Resultado > 18.5)
                {
                    labelCategoria2.Text = "VOCE ESTA COM PESO NORMAL";
                }
                else if (Resultado < 18.5)
                {
                    labelCategoria2.Text = "VOCE ESTA ABAIXO DO PESO";
                }


                funcao_buttonCALCULAR = "L";
                buttonCLICK.Text = "Limpar...";
                textBoxNUM1.Enabled = false;
                textBoxNUM2.Enabled = false;

            }else
            {
                textBoxNUM1.Text = string.Empty;
                textBoxNUM2.Text = string.Empty;
                labelIMC.Text = "0,00";
                labelCategoria2.Text = "Voce está...";

                funcao_buttonCALCULAR = "C";
                buttonCLICK.Text = "Calcular...";
                textBoxNUM1.Enabled = true;
                textBoxNUM2.Enabled = true;

            }
           
           
        }

        private void labelIMC_Click(object sender, EventArgs e)
        {
            
        }

        private void labelCATEGORIA_Click(object sender, EventArgs e)
        {
            
        }

        private void labelCategoria2_Click(object sender, EventArgs e)
        {

        }
    }
}
