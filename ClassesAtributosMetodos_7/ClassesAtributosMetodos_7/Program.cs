using System.Globalization;

namespace ClassesAtributosMetodos_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Retangulo r = new Retangulo(); 
            
            Console.WriteLine("Entre a largura e altura do retângulo");
            r.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

           
            Console.WriteLine("Area = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}