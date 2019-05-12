using System;

namespace ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            string valor;
            Console.WriteLine("Ingrese numero del dia:");
            valor = Console.ReadLine();
            dia = Convert.ToInt16(valor);

            switch (dia)
            {
                case 1:
                 
                    Console.WriteLine("Lunes");
                    Console.Read(); break;
                case 2:
                    Console.WriteLine("Martes");
                    Console.Read(); break;
                case 3:
                    Console.WriteLine("Miercoles");
                    Console.Read(); break;
                case 4:
                    Console.WriteLine("Jueves");
                    Console.Read(); break;
                case 5:
                    Console.WriteLine("viernes");
                    Console.Read(); break;
                case 6:
                    Console.WriteLine("Sabado");
                    Console.Read(); break;
                case 7:Console.WriteLine("Domingo");
                    Console.Read(); break;
                default: Console.WriteLine("Error"); Console.Read(); break;
            }
        }
    }
}
