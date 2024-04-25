using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class LINQEj2 : IPractica1
    {
        /*
            2) Escriba una consulta que devuelva palabras de al menos 5 caracteres y las ponga en mayúsculas. 
            Ejemplo: "computadora", "usb" → "COMPUTADORA"

         */

        public void Ejecutar()
        {
            List<string> listado = new List<string>();
            listado.Add("computadora");
            listado.Add("usb");

            var listadoNuevo = listado.Where(palabra => palabra.Length >= 5).Select(palabra => palabra.ToUpper()).ToList();


            foreach (var item in listadoNuevo)
            {
                Console.WriteLine(item);
            }

        }


    }
}
