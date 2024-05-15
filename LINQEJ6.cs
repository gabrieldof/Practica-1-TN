using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class LINQEj6
    {
        /* 6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una 
                lista de palabras dada. Para simplificar escribir todo sin acento.
                Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*" */
        public void Ejecutar()
        {

            Console.WriteLine("Ingrese las palabras separadas por coma:");
            string? entrada = Console.ReadLine();

            List<string> palabras = entrada.Split(',').Select(palabra => palabra.Trim()).ToList();

            List<string> palabrasModificadas = palabras
                .Select(palabra => palabra.Replace("ia", "*"))
                .ToList();

            Console.WriteLine("Palabras modificadas:");
            foreach (var palabra in palabrasModificadas)
            {
                Console.WriteLine(palabra);
            }
        }
    }
}
