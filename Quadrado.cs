class Quadrado
{
    private double lado;
    private double altura;

    public double Lado
    {
        get { return lado; }
        set
        {
            if (value > 0)
            {
                lado = value;
            }
            else
            {
                Console.WriteLine("O lado não pode ser zero ou negativo.");
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

    public Quadrado(double lado, double altura)
    {
        if (lado <= 0)
        {
            throw new ArgumentException("O lado não pode ser zero ou negativo.");
        }

        if (altura <= 0)
        {
            throw new ArgumentException("A altura não pode ser zero ou negativa.");
        }

        this.lado = lado;
        this.altura = altura;
    }

    public override string ToString()
    {
        return $"Quadrado - Lado: {lado}, Altura: {altura}";
    }

    public double CalcularArea()
    {
        return lado * altura;
    }
}