using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleApp.Contracts.Repository
{
    public interface IExamenRepository : IRepository<Examen>
    {
        void Ingresar(Examen exam, Materia mat);
        List<CantidadExamen> GetInfo();
        List<Calificacion> Introducir(int nota, string materia);

    }
}
