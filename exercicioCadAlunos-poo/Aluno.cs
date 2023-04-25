namespace exercicioCadAlunos_poo
{
    public class Aluno
    {
        //propriedades
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        //metodos

    public void VerMediaFinal()
    {
        Console.WriteLine($"A sua média final é: {this.mediaFinal}");
    }

    public float VerMensalidade()
    {
        if (this.bolsista && this.mediaFinal >= 8)
        {
            return this.valorMensalidade / 2;
        }

        else if (this.bolsista && this.mediaFinal > 6 && this.mediaFinal < 8)
        {
            return this.valorMensalidade * 30 / 100;
        }

        else
        {
            return this.valorMensalidade;
        }
    }
    }
}