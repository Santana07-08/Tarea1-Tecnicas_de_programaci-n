using System;

namespace Ejercicio4
{
    // Creamos la Clase abstracta
    public abstract class Figura
    {
        // Método abstracto que debe implementarse en las clases hijas
        public abstract double CalcularArea();
    }

    // Clase Triangulo
    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double baseTriangulo, double altura)
        {
            Base = baseTriangulo;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }


    // Procedemos a crear la Clase Cuadrado
    public class Cuadrado : Figura
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }

   

    // Programa principal
    class Areas
    {
        static void Main(string[] args)
        {
            // Crear un cuadrado de lado 5
            Cuadrado cuadrado = new Cuadrado(5);
            Console.WriteLine("El Área del cuadrado es: " + cuadrado.CalcularArea());

            // Crear un triángulo de base 6 y altura 4
            Triangulo triangulo = new Triangulo(6, 4);
            Console.WriteLine("El Área del triángulo es: " + triangulo.CalcularArea());
        }
    }
}