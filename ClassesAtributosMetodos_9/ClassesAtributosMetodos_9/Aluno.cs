
using System.Security.Cryptography.X509Certificates;

namespace ClassesAtributosMetodos_9
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;


        public double NotaTrimestral()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaTrimestral() >= 60.0)
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
                return 60.0 - NotaTrimestral();
            }
        }
    }
}
