using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismoTest
{
    internal class BMW:Auto
    {
        private string marca = "BMW";
        public string Modelo { get; set; }
        public BMW()
        {
            this.Color = "blanco";
            this.HP = 0;
            this.Modelo = "basic";
        }
        public BMW(int potencia, string color, string modelo)
        {
            this.Color = color;
            this.HP = potencia;
            this.Modelo = modelo;
        }

        public override string MostrarDetalles()
        {
            return string.Format("Potencia {0}, color {1}, marca {2}, modelo {3}", HP, Color, marca, Modelo);
        }
    }
}
