namespace aulaPOOcelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligadoDesligado;

        public void Ligar()
        {
            Console.WriteLine($"Ligando a aparelho..");
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando o aparelho..");
        }

        public void FazerLigacao()
        {
            Console.WriteLine($"Fazendo ligação..");
        }

        public void EnviarMensagem()
        {
            Console.WriteLine($"Enviando mensagem..");
        }
    }
}