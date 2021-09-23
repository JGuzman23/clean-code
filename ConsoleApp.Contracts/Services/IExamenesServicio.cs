using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleApp.Contracts.Services
{
    public interface IExamenesServicio
    {
        void Ingresar(Examen exam, Materia mat);

        List<CantidadExamen> GetInfo();

        List<Calificacion> Introducir(int nota,string materia) ;
        
    }
}
