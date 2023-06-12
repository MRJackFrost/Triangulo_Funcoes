using System;
using System.Globalization;

namespace Course{
    public class Program { //definindo o nome da classe
        public static void Main(string[] args) //abrindo o bloco principal
        {
            double[] medidasX = LerMedidasTriangulo("X"); //Definindo a variavel com array e chamando uma função
            double[] medidasY = LerMedidasTriangulo("Y"); //Definindo a variavel com array e chamando uma função

            double areaX = CalcularAreaTriangulo(medidasX); //Definindo a variavel e chamando uma função
            double areaY = CalcularAreaTriangulo(medidasY); //Definindo a variavel e chamando uma função

            Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture)); //Mostrando o resultado da area para o usuario
            Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture)); //Mostrando o resultado da area para o usuario

            if (areaX > areaY) // se x for maior
            {
                Console.WriteLine("A area de X é Maior"); //mostrando na interface do usuario
            }
            else //se não
            {
                Console.WriteLine("A area de Y é Maior"); //mostrando na interface do usuario
            }

        }
        public static double[] LerMedidasTriangulo(string nomemedidas) //Definindo a função e pedindo uma string
        {
            double[] medidas = new double[3]; //definindo um array

            Console.WriteLine("Entre com a area do triangulo " + nomemedidas); //pedido na interface do usuario
            for (int i = 0; i < 3; i++) //enquanto i for menor que 3 faça
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //pedindo o valor dos arrays para o usuario
            }
            return medidas; //retorne o valor
        }

        public static double CalcularAreaTriangulo(double[] medidas) //abrindo a função para o calculo pedindo um array
        { 
            double a = medidas[0]; //definindo as variaveis para o calculo
            double b = medidas[1];  //definindo as variaveis para o calculo
            double c = medidas[2]; //definindo as variaveis para o calculo

            double p = (a + b + c) / 2.0; //calculo
            double area = Math.Sqrt(p * (p - a) * p * (p - b) * p * (p - c)); //calculo usando raiz quadrada

            return area; //retorne o resultado
        }
    }
}
