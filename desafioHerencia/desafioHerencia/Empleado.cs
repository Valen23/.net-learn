using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioHerencia
{
    class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        protected float salario { get; set; }
        public bool trabajando = false;

        public Empleado()
        {
            nombre = "Nombre";
            apellido = "Apellido";
            salario = 0.0f;
        }
        public Empleado(string nombre, string apellido, float salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.salario = salario;
        }

        public virtual void Trabajar()
        {
            if (!trabajando)
            {
                Console.WriteLine("Estoy trabajando!");
                trabajando = true;
            }
            else
            {
                Console.WriteLine("Ya estoy trabajando, bigote!");
            }
        }

        public void Descansar()
        {
            Console.WriteLine("Me estoy tomando un descanso!");
        }
    }
}
