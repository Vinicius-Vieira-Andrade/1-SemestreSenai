using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final_Sprint3
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            Cadastrar();
        }
        public string Cadastrar()
        {
            return
            this.Nome = "vinicius";
            this.Email = "v";
            this.Senha = "123";
            this.DataCadastro = DateTime.UtcNow;
        }

        public void Deletar(Usuario usuario)
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
    }
}
