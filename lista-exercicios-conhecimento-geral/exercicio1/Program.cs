// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu)
Console.WriteLine($"estamos no ano {DateTime.Now.Year}");

Console.WriteLine($"Insira o ano em que você nasceu:");
int ano = int.Parse(Console.ReadLine());

int idade = (DateTime.Now.Year - ano);

if (idade > 16 )
{
    Console.WriteLine($"Você pode votar");
}

else
{
Console.WriteLine($"Você não pode votar");

}

