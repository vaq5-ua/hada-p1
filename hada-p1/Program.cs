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
                Console.WriteLine("Introduce unidad (segundos/minutos)");
                String unidad = Console.ReadLine();
                Console.WriteLine("Introduce cantidad");
                Double cantidad = double.Parse(Console.ReadLine());
                Console.WriteLine("Desea continuar? (si/no)");
                ans = Console.ReadLine();
            } while (ans == "si");
        }
    }
}
