using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_TN
{
    internal class Ejercicio6 : IPractica1
    {
        public void Ejecutar()
        {
            Console.WriteLine("ingrese el precio del producto: ");

            double.TryParse(Console.ReadLine(), out double precio);

            Console.WriteLine($"Precio ingresado: {precio.ToString()}");
            
            Console.WriteLine("Ingrese forma de pago: ");
            Console.WriteLine("1 - Efectivo");
            Console.WriteLine("2 - Tarjeta");
            Console.WriteLine("Elija opción de forma de pago: ");

            int.TryParse(Console.ReadLine(), out int opcionPago);

            switch (opcionPago)
            {
                case 1:
                       Console.WriteLine("Pago en Efectivo");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el número de la tarjeta");
                    string numTarjeta = Console.ReadLine() ?? "";
                    if (numTarjeta.Length != 16)
                    {
                        Console.WriteLine($"Número de tarjeta incorrecto  {numTarjeta}");
                    }
                    else {

                        double precioPago = precio * 1.1;
                        precioPago = Math.Round(precioPago, 2);
                        Console.WriteLine($"Precio a Pagar: {precioPago.ToString()}"); 

                    }

                    break;
               default:
                    Console.WriteLine("Opción no valida.");
                    break;
            }

        }
    }
}
