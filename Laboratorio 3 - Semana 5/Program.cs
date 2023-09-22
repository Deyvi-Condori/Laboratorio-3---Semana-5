using System;

namespace PromNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de notas: ");
            int cantidadNotas = int.Parse(Console.ReadLine());

            int sumaNotas = 0; 

            for (int i = 1; i <= cantidadNotas; i++)
            {
                Console.Write($"Ingrese la nota {i}: ");
                int nota = int.Parse(Console.ReadLine());
                sumaNotas += nota;
            }

            int promedio = sumaNotas / cantidadNotas;

            Console.WriteLine($"El promedio es {promedio}");
        }
    }
}