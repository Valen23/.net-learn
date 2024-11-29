using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inANDoutTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miTexto = File.ReadAllText(@"C:\Users\valen\source\repos\inANDoutTest\texto.txt");
            Console.WriteLine(miTexto);

            string nuevoTexto = "La gacela, el cuadrado y el rkt.";
            File.WriteAllText(@"C:\Users\valen\source\repos\inANDoutTest\nuevoTexto.txt", nuevoTexto);
        }
    }
}
