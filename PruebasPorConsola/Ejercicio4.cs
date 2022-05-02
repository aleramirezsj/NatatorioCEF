using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPorConsola
{
    internal class Ejercicio4
    {
        delegate int DelegadoOperacionMatematica(int num1);
        public int MultiplicarPor10(int numero1)
        {
            return numero1 * 10;
        }
        //Sumattion(8);
        public Ejercicio4()
        {
            DelegadoOperacionMatematica delegadoMultiPor10 = MultiplicarPor10;
            Console.WriteLine("El número 5 multiplicado por 10 es ="+CallBack(5, delegadoMultiPor10));
        }

        private int CallBack(int número, DelegadoOperacionMatematica delegado)
        {
            return delegado(número);
        }

    }
}
