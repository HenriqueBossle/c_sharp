using System.Collections;
//Arrays do mesmo tipo com tamanho fixo

int[] numeros = new int[3];

numeros[0] = 10;
numeros[1] = 2;
numeros[2] = 5;

foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}

//list<T> Listas do mesmo tipo que aumentam dinamicamente

List<string> frutas = new List<string>();

frutas.Add("Maça");
frutas.Add("Banana");

frutas.Remove("Maça");

foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}

//ArrayList uma lista que armazena valores de qualuer tipo e aumenta dinamicamente

ArrayList itens = new ArrayList();
itens.Add(10);
itens.Add("Henrique");
itens.Add(30.5);

foreach (var item in itens)
{
    Console.WriteLine(item);
}