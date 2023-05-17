using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final_Sprint3
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }

        List<Produto> listaProdutos = new List<Produto>();

        public void Cadastrar()
        {
            Usuario usu = new Usuario();
            Produto adicionaProdutosListaProdutos = new Produto();

            Console.WriteLine($"Quantos produtos deseja cadastrar? Máximo 3");
            int respostaProdutos = int.Parse(Console.ReadLine()!);
            if (respostaProdutos > 0 && respostaProdutos < 4)
            {
                for (var i = 0; i < respostaProdutos; i++)
                {
                    Console.WriteLine($"Insira o nome do produto(os): ");
                    adicionaProdutosListaProdutos.NomeProduto = Console.ReadLine()!;
                    Console.WriteLine($"Insira o código do produto(os): ");
                    adicionaProdutosListaProdutos.Codigo = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Insira o preço do produto(os): ");
                    adicionaProdutosListaProdutos.Preco = float.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Qual o nome da marca do produto>: ");

                    listaProdutos.Add(adicionaProdutosListaProdutos);
                }
            }

        }
        public void listar()
        {
            
        }
        public void Deletar(int codigo)
        {

        }
    }
}