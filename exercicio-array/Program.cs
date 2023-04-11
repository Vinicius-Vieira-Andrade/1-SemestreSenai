//receber 5 nomes e idade de 5 pessoas
//personalizar resposta nome azul e resposta idade em verde (fonte)

// exemplo exibicao
// 1) nome: fulano
// idade: ?? anos

string[] nomes = new string[5];
int[] idade = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Insira seu nome:");
    nomes[i] = Console.ReadLine()!;
    Console.WriteLine($"Insira a sua idade:");
    idade[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < 5; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Nome: {nomes[i]}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"idade: {idade[i]} anos");
    Console.ResetColor();
}

