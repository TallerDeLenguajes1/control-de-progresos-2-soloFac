using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoRol
{

    public enum ValoresMaximos
    {
        velocidad = 10,
        destreza = 5,
        fuerza = 10,
        nivel = 10,
        armadura = 10
    }

    enum Tipos
    {
        barbaro = 0,
        luchador = 1,
        spartano = 2
    }

    public class Personaje
    {

        int velocidad;
        int destreza;
        int fuerza;
        int nivel;
        int armadura;

        Tipos tipo;
        string nombre;
        string apodo;
        DateTime FechaNacimiento;


        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public Tipos Tipo { get => tipo; set => tipo = value; }



        /*
        static public class Helper
        {
            public static DateTime FechaAleatoria(int anios)
            {
                Random gen = new Random();
                DateTime start = DateTime.Today.AddDays(-anios);
                int range = (DateTime.Today - start).Days;
                return start.AddDays(gen.Next(range));
            }
        }
        */
    }

