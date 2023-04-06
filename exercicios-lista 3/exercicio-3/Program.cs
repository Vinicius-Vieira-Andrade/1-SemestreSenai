// 3. Faça um programa que receba um número inteiro e mostre a sua tabuada

Console.WriteLine($"Insira uma número inteiro para ser multiplicado: ");
int numero = int.Parse(Console.ReadLine());

for (int y = 0; y <= 10; y+=1)
{
    Console.WriteLine($"{numero} x {y} = {numero * y}");
    
}