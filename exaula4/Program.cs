Livro l1 = new Livro();
l1.nome = "Star Wars: Colheita Vermelha";
l1.autor = "Joe Schreiber";
l1.ano = 2010;
l1.paginas = 350;

l1.ExibirInformacoes();
Console.WriteLine($"O livro tem mais de 300 paginas? {l1.VerificarPaginas()}");