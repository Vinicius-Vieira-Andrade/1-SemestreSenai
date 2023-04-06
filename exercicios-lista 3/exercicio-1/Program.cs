// 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

bool notaCerta = true;

do
{
    Console.WriteLine($"informe uma nota: ");
    float nota = float.Parse(Console.ReadLine());
   
   if (nota >= 0 && nota <= 10)   
        {
            Console.WriteLine($"Nota válida!");
            notaCerta = false;
            break;
        }

        else
        Console.WriteLine($"Nota inválida, tente novamente!!");
        notaCerta = true;
    
} while (notaCerta);