using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final_Sprint3
{
    public class Usuario
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        
        // public Usuario()
        // {
        // }
        public void Cadastrarr(Usuario user)
        {
            bool validarCad = true;
            do
            {
                validarCad = false;
                Console.WriteLine($"Digite o email que você deseja cadastrar: ");
                Email = Console.ReadLine()!;
                Console.WriteLine($"Digite a senha que você deseja cadastrar: ");
                Senha = Console.ReadLine()!;
                Console.WriteLine($"Insira seu nome: ");
                Nome = Console.ReadLine()!;


                if (Email == "" && Senha == "")
                {
                    validarCad = true;
                    Console.WriteLine($"Não será aceito Email e Senha sem preenchimento!");
                }
                else if (Senha == Email)
                {
                    validarCad = true;
                    Console.WriteLine($"Não será aceito Emails e Senhas iguais!");
                }
            } while (validarCad);
            this.DataCadastro = DateTime.Now;
        }

        public void Deletar(Usuario _usuario)
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
    }
}
