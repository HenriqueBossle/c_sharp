public class Bicicleta : Veiculo, IAceleravel
{
    public Bicicleta(string marca, string modelo):base(marca, modelo)
    {

    }

    public void Acelerar()
    {
        Console.WriteLine($"A bike {Marca} {Modelo} está pedalando mais rapido");
    }

    public override void Ligar()
    {
        Console.WriteLine($"A bike {Marca} {Modelo} está pronta para o uso");
    }
}