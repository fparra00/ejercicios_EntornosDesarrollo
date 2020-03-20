using System;

/*********************
* Autor: Fernando Parra
* Curso: 1DAM
* Asignación: Condicionales condicionesCompuestas
* Fecha Asignación: 5 de Febrero de 2020
*********************/

namespace condicionesCompuestas
{
    class Program
    {
        static void Main(string[] args)
        {
            String mes;
            Console.Write("Introduce un mes del año, por favor..." +
                "\n> ");
            //Captamos el mes por teclado, extraemos unicamente las tres
            //primeras letras de la cadena y las convertimos a minusculas
            mes = Console.ReadLine();
            mes = mes.Substring(0, 3);
            mes = mes.ToLower();

            //Comprobamos que la cadena contenga las siguientes palabras
            if (mes.Equals("ene")|| mes.Equals("feb") || mes.Equals("mar"))
            {
                Console.WriteLine("El mes introducido es del primer trimestre");
            }
        }
    }
}
