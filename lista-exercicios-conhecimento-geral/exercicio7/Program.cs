// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

// 1. ler 15 numeros e guarda-los num vetor(array)
// 2. escrever os 15 numeros na ordem inversa da qual foi escrita/declarada

int[] numeros = new int[15];
for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"Insira o {i + 1}º");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Os numeros digitados na ordem inversa ficarão da seguinte maneira:");

foreach (int item in numeros.Reverse())
{
    Console.WriteLine($"{item}");
}



