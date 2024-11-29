using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expresionesLambda
{
    internal class Program
    {
        public delegate int Calculos(int x);
        public static int Potencia(int x)
        {
            return x * x;
        }
        public static int Suma(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            DoSomething();


            List<int> listaNumeros = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            List<int> listaPares = listaNumeros.FindAll(x => x % 2 == 0);
            listaPares.ForEach(x => Console.WriteLine(x));




        }
        public static void DoSomething()
        {
            Calculos matematicas = new Calculos(Potencia);
            Console.WriteLine(matematicas(7));
        }
    }
}
