using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final_Sprint3
{
    public class Login
    {
        public bool Logado { get;  set; }

        public Login()
        {
        }

        public string Logar(Usuario)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return "LOGIN EFETUADO COM SECESSO!!!";
            Console.ResetColor();
        }

        public string Deslogar(Usuario)
        {
            return "Deslogado com suceesso!!!";
        }
    }
}