// 3)Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.


Console.WriteLine($"Insira o primeiro lado do triângulo: ");
float primeiroLado = float.Parse(Console.ReadLine());
Console.WriteLine($"Insira o segundo lado do triângulo: ");
float segundoLado = float.Parse(Console.ReadLine());
Console.WriteLine($"Insira o terceiro lado do triângulo: ");
float terceiroLado = float.Parse(Console.ReadLine());

if (primeiroLado == segundoLado && terceiroLado == segundoLado && primeiroLado == terceiroLado)
{
    Console.WriteLine($"O triângulo é equilatero/igual");
}

else if (primeiroLado != segundoLado && segundoLado != terceiroLado && terceiroLado!= primeiroLado)
{
    Console.WriteLine($"O triângulo é escaleno/3 lados diferentes");
}

else
{
    Console.WriteLine($"O triângulo é isóscele/ 2 lados igual");
}

