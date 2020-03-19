using System;

namespace operacionMatematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el primer número, por favor" +
                            "\n> ");
            string n1 = Console.ReadLine();
            Console.Write("Introduce el operador, por favor" +
                "\n> ");
            string op = Console.ReadLine();
            Console.Write("Introduce el segundo número, por favor" +
                "\n> ");
            string n2 = Console.ReadLine();
            long resultado;

            try
            {
                Int32.Parse(n1);
                Int32.Parse(n2);
            }
            catch
            {
                //Este código de error indica un mal formato
                System.Environment.Exit(11);
            }


            int n1_1 = int.Parse(n1);
            int n2_1 = int.Parse(n2);

            switch (op)
            {
                case "+":
                    resultado = n1_1 + n2_1;
                    Console.WriteLine("El resultado es: " + n1_1 + " + " + n2_1 + " : " + resultado);
                    break;
                case "-":
                    resultado = n1_1 - n2_1;
                    Console.WriteLine("El resultado es: " + n1_1 + " - " + n2_1 + " : " + resultado);
                    break;
                case "*":
                    resultado = n1_1 * n2_1;
                    Console.WriteLine("El resultado es: " + n1_1 + " * " + n2_1 + " : " + resultado);
                    break;
                case "%":
                    resultado = n1_1 % n2_1;
                    Console.WriteLine("El resultado es: " + n1_1 + " / " + n2_1 + " : " + resultado);
                    break;
                default:
                    //Este código de error indica un mal formato
                    System.Environment.Exit(11);
                    break;

            }
        }
    }
    }

