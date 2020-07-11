using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoRol
{   //minuto 44 del video

    public enum MaximosValCaract
    {
        velocidad = 10,
        destreza = 5,
        fuerza = 10,
        nivel = 10,
        armadura = 10
    }

    enum Tipos
    {
        barbaro,
        luchador,
        spartano,
        chino,
        romano,
        andabata,
        crestus
    }

    public class Personaje
    {
        Datos dato = new Datos();
        Caracteristicas caracteristica = new Caracteristicas();

        public Datos Dato { get => dato; set => dato = value; }
        public Caracteristicas Caracteristica { get => caracteristica; set => caracteristica = value; }

        /*
        Personaje CargarDatos()
        {
            Random gen = new Random();
            Velocidad = gen.Next(1, Tipo.Velocidad);
            Destreza = ;
            Fuerza =
            Nivel = 
            Armadura =

            return 
        }
        */

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

        public void GenerarPersonaje()
        {
            var rand = new Random();
            DateTime Fecha = Helper.FechaAleatoria(rand.Next(80, 401));

            string[] Nombre = {"Ansgar", "Rilien", "Rhovanion", "Thandraug", "Eola", "Lothar", "Sakata"};
            string[] Apodo = {"Infinity", "Haruka", "Tzuyu", "Punchman", "Steff", "Taylor", "Harston"};

            Dato.Nombre = Nombre[rand.Next(Nombre.Length)];
            Dato.Apodo = Apodo[rand.Next(Apodo.Length)];
            Dato.Tipo = (JuegoRol.Tipos) rand.Next(7 + 1);
            Dato.FechaNacimiento = Fecha;

            Caracteristica.Velocidad = rand.Next((int)MaximosValCaract.velocidad) + 1;
            Caracteristica.Destreza = rand.Next((int)MaximosValCaract.destreza) + 1;
            Caracteristica.Fuerza = rand.Next((int)MaximosValCaract.fuerza) + 1;
            Caracteristica.Nivel = rand.Next((int)MaximosValCaract.nivel) + 1;
            Caracteristica.Armadura = rand.Next((int)MaximosValCaract.armadura) + 1;
        }

        public string MostrarDatos()
        {
            string StringDatos = Dato.Nombre + "\n" + Dato.Apodo + "\n" + Dato.Tipo + "\n" + 
                    Dato.FechaNacimiento.ToShortDateString() + "\n";

            return StringDatos;
        }

        public string MostrarCaracteristicas()
        {
            string StringCaracteristicas = "Velocidad: " + Caracteristica.Velocidad + "\n" + "Destreza: " + Caracteristica.Destreza + "\n" + 
                "Fuerza: " + Caracteristica.Fuerza + "\n" + "Nivel: " + Caracteristica.Nivel + "\n" + 
                "Armadura: " + Caracteristica.Armadura + "\n";

            return StringCaracteristicas;
        }
    }

    public class Datos
    {
        Tipos tipo;
        string nombre;
        string apodo;
        DateTime fechaNacimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        internal Tipos Tipo { get => tipo; set => tipo = value; }
    }

    public class Caracteristicas
    {
        int velocidad;
        int destreza;
        int fuerza;
        int nivel;
        int armadura;

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
    }
}

