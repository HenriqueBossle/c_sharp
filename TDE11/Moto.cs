public class Moto : Veiculo
{
    private bool temBageiro;
   
    public void darGrau()
    {
        Console.WriteLine("Randandandan");
    }

    public void exibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo {Modelo}, Tem Bageiro {tembageiro}");
    }

    public Moto(string marca, string modelo, int ano, bool Tembageiro):base(marca, modelo, ano)
    {
        this.tembageiro = Tembageiro;
    }
}
