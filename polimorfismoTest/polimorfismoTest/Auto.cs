using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismoTest
{
    internal abstract class Auto
    {
        public int HP { get; set; }
        public string Color { get; set; }
        protected RegistroAuto miRegistro = new RegistroAuto();
        public Auto()
        {
            HP = 0;
            Color = "Blanco";
        }
        public Auto(int potencia, string color)
        {
            this.HP = potencia;
            this.Color = color;
        }

        public abstract string MostrarDetalles();

        public void Reparar()
        {
            Console.WriteLine("Auto reparado.");
        }
        public void RegistrarDatos(string nombre, string patente)
        {
            miRegistro.Titular = nombre;
            miRegistro.Patente = patente;
        }
    }
}
