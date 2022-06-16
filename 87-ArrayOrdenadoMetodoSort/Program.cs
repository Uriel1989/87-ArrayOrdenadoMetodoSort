using System;

//Dado un array de numeros con el metodo Sort, ordenalos y muestra su contenido.

namespace _87_ArrayOrdenadoMetodoSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            array[0] = 32;
            array[1] = 27;
            array[2] = 45;

            Console.WriteLine("Desordenado:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Array.Sort(array);


            Console.WriteLine("Ordenado:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
