using System;
using System.Globalization;
using Udemy___Área_de_triângulo;
class Program
{
    static void Main()
    {
        Triangulo x, y;
        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Entre com as medidas do triângulo X: ");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y: ");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double p = (x.A + x.B + x.C) / 2.0;
        double X = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

        p = (y.A + y.B + y.C) / 2.0;
        double Y = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

        Console.WriteLine("Área do triângulo X é : " + X.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área do triângulo Y é : " + Y.ToString("F4", CultureInfo.InvariantCulture));

        if (X > Y) 
        {
            Console.WriteLine("Maior área é a do Triangulo X"); 
        }
        else
        {
            Console.WriteLine("Maior área é a do Triangulo Y");
        }
    }
}
