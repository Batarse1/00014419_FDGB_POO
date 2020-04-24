using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace Meet2304
{
  internal class Program 
  {
    public static void Main(string[] args)
    {
      //List<Persona> p = new List<Persona>();
      var lista = new List<Persona>();
      lista.Add(new Persona(nombre:"Walter", apellido:"Rafael", edad: 20));
      lista.Add(new Persona("Batar", edad:19));
      lista.Add(new Persona(edad:19));
      lista.Add(new Persona(apellido:"Morales"));

      Console.Write("Nombre a cambiar: ");
      String buscar = Console.ReadLine();
      
      lista.ForEach(it =>
      {
        if (buscar.Equals(it.Nombre))
        {
          Console.Write("Nuevo nombre: ");
          it.Nombre = Console.ReadLine();
          Console.WriteLine(it.ToString());
        }

        int añadir = 12;
        int árbol = 14;
      });
    }
  }
}