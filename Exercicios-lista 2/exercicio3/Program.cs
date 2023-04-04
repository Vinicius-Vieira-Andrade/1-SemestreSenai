// 3)Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

Console.WriteLine($"Qual o raio da circunferência?: ");
float raio = float.Parse(Console.ReadLine());

float diâmetro = (raio * 2);
double comprimento = (2 * Math.PI * raio);
double área = (Math.PI * Math.Pow(raio, 2));

Console.WriteLine($"O diâmetro é {diâmetro}");
Console.WriteLine($"O comprimento é {comprimento}");
Console.WriteLine($"O área é {área}");






