using ConsoleApp.Contracts.Repository;
using ConsoleApp.Models;
using System.Linq;

namespace ConsoleApp.Repository
{
    public class MateriasRepository : Repository<Materia>, IMateriaRepository
    {
        public Materia GetByName(string name)
        {
            return Items.SingleOrDefault(x => x.Nombre == name);
        }
    }
}
