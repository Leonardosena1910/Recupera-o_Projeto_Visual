using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperação_Projeto_Visual
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Metros, Massa_Corporal, IMC;
            Metros = Convert.ToDouble(txtAltura.Text);
            Massa_Corporal = Convert.ToDouble(txtPeso.Text);
            IMC = Massa_Corporal / (Metros * Metros);

            if (rbHomem.Checked)
            {
                if (IMC < 20)
                {
                    lblResultado.Text = "Abaixo do normal";
                }
                else if (IMC >= 20 && IMC <= 24.9)
                {
                    lblResultado.Text = "Normal";
                }
                else if (IMC >= 25 && IMC <= 29.9)
                {
                    lblResultado.Text = "Obesidade leve";
                }
                else if (IMC >= 30 && IMC <= 39.9)
                {
                    lblResultado.Text = "Obesidade moderada";
                }
                else if (IMC > 39.9)
                {
                    lblResultado.Text = "Obesidade mórbida";
                }
            }
            else if (rbMulher.Checked)
            {
                if (IMC < 19)
                {
                    lblResultado.Text = "Abaixo do normal";
                }
                else if (IMC >= 19 && IMC <= 23.9)
                {
                    lblResultado.Text = "Normal";
                }
                else if (IMC >= 24 && IMC <= 28.9)
                {
                    lblResultado.Text = "Obesidade leve";
                }
                else if (IMC >= 29 && IMC <= 38.9)
                {
                    lblResultado.Text = "Obesidade moderada";
                }
                else if (IMC > 38.9)
                {
                    lblResultado.Text = "Obesidade morbida";
                }
            }
            else
            {
                MessageBox.Show("Selecione o sexo");
            }
         }
      }
   }

