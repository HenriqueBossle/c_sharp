//2)Faça um programa que receba dois números e ao final mostre a soma, subtração, multiplicação e a divisão dos números lidos.

double num1;
double num2;

Console.WriteLine("Informe um número: ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe um segundo número: ");
num2 = Convert.ToDouble(Console.ReadLine());

double soma = num1 + num2;
double sub = num1 - num2;
double multi = num1 * num2;
double divisao = num1 / num2;

Console.WriteLine($"A soma entre os números {num1} e {num2} é igual a {soma}");

Console.WriteLine($"A subtração entre os valores {num1} e {num2} resulta em: {sub}");

Console.WriteLine($"A multiplicação entre os número {num1} e {num2} é {multi}");

Console.WriteLine($"O resultado da divisão entre {num1} e {num2} é {divisao}");



