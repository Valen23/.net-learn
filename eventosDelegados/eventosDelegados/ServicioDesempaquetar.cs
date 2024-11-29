using System;
using System.Threading;

namespace eventosDelegados
{
    public class ServicioDesempaquetar
    {
        public void EnArchivoDescargado(object fuente, EventArgs e)
        {
            Console.WriteLine("Desempaquetando el archivo...");
            Thread.Sleep(3000);
        }
    }
}
