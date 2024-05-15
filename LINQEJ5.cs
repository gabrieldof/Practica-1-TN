using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    /* 5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: 
            "número - cuadrado" sólo si el cuadrado es mayor que 20
            Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900” */

    
    public class LINQEj5
    {
        public void Ejecutar()
        {
            //List<int> lista = new List<int>();

            Console.WriteLine("Ingrese los números separados por comas:");
            string? entrada = Console.ReadLine();
            List<int> numeros = entrada.Split(',').Select(int.Parse).ToList();


            //Method
            var resultado = numeros.Select(l => new { Original = l, Cuadrado = l * l })
                 .Where(x => x.Cuadrado > 20)
                 .Select(x => $"{x.Original} - {x.Cuadrado}");
            //Query Expressions
            //         var resultado = from n in numeros
            //let cuadrado = n * n
            //            where cuadrado > 20
            //            select $"{n} - {cuadrado}";

            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }


        }
    }
}
