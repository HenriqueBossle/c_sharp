Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name}!");
Console.Write("Digite o seu ano de nascimento: ");

int year = int.Parse(Console.ReadLine());

int age = 2024 - year;

Console.WriteLine($"Você tem {age} anos");

if (age >= 18 && name == "Misora"){
    Console.WriteLine("Você é maior de idade.");
}
else {
    Console.WriteLine("Você é menor de idade");
}
