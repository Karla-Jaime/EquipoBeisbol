using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo equipo1 = new Equipo();

            equipo1.Nombre = "Mets";
            equipo1.CiudadDeOrigen = "New York";
            equipo1.Entrenador = "Bugs Bunny";

            equipo1.estadio = new Estadio("Tomas Oroz", "Guerrero #542", 120);

            equipo1.jugadores.Add(new Jugador("Michael Jordan ", "45"));
            equipo1.jugadores.Add(new Jugador("Babe Ruth ", "3"));
            equipo1.jugadores.Add(new Jugador("Tomas J.", "35"));

            equipo1.jugadores.Add(new Jugador("Bon Jovi ", "48"));
            equipo1.jugadores.Add(new Jugador("Tim", "21"));
            equipo1.jugadores.Add(new Jugador("Oliver A. ", "10"));

            equipo1.jugadores.Add(new Jugador("Zack Wheeler ", "25"));
            equipo1.jugadores.Add(new Jugador("Jacob deGrom", "48"));
            equipo1.jugadores.Add(new Jugador("Noah Syndergaard ", "34"));


            Equipo equipo2 = new Equipo();
            equipo2.Nombre = "Dodgers";
            equipo2.CiudadDeOrigen = "Los Angeles";
            equipo2.Entrenador = "Dave Roberts";
           

            equipo2.jugadores.Add(new Jugador("Enrique J. ", "14"));
            equipo2.jugadores.Add(new Jugador("Justin Turner ", "10"));
            equipo2.jugadores.Add(new Jugador("Matt Kemp ", "27"));

            equipo2.jugadores.Add(new Jugador("Brian Dozier ", "6"));
            equipo2.jugadores.Add(new Jugador("Max Muncy ", "13"));
            equipo2.jugadores.Add(new Jugador("Cody Bellinger ", "25"));

            equipo2.jugadores.Add(new Jugador("Chase Utley ", "26"));
            equipo2.jugadores.Add(new Jugador("Kenta Maeda ", "18"));
            equipo2.jugadores.Add(new Jugador("Joc Pederson ", "62"));

            equipos.Add(equipo1);
            equipos.Add(equipo2);
            // team es un nuevo nombre que se le asigna, debe ser igual para ambos foreach para poder recorrer
            foreach (Equipo team in equipos)
            {
                Console.WriteLine("Equipo: " + team.Nombre);
                Console.WriteLine("Ciudad: " + team.CiudadDeOrigen);
                Console.WriteLine("Entrenador: " + team.Entrenador);
                if (team.estadio != null )
                {
                   
                        Console.WriteLine("Nombre estadio: " + team.estadio.Nombre);
                        Console.WriteLine("Direccion: " + team.estadio.Direccion);
                        Console.WriteLine("Capacidad: " + team.estadio.Capacidad);
                        Console.WriteLine("\n");
                    
                }
                else
                {
                    Console.WriteLine("No tiene estadio");
                }
                foreach (Jugador jugadores in team.jugadores)
                {
                    Console.WriteLine("Jugador: " + jugadores.Nombre);
                    Console.WriteLine("Numero: " + jugadores.Numero);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
