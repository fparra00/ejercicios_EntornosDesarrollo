using System;

namespace ejerciciosConArreglos
{
    class Program
    {
        //Creamos enumeración con todos los días
        public enum dias
        {
            Lunes=0,
            Martes=1,
            Miercoles=2,
            Jueves=3,
            Viernes=4,
            Sabado=5,
            Domingo=6
        }
            static void Main(string[] args)
        {
            //Creamos arrays con los días y las horass trabajadas
            int[] hmanana = { 4, 4, 4, 4, 6, 0, 0 };
            Console.WriteLine("BIENVENIDO A CALENDARIO LABORAL");
            Console.Write("¿De que día deseas comprobar las horas trabajadas?" +
                "\n> ");
            String l = Console.ReadLine();
            int dia = int.Parse(l);
            dia = dia - 1;
            dias x = (dias)dia;

            if (dia<=6&&dia>=0)
            {
                Console.WriteLine("\nDía: " + x + "\nHoras trabajadas: " + hmanana[dia]);
            } else
            {
                Console.WriteLine("Día incorrecto");
            }

                }
    }
}
