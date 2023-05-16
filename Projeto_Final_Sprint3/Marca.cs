using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final_Sprint3
{
    public class Marca
    {
        List<Marca> marcas = new List<Marca>();

        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadasstro { get; set; }

        public string Cadastrar(Marca)
        {

        }

        public void listar()
        {
            if (marcas.Count > 0)
            {
                foreach (var item in marcas)
                {
                    Console.WriteLine(@$"
                    Código da Marca: {item.Codigo}
                    Nome da marca: {item.NomeMarca}
                    Data do cadastro: {item.DataCadasstro}
                ");
                }
            }

            else
            {
                Console.WriteLine($"Não é possível listar, pois não tem marcas cadastradas!");
            }

        }
    }
}