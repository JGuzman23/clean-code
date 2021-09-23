using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleApp.Contracts.Services
{
    public interface IMateriaService
    {
        void Ingresar(Materia materia);
        List<Materia> GetMaterias();

    }
}
