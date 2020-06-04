using System;
using System.ComponentModel.DataAnnotations;

namespace JuegoRol
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje mipersonaje = new Personaje();

            string[] tipo = { "", "", "", "" };

            Console.WriteLine("Cuantos personajes desea crear: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Random Aleatorio = new Random();

                for (j=0; j < 3; j++)
                {
                    int alteatorio = Aleatorio.Next((int)ValoresMaximos.armadura);
                }

                foreach ()
                {

                }


            }
        }
    }
}
