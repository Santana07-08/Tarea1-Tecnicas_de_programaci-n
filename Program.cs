using System;

namespace Ejercicio3
{
    // Se crea Clase Calculadora
    public class Calculadora
    {
        // Procemos a Sumar dos enteros
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        // Procedemos a Sumar tres enteros
        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }

        // Procedemos a Sumar dos números double
        public double Sumar(double a, double b)
        {
            return a + b;
        }
    }

    class Calculadora1
    {
        static void Main(string[] args)
        {
            Calculadora calcu = new Calculadora();

            // Procedemos a imprimir el resultado de la Suma de dos enteros
            int r1 = calcu.Sumar(5, 10);
            Console.WriteLine("Suma de 5 + 10 = " + r1);

            // Procedemos a imprimir el resultado de la Suma de tres enteros
            int r2 = calcu.Sumar(3, 7, 2);
            Console.WriteLine("Suma de 3 + 7 + 2 = " + r2);

            // Procedemos a imprimir el resultado de la Suma de dos doubles
            double r3 = calcu.Sumar(4.5, 3.2);
            Console.WriteLine("Suma de 4.5 + 3.2 = " + r3);
        }
    }
}