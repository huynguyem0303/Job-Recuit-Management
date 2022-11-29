using Repository.Models;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class HrAccountService
    {
        HrAccountRepo repo;

        public HrAccountService()
        {
            repo = new HrAccountRepo();
        }
        public List<Hraccount> GetAll()
        {
            return repo.GetAll().ToList();
        }
        public void Create(Hraccount obj)
        {
            repo.Create(obj);
        }
        public void Delete(Hraccount obj)
        {
            repo.Delete(obj);
        }
        public void Update(Hraccount obj)
        {
            repo.Update(obj);
        }
    }
}
