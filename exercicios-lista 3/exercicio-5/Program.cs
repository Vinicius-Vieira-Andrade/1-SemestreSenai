// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.
float mediaMulherIdade = 0;
float mediaHomemIdade = 0;
float peso;
char sexo;

int totalMulher = 0;
int totalHomem = 0;


for (var i = 1; i <= 10; i++)
{
    Console.WriteLine(@$"
    Qual seu sexo?
    (m) - Masculino
    (f) - Feminino
    ");

    sexo = char.Parse(Console.ReadLine().ToLower());

    if (sexo == 'f')
    {
        totalMulher++;
        Console.WriteLine($"Informe sua idade: ");
        int idadeMulher = int.Parse(Console.ReadLine());
        
    }
    else
    {
        totalHomem++;
         Console.WriteLine($"Informe sua idade: ");
        int idadeHomem = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine($"Total de homens: {totalHomem}");
Console.WriteLine($"Total de mulheres: {totalMulher}");
Console.WriteLine($"Média de idade dos homens: {idadeHomem}");












