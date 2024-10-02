Cachorro cachorro = new Cachorro();
cachorro.setNome("Bilu");
cachorro.setIdade(7);
cachorro.Alimentar();
cachorro.Latir();

Gato gato = new Gato();
gato.setNome("Fraj");
gato.setIdade(10);
gato.numeroDeVidas = 7;
gato.Alimentar();
gato.Miar();

Console.WriteLine($"O gato tem {gato.getIdade()} anos");
Console.WriteLine($"O gato se chama {gato.getNome()}");