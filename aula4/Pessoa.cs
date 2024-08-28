class Pessoa{
    public string nome;
    public int idade;
    public string sexo;


    public void ExibirInformacoes(){
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Sexo: {sexo}");
        Console.WriteLine("");
    }
}