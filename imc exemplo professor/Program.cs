// Programa IMC

Console.WriteLine(@$"

-------------------
|  Programa para  |
|  calcular IMC   |
-------------------

");

Console.WriteLine($"Informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Informe o peso do paciente: ");
float peso = float.Parse (Console.ReadLine());

Console.WriteLine("Informe a altura do paciente: ");
float altura = float.Parse (Console.ReadLine());

float imc = peso / ((float)Math.Pow(altura,2));

//concatenação
//Console.WriteLine("O paciente " + nome + " tem o IMC igual a: " + imc);

//interpolação
Console.WriteLine($"O paciente {nome} tem o imc igual a: {imc}");

Console.WriteLine($"Obrigado por utilizar nosso sistema");








