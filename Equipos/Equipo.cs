using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadDeOrigen { get; set; }
        public string Entrenador { get; set; }
        public string Jugadores { get; set; }

        public List<Jugador> jugadores {get; set;}
        public Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string nombre, string ciudad, string entrenador, string jugadores)
        {
            Nombre = nombre;
            CiudadDeOrigen = ciudad;
            Entrenador = Entrenador;
            Jugadores = jugadores;
        }
    }
}
