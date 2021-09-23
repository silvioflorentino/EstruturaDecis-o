using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaDecisão
{
    public partial class TelaEstrutura : Form
    {
        public TelaEstrutura()
        {
            InitializeComponent();
        }

        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            int num01 = Convert.ToInt32(nNum01.Value);
            int num02 = Convert.ToInt32(nNum02.Value);
            int num03 = Convert.ToInt32(nNum03.Value);
            int maior;
            if (num01 == num02 && num02 == num03)
            {
                lblResultado.Text = "Valores São Iguais";
                return;
            }

            if (num01 == num03 && num01 > num02 && num03 > num02)
            {
                lblResultado.Text = "Valores "+ num01 +" e  "+ num03 + " São maiores.";
                return;
            }

            if (num02 == num03 && num02 > num01 && num03 > num01)
            {
                lblResultado.Text = "Valores " + num02 + " e  " + num03 + " São maiores.";
                return;
            }

            if (num01 == num02 && num01 > num03 && num02 > num03)
            {
                lblResultado.Text = "Valores " + num01 + " e  " + num02 + " São maiores.";
                return;
            }

            if (num01 > num02 && num01 > num03)
            {
                maior = num01;
            }else if(num02 > num01 && num02 > num03)
            {
                maior = num02;
            }
            else
            {
                maior = num03;
            }

            lblResultado.Text = "O número " + maior + " é o maior.";

        }
    }
}
