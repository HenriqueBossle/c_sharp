public class Retangulo
{
    double largura;
    double altura;

    public Retangulo()
    {
        largura = 0;
        altura = 0;
    } 

    public Retangulo(double valor)
    {
        largura = valor;
        altura = valor;
    }
    
    public Retangulo(double valor1, double valor2)
    {
        largura = valor1;
        altura = valor2;
    }

    public double CalcularArea()
    {
        return largura * altura;
    }

    public double CalcularPerimetro()
    {
        return (largura + altura) * 2;
    }    

    public void Redimencionar()
    {

    }
 
    public void Redimencionar(double fator)
    {
        altura *= fator;
        largura *= fator;
    }

    public void Redimencionar(double altura, double largura)
    {
        this.altura = altura;
        this.largura = largura;
    }

    

}