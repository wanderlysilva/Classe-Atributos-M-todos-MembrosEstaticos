

using System.Globalization;

namespace ClassesAtributosMetodos_8
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentoSalario (double porcentagem)
        {
           Salario = Salario + (Salario * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
          
        }
    }
}
