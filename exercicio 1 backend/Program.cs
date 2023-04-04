// 1)
// Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos.
// Imprima o resultado no console.


Console.WriteLine($"Bem vindo ao nosso sistema");

Console.WriteLine($"Insira a sua idade");
int idade = int.Parse(Console.ReadLine());

int meses = (idade * 12);
int dias = (idade * 365);
int horas = (idade * 24);
int minutos = (idade * 60);
Console.WriteLine($" Você tem {idade} anos {meses} meses {dias} dias {horas} horas {minutos} e minutos de vida");






