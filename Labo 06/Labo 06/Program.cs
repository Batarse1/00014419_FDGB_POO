using System;
using System.Collections.Generic;

namespace Labo_06
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            var evaluationList = new List<Evaluacion>();       
            byte opt = 0;
            do
            {
                try
                {
                    menu();
                    opt = Convert.ToByte(Console.ReadLine());
                    switch (opt)
                    {
                        case 1: 
                            evaluationList = AgregarEvaluacion(evaluationList);
                            break;
                        case 2:
                            MostrarEvaluaciones(evaluationList);
                            break;
                        case 3:
                            evaluationList = EliminarEvaluacion(evaluationList);
                            break;
                        case 4:
                            break;
                        default:
                            throw new OutOfLimitsException("Opción inválida, Digite un número entre 1 y 4...");
                    }
                }
                catch (OutOfLimitsException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opción invalida,  Digite un número entre 1 y 4...");
                }
            } while (opt!=4);
        }
        
        private static void menu()
        {
            Console.WriteLine(
                "MENU \n"+
                "1.Agregar evaluación \n"+
                "2.Mostrar evaluaciones almacenadas \n"+
                "3.Eliminar evaluación \n"+
                "4.Terminar programa"
            );
        }
        
        private static List<Evaluacion> AgregarEvaluacion(List<Evaluacion> ev)
        {
            bool continuar = true;
            int porcentaje = 0;
            int tipoEvaluacion = 0;
            string nombre = "\0";
            do
            {
                try
                {
                    MenuTipo();
                    tipoEvaluacion = Convert.ToByte(Console.ReadLine());
                    if (tipoEvaluacion < 1 || tipoEvaluacion > 3)
                    {
                        throw new OutOfLimitsException("Opción inválida, Digite un número entre 1 y 3...");
                    }
                }
                catch (OutOfLimitsException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opción invalida,  Digite un número entre 1 y 3...");
                }
            } while (tipoEvaluacion!=1 && tipoEvaluacion!=2 && tipoEvaluacion!=3);

            do
            {
                try
                {
                    Console.Write("Digite el nombre: ");
                    nombre = Console.ReadLine();
                    if (nombre.Equals(""))
                    {
                        throw new EmptyStringException("Nombre inválido, debe introducir una cadena de caracteres");
                    }
                    else
                    {
                        continuar = false;
                    }
                }
                catch(EmptyStringException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            } while (continuar);
            
            continuar = true;
            do
            {
                try
                {
                    Console.Write("Digite el porcentaje: ");
                    porcentaje = Convert.ToInt32(Console.ReadLine());
                    if (porcentaje <= 0)
                    {
                        throw new WrongPercentageException("Porcentaje inválido, digite un porcentaje positivo");
                    }
                    else if (PorcentajeActual(ev) + porcentaje > 100)
                    {
                        throw new WrongPercentageException(
                            "Porcentaje inválido, digite un porcentaje que no lleve a cabo un exceso del 100%");
                    }
                    else
                    {
                        continuar = false;
                    }
                }
                catch (WrongPercentageException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Porcentaje inválido, digite un número entero");
                }
            } while (continuar);

            if (tipoEvaluacion == 1)
            {
                string tipoLaboratorio = "\0";
                continuar = true;
                do
                {
                    try
                    {
                        Console.Write("Digite el tipo de laboratorio:");
                        tipoLaboratorio = Console.ReadLine();
                        if (tipoLaboratorio.Equals(""))
                        {
                            throw new EmptyStringException("Tipo de laboratorio inválido, debe introducir una cadena de caracteres");
                        }
                        else
                        {
                            continuar = false;
                        }
                    }
                    catch(EmptyStringException exc)
                    {
                        Console.WriteLine(exc.Message);
                    }
                } while (continuar);
                
                Laboratorio aux = new Laboratorio(porcentaje,nombre,tipoLaboratorio);
                ev.Add(aux);
            }

            if (tipoEvaluacion == 2)
            {
                int cantidadPreguntas = 0;
                continuar = true;
                do
                {
                    try
                    {
                        Console.Write("Digite la cantidad de preguntas: ");
                        cantidadPreguntas = Convert.ToInt32(Console.ReadLine());
                        if (cantidadPreguntas <= 0)
                        {
                            throw new WrongPercentageException("Cantidad de preguntas inválida, digite un porcentaje positivo");
                        }
                        else
                        {
                            continuar = false;
                        }
                    }
                    catch (WrongPercentageException exc)
                    {
                        Console.WriteLine(exc.Message);
                    }
                    catch (FormatException exc)
                    {
                        Console.WriteLine("Cantidad de preguntas inválida, digite un número entero");
                    }
                } while (continuar);
                Parcial aux = new Parcial(porcentaje,nombre,cantidadPreguntas);
                ev.Add(aux);
            }
            
            if (tipoEvaluacion == 3)
            {
                DateTime fechaEntrega = DateTime.Today;
                continuar = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Digite la fecha con el siguiente formato Mes/Día/Año");
                        DateTime tipoLaboratorio = DateTime.Parse(Console.ReadLine(),
                            System.Globalization.CultureInfo.InvariantCulture);
                        continuar = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Fecha inválida, digite la fecha con el siguiente formato Mes/Día/Año");
                    }
                } while (continuar);
                Tarea aux = new Tarea(porcentaje,nombre,fechaEntrega);
                ev.Add(aux);
            }
            return ev;
        }
        
        private static void MenuTipo()
        {
            Console.WriteLine(
                "DIGITE EL TIPO DE EVALUACIÓN \n" +
                "1.Laboratorio \n"+
                "2.Parcial \n" +
                "3.Tarea"
            );
        }

        private static int PorcentajeActual(List<Evaluacion> ev)
        {
            int suma = 0;
            foreach (var element in ev)
            {
                suma += element.Porcentaje;
            }
            return suma;
        }

        private static void MostrarEvaluaciones(List<Evaluacion> ev)
        {
            int cont = 0;
            Console.WriteLine();
            foreach (var element in ev)
            {
                cont++;
                Console.WriteLine("Evaluación "+cont);
                if (element is Laboratorio)
                {
                    Console.WriteLine("Laboratorio");
                    Console.WriteLine("Nombre: " + element.Nombre);
                    Console.WriteLine("Porcentaje: " + element.Porcentaje);                    
                }
                else if (element is Parcial)
                {
                    Console.WriteLine("Parcial");
                    Console.WriteLine("Nombre: " + element.Nombre);
                    Console.WriteLine("Porcentaje: " + element.Porcentaje);                    
                }
                else
                {
                    Console.WriteLine("Tarea");
                    Console.WriteLine("Nombre: " + element.Nombre);
                    Console.WriteLine("Porcentaje: " + element.Porcentaje);                    
                }
                Console.WriteLine();
            }
        }

        private static List<Evaluacion> EliminarEvaluacion(List<Evaluacion> ev)
        {
            string nombre = "\0";
            bool continuar = true;
            do
            {
                try
                {
                    Console.Write("Digite el nombre de la evaluacion a eliminar:");
                    nombre = Console.ReadLine();
                    if (nombre.Equals(""))
                    {
                        throw new EmptyStringException("Tipo de laboratorio inválido, debe introducir una cadena de caracteres");
                    }
                    else
                    {
                        continuar = false;
                    }
                }
                catch (EmptyStringException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            } while (continuar);

            bool exist = false;
            int cont = 0;
            foreach (var element in ev)
            {
                if (string.Equals(element.Nombre, nombre, StringComparison.OrdinalIgnoreCase))
                {
                    byte opt = 0;
                    do
                    {
                        try
                        {
                            Console.WriteLine("¿Es esta la evalución que quiere borrar? (1.Si, 2.No)");
                            if (element is Laboratorio)
                            {
                                Console.WriteLine("Laboratorio");
                                Console.WriteLine("Nombre: " + element.Nombre);
                                Console.WriteLine("Porcentaje: " + element.Porcentaje);                    
                            }
                            else if (element is Parcial)
                            {
                                Console.WriteLine("Parcial");
                                Console.WriteLine("Nombre: " + element.Nombre);
                                Console.WriteLine("Porcentaje: " + element.Porcentaje);                    
                            }
                            else
                            {
                                Console.WriteLine("Tarea");
                                Console.WriteLine("Nombre: " + element.Nombre);
                                Console.WriteLine("Porcentaje: " + element.Porcentaje);                    
                            }
                            opt = Convert.ToByte(Console.ReadLine());
                            if (opt < 1 || opt > 2)
                            {
                                throw new OutOfLimitsException("Opción inválida, Digite un número entre 1 y 2...");
                            }
                        }
                        catch (OutOfLimitsException exc)
                        {
                            Console.WriteLine(exc.Message);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Opción invalida,  Digite un número entre 1 y 2...");
                        }
                    } while (opt!=1 && opt!=2);

                    if (opt == 1)
                    {
                        exist = true;
                        break;
                    }
                }
                cont++;
            }

            if (exist)
            {
                ev.RemoveAt(cont);
                Console.WriteLine("La evaluación a sido borrada con éxito");
            }
            else
            {
                Console.WriteLine("La evaluación deseada no existe");
            }
            return ev;
        }
    }
}