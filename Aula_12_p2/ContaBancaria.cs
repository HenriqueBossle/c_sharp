public class ContaBancaria
{
    //public decimal Saldo {get; set;}

    private decimal _saldo;

    public decimal Saldo
    {
       get { return _saldo;}
       private set 
       {
           if(value < 0)
           {
               Console.WriteLine("O saldo não pode ser negativo");
           }
           else
           {
                _saldo = value;
           }
       }
    }

    public int NumConta {get;}

    public string Titular {get; set;}

    public ContaBancaria(int numeroConta, string titular)
    {
        NumConta = numeroConta;
        Titular = titular;
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Deposito de valor {valor}, foi realizado, saldo = {Saldo}"); 
    }

}