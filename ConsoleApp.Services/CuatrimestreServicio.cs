using ConsoleApp.Contracts.Services;
using System;

namespace ConsoleApp.Services
{
    public class CuatrimestreServicio:ICuatrimestreService
    {
        public int Ingresar()
        {
            int cantidad = Convert.ToInt32(Console.ReadLine());

            return cantidad;

        }
    }

}
