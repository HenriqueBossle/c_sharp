using System.Security.Cryptography.X509Certificates;

public class Pessoa
{
    public string? nome;

    public void AtribuiNome(string novoNome)
    {
        nome = novoNome;
    }
    public string RetornaNome()
    {
        return nome;
    }
}