using System;

namespace pintarConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] car = new string[] { "A", "B", "C", "D", "E" };

            int iter = 0;
            while (iter < 3000)
            {
                //Random de los ejes X e Y
                int y = rnd.Next(1, 24);
                int x = rnd.Next(1, 80);
                //Random del carácter
                int z = rnd.Next(0, 5);
                //Posicionamos el cursor en una posición aleatoria e imprimimos
                Console.SetCursorPosition(x, y);
                Console.Write(car[z]);
                //Generamos aleatoriamente nuevos colores
                Console.ForegroundColor = (ConsoleColor)rnd.Next(16);
                Console.BackgroundColor = (ConsoleColor)rnd.Next(16);
                iter++;
            }
            //Situamos el cursor en la ultima linea para que no aparezca el mensaje
            //de finalización de proceso en mitad de la pantalla
            Console.SetCursorPosition(80, 25);
        }
    }
}
