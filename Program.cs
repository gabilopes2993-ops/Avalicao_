Triangulo triangulo1 = new Triangulo(10, 5);
Triangulo triangulo2 = new Triangulo(8, 4);

Retangulo retangulo1 = new Retangulo(10, 6);
Retangulo retangulo2 = new Retangulo(8, 5);

Quadrado quadrado1 = new Quadrado(5, 7);
Quadrado quadrado2 = new Quadrado(5, 9);

Console.WriteLine(triangulo1);
Console.WriteLine(triangulo2);

Console.WriteLine(retangulo1);
Console.WriteLine(retangulo2);

Console.WriteLine(quadrado1);
Console.WriteLine(quadrado2);

Console.WriteLine("================================");

double areaTriangulo1 = triangulo1.CalcularArea();
Console.WriteLine($"Área do Triângulo 1: {areaTriangulo1}");
Console.WriteLine("--------------------------------");
double areaTriangulo2 = triangulo2.CalcularArea();
Console.WriteLine($"Área do Triângulo 2: {areaTriangulo2}");

Console.WriteLine("================================");

double areaRetangulo1 = retangulo1.CalcularArea();
Console.WriteLine($"Área do Retângulo 1: {areaRetangulo1}");
Console.WriteLine("--------------------------------");
double areaRetangulo2 = retangulo2.CalcularArea();
Console.WriteLine($"Área do Retângulo 2: {areaRetangulo2}");

Console.WriteLine("================================");

double areaQuadrado1 = quadrado1.CalcularArea();
Console.WriteLine($"Área do Quadrado 1: {areaQuadrado1}");
Console.WriteLine("--------------------------------");
double areaQuadrado2 = quadrado2.CalcularArea();
Console.WriteLine($"Área do Quadrado 2: {areaQuadrado2}");