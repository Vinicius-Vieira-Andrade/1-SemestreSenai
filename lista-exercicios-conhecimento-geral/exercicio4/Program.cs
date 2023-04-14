// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.'

int[] valores = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Insira um numero");
    valores[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"O valor máximo é: {valores.Max()} e o valor mínimo é: {valores.Min()}");