/* 6)	Faça um programa que:
a) Obtenha o valor para a variável HT (horas trabalhadas no mês);
b) Obtenha o valor para a variável VH (valor hora trabalhada):
c) Obtenha o valor para a variável PD (percentual de desconto);
d) Calcule o salário bruto => SB = HT * VH;
e) Calcule o total de desconto => TD = (PD/100)*SB;
f) Calcule o salário líquido => SL = SB – TD;
g) Apresente os valores de: Horas trabalhadas, Salário Bruto, Desconto, Salário
Liquido */

Console.WriteLine("Insira as horas trabalhadas no mês: ");
double ht = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o valor da hora trabalhada: ");
double vh = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o valor percentual de desconto: ");
double pd = Convert.ToDouble(Console.ReadLine());

double sb = ht * vh;

double td = pd/100*sb;

double sl = sb - td;

Console.WriteLine($"Horas trabalhadas: {ht} \nSálario bruto: {sb} \nDesconto: {pd} \nSálario liquido: {sl}");

