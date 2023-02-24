using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Esta clase contiene métodos para convertir de segundos a minutos y viceversa
    /// </summary>
    class HadaP1
    {
       /// <summary>
       /// Esta funcion recibe por parametro una cantidad determinada de segundos y lo convierte a minutos.
       /// </summary>
       /// <param name="s"></param>
       /// <returns></returns>
        public static double Seconds2Minutes(double s)
        {
            if(s == 0)
            {
                return 0;
            }
            else
            {
                double m = s / 60;
                return m;
            }
        }
        /// <summary>
        /// Esta funcion recibe por parametro una cantidad determinada de minutos y lo convierte a segundos.
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static double Minutes2Seconds(double m)
        {
            double sec = m * 60;
            return sec;
        }
    }
}
