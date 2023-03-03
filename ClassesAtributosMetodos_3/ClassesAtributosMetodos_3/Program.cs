using System.Threading.Channels;

namespace ClassesAtributosMetodos_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1,pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());


            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Pessoa mais velha : " + pessoa1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha : " + pessoa2.nome);
            }
        }
    }
}