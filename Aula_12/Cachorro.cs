public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Cachorro emitindo som");
        base.EmitirSom();
    }
}