using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio3 : IPractica1
    {

       /*3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: “Te llamas ” 
        * <nombre> ” y tienes ” <años> ” años” */
        public void Ejecutar()
        {
            Console.WriteLine("Ingrese su nombre: ");
            string? nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            string? edad = Console.ReadLine();

            Console.WriteLine($"Te llamas {nombre} y tienes {edad} años");

        }

    }
}
