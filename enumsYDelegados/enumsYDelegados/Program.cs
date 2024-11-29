using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    enum EstadoPedido {Pendiente = 1, Enviado, Entregado, Cancelado = 9}
    public delegate int ValidarNumero(int x);
    internal class Program
    {
        public static void EsMayor(int x)
        {
            Console.WriteLine(x > 0);
        }
        public static void EsPar(int x)
        {
            Console.WriteLine(x % 2 == 0);
        }
        static void Main(string[] args)
        {
            // EstadoPedido estado = EstadoPedido.Entregado;

            Random random = new Random();
            int unAleatorio = random.Next(-256, 256);

            ValidarNumero validate = delegate (int val)
            {
                return val;
            };
            Console.WriteLine("value: {0}", validate(7));
        }
    }
}
