// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

using System.Globalization;

Console.WriteLine($"Insira o produto:");
string nomeProduto = Console.ReadLine()!;

Console.WriteLine($"Insira a quantidade desejada: ");
int quantidadeProduto = int.Parse(Console.ReadLine())!;

Console.WriteLine($"Insira o preço do produto: ");
float precoProduto = float.Parse(Console.ReadLine())!;

float total = quantidadeProduto * precoProduto;
float resposta;
float totalDesconto;

if (quantidadeProduto <= 5)
{
    resposta = total * 2 / 100;
    totalDesconto = total - resposta;
}

else if (quantidadeProduto > 5 && quantidadeProduto <= 10)
{
    resposta = total * 3 / 100;
    totalDesconto = total - resposta;
}

else
{
    resposta = total * 5 / 100;
    totalDesconto = total - resposta;
}

Console.WriteLine($" o total deu: {total.ToString("C", new CultureInfo("pt-BR"))} e o total com desconto deu: {totalDesconto.ToString("C", new CultureInfo("pt-BR"))}");

