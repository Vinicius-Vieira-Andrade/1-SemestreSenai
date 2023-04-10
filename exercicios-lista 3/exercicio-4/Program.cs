// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

char sexo;
char gostouDoProduto;

int totalSim = 0;
int totalNao = 0;

int totalMulher = 0;
int totalMulherSim = 0;

int totalHomem = 0;
int totalHomemNao = 0;

double porcentagemHomemNao = 0;

for (int contador = 1; contador <= 10; contador++)
{
    //entrada de dados
    Console.WriteLine(@$"
    Informe o sexo da pessoa:
    (m) - Masculino
    (f) - Feminino
    ");
    

    sexo = char.Parse(Console.ReadLine().ToLower());

    //processamento
    if (sexo == 'f')
    {
        totalMulher++;
    }

    else{
        totalHomem++;
    }

    Console.WriteLine(@$"
    A pessoa gostou do lançamento?
    (s) - Sim
    (n) - Não
    ");
    
    gostouDoProduto = char.Parse(Console.ReadLine().ToLower());
    if (gostouDoProduto == 's')
    {
        totalSim++;
        if (sexo == 'f')
        {
            totalMulherSim++;
        }
    }

    else
    {
        totalNao++;
        if (sexo == 'm')
        {
            totalHomemNao++;
        }
    }
    
}

porcentagemHomemNao = Math.Round(((double)totalHomemNao/(double)totalHomem)* 100,2);

Console.WriteLine($"O total de pessoas que responderam sim foi de : {totalSim}");
Console.WriteLine($"O total de pessoas que responderam não foi de : {totalNao}");

Console.WriteLine($"O total de mulheres que responderam sim foi de : {totalMulherSim}");

Console.WriteLine($"A porcentagem de homens que responderam que não gostaram no produto é de: {porcentagemHomemNao} %");

