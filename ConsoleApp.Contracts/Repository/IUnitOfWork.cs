using ConsoleApp.Models;

namespace ConsoleApp.Contracts.Repository
{
    public interface IUnitOfWork
    {
        IRepository<Materia> MateriaRepository { get; }

        IAsistenciaRepository AsistenciaRepository { get; }
        IExamenRepository ExamenRepository { get; }




    }

}
