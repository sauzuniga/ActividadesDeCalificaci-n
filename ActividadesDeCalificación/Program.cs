using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesDeCalificación
{
    class Program
    {
        static void Main()
        {
            int[] notas = new int[10];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Escriba la nota {0}: ", i);
                notas[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("notas {0}: {1}", i, notas[i]);
               
            }
            Console.ReadKey();
        }
    }
}
