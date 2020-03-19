using System;

namespace tryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;
            String ruta = "/Users/whysxpvrrv/ejemplo.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(ruta);

            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                }
                file.Close();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Error reading from {0}. Message = {1}", ruta, e.Message);
                Environment.Exit(0);

            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
                System.Console.WriteLine("There were {0} lines.", counter);
                System.Console.ReadLine();
                Environment.Exit(0);

            }
        }
    }
    }

