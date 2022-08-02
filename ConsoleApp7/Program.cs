using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            int num2 = int.Parse(Console.ReadLine());
            var multiplicacion = num1 * num2;
            Console.WriteLine("La multiplicacdion de los numeros es: {0}", multiplicacion);
        }
    }
}
