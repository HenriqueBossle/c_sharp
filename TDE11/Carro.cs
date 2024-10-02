public class Carro : Veiculo
{
    private int numeroDePortas;
    
    public void abrirMalas()
    {
        Console.WriteLine("O porta malas está aberto");
    }

    public Carro(int numDePortas, string marca, string modelo, int ano)
    :base(marca, modelo, ano)
        {
            numeroDePortas = numDePortas;
        }


    public void exibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo {Modelo}, Ano {Ano}");

    }
    
}    