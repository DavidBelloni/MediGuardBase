using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Reflection.Emit;

namespace Services.Facade
{
    public class IdiomaManager
    {
        private static string _idiomaActual = "es-ES"; // Idioma predeterminado

        // Evento para notificar los cambios de idioma (permite que una clase notifique a otras cuando ocurre algo especifico)
        // Cuando cambia el idioma, la clase IdiomaMaganer notifica a los forms suscritos y abiertos para que actualicen sus textos.
        public static event Action IdiomaCambiado;

        public static string IdiomaActual
        {
            get => _idiomaActual;
            set
            {
                if (_idiomaActual != value)
                {
                    _idiomaActual = value;
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(value);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(value);

                    // Cuando el idioma cambia, llama automaticamente a todos los metodos suscritos al evento IdiomaCambiado
                    // Esto permite que los formularios que se suscribieron al evento actualicen su texto automaticamente
                    // En frmRecepcion seria OnIdiomaCambiado().
                    // Esto llama automáticamente a todos los métodos que se hayan suscrito al evento, permitiendo que, por ejemplo, los formularios actualicen sus textos al nuevo idioma.
                    IdiomaCambiado?.Invoke();
                }
            }
        }
    }

    // ¿Por Qué Usar Eventos?
    // Desacoplamiento: Los formularios no necesitan saber cómo funciona IdiomaManager.Solo se suscriben al evento y reaccionan cuando ocurre.
    // Flexibilidad: Puedes agregar o quitar suscriptores dinámicamente.
}
