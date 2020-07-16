using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace JuegoRol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personaje> ListaPersonajes = new List<Personaje>();

            var aleat = new Random();

            int CantidadDePersonajes = aleat.Next(6,10);

            for (int i = 1; i <= CantidadDePersonajes; i++)
            {
                Personaje mipersonaje = new Personaje();
                mipersonaje.GenerarPersonaje();

                ListaPersonajes.Add(mipersonaje);   //Cuando agrego un personaje a la lista, se crea una copia y se almacena en la lista?
            }

            //Generar dos valores aleatorios distintos
            int p1 = aleat.Next(CantidadDePersonajes + 1);
            int p2 = aleat.Next(CantidadDePersonajes + 1);

            while (p1 == p2)
            {
                p2 = aleat.Next(CantidadDePersonajes + 1);
            }

            //Seleccionar Personajes de los valores aleatorios seleccionados
            Personaje PersonajeN1 = ListaPersonajes[p1];
            Personaje PersonajeN2 = ListaPersonajes[p2];

            //Guardo la salud inicial de cada personaje
            int SaludIniPersonaje1 = PersonajeN1.Dato.Salud;
            int SaludIniPersonaje2 = PersonajeN2.Dato.Salud;

            SistemaDeCombate.Combate(PersonajeN1, PersonajeN2);

            SistemaDeCombate.CompararSalud(PersonajeN1, PersonajeN2, ListaPersonajes, SaludIniPersonaje1, SaludIniPersonaje2);


            //Console.WriteLine(ListaPersonajes[3]);


            /* //Listado de Datos
            string dato;

            foreach (Personaje s in ListaPersonajes)
            {
                dato = s.MostrarDatos();
                Console.WriteLine(dato);
            }

            //Listado de Caracteristicas
            string caract;

            foreach (Personaje s in ListaPersonajes)
            {
                caract = s.MostrarCaracteristicas();
                Console.WriteLine(caract);
            }
            */

        }

        
    }
}
