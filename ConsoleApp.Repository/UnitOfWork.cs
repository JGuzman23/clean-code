using ConsoleApp.Contracts.Repository;
using ConsoleApp.Models;

namespace ConsoleApp.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly IRepository<Materia> _materiaRepository;
        private readonly IAsistenciaRepository _AsistenciaRepository;
        private readonly IExamenRepository _ExamenRepository;

        public UnitOfWork()
        {
            _materiaRepository = new Repository<Materia>();
            _AsistenciaRepository = new AsistenciaRepository();
            _ExamenRepository = new ExamenRepository();
        }

        public IRepository<Materia> MateriaRepository => _materiaRepository ?? new Repository<Materia>();

        public IAsistenciaRepository AsistenciaRepository => _AsistenciaRepository ?? new AsistenciaRepository();
        public IExamenRepository ExamenRepository => _ExamenRepository ?? new ExamenRepository();


    }
}
