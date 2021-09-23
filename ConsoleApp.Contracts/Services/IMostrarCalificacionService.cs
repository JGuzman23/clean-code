using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleApp.Contracts.Services
{
    public interface IMostrarCalificacionService
    {
        List<Calificacion> Mostrar(List<Materia> materias );
    }
}
