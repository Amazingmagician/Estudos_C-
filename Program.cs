using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ResolvendoSegundoProblema {
    class Program {
        
        static void Main(string[] args) {
            Produto p = new Produto();
            Console.WriteLine("Entre os Dados do Produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantida no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: "+ p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados "+p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser Removidos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + p);

        }
    }
}
