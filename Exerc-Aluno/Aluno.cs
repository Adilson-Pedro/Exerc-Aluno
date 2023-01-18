using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_Aluno
{
    internal class Aluno
    {

        // Atributos

        public string Nome;
        public double Nota1, Nota2, Nota3;


        public double CalcularNota()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (CalcularNota() >= 60.0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - CalcularNota();
            }




        }
    }
}   
