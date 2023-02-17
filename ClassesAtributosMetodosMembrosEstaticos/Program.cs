using System;
using System.Globalization;

namespace ClassesAtributosMetodosMembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com as medidas do triângulo X:");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = p(xA, xB, xC);
            double pY = p(yA, yB, yC);

            double areaX = area(xA, xB, xC, pX);
            double areaY = area(yA, yB, yC, pY);

            Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de X: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX >= areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }

        static double p(double a, double b, double c)
        {
            return (a + b + c) / 2.0;
        }

        static double area(double a, double b, double c, double p)
        {
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}