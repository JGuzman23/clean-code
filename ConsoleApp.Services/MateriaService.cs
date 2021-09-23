using ConsoleApp.Contracts.Repository;
using ConsoleApp.Contracts.Services;
using ConsoleApp.Models;

using System.Collections.Generic;

namespace ConsoleApp.Services
{

    public class MateriaService :IMateriaService
    {        
        readonly IUnitOfWork _unitOfWork;

        public MateriaService(IUnitOfWork unitOfWork)
        => _unitOfWork = unitOfWork;
        

        public void Ingresar(Materia materia)
        {
            _unitOfWork.MateriaRepository.Create(materia);
        }

        public List<Materia> GetMaterias()
        {          
            return _unitOfWork.MateriaRepository.GetAll();
        }

    }
}
