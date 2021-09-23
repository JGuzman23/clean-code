using ConsoleApp.Contracts.Repository;
using ConsoleApp.Contracts.Services;
using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class ExamenService : IExamenesServicio
    {
     
        private readonly IExamenRepository _examenRepository;
      
        public ExamenService(IExamenRepository examenRepository)
        {
            _examenRepository = examenRepository;
        }
        

        public void Ingresar(Examen examen , Materia mat)
        {
            _examenRepository.Ingresar(examen, mat);
        }

        public List<CantidadExamen> GetInfo()
        {
           
           var info= _examenRepository.GetInfo();
            return info;
        }


        public List<Calificacion> Introducir(int nota, string materia)
        {



            var valor =_examenRepository.Introducir(nota, materia);

            return valor;

        }
    }
}
