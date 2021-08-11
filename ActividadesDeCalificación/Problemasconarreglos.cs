using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesDeCalificación
{
    class Problemasconarreglos
    {
        static void Main()
        {
            int mayor = 0;
            string[] Nombres = new string[10];
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine(" Escriba el nombre del estudiantes {0}: ",i);
                Nombres[i] = Console.ReadLine();

            }
            int[] notas = new int[10];
            for (int inc = 0; inc < notas.Length; inc++)
            {
                Console.WriteLine(" Escriba las notas del estudiante {0} ", inc);
                notas[inc] = int.Parse(Console.ReadLine());
                if (notas[inc] > mayor )
                {
                    mayor = notas[inc];
                }
            }

            int suma = notas[0] + notas[1] + notas[2] + notas[3] + notas[4] + notas[5] + notas[6] + notas[7] + notas[8] + notas[9];
            double promedio = suma / 10;
           for (int i= 0; i < Nombres.Length; i++)
            {
                Console.WriteLine("Estudiante {0}: {1} ", i, Nombres[i]);
            }
           for (int inc = 0; inc < notas.Length; inc++)
            {
                Console.WriteLine("Calificación estudiante {0}: {1} ", inc, notas[inc]);
            }
            Console.WriteLine(" El promedio de las de las notas de los estudiantes es: "+ promedio);
            Console.WriteLine("La nota mayor es: " + mayor);
            Console.ReadKey();
        }
    }
}
