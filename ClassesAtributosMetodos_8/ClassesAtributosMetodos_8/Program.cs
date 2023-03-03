using System.Globalization;

namespace ClassesAtributosMetodos_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Saário bruto: ");
            f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double amt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentoSalario(amt);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);

        }
    }
}