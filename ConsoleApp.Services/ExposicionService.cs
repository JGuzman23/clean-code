using ConsoleApp.Contracts.Repository;
using ConsoleApp.Contracts.Services;
using ConsoleApp.Models;

namespace ConsoleApp.Services
{
    public class ExposicionService : IExposicionService
    {
        readonly IExposicionRepository _exposicionRepository;
        public ExposicionService(IExposicionRepository exposicionRepository)
        {
            _exposicionRepository = exposicionRepository;
        }
        
        public void Ingresar(Exposicion expo)
        {
            _exposicionRepository.Create(expo);
            
        }
    }
}
