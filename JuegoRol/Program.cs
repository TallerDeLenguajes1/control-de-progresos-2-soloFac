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

                ListaPersonajes.Add(mipersonaje);
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

            Combate(PersonajeN1, PersonajeN2);

            CompararSalud(PersonajeN1, PersonajeN2, ListaPersonajes, SaludIniPersonaje1, SaludIniPersonaje2);



            //Console.WriteLine(ListaPersonajes[3]);


            /* //Listado de Datos
            string dato;

            foreach (Personaje s in ListaPersonajes)
            {
                dato = s.MostrarDatos();
                Console.WriteLine(dato);
            }

            string caract;

            foreach (Personaje s in ListaPersonajes)
            {
                caract = s.MostrarCaracteristicas();
                Console.WriteLine(caract);
            }
            */

        }

        static void Combate(Personaje Personaje1, Personaje Personaje2)
        {
            //Realiza 3 veces el ataque al oponenete
            for (int i = 0; i < 3; i++)
            {
                Personaje1.Atacar(Personaje1, Personaje2);   //Personaje 1 ataca al Personaje 2
                Personaje2.Atacar(Personaje2, Personaje1);   //Al reves
            }
        }

        static void CompararSalud(Personaje Personaje1, Personaje Personaje2, List<Personaje> ListaPersonajes, int SaludIniPersonaje1, int SaludIniPersonaje2)  //Aqui tambien se esta realizando un pasaje por refenrecia? Como cuando se realiza un llamado al metodo de una clase
        {
            if (Personaje1.Dato.Salud == Personaje2.Dato.Salud)
            {

            }
            else if (Personaje1.Dato.Salud > Personaje2.Dato.Salud)
            {
                ListaPersonajes.Remove(Personaje2);
                PremioAlGanador(Personaje1, SaludIniPersonaje1);
            }
            else
            {
                ListaPersonajes.Remove(Personaje1);
                PremioAlGanador(Personaje2, SaludIniPersonaje2);
            }
        }

        static void PremioAlGanador(Personaje Ganador, int Salud)
        {
            Ganador.Dato.Salud = Salud;
            Ganador.Dato.Salud += 10;
        }
    }
}
