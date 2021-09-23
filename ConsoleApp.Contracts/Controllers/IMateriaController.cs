using ConsoleApp.Models.DTOs;
using System.Collections.Generic;

namespace ConsoleApp.Contracts.Controllers
{
    public interface IMateriaController
    {
        void Create(string materia, int contador);
        List<MateriaDto> GetAll();
    }
}
