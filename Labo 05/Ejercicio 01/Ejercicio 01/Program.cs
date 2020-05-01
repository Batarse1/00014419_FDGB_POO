using System;

namespace Ejercicio_01
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            int num1 = 0;
            int num2 = 1;
            Console.Write("Digite hasta que término n quiere llegar en la sucesión de fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("TÉRMINOS, HASTA EL TÉRMINO NÚMERO "+ n +" DE LA SUCESIÓN DE FIBONACCI: ");
            for (int i = 0;i < n;i++)
            {
                Console.Write(num1);
                if (i < n-1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(".");
                }
                int aux = 0;
                aux = num1 + num2;
                num1 = num2;
                num2 = aux;
            }
        }
    }
}