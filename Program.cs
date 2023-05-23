using System;
using System.Globalization;

namespace Course{
    public class Program {
        public static void Main(string[] args)
        {
            double[] medidasX = LerMedidasTriangulo("X");
            double[] medidasY = LerMedidasTriangulo("Y");

            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);

            Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("A area de X é Maior");
            }
            else 
            {
                Console.WriteLine("A area de Y é Maior");
            }

        }
        public static double[] LerMedidasTriangulo(string nomemedidas) 
        {
            double[] medidas = new double[3];

            Console.WriteLine("Entre com a area do triangulo " + nomemedidas);
            for (int i = 0; i < 3; i++) 
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            return medidas;
        }

        public static double CalcularAreaTriangulo(double[] medidas)
        { 
            double a = medidas[0];
            double b = medidas[1]; 
            double c = medidas[2];

            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * p * (p - b) * p * (p - c));

            return area;
        }
    }
}