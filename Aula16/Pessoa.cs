public class Pessoa
{
    public static int Contador = 0;
    public string Nome { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
        Contador ++;
    }
}