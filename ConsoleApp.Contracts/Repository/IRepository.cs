using System.Collections.Generic;

namespace ConsoleApp.Contracts.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);       
        void Create(T model);
        void Update(T model);
        bool Delete(int id);
    }
}
