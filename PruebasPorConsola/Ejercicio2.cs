using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPorConsola
{
    internal class Ejercicio2
    {
        public Ejercicio2()
        {
            LoopDeImpares(6, "Impares");
        }
        /// <summary>
        /// ejercicio Nº2
        /// </summary>
        /// <param name="número"></param>
        /// <param name="palabra"></param>
        private void LoopDeImpares(int número, string palabra)
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
