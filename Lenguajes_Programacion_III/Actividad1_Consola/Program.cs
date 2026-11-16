using System;

namespace Actividad1_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables en camelCase
            string nombreCompleto;
            int edad;
            string fechaNacimiento;
            string carreraIngreso;

            // Mensaje de bienvenida inicial
            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel");
            Console.WriteLine("------------------------------------");

            // Solicitud y captura de datos
            Console.Write("Ingresa tu Nombre completo: ");
            nombreCompleto = Console.ReadLine();

            Console.Write("Ingresa tu Edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tu Fecha de Nacimiento (DD/MM/AAAA): ");
            fechaNacimiento = Console.ReadLine();

            Console.Write("Ingresa la Carrera a la que desea ingresar: ");
            carreraIngreso = Console.ReadLine();

            Console.WriteLine();
            // Mensaje final exacto solicitado por la rúbrica
            Console.WriteLine($"Gracias {nombreCompleto} por formar parte de UMI/Universidad Coppel, Bienvenido a la carrera {carreraIngreso}");

            // Pausa para evitar que se cierre la ventana de consola
            Console.ReadLine();
        }
    }
}