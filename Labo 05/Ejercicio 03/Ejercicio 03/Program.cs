using System;

namespace Ejercicio_03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite el número n hasta el que quiere llegar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            recursivefunction(1,n);
        }

        public static void recursivefunction(int cont,int n)
        {
            if (n == cont)
            {
                Console.WriteLine(cont);
            }
            else
            {
                Console.WriteLine(cont);
                recursivefunction(++cont, n);
                Console.WriteLine(--cont);
            }
        }
    }
}