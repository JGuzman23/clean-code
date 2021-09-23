using ConsoleApp.Contracts.Repository;
using ConsoleApp.Contracts.Services;
using ConsoleApp.Models;

namespace ConsoleApp.Services
{
    public class AsistenciaService : IAsistenciaService
    {
        readonly IAsistenciaRepository _IAsistenciaRepository;
        
        public AsistenciaService( IAsistenciaRepository IAsistenciaRepository)
        {
            _IAsistenciaRepository = IAsistenciaRepository;
        }
        
        public void Ingresar(Asistencia asist)
        {
                     
            _IAsistenciaRepository.Create(asist);
        }
    }
}
