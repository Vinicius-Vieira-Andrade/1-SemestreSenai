using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final_Sprint3
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro = new DateTime();
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; private set; }

        List<Produto> listaProdutos = new List<Produto>();

        public void Cadastrar(Usuario user)
        {

            Produto adicionaProdutosListaProdutos = new Produto();
            Marca m1 = new Marca();
            Usuario usu = new Usuario();
            adicionaProdutosListaProdutos.CadastradoPor = user;

            Console.WriteLine($"Insira o nome do produto: ");
            adicionaProdutosListaProdutos.NomeProduto = Console.ReadLine()!;
            Console.WriteLine($"Insira o código do produto: ");
            adicionaProdutosListaProdutos.Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Insira o preço do produto: ");
            adicionaProdutosListaProdutos.Preco = float.Parse(Console.ReadLine()!);

            adicionaProdutosListaProdutos.Marca = m1.Cadastrar();

            adicionaProdutosListaProdutos.DataCadastro = DateTime.Now;

            listaProdutos.Add(adicionaProdutosListaProdutos);
        }
        public void listar(Usuario user)
        {
            Usuario u = new Usuario();
            if (listaProdutos.Count > 0)
            {
                foreach (var item in listaProdutos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"
             <=>=<=><=>=<=><=>=<=><=>=<=><=>=<=><=>=<=><=>
                 Nome do produto: {item.NomeProduto}
                 Código do produto: {item.Codigo}
                 Preço do produto: {item.Preco:c2}
                 Nome da marca: {item.Marca.NomeMarca}
                 Cadastrado por: {item.CadastradoPor.Nome}
                 Data do cadastro: {item.DataCadastro}
             <=>=<=><=>=<=><=>=<=><=>=<=><=>=<=><=>=<=><=>
             ");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine($"Sem produtos cadastrados, não é possivel lista-los");
            }

        }
        public void Deletar(int codigo)
        {
            if (listaProdutos.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Produto rr = listaProdutos.Find(x => x.Codigo == codigo)!;
                listaProdutos.Remove(rr);
                Console.WriteLine($"O produto cujo o código é: {codigo} foi removido!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Não é possível deletar o produto, pois o mesmo não foi cadastrado!");
            }

        }
    }
}