using System.Globalization;
namespace Construtor
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome,double preco,int quantidade)//Construtor geralmente é depois dos atributos
        {//Não faz sentido um nome nulo,preço valendo zero,quantidade 0?Então pra evitar um produto sem nome,sem preço,quantidade
         //Então obrigamos a iniciação com valor criando um construtor,ai o programador vai ser obrigado  informa valores na hora de instanciar produtos.
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}