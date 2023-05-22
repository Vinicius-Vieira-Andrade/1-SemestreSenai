using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final_Sprint3
{
    public class Marca
    {
        List<Marca> listaMarcas = new List<Marca>();

        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Marca Cadastrar()
        {
            Marca marcaAdicionaListaMarcas = new Marca();

            Console.WriteLine($"Insira o nome da marca: ");
            marcaAdicionaListaMarcas.NomeMarca = Console.ReadLine()!;
            Console.WriteLine($"Insira o código da marca: ");
            marcaAdicionaListaMarcas.Codigo = int.Parse(Console.ReadLine()!);

            marcaAdicionaListaMarcas.DataCadastro = DateTime.Now;

            listaMarcas.Add(marcaAdicionaListaMarcas);

            return marcaAdicionaListaMarcas;
        }
        public void listar()
        {
            if (listaMarcas.Count > 0)
            {
                foreach (var item in listaMarcas)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"\
                    --------------------------------------------
                        Código da Marca: {item.Codigo}
                        Nome da marca: {item.NomeMarca}
                        Data do cadastro: {item.DataCadastro}
                    --------------------------------------------
                ");
                }
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine($"Não é possível fazer a listagem, pois não existem marcas cadastradas!");
            }
        }

        public void Deletar(int codigo)
        {
            if (listaMarcas.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Marca mc = listaMarcas.Find(x => x.Codigo == codigo)!;
                listaMarcas.Remove(mc);
                Console.WriteLine($"A marca cujo o código é: {codigo} foi removido!");
                Console.ResetColor();
            }
             else
            {
                Console.WriteLine($"Não é possível deletar a marca, pois a mesma não foi cadastrada!");
            }

        }
    }
}




