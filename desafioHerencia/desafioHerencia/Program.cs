using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado unEmpleado = new Empleado();
            Jefe unJefe = new Jefe();
            Pasante unPasante = new Pasante();

            unPasante.HorasDeTrabajo = 3;
            unPasante.HorasDeEscuela = 7;

            unJefe.Dirigir();
            unPasante.Trabajar();
        }
    }
}
