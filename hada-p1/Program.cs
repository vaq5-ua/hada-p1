using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            String ans;
            do
            {
                String unidad;
                do {
                    Console.WriteLine("Introduce unidad (segundos/minutos/horas)");
                    unidad = Console.ReadLine();
                } while (unidad != "segundos" && unidad != "minutos" && unidad != "horas");
                Console.WriteLine("Introduce cantidad");
                Double cantidad = double.Parse(Console.ReadLine());
                if(unidad == "segundos"){
                    Console.WriteLine(HadaP1.Seconds2Minutes(cantidad) + " Minutos");
                }
                else if(unidad == "minutos"){
                    Console.WriteLine(HadaP1.Minutes2Seconds(cantidad) + " Segundos");
                }
                else{
                    Console.WriteLine(HadaP1.Hours2Minutes(cantidad) + " Minutos");
                }

                Console.WriteLine("Desea continuar? (si/no)");

                ans = Console.ReadLine();
            } while (ans == "si");
        }
    }
}
