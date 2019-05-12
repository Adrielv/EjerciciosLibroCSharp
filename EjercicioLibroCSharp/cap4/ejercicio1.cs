using System;

namespace ejer1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num;
            int resultado;
            Console.WriteLine("Ingrese el numero a multiplicar");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                resultado = num * i;
                Console.WriteLine(num + "*" + i + "=" + resultado);
            }
            Console.Read();
        }
    }
}
