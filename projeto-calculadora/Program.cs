//calculadores

//Algoritimo
// 1. informar operação
// 2. informa primeiro número 
// 3. informa segundo número 
// 4. processar dados
// 5. exibe os resultados

Console.WriteLine(@$"

|-------------------------------|
|    Programa de calculadora    |
|                               |
|       informe a operação      |
|                               |
|        (+) Adição             |
|        (-) Subtração          |
|        (*) Multiplicação      |
|        (/) Divisão            |
|                               |
|                               |
|-------------------------------|

");
Console.WriteLine($"Informe a operação: ");
char operação = char.Parse(Console.ReadLine());

Console.WriteLine($"Informe o primero número: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo número");
double num2 = double.Parse(Console.ReadLine());

double resultado = 0;

switch (operação)
{
    case '+':
        resultado = (num1 + num2);
        Console.WriteLine($"A conta deu: {resultado}");
        break;

    case '-':
        resultado = (num1 - num2);
        Console.WriteLine($"A conta deu: {resultado}");
        break;

    case '*':
        resultado = (num1 * num2);
        Console.WriteLine($"A conta deu: {resultado}");
        break;

    case '/':
        resultado = (num1 / num2);
        Console.WriteLine($"A conta deu: {resultado}");
        break;

    default:
        Console.WriteLine($"Operação inválida, repita o processo!!!");
        break;
}





