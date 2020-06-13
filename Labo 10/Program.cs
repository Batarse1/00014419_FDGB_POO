using System;
using System.Collections.Generic;
using System.Diagnostics;
using Labo_10.Model;

namespace Labo_10
{
    internal class Program
    {
        private delegate void AccountDelegate(List<CuentaBancaria> c);

        private static AccountDelegate _accountDelegate;
        
        public static void Main(string[] args)
        {
            var accountList = new List<CuentaBancaria>();
            byte opt = 0;
            do
            {
                try
                {
                    Menu();
                    opt = Convert.ToByte(Console.ReadLine());
                    switch(opt)
                    {
                        case 1:
                            try
                            {
                                accountList.Add(AddAccount());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Ha ocurrido un error, la cuenta no se a podido añadir");
                            }
                            break;
                        case 2:
                            AccountList(accountList);
                            break;
                        case 3:
                            #region Delegate
                            
                            _accountDelegate = AccountList;
                            _accountDelegate += TotalBalance;
                            _accountDelegate.Invoke(accountList);
                            
                            #endregion
                            break;
                        case 4:
                            #region Action

                            Action<List<CuentaBancaria>> _accountAction;
                            _accountAction = (list) =>
                            {
                                Console.WriteLine("CUENTAS");
                                foreach (var element in list)
                                {
                                    Console.WriteLine(
                                        $"Nombre del propietario: {element._owner}, Saldo actual: {element._balance}");
                                }
                            };
                            _accountAction += (list) =>
                            {
                                double totalBalance = 0.0d;
                                foreach (var element in list)
                                {
                                    totalBalance += element._balance;
                                }
                                Console.WriteLine($"El saldo total es de: {totalBalance}");
                            };
                            _accountAction += (list) =>
                            {
                                Console.WriteLine("CUENTAS QUE EMPIEZAN POR VOCALES");
                                foreach (var element in list)
                                {
                                    if (element._owner[0] == 'A' || element._owner[0] == 'E' ||
                                        element._owner[0] == 'I' || element._owner[0] == 'O' ||
                                        element._owner[0] == 'U' || element._owner[0] == 'a' || element._owner[0] == 'e' ||
                                        element._owner[0] == 'i' || element._owner[0] == 'o' ||
                                        element._owner[0] == 'u')
                                    {
                                        Console.WriteLine(
                                            $"Nombre del propietario: {element._owner}, Saldo actual: {element._balance}");
                                    }
                                }
                            };
                            _accountAction.Invoke(accountList);
                            
                            #endregion
                            break;
                        case 5:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Digite una opción válida...");
                            break;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Digite una opción válida...");
                }
            } while (opt!=5);
        }

        #region Methods

        private static void Menu()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("MENU");
            Console.WriteLine("1. Agregar una cuenta");
            Console.WriteLine("2. Ver cuentas almacenadas");
            Console.WriteLine("3. Ver cuentas almacenadas y el total de las cuentas");
            Console.WriteLine("4. Ver cuentas almacenadas, el total de las cuentas, y las cuentas de las personas que su nombre inicie con una vocal");
            Console.WriteLine("5. Salir ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        }

        private static CuentaBancaria AddAccount()
        {
            string owner = "";
            double balance = 0.0d;
            Console.Write("Digite el nombre del propietario: ");
            owner = Console.ReadLine();
            Console.Write("Digite el saldo actual de la cuenta: ");
            balance = Convert.ToDouble(Console.ReadLine());
            return new CuentaBancaria(owner,balance);
        }

        private static void AccountList(List<CuentaBancaria> list)
        {
            Console.WriteLine("CUENTAS");
            foreach (var element in list)
            {
                Console.WriteLine($"Nombre del propietario: {element._owner}, Saldo actual: {element._balance}");
            }
        }
        
        private static void TotalBalance(List<CuentaBancaria> list)
        {
            double totalBalance = 0.0d;
            foreach (var element in list)
            {
                totalBalance += element._balance;
            }
            Console.WriteLine($"El saldo total es de: {totalBalance}");
        }

        #endregion
    }
}