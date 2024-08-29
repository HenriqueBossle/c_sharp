//1)Faça um programa que receba dois números e exiba o resultado da sua soma.



Console.WriteLine("Informe um número: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe mais um número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int soma = num1 + num2;
Console.WriteLine($"O resultado da soma entre {num1} e {num2} é igual a {soma}");