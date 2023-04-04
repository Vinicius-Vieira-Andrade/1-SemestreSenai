// 2) Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"Insira os gols do primeiro time");
int time1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Insira os gols do segundo time");
int time2 = int.Parse(Console.ReadLine());

if (time1 > time2)
{
    Console.WriteLine($"O vencedor foi o time1");
}

else if (time2 > time1)
{
    Console.WriteLine($"O vencedor foi o time2");
}

 else {
    Console.WriteLine($"Empate!");
 }



