// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

for (int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($"Qual seu sexo? Use 'm' para masculino e 'f para feminino'");
    char sexo = char.Parse(Console.ReadLine());
    
    Console.WriteLine($"Você gostou do produto? Utilize 's' para sim e 'n' para não");
    char avaliar = char.Parse(Console.ReadLine());   




}