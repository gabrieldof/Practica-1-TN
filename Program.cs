// See https://aka.ms/new-console-template for more information
using Practica_1_TN;

Console.WriteLine("Hello, World!");

var ej1 = new Ejercicio1();
var ej2 = new Ejercicio2();
var ej3 = new Ejercicio3();

Console.WriteLine($" {ej1.GetType().Name}");
ej1.Ejecutar();

Console.WriteLine($" {ej2.GetType().Name}");
ej2.Ejecutar();

Console.WriteLine($" {ej3.GetType().Name}");
ej3.Ejecutar();