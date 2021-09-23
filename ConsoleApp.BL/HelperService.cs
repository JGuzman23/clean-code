using ConsoleApp.Contracts.BL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BL
{
    public class HelperService : IHelperService
    {

        public bool ValidarSiEsNumerico(string value)
        {
            return int.TryParse(value, out _);
        }

        public bool ValidarSiNumeroEsMayorCero(double value)
        {
            return value > 0;
        }


    }
}
