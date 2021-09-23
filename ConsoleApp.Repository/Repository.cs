using ConsoleApp.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Repository
{
    public class Repository<T> : IRepository<T>
    {
        public List<T> Items;

        public Repository()
        {
            Items = new List<T>();
        }

        public void Create(T model)
        {
            Items.Add(model);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return Items.ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
