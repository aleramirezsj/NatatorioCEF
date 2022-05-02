using System;

namespace PruebasPorConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcion = 0;
            do
            {
                MenuPantalla();
                opcion=int.Parse(Console.ReadLine());
                LlamarAEjercicio(opcion);
                Console.ReadKey();
            } while (opcion!=9);
        }

        private static void LlamarAEjercicio(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    new Ejercicio1();
                    break;
                case 2:
                    new Ejercicio2();
                    break;
                case 3:
                    new Ejercicio3();
                    break;
                case 4:
                    new Ejercicio4();
                    break;
                default:
                    Console.WriteLine("Se ingresó un valor no válido(presione cualquier tecla para continuar)");
                    Console.ReadKey();
                    break;
            }
        }

        static void MenuPantalla()
        {
            Console.Clear();
            Console.WriteLine("EJERCICIOS DE PROGRAMACIÓN");
            Console.WriteLine("1-Ejercicio Loop de pares:");
            Console.WriteLine("2-Ejercicio Loop de impares:");
            Console.WriteLine("3-Ejercicio Sumattions:");
            Console.WriteLine("4-Ejercicio Callbacks:");
            Console.WriteLine("9-Para salir");
            Console.Write("Ingrese una opción");
        }

    }




}
