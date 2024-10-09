Empresa empresa = new Empresa();
Funcionario f1 = new Funcionario("James", 19);
Gerente gerente = new Gerente("Henrique", 19, 5000.0);
Estagiario estagiario = new Estagiario("Jonas", 30);

empresa.AdicionarFuncionario(f1);
empresa.AdicionarFuncionario(gerente);
empresa.AdicionarFuncionario(estagiario);

empresa.ListarFuncionarios();