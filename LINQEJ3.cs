using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class LINQEj3 : IPractica1
    {

        public void Ejecutar()
        {
            List<string> listado = new List<string>();
            listado.Add("computadora");
            listado.Add("bar");
            listado.Add("usb");
            listado.Add("barrer");
            listado.Add("ventilador");


            //Query Expressions
            var listadoNuevo = from string l in listado
                        where l[0].ToString() == "b" && l.EndsWith('r')
                        select l;
            //Method 
            var listadoNuevo2 = listado.Where(l => l[0].ToString() == "b" && l.EndsWith('r'));

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
