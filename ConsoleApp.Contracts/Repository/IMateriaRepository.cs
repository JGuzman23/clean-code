using ConsoleApp.Models;

namespace ConsoleApp.Contracts.Repository
{
    public interface IMateriaRepository: IRepository<Materia>
    {
        Materia GetByName(string name);
    }
}
