using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 5, 2, 8, 7, 9, 1, 4 };
            int indice = lista.FindIndex(x => x == 9);
            Console.WriteLine(indice);
        }
    }
}
