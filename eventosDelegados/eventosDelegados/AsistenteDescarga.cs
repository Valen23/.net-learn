using System;
using System.Threading;

namespace eventosDelegados
{
    class AsistenteDescarga
    {
        // Creamos el delegado
        //public delegate void GestorEventoArchivoDescargado(object fuente, EventArgs argumento

        // Creamos el evento relacionado al método delegado
        public event EventHandler<EventArgs> ArchivoDescargado; // 'EventHandler<EventArgs>' nos ahorra de crear un delegado como el de arriba.
        // Inicializar el evento mediante un método
        protected virtual void EnArchivoDescargado()
        {
            // Esta condicion verifica si hay eventos suscritos a 'ArchivoDescargado'
            if (ArchivoDescargado != null)
            {
                // Se efectuan los eventos suscritos a 'ArchivoDescargado'
                ArchivoDescargado(this, EventArgs.Empty);
            }
        }
        public void Descarga(Archivo archivo)
        {
            Console.WriteLine("Descargando archivo...");
            Thread.Sleep(3000);
            // Inicializamos el evento:
            EnArchivoDescargado();
        }

    }
}
