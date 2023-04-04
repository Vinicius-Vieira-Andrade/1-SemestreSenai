// 1)Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013

Console.WriteLine($"Insira o dia do seu aniversário: ");
int diaAniversario = int.Parse(Console.ReadLine());

if (diaAniversario < 31 && diaAniversario > 1)
{
    Console.WriteLine($"Dia valido");
}


Console.WriteLine($"Insira o mês do seu aniversário: ");
int mesAniversario = int.Parse(Console.ReadLine());

if (mesAniversario < 12 && mesAniversario > 1)
{
    Console.WriteLine($"Mês valido");
    
}


Console.WriteLine($"Insira o ano do seu nascimento: ");
int anoAniversario = int.Parse(Console.ReadLine());

if (anoAniversario < 2013 && anoAniversario > 1800)
{
    Console.WriteLine($"Data valido");
    
}

else
{
    Console.WriteLine($"Data invalido");

}



