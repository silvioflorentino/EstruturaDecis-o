using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDecisão
{
    public class CalculoSe
    {
       public string Calcular(int num01, int num02, int num03)
        {

           int maior;
           string resul;
            
            if (num01 == num02 && num02 == num03)
            {
                resul = "Valores São Iguais";
                return resul;
            }

            if (num01 == num03 && num01 > num02 && num03 > num02)
            {
                resul = "Valores " + num01 + " e  " + num03 + " São maiores.";
                return resul;
            }

            if (num02 == num03 && num02 > num01 && num03 > num01)
            {
                resul = "Valores " + num02 + " e  " + num03 + " São maiores.";
                return resul;
            }

            if (num01 == num02 && num01 > num03 && num02 > num03)
            {
                resul = "Valores " + num01 + " e  " + num02 + " São maiores.";
                return resul;
            }
           
            if (num01 > num02 && num01 > num03)
            {
                maior = num01;
                return "O número " + maior + " é o maior.";
            }
            else if (num02 > num01 && num02 > num03)
            {
                maior = num02;
                return "O número " + maior + " é o maior.";
            }
            else
            {
                maior = num03;
                resul = "O número " + maior + " é o maior.";
                return resul;
            }
            
           // return maior;
        }
    }
}
