// //tipos de variaveis

// int x = 10;
// double pi = 3.1415;
// char letra = 'M';
// bool isTrue = true;
// string texto = "5";

// double outroValor;
// //conversão inplicita
// outroValor = x;
// //conversão explicta
// int valorInteiro = (int) pi;

// //conversão explicita com a classe Convert

// int y = Convert.ToInt32(texto);

// //Operadores
// //+,-,/,*,=,==

// int numero;
// Console.WriteLine("Digite um número:");
// numero = Convert.ToInt32(Console.ReadLine());
// //Concatenação
// Console.WriteLine("O usuario digitou: " + numero);
// //Interpolação
// Console.WriteLine($"O dobro do que o usuario digitou é: {numero * 2}");

double numero;
double numero2;
Console.WriteLine("Informe um número: ");
numero = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe um segundo número: ");
numero2 = Convert.ToDouble(Console.ReadLine()); 

double soma = numero + numero2;
double subtracao = numero - numero2;
double multiplicacao = numero * numero2;
double divisao = numero / numero2;

Console.WriteLine("A soma entre "+ numero + " e " + numero2 + " é igual a " + soma);
Console.WriteLine($"A soma entre {numero} e {numero2} é igual a {soma}");
Console.WriteLine("A soma entre {0} e {1} é igual a {2}",numero, numero2, soma);
Console.WriteLine("A subtração entre "+ numero + " e " + numero2 + " é igual a " + subtracao);
Console.WriteLine($"A subtração entre {numero} e {numero2} é igual a {subtracao}");
Console.WriteLine("A subtração entre {0} e {1} é igual a {2}",numero, numero2, subtracao);
Console.WriteLine("A multiplicação entre "+ numero + " e " + numero2 + " é igual a " + multiplicacao);
Console.WriteLine($"A multplicação entre {numero} e {numero2} é igual a {multiplicacao}");
Console.WriteLine("A multiplicação entre {0} e {1} é igual a {2}",numero, numero2, multiplicacao);
Console.WriteLine("A divisão entre "+ numero + " e " + numero2 + " é igual a " + divisao);
Console.WriteLine($"A divisão entre {numero} e {numero2} é igual a {divisao}");
Console.WriteLine("A divisão entre {0} e {1} é igual a {2}",numero, numero2, divisao);

Console.ReadKey();


