using AutoMapper;
using ConsoleApp.Contracts.Controllers;
using ConsoleApp.Contracts.Services;
using ConsoleApp.Models;
using ConsoleApp.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Controllers
{
    public class MateriaController : IMateriaController
    {
        private readonly IMateriaService _materiaService;
        private readonly IMapper _mapper;


        public MateriaController(IMateriaService materiaService, IMapper mapper)
            => (_materiaService, _mapper) = (materiaService, mapper);

        public void Create(string materia, int contador)
        {            
            var materiaDto = new ConsoleApp.Models.DTOs.MateriaDto { Nombre = materia, NumeroCuatrimestre = contador + 1 };
            _materiaService.Ingresar(_mapper.Map<Materia>(materiaDto));
        }

        public List<MateriaDto> GetAll()
        {
            return _mapper.Map<List<MateriaDto>>(_materiaService.GetMaterias());
        }

    }
}
