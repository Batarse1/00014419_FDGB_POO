using System;

namespace Ejercicio_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var palindrome = true;
            Console.Write("Digite la palabra que quiere verificar si es palindrome: ");
            var pal = Console.ReadLine();
            int aux = pal.Length;
            for (int i = 0; i < pal.Length; i++)
            {
                aux--;
                if(pal[i] == ' ' && pal[aux] == ' '){
                }
                else if(pal[i] == ' '){
                    aux++;
                }
                else if(pal[aux] == ' '){
                    i--;
                }
                else if(pal[i] != pal[aux]){
                    palindrome=false;
                }
            }

            if (palindrome == true)
            {
                Console.WriteLine("La palabra es palindrome");
            }
            else
            {
                Console.WriteLine("La palabra no es palindrome");
            }
        }
    }
}