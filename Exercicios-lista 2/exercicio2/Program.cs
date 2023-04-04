// 2)Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"Insira o primeiro o número:");
float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira o segundo o número:");
float numero2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira o terceiro o número:");
float numero3 = float.Parse(Console.ReadLine());

List<float> maiorMenor = new List<float> {numero1, numero3, numero3};

Console.WriteLine($"O maior número dos três informados é o: {maiorMenor.Max()}");

Console.WriteLine($"O menor número dos três informados é o: {maiorMenor.Min()}");



