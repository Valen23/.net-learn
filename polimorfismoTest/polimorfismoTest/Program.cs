using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Audi unAudi = new Audi(320, "blanco", "A3");
            BMW unBMW = new BMW(274, "negro", "E5");
            E5 unE5 = new E5(214, "rojo");
            unE5.RegistrarDatos("Valentino", "00-EJZ-91");
            Console.WriteLine(unE5.MostrarDetalles());
        }
    }
}
