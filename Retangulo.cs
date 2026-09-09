class Retangulo
{
    private double largura;
    private double altura;

    public double Largura
    {
        get { return largura; }
        set
        {
            if (value > 0)
            {
                largura = value;
            }
            else
            {
                Console.WriteLine("A largura não pode ser zero ou negativa.");
            }
        }
    }

    public double Altura
    {
        get { return altura; }
        set
        {
            if (value > 0)
            {
                altura = value;
            }
            else
            {
                Console.WriteLine("A altura não pode ser zero ou negativa.");
            }
        }
    }

    public Retangulo(double largura, double altura)
    {
        if (largura <= 0)
        {
            Console.WriteLine("A largura não pode ser zero ou negativa.");
        }

        if (altura <= 0)
        {
            Console.WriteLine("A altura não pode ser zero ou negativa.");
        }

        this.largura = largura;
        this.altura = altura;
    }

    public override string ToString()
    {
        return $"Retângulo - Largura: {largura}, Altura: {altura}";
    }

    public double CalcularArea()
    {
        return largura * altura;
    }
}