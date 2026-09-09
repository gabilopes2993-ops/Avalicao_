class Triangulo
{
    private double baseTriangulo;
    private double altura;

    public double BaseTriangulo
    {
        get { return baseTriangulo; }
        set
        {
            if (value > 0)
            {
                baseTriangulo = value;
            }
            else
            {
                Console.WriteLine("A base não pode ser zero ou negativa.");
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

    public Triangulo(double baseTriangulo, double altura)
    {
        if (baseTriangulo <= 0)
        {
            throw new ArgumentException("A base não pode ser zero ou negativa.");
        }

        if (altura <= 0)
        {
            throw new ArgumentException("A altura não pode ser zero ou negativa.");
        }

        this.baseTriangulo = baseTriangulo;
        this.altura = altura;
    }

    public override string ToString()
    {
        return $"Triângulo - Base: {baseTriangulo}, Altura: {altura}";
    }

    public double CalcularArea()
    {
        return (baseTriangulo * altura) / 2;
    }
}