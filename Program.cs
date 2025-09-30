using System;
using System.Collections.Generic;

namespace Ejercicio5
{
    // Interfaz Animali
    public interface Animali
    {
        string Nombre { get; set; }
        void HacerSonido();
    }

    // Clase Gato
    public class Gato : Animali
    {
        public string Nombre { get; set; }

        public Gato(string nombre)
        {
            Nombre = nombre;
        }

        public void HacerSonido()
        {
            Console.WriteLine("Miau Miau!");
        }
    }

    // Clase Perro
    public class Perro : Animali
    {
        public string Nombre { get; set; }

        public Perro(string nombre)
        {
            Nombre = nombre;
        }

        public void HacerSonido()
        {
            Console.WriteLine("Guau Guau!");
        }
    }

   

    class Sonidos
    {
        static void Main(string[] args)
        {
            // Crear lista de IAnimal
            List<Animali> animales = new List<Animali>();


            // Agregar 4 gatos
            animales.Add(new Gato("Ramiro"));
            animales.Add(new Gato("Tigre"));
            animales.Add(new Gato("Peludo"));
            animales.Add(new Gato("Simba"));

            // Agregar 4 perros
            animales.Add(new Perro("Sami"));
            animales.Add(new Perro("Max"));
            animales.Add(new Perro("Tobby"));
            animales.Add(new Perro("Tostada"));


            // Recorrer la lista e imprimir nombre y sonido
            foreach (Animali animal in animales)
            {
                Console.WriteLine("Animal: " + animal.Nombre);
                Console.Write("Sonido: ");
                animal.HacerSonido();
                Console.WriteLine(); // Salto de línea extra
            }
        }
    }
}