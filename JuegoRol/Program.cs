using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JuegoRol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personaje> ListaPersonajes = new List<Personaje>();

            var aleat = new Random();

            int CantidadDePersonajes = aleat.Next(40,50);

            for (int i = 1; i <= CantidadDePersonajes; i++)
            {
                Personaje mipersonaje = new Personaje();
                mipersonaje.GenerarPersonaje();

                ListaPersonajes.Add(mipersonaje);
            }

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

            //string datos = ListaPersonajes

        }
    }
}
