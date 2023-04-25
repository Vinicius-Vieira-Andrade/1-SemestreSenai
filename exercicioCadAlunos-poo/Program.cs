// ********************************** 2º parte da aula ****************************************
// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.
// Crie uma classe Aluno com as seguintes propriedades:
// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.
// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
// Acrescente o que achar necessário.
using exercicioCadAlunos_poo;

Aluno a1 = new Aluno(); //INSTANCIAR UM OBJETO DA CLASSE ALUNO

Console.WriteLine($"Digite o valor da sua mensalidade: ");
a1.valorMensalidade = float.Parse(Console.ReadLine()!);
Console.WriteLine($"Insira sua media");
a1.mediaFinal = float.Parse(Console.ReadLine()!);


Console.WriteLine($"Insira o seu nome");
a1.nome = Console.ReadLine()!;
Console.WriteLine($"Insira o seu curso");
a1.curso = Console.ReadLine()!;
Console.WriteLine($"Digite sua idade");
a1.idade = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Insira seu RG");
a1.rg = Console.ReadLine()!;

checkBolsa: //CHECKPOINT
Console.WriteLine(@$"
Você é bolsista?
Resposta 's' para sim e 'n' para não 
");
string respostaBolsa = Console.ReadLine()!.ToLower();

if (respostaBolsa == "s")
{
    a1.bolsista = true;
}

else if (respostaBolsa == "n")
{
    a1.bolsista = false;
}

else
{
    Console.WriteLine($"Resposta inválida, insira uma resposta válida");
    goto checkBolsa;
}


Console.WriteLine($"Cadastro realizado com sucesso!");

opcao:
Console.WriteLine(@$"

    Menu opções

    (1) para ver media

    (2) para ver mensalidade

");

string opcao = Console.ReadLine()!;

switch (opcao)
{
    case "1":
        a1.VerMediaFinal();
        break;
    case "2":
        Console.WriteLine($"A sua mensalidade é: {a1.VerMensalidade()}");

        break;
    default:
        Console.WriteLine($"Opção inválida, tente novamente");
        goto opcao;
}

