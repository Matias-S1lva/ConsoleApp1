using System;
using System.Collections.Generic;
using ConsoleApp1;


class Program
{
    static void Main(string[] args)
    {
        
        List<Alumno> alumnos = new List<Alumno>();

        while (true)
        {
            Console.WriteLine("1: Agregar datos");
            Console.WriteLine("2: Promedio de notas");
            Console.WriteLine("3: Cantidad de alumnos aprobados");
            Console.WriteLine("4: Cantidad de alumnos desaprobados");
            Console.WriteLine("5: Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (alumnos.Count < 30)
                    {
                        Alumno nuevoAlumno = new Alumno();
                        Console.Clear();
                        Console.WriteLine("Ingrese nombre:");
                        nuevoAlumno.Nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese apellido:");
                        nuevoAlumno.Apellido = Console.ReadLine();

                        Console.WriteLine("Ingrese nota:");
                        nuevoAlumno.Nota = double.Parse(Console.ReadLine());

                        alumnos.Add(nuevoAlumno);
                    }
                    else
                    {
                        Console.WriteLine("Se ha alcanzado el máximo de alumnos (30).");
                    }
                    break;

                case 2:
                    Console.Clear();
                    double sumaNotas = 0;
                    foreach (Alumno alumno in alumnos)
                    {
                        sumaNotas += alumno.Nota;
                    }
                    double promedio = sumaNotas / alumnos.Count;
                    Console.WriteLine("El promedio de notas es: " + promedio);
                    break;

                case 3:

                    Console.Clear();
                    int aprobados = 0;
                    foreach (Alumno alumno in alumnos)
                    {
                        if (alumno.Nota >= 4)
                        {
                            aprobados++;
                        }
                    }
                    Console.WriteLine("Cantidad de alumnos aprobados: " + aprobados);
                    break;

                case 4:

                    Console.Clear();
                    int desaprobados = 0;
                    foreach (Alumno alumno in alumnos)
                    {
                        if (alumno.Nota < 4)
                        {
                            desaprobados++;
                        }
                    }
                    Console.WriteLine("Cantidad de alumnos desaprobados: " + desaprobados);
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Saliendo del programa...");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Ingrese un número del 1 al 5.");
                    break;
            }
        }
    }
}
