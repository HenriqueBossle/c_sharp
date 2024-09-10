Pessoa p1 = new Pessoa();

string nomeParaObjeto;

Console.WriteLine("Infome o nome para o objeto");

nomeParaObjeto = Console.ReadLine();

p1.AtribuiNome(nomeParaObjeto);

string retornoDaFuncao;

retornoDaFuncao = p1.RetornaNome();

Console.WriteLine(retornoDaFuncao);