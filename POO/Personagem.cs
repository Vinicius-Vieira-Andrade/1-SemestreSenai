namespace POO
{
        public class Personagem
{
    //atributos
    //NOME, IDADE, ARMADURA, IA

    public string nome;
    public int idade;
    public string armadura;
    public string ia;

    //METODOS
    //ATACAR, DEFENDER, RESTAURAR ARMADURA

    public void Atacar() 
    {
        Console.WriteLine($"O personegem atacou!!!");
    }

    public void Defender()
    {
        Console.WriteLine($"O personagem defendeu!!!");
    }

    public void RestaurarArmadura()
    {
        Console.WriteLine($"O personagem restaurou a armadura!!!");
    }
}
}
