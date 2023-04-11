//SEM ARRAY
// string carro1;
// string carro2;
// string carro3;

// Console.WriteLine($"digite o nome do carro: ");
// carro1 = Console.ReadLine();
// Console.WriteLine($"digite o nome do carro: ");
// carro2 = Console.ReadLine();
// Console.WriteLine($"digite o nome do carro: ");
// carro3 = Console.ReadLine();

// Console.WriteLine($"{carro1}, {carro2}, {carro3}");




//------------------------------------------------------------------------------------------------------------------------------------//

//COM ARRAY string diferenciada, que guarda varios valores

//CRIAMOS UMA VARIAVEL DE ARRAY DO TIPO STRING COM CAPACIDADE DE ARMAZENAR 3 CARROS/DADOS

// string[] carros = new string[3];

// Console.WriteLine($"Digite o nome do carro: ");
// carros[0] = Console.ReadLine();
// carros[1] = Console.ReadLine();
// carros[2] = Console.ReadLine();

// Console.WriteLine($"O primeiro carro da lista: {carros[0]}");
// Console.WriteLine($"O segundo carro da lista: {carros[1]}");
// Console.WriteLine($"O terceiro carro da lista: {carros[2]}");


//------------------------------------------------------------------------------------------------------------------------------------//

//Com arrays e for, considerando boas praticas evitando repeticao de codigo

string[] carros = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o {i + 1}º nome do carro: ");
    carros[i] = Console.ReadLine();
}


for (int i = 0; i < 300; i++)
{
    Console.WriteLine($"Nome do {i + 1}º carro é {carros[i]}");
//{I + 1} COMECA A CONTAGEM A PARTIR DO 1 DANDO A SOMA DE I = 0 ENTAO 0 + 1 = 1 OU I + 1 = 1
}

//foreach (var item in carros) PARA TODOS OS VALORES DENTRO DA ARRAY/NUM ESCOPO INTEIRO
// {
//     Console.WriteLine($"Nome do carro {item}");
// }