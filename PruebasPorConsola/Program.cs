using System;

namespace PruebasPorConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var ejercicios = new Ejercicios(5,"ISP20");
        }

    }
    public class Ejercicios
    {
        public Ejercicios(int parámetro)
        {
            LoopDePares(parámetro);
        }
        public Ejercicios(int parámetro,string palabra)
        {
            LoopDeImpares(parámetro,palabra);
        }
        private void LoopDePares(int número)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                int suma = i + número;
                if (suma %2==0)
                    Console.WriteLine($"el número {suma} es par");
                                    
            }
        }
        private void LoopDeImpares(int número,string palabra)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                int suma = i + número;
                if (suma % 2 != 0)
                    Console.WriteLine(palabra);

            }
        }
    }
}
