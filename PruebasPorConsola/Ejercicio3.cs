using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPorConsola
{
    internal class Ejercicio3
    {
        public Ejercicio3()
        {
            Sumattion(8);
        }
        private void Sumattion(int número)
        {
            int sumatoria = 0;
            for (int i = 1; i <= número; i++)
            {
                sumatoria += i;
            }
            Console.WriteLine($"La suma total de los números anteriores a{número} es:{sumatoria}");
        }
    }
}
