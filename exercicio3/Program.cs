// 3)	Faça um programa que:
// a)	Leia o nome;
// b)	Leia o sobrenome;
// c)	Concatene o nome com o sobrenome;
// d)	Apresente o nome completo.

Console.WriteLine("Digite um nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite o sobrenome: ");
string sobrenome = Console.ReadLine();

Console.WriteLine($"{nome} " + $"{sobrenome}");


