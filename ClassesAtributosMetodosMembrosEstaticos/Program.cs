using System;
using System.Globalization;

namespace ClassesAtributosMetodosMembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferencia: "+Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: "+ Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: "+Calculadora.Pi.ToString("F2",CultureInfo.InvariantCulture));

        }

    }

}