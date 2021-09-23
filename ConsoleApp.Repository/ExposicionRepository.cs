using ConsoleApp.Contracts.Repository;
using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleApp.Repository
{
    public class ExposicionRepository : Repository<Exposicion>,IExposicionRepository
    {
        List<int> expo = new List<int>() { };
        public void Add(int exposicion)
        {

            expo.Add(exposicion);
            
        }
    }
}
