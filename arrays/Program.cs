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





//COM ARRAY string diferenciada, que guarda varios valores
string[] carros = new string[3];

Console.WriteLine($"Digite o nome do carro: ");
carros[0] = Console.ReadLine();
carros[1] = Console.ReadLine();
carros[2] = Console.ReadLine();

Console.WriteLine($"O primeiro carro da lista: {carros[0]}");
Console.WriteLine($"O segundo carro da lista: {carros[1]}");
Console.WriteLine($"O terceiro carro da lista: {carros[2]}");
