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

            CalculoSe CalculoSe = new CalculoSe();
            string maior=  CalculoSe.Calcular(num01, num02, num03);

            lblResultado.Text = maior;
           // lblResultado.Text = "O número " + maior + " é o maior.";

        }
    }
}
