using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos
{
    class Jugador
    {
        public string Numero { get; set; }
        public string Nombre { get; set; }

        public Jugador()
        {
            Nombre = "Michael Jordan";
            Numero = "45";
        }

        public Jugador(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;

        }
    }
}
