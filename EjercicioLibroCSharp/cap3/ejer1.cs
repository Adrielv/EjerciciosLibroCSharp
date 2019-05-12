using System;

namespace ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Ingrese un numero para saber si es par o impar");
            valor = Convert.ToInt16(Console.ReadLine());

            if ((valor % 2) == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es impar");
            Console.Read();

        }
    }
}
