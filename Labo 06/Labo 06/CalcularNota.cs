using System;
using System.Collections.Generic;

namespace Labo_06
{
    public static class CalcularNota
    {
        public static double Calcular(List<Evaluacion> ev)
        {
            bool continuar = true;
            double opt = 0;
            double numerador = 0;
            int cont = 0;
            foreach (var element in ev)
            { 
                continuar = true;
                do 
                {
                       try
                       {
                           Console.WriteLine("¿Cúal fue su calificación de la siguiente evaluación?");
                           if (element is Laboratorio)
                           {
                               Console.WriteLine("Laboratorio");
                               Console.WriteLine(((Laboratorio)element).ToString());
                           }
                           else if (element is Parcial)
                           {
                               Console.WriteLine("Parcial");                    
                               Console.WriteLine(((Parcial)element).ToString());
                           }
                           else
                           {   
                               Console.WriteLine("Tarea");
                               Console.WriteLine(((Tarea)element).ToString());
                           }
                           opt = Convert.ToByte(Console.ReadLine());
                           numerador += opt*element.Porcentaje;
                           continuar = false;
                       }
                       catch (FormatException)
                       {
                           Console.WriteLine("Opción invalida,  Digite un número entre 1 y 2...");
                       }
                } while (continuar); 
                cont++;
            }
            return numerador/100;
        }
    }
}