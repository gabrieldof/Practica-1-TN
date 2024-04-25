using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class LINQEj4 : IPractica1
    {

        //4)4) Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
        //Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21

        public void Ejecutar()
        {
            List<int> numeros = new List<int>();
            numeros.Add(78);
            numeros.Add(-9);
            numeros.Add(0);
            numeros.Add(23);
            numeros.Add(54);
            numeros.Add(21);
            numeros.Add(7);
            numeros.Add(86);



            var listadoNuevo = (from int num in numeros
                         orderby num descending
                         select num).Take(5);



            var listadoNuevo2 = numeros.OrderByDescending(num => num).Take(5);

            foreach (var item in listadoNuevo)
            {
                Console.WriteLine(item);
            }

            foreach (var item in listadoNuevo2)
            {
                Console.WriteLine(item);
            }

        }

    }
}
