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
        Console.WriteLine($"A sua média final é: {mediaFinal}");
    }

    public float VerMensalidade()
    {
        if (bolsista == true && mediaFinal >= 8)
        {
            return valorMensalidade / 2;
        }

        else if (bolsista == true && mediaFinal > 6 && mediaFinal < 8)
        {
            return valorMensalidade * 30 / 100;
        }

        else
        {
            return valorMensalidade;
        }
    }
    }
}