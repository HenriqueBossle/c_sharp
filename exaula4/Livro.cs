class Livro{
    public string nome;
    public string autor;
    public int ano;
    public int paginas;

    public void ExibirInformacoes(){
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Autor: {autor}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Paginas: {paginas}");
    }

    public bool VerificarPaginas(){
        return (paginas > 300);
    }
    
}