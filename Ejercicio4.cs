using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    public class Ejercicio4 : IPractica1
    {

        // 4) Pedir dos números al usuario por teclado y decir qué número es el mayor.
        public void Ejecutar()
        { 
            int num1, num2;

            Console.WriteLine("Ingrese el primer número: ");
            int.TryParse(Console.ReadLine(), out num1);
            //num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            int.TryParse(Console.ReadLine(), out num2);

            if (num1 > num2)
            {
                Console.WriteLine($"El número {num1} es mayor que {num2}.");            
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"El número {num2} es mayor que {num1}.");
            }
            else
            {
                Console.WriteLine($"Los números {num1} y {num2} son iguales.");
            }




        }

    }
}
