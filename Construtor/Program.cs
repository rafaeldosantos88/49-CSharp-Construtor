using System;
using System.Globalization;

namespace Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Construtor: é uma operação especial da classe,que executa no momento da instanciação do objeto.
             * Uso Comuns:
             -Iniciar valor dos atributos.
             -permitir ou obriar que o objeto receba dados / dependências no momento de sua instanciação(injeção de depedência)
             •Se um construtor customizado não for especificado,a classe disponibiliza o construtor padrão.
             -Produto p= new Produto();
             •É possivel especificar mais de um construtor na mesma classe(Sobrecarga).*/

            
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Produto p = new Produto(nome, preco, quantidade);//Aqui instanciei o Produto


            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p); 
        }
    }
}



