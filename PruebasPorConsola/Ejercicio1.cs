using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPorConsola
{
    internal class Ejercicio1
    {
        public Ejercicio1()
        {
            LoopDePares(5);
        }
        /// <summary>
        /// ejercicio nº1 
        /// </summary>
        /// <param name="número"></param>
        private void LoopDePares(int número)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                int suma = i + número;
                if (suma % 2 == 0)
                    Console.WriteLine($"el número {suma} es par");

            }
        }
    }
}
