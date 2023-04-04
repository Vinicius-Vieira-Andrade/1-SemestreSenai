// 5)As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.WriteLine($"Digite quantas maçãs você comprou");
int maçã = int.Parse(Console.ReadLine());

if (maçã >= 12)
{
    float valor1 = (maçã * 0.25f);
    Console.WriteLine($"o total da compra foi: {Math.Round(valor1, 2)}");
    
}

else
{
    float valor2 = (maçã * 0.30f);
    Console.WriteLine($"o total da compra foi: {Math.Round(valor2, 2)}");
    
}



