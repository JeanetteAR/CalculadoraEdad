// Este programa pide el nombre del usuario
// año de nacimiento, calcula la edad del usuario
// y muestra un saludo y un mensaje con su edad
// Repite si el usuario quiere.

using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
        // Mientras la bandera sea true el programa se seguirá repitiendo.
        bool bandera = true;

        while (bandera)
        {
            // 1.- Saludo y entrada de datos.
            Console.WriteLine("Hola, ingresa la siguiente información");
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Año de nacimiento:");
            int userYear = int.TryParse(Console.ReadLine(), out int secureYear) ? secureYear : 0;

            // 2.- Cálculo de edad.
            int actualYear = DateTime.Now.Year;
            int responseYear = actualYear - userYear;

            // 3.- Mensaje respuesta.
            Console.WriteLine($"Hola {nombre}, tienes aproximadamente {responseYear} años.");
            Console.WriteLine("¿Quieres calcular otra edad? (si/no)");
            string repetirResponse = Console.ReadLine();
            if (repetirResponse.ToLower() == "si")
            {
                bandera = true;
            }
            else
            {
                Console.WriteLine("¡Hasta Pronto!");
                bandera = false;
            }
         }
     }
 }
