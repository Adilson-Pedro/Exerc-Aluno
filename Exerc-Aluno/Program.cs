using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno A = new Aluno();

            Console.Write("Nome do Aluno: ");
            A.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            Console.Write("Nota 1: ");
            A.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Nota 2: ");
            A.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Nota 3: ");
            A.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("NOTA FINAL = " + A.CalcularNota().ToString("F2", CultureInfo.InvariantCulture));

            if (A.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + A.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
