// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// exemplo viniciusVieiraDeAndradeCorreia (camel case)
// exemplo ViniciusVieiraDeAndradeCorreia (pascal casa)

// variable

// declarando uma variável

// tipo nome = valor
// string name = "Vinicius";
// Console.WriteLine(name);

// const int idade = 19;
// Console.WriteLine(idade);


// Console.WriteLine("A idade do " + name + " é " + idade + " anos");


// tipos de dados
// int quantidade = 10;
// double preco = 4.99D;
// float altura = 2.29F;
// bool careca = true;
// string texto = "Olá, mundo";
// char letra = 'A';

//operador de atribuicao
//int idade = 19;

// operadores aritimeticos

// soma
//Console.WriteLine(7 + 7);

// subtracao
//Console.WriteLine(19 - 10);

// multiplicacao
//Console.WriteLine(23 * 22);

//divisao
//Console.WriteLine(10 / 2);

//modular
// Console.WriteLine(4 % 2);



//operadores de comparacao - resposta true ou false

//igual a
// Console.WriteLine(7 == 7);

//maior ou igual a
// Console.WriteLine(5 >= 4);

//menor ou igual a
// Console.WriteLine(4 <= 4);

//maior que
// Console.WriteLine(5 > 2);

//menor que
// Console.WriteLine(5 < 3);

//diferente de
// Console.WriteLine(5 != 4);


//operadores logicos e tabela verdade

//&& : e cara rígido
//|| : ou cara bonzinho
// ! : negação
                                    //TABELA VERDADE
// Console.WriteLine(5 == 5 && 8==8); //TRUE & TRUE = TRUE
// Console.WriteLine(5 == 5 && 3==4); //TRUE & FALSE = FALSE
// Console.WriteLine(7 == 5 && 4==4); //FALSE & TRUE = FALSE
// Console.WriteLine(7 == 5 && 9==4); //FALSE & FALSE = FALSE

// Console.WriteLine(2 == 2 || 5 == 5);//TRUE & TRUE = TRUE
// Console.WriteLine(2 == 2 || 5 == 1);//TRUE & FALSE = TRUE
// Console.WriteLine(2 == 4 || 1 == 1);//FALSE & TRUE = TRUE
// Console.WriteLine(2 == 5 || 1 == 5);//FALSE & FALSE = FALSE


// Console.WriteLine(!(2 == 2 || 3 == 3)); //NATURALMENTE TRUE COM A NEGAÇÃO (!) SE TORNA FALSO






















//Crie um programa para calcular o IMC de uma pessoa

// entrada
string nome = "aiaiai";
float peso = 100.5f;
float altura = 2.70f;

//processamento
float imc = peso / (altura * altura);

Console.WriteLine( "o IMC do " + nome + " é de : " + Math.Round(imc,2));

