public class OperacoesMatematicas
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }
 
    public int Somar(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }

    public int Somar(int a, double b)
    {
        return a + (int)b;
    }

    public int Somar(double a, int b)
    {
        return b + (int) a ;
    }
}