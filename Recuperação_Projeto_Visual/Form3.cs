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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular1_Click(object sender, EventArgs e)
        {
            Double diametro, raio, AreaDoCirculo, Pi;
            diametro = Convert.ToDouble(txtCirculo.Text);
            Pi = 3.14;
            raio = Convert.ToDouble(txtCirculo.Text);
            AreaDoCirculo = Pi * Math.Pow (raio, 2);

            if (Double.TryParse(txtCirculo.Text, out diametro))
            {
                AreaDoCirculo = Pi * Math.Pow (raio, 2);
            }

             if (rbCirculo.Checked)
            {
               lblResult1.Text = AreaDoCirculo.ToString();
            }
            else
            {
                lblResult1.Text = "Selecione o diâmetro para calcular a área!";
            }  
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC, perimetro;
            ladoA = Convert.ToDouble(txtri1.Text);
            ladoB = Convert.ToDouble(txtri2.Text);
            ladoC = Convert.ToDouble(txtri3.Text);

            if (double.TryParse(txtri1.Text, out ladoA) || ladoA < 0 ||
                double.TryParse(txtri2.Text, out ladoB) || ladoB < 0 ||
                double.TryParse(txtri3.Text, out ladoC))
            {
      
             if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
                {
                    perimetro = ladoA + ladoB + ladoC;
                    lblResult2.Text = perimetro.ToString();
                    lblResult3.Text = "Os lados digitados são validos";
                }
                else
                {
                    lblResult3.Text = "Os lados digitados não são validos";
                }
            }
        }

        private void btnCalcular3_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC, ladoD, perimetro;
            ladoA = Convert.ToDouble(txtqua1.Text);
            ladoB = Convert.ToDouble(txtqua2.Text);
            ladoC = Convert.ToDouble(txtqua3.Text);
            ladoD = Convert.ToDouble(txtqua4.Text);

            if (double.TryParse(txtqua1.Text, out ladoA) || ladoA > 0 ||
                double.TryParse(txtqua2.Text, out ladoB) || ladoB > 0 ||
                double.TryParse(txtqua3.Text, out ladoC) || ladoC > 0 ||
                double.TryParse(txtqua4.Text, out ladoD))
            {
               if (ladoA > 0 && ladoB > 0 && ladoC > 0 && ladoD > 0)
                {


                    if (ladoA + ladoB + ladoC > ladoD && ladoA + ladoB + ladoD > ladoC && ladoA + ladoC + ladoD > ladoB && ladoB + ladoC + ladoD > ladoA)
                    {
                    perimetro = ladoA + ladoB + ladoC + ladoD;
                        lblResult5.Text = perimetro.ToString();
                        lblResult6.Text = "Os lados digitados são validos";
                    }
                    else
                    {
                        lblResult6.Text = "Os lados digitados não são validos";
                    }
                }
                else
               {
                    lblResult6.Text = "Digite vslores númericos em todos os lados";
                }
            }
       }

        private void lblResult6_Click(object sender, EventArgs e)
        {

        }

        private void lblResult5_Click(object sender, EventArgs e)
        {

        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            lbldiâmetro.Visible = false;
            txtCirculo.Visible = false;
            btnCalcular1.Visible = false;
            lblResult1.Visible = false;
            lbltri1.Visible = true;
            txtri1.Visible = true;
            lbltri2.Visible = true;
            txtri2.Visible = true;
            lbltri3.Visible = true;
            txtri3.Visible = true;
            btnCalcular2.Visible = true;
            lblResult2.Visible = true;
            lblResult3.Visible = true;
            lblqua1.Visible = false;
            txtqua1.Visible = false;
            lblqua2.Visible = false;
            txtqua2.Visible = false;
            lblqua3.Visible = false;
            txtqua3.Visible = false;
            lblqua4.Visible = false;
            txtqua4.Visible = false;
            btnCalcular3.Visible = false;
            lblResult5.Visible = false;
            lblResult6.Visible = false;
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            lbldiâmetro.Visible = true;
            txtCirculo.Visible = true;
            btnCalcular1.Visible = true;
            lblResult1.Visible = true;
            lbltri1.Visible = false;
            txtri1.Visible = false;
            lbltri2.Visible = false;
            txtri2.Visible = false;
            lbltri3.Visible = false;
            txtri3.Visible = false;
            btnCalcular2.Visible = false;
            lblResult2.Visible = false;
            lblResult3.Visible = false;
            lblqua1.Visible = false;
            txtqua1.Visible = false;
            lblqua2.Visible = false;
            txtqua2.Visible = false;
            lblqua3.Visible = false;
            txtqua3.Visible = false;
            lblqua4.Visible = false;
            txtqua4.Visible = false;
            btnCalcular3.Visible = false;
            lblResult5.Visible = false;
            lblResult6.Visible = false;
        }



        private void rbquadrilátero_CheckedChanged(object sender, EventArgs e)
        {
            lbldiâmetro.Visible = false;
            txtCirculo.Visible = false;
            btnCalcular1.Visible = false;
            lblResult1.Visible = false;
            lbltri1.Visible = false;
            txtri1.Visible = false;
            lbltri2.Visible = false;
            txtri2.Visible = false;
            lbltri3.Visible = false;
            txtri3.Visible = false;
            btnCalcular2.Visible = false;
            lblResult2.Visible = false;
            lblResult3.Visible = false;
            lblqua1.Visible = true;
            txtqua1.Visible = true;
            lblqua2.Visible = true;
            txtqua2.Visible = true;
            lblqua3.Visible = true;
            txtqua3.Visible = true;
            lblqua4.Visible = true;
            txtqua4.Visible = true;
            btnCalcular3.Visible = true;
            lblResult5.Visible = true;
            lblResult6.Visible = true;
        }
    }
}
