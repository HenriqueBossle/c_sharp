public class Animal
{
    public string nome;
    public int idade;
     
    public virtual void EmitirSom()
    {
        Console.WriteLine($"O {nome} está emitindo um som.");
    }

}  