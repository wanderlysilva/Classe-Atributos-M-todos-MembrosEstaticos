

using System.Globalization;

namespace ClassesAtributosMetodos_6
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTodalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos (int quantiade)
        {
            Quantidade += quantiade;
        }

        public void RemoverProduto (int quantiade)
        {
            Quantidade -= quantiade;
        }



        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTodalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
