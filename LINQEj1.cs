using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    internal class LINQEj1 : IPractica1
    {
        //Dada una lista de números enteros, escriba una consulta que devuelva la
        //lista de números mayores que 30 y menores que 100. Ejemplo: [67, 92, 153, 15] → 67, 92
        public void Ejecutar()
        { 
            List<int> enteros = new List<int>();

            enteros.Add(67);
            enteros.Add(92);
            enteros.Add(153);
            enteros.Add(15);

            //Query Expressions
            var resultado = from ent in enteros
                                where ent > 30 && ent < 100
                                orderby ent descending
                                select ent;
            //Methods
            var resultado2 = enteros.Where(num => num > 30 && num < 100).ToList().OrderDescending();


            Console.WriteLine("Números mayores que 30 y menores que 100:");

            foreach (var ent in resultado)
            {
                Console.WriteLine(ent);
            }

            foreach (var ent2 in resultado2)
            {
                Console.WriteLine(ent2);
            }




        }

    }
}
