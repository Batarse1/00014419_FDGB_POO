using System;
using System.Collections.Generic;

namespace Ejercicio_05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var lista = new List<Char>();
            Console.Write("Digite cuantos letras quiere ingresar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int aux = i + 1;
                Console.Write("Digite el carácter " + aux + ": ");
                Char c = Convert.ToChar(Console.ReadLine());
                if(c=='a' || c=='e' || c=='i' || c=='o' || c=='u' || c=='A' || c=='E' || c=='I' || c=='O' || c=='U'){
                    lista.Add(c);
                }
            }
            Console.Write("Las vocales que se ingresaron fueron las siguientes: " + String.Join(", ",lista));
        }
    }
}