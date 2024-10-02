public class Animal
{
    protected string nome;
    private int idade;

    public void Alimentar()
    {
        Console.WriteLine($"{nome} está se alimentando");
    }

    public void setIdade(int idade)
    {
        if(idade >= 0)
        {
            this.idade = idade;
        }else{
            Console.WriteLine("Não é permitido idade negativa");
        }
    }

    public int getIdade()
    {
        return idade;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getNome()
    {
        return nome;
    }

}