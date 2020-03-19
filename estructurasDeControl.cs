using System;

namespace estructurasDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce la cantidad de numeros que quieres crear, por favor..." +
                "\n> ");
            string l = Console.ReadLine();
            int cantidad = int.Parse(l);
            Random r = new Random();
            int[] array = new int[cantidad];
            Console.WriteLine("Números generados aleatoriamente: ");

            for (int i = 0; i < array.Length; i++)
            {
                //Generamos los números aleatorios de entre uno y 100,
                //En caso de que sean pares, los introducimos en el array, contando el 0.
                int aleatorio = r.Next(1, 100);

                if (aleatorio % 2 == 0)
                {
                    array[i] = aleatorio;

                }
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nMultiplicación de los números: ");

            int resultado = 0;
            //Mostramos la multiplicación 1 a 1

             for (int i = 0; i < array.Length-1; i++)
            {
                resultado = array[i] * array[i + 1];
                Console.Write(array[i] + " * " + array[i + 1] + " = " + resultado);
            }
        }

    }
}
