using System;

namespace Ejercicio_04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite la frase que quiere encriptar: ");
            var frase = Console.ReadLine();
            var frase_mofificada = frase.Replace('a', 'b');
            Console.WriteLine("La frase encriptada es: " + frase_mofificada);
        }
    }
}