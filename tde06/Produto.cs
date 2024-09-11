class Produto
{
    public string nome;
    public int quantidade;
    public double preco;
    public void AdicionarEstoque(int valor)
    {
        if(valor > 0){
        quantidade += valor;
        Console.WriteLine($"A quantidade {valor} foi adicionado no produto {nome}."); 
        }else{
            Console.WriteLine("ERRO: Digite um valor válido!");
            Console.ReadKey();
        }
    }
    public void RemoverEstoque(int valor)
    {
        if(valor > 0 && valor <= quantidade){
        quantidade -= valor;
        Console.WriteLine($"A quantidade {valor} foi REMOVIDA no produto {nome}.");
        }else if (valor <= 0){
            Console.WriteLine("O valor informado é menor ou igual a zero");
        }else{
            Console.WriteLine("O valor informado é maior do que a quantidade disponivel em estoque");
        }
    }
    public double CalcularValorEstoque()
    {
        return quantidade * preco;
    }

    public void DefinirValores()
    {
        Console.WriteLine("Informe o nome do produto:");
        nome = Console.ReadLine();
        Console.WriteLine("Informe a quantidade do produto:");
        quantidade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o preço do produto:");
        preco = Convert.ToDouble(Console.ReadLine());
        
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Nome do produto: " + nome);
        Console.WriteLine("Qtd em estoque: " + quantidade);
        Console.WriteLine("Preço do produto unidade: " + preco);
        Console.WriteLine("Valor total do estoque: " + CalcularValorEstoque());
    }
}