using System;
using System.Globalization;

namespace ClassesAtributosMetodos_4
{
    internal class Program
    {
        static void Main(string[] args) { 

        

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário (a): ");
            Console.Write("Nome: " );
            p1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segunda funcionário (a): ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (p1.salario + p2.salario) / 2 ;
            Console.WriteLine();

            Console.WriteLine("Salário médio = " + mediaSalario.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}