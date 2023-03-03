using System.Globalization;

namespace MemborsEstaticos_1
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);


            Console.Write("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("Valor de PI: " + Pi.ToString("F2",CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        static double Volume (double r)
        {
            return 4.0 / 3.0 * Pi * r * r* r;
        }
    }
}