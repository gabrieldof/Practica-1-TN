using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class LINQEj7 : IPractica1
    {
        /*7) Implementar la función 
            public static IList<string> DevolverPalabrasCapitales(string cadena)
            que devuelva sólo las palabras en mayúsculas de la cadena.
            Ejemplo: "ESTO es un EJEMPLO del EJERcicio" → ESTO, EJEMPLO */


        public void Ejecutar()
        {

            string cadena = "ESTO es un EJEMPLO del EJERcicio";
            IList<string> palabrasCapitales = DevolverPalabrasCapitales(cadena);

            Console.WriteLine("Palabras en mayúsculas:");
            foreach (string palabra in palabrasCapitales)
            {
                Console.WriteLine(palabra);
            }

        }

        public static IList<string> DevolverPalabrasCapitales(string cadena)

        {
            var listaSplit = cadena.Split(" ");
            var lista = from palabra in listaSplit
                        where palabra == palabra.ToUpper()
                        select palabra;




            return lista.ToList();
            
        }

    }
}
