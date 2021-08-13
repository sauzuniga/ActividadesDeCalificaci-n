using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesDeCalificación
{
    class Diccionario
    {
        static void Main()
        {
            Dictionary<string, int> familia = new Dictionary<string, int>();
            familia.Add(" Yesenia", 46);
            familia.Add(" Miguel", 18);
            familia.Add(" Alberto", 56);
            familia.Add(" Saúl", 19);
            var list = familia.Keys.ToList();
            list.Sort();
            foreach (var item in list )
            {
                Console.WriteLine("Key: {0}, value: {1}", item, familia[item]);
            }
            Console.ReadKey();
        }
    }
}
