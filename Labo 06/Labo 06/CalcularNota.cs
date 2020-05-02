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
                            Console.WriteLine(((Laboratorio) element).ToString());
                        }
                        else if (element is Parcial)
                        {
                            Console.WriteLine("Parcial");
                            Console.WriteLine(((Parcial) element).ToString());
                        }
                        else
                        {
                            Console.WriteLine("Tarea");
                            Console.WriteLine(((Tarea) element).ToString());
                        }

                        opt = Convert.ToDouble(Console.ReadLine());
                        if (opt < 0 || opt > 10)
                        {
                            throw new OutOfLimitsException("Número inválido, digite un numero entre 0 y 10");
                        }

                        numerador += opt * element.Porcentaje;
                        continuar = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Opción invalida,  Digite un número entre 0 y 10...");
                    }
                    catch (OutOfLimitsException exc)
                    {
                        Console.WriteLine(exc.Message);
                    }
                } while (continuar); 
                cont++;
            }
            return numerador/100;
        }
    }
}