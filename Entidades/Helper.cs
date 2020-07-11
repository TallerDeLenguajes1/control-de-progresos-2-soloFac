using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    static class Helper
    {
        public static DateTime FechaAleatoria(int anios)
        {
            Random aleatorio = new Random();
            DateTime start = DateTime.Today.AddDays(-anios*365);
            int range = (DateTime.Today - start).Days;

            return start.AddDays(aleatorio.Next(range));
        }
    }
}
