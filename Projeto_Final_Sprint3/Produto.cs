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
        public Marca Marca { get; set; }
        public Usuario CadastradoPor { get; set; }

        List<Produto> _Produtos = new List<Produto>();

        public string Cadastrar(Produto)
        {
            return "Produto cadastrado com sucesso!";
        }
        public void listar()
        { 

        }
    }
}