using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final_Sprint3
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login()
        {
            Usuario user = new Usuario();
            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {
        // voltarUser:
            Console.WriteLine($"Informe o Email: ");
            string emailDigitado = Console.ReadLine()!;

            Console.WriteLine($"Informe a senha:");
            string senhaDigitada = Console.ReadLine()!;

            if (emailDigitado == usuario.Email && senhaDigitada == usuario.Senha)
            {
                this.Logado = true;
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Email e/ou Senha inválido, Digite novamente");
                // goto voltarUser;
            }
        }

        public string Deslogar(Usuario usuario)
        {
            Logado = false;
            return "Deslogado com suceesso!!!";
        }

        public void GerarMenu()
        {
            Produto produtos = new Produto();
            Marca marcas = new Marca();
            string opcoes;

            do
            {
                Console.WriteLine(@$"
            
            ====>Menu Opções<====
            [1] - Cadastrar Produto
            [2] - Remover Produto
            [3] - Listar Produtos
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marcas

            [0] - Sair
            ");

                opcoes = Console.ReadLine()!;
                switch (opcoes)
                {
                    case "1":
                        produtos.Cadastrar();
                        break;
                    case "2":
                        Console.WriteLine($"Insira o código do produto a ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine()!);
                        produtos.Deletar(codigoProduto);
                        break;
                    case "3":
                        produtos.listar();
                        break;
                    case "4":
                        marcas.Cadastrar();
                        break;
                    case "5":
                        marcas.listar();
                        break;
                    case "6":
                        Console.WriteLine($"Insira o código da marca a ser removida: ");
                        int codigoMarca = int.Parse(Console.ReadLine()!);
                        marcas.Deletar(codigoMarca);
                        break;
                    case "0":
                        Console.WriteLine($"Saindo do programa, obrigado!");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida, escolha uma opção correta!");
                        break;
                }
            } while (opcoes != "0");

        }
    }
}


