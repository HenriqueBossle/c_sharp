Retangulo re1 = new Retangulo();
Retangulo re2 = new Retangulo(5);
Retangulo re3 = new Retangulo(4, 6);

Console.WriteLine($"Retangulo 1 Area: {re1.CalcularArea()} e Perimetro: {re1.CalcularPerimetro()}");
Console.WriteLine($"Retangulo 2 Area: {re2.CalcularArea()} e Perimetro: {re2.CalcularPerimetro()}");
Console.WriteLine($"Retangulo 3 Area: {re3.CalcularArea()} e Perimetro: {re3.CalcularPerimetro()}");

re3.Redimencionar(2);

Console.WriteLine($"Retangulo 3 Area redimencionada: {re3.CalcularArea()} e Perimetro: {re3.CalcularPerimetro()}");

re2.Redimencionar(10, 15);

Console.WriteLine($"Retangulo 2 Area redimencionada: {re2.CalcularArea()} e Perimetro: {re2.CalcularPerimetro()}");
