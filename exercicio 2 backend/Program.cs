// 2)
// Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos
// e semanas e imprima o resultado no console.

Console.WriteLine($"bem vindo ao nosso sistema");

Console.WriteLine($"insira o ano de nascimento");
int nascimento = int.Parse(Console.ReadLine()!);

int anos = (DateTime.Now.Year - nascimento);
int semanas = (nascimento * 52);

Console.WriteLine(@$"
Vôce tem:
 {anos} anos
 {semanas} semanas
");







