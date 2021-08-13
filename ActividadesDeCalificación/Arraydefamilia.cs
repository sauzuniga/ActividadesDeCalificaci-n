using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesDeCalificación
{
    class Arraydefamilia
    {
        static void Main()
        {
            string[] miembros = new string[5];
            for(int i=0; i<miembros.Length; i++)
            {
                Console.WriteLine("Ingrese el miembro {0}:", i);
                miembros[i] = Console.ReadLine();
            }
            Array.Sort(miembros);
            for (int i = 0;i<miembros.Length;i++)
            {
                Console.WriteLine(" Nombres de los integrantes {0}: {1} ", i, miembros[i]);
            }
            Console.ReadKey();y
        }
    }
}
