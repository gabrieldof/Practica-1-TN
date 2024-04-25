// See https://aka.ms/new-console-template for more information
using Practica_1_TN;

//Console.WriteLine("Hello, World!");

/*var ej1 = new Ejercicio1();*/

/*Console.WriteLine($" {ej1.GetType().Name}");
ej1.Ejecutar();*/

Console.WriteLine("Seleccione el número del ejercicio que desea ejecutar:");
Console.WriteLine("1. Ejercicio 1");
Console.WriteLine("2. Ejercicio 2");
Console.WriteLine("3. Ejercicio 3");
Console.WriteLine("4. Ejercicio 4");
Console.WriteLine("5. Ejercicio 5");
Console.WriteLine("6. Ejercicio 6");
Console.WriteLine("7. Ejercicio 7");
Console.WriteLine("8. Ejercicio 8");
Console.WriteLine("9. Ejercicio 9");
Console.WriteLine("10. Ejercicio 10");
Console.WriteLine("11. LINQ Ejercicio 1");
Console.WriteLine("12. LINQ Ejercicio 2");
Console.WriteLine("13. LINQ Ejercicio 3");
Console.WriteLine("14. LINQ Ejercicio 4");
Console.WriteLine("15. LINQ Ejercicio 5");
Console.WriteLine("16. LINQ Ejercicio 6");
Console.WriteLine("17. LINQ Ejercicio 7");
Console.WriteLine("Ingrese el número correspondiente:");

int opcion = Convert.ToInt32(Console.ReadLine());


switch (opcion)
{
    case 1:
        var ej1 = new Ejercicio1();
        Console.WriteLine($"Ejecutando: {ej1.GetType().Name}");
        ej1.Ejecutar();
        break;
    case 2:
        var ej2 = new Ejercicio2();
        Console.WriteLine($"Ejecutando: {ej2.GetType().Name}");
        ej2.Ejecutar();
        break;
    case 3:
        var ej3 = new Ejercicio3();
        Console.WriteLine($"Ejecutando: {ej3.GetType().Name}");
        ej3.Ejecutar();
        break;
    case 4:
        var ej4 = new Ejercicio4();
        Console.WriteLine($"Ejecutando: {ej4.GetType().Name}");
        ej4.Ejecutar(); ;
        break;
    case 5:
        var ej5 = new Ejercicio5();
        Console.WriteLine($"Ejecutando: {ej5.GetType().Name}");
        ej5.Ejecutar(); ;
        break;
    case 6:
        var ej6 = new Ejercicio6();
        Console.WriteLine($"Ejecutando: {ej6.GetType().Name}");
        ej6.Ejecutar(); ;
        break;
    case 7:
        var ej7 = new Ejercicio7();
        Console.WriteLine($"Ejecutando: {ej7.GetType().Name}");
        ej7.Ejecutar(); ;
        break;
    case 8:
        var ej8 = new Ejercicio8();
        Console.WriteLine($"Ejecutando: {ej8.GetType().Name}");
        ej8.Ejecutar(); ;
        break;
    case 9:
        var ej9 = new Ejercicio9();
        Console.WriteLine($"Ejecutando: {ej9.GetType().Name}");
        ej9.Ejecutar(); ;
        break;
    case 10:
        var ej10 = new Ejercicio10();
        Console.WriteLine($"Ejecutando: {ej10.GetType().Name}");
        ej10.Ejecutar(); ;
        break;
    case 11:
        var linqEj1 = new LINQEj1();
        Console.WriteLine($"Ejecutando: {linqEj1.GetType().Name}");
        linqEj1.Ejecutar(); ;
        break;
    case 12:
        var linqEj2 = new LINQEj2();
        Console.WriteLine($"Ejecutando: {linqEj2.GetType().Name}");
        linqEj2.Ejecutar(); ;
        break;
    case 13:
        var linqEj3 = new LINQEj3();
        Console.WriteLine($"Ejecutando: {linqEj3.GetType().Name}");
        linqEj3.Ejecutar(); ;
        break;
    case 14:
        var linqEj4 = new LINQEj4();
        Console.WriteLine($"Ejecutando: {linqEj4.GetType().Name}");
        linqEj4.Ejecutar(); ;
        break;
    case 15:
        var linqEj5 = new LINQEj5();
        Console.WriteLine($"Ejecutando: {linqEj5.GetType().Name}");
        linqEj5.Ejecutar(); ;
        break;
    case 16:
        var linqEj6 = new LINQEj6();
        Console.WriteLine($"Ejecutando: {linqEj6.GetType().Name}");
        linqEj6.Ejecutar(); ;
        break;
    case 17:
        var linqEj7 = new LINQEj7();
        Console.WriteLine($"Ejecutando: {linqEj7.GetType().Name}");
        linqEj7.Ejecutar(); ;
        break;
    default:
        Console.WriteLine("Opción no válida. Por favor, seleccione un número válido.");
        break;
}

