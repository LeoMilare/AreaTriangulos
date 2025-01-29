using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        double xA, xB, xC, yA, yB, yC;

        Console.WriteLine("Entre com as medidas do primeiro triângulo: ");
        xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do segundo triângulo: ");
        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double p = (xA + xB + xC) / 2.0;
        double AreaPrimeiroTriangulo = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

        p = (yA + yB + yC) / 2.0;
        double AreaSegundoTriangulo = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

        Console.WriteLine("Área do primeiro triângulo é : " + AreaPrimeiroTriangulo.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área do segundo triângulo é : " + AreaSegundoTriangulo.ToString("F4", CultureInfo.InvariantCulture));

        if (AreaPrimeiroTriangulo > AreaSegundoTriangulo) 
        {
            Console.WriteLine("Maior área é a do Primeiro Triangulo ");
        }
        else
        {
            Console.WriteLine("Maior área é a do Segundo Triangulo ");
        }
    }
}