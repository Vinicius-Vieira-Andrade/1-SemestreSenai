using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final_Sprint3
{
    public class Marca
    {
        List<Marca> listaMarcas = new List<Marca>();

        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public void Cadastrar()
        {
            Marca marcaAdicionaListaMarcas = new Marca();
            Console.WriteLine($"Quantas marcas deseja cadastrar? Máximo 3");
            int respostaMarcas = int.Parse(Console.ReadLine()!);
            if (respostaMarcas > 0 && respostaMarcas < 4)
            {
                for (var i = 0; i < respostaMarcas; i++)
                {
                    Console.WriteLine($"Insira o nome da marcas(as): ");
                    marcaAdicionaListaMarcas.NomeMarca = Console.ReadLine()!;
                    Console.WriteLine($"Insira o código da marcas(as): ");
                    marcaAdicionaListaMarcas.Codigo = int.Parse(Console.ReadLine()!);

                    listaMarcas.Add(marcaAdicionaListaMarcas);
                }
            }
        }
        public void listar()
        {
            if (listaMarcas.Count > 0)
            {
                foreach (var item in listaMarcas)
                {
                    Console.WriteLine(@$"
                    Código da Marca: {item.Codigo}
                    Nome da marca: {item.NomeMarca}
                    Data do cadastro: {item.DataCadastro}
                ");
                }
            }

            else
            {
                Console.WriteLine($"Não é possível listar, pois não tem marcas cadastradas!");
            }
        }

        public void Deletar(int codigo)
        {

        }
    }
}




