


namespace Ejercicio1
{
    public class CuentaBancaria
    {
        private int saldo; //Se crea el atributo privado

        public void Depositar(int cantidad) //Creamos la operacion para depositar
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
                Console.WriteLine("Su depósito ha sido exitoso. Saldo actual: " + saldo);
            }
            else
            {
                Console.WriteLine("La cantidad a depositar tiene que ser mayor que cero.");
            }
        }

        public void Retirar(int cantidad) // Creamos la operacion para retirar
        {
            if (cantidad > saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else if (cantidad > 0)
            {
                saldo -= cantidad;
                Console.WriteLine("Su retiro ha sido exitoso. Saldo actual: " + saldo);
            }
            else
            {
                Console.WriteLine("La cantidad a retirar tiene que ser mayor que cero.");
            }
        }

        public int ObtenerSaldo()
        {
            return saldo;
        }
    }

    class Eje1
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();
            int opcion;

            do
            {
                Console.WriteLine("\n MENÚ ");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Consultar saldo");
                Console.WriteLine("4. Salir");
                Console.Write("Elija una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad a depositar: ");
                        int deposito = int.Parse(Console.ReadLine());
                        cuenta.Depositar(deposito);
                        break;

                    case 2:
                        Console.Write("Ingrese la cantidad a retirar: ");
                        int retiro = int.Parse(Console.ReadLine());
                        cuenta.Retirar(retiro);
                        break;

                    case 3:
                        Console.WriteLine("Saldo actual: " + cuenta.ObtenerSaldo());
                        break;

                    case 4:
                        Console.WriteLine("Saliendo");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
