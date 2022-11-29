using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class CandidateProfileService
    {
        CandidateProfileRepo repo;
        public CandidateProfileService()
        {
            repo = new CandidateProfileRepo();
        }
        public List<CandidateProfile> GetAll()
        {
            return repo.GetAll().Include(p=>p.Posting).ToList();
        }
        public void Create(CandidateProfile obj)
        {
             repo.Create(obj);
        }
        public void Update(CandidateProfile obj)
        {
            repo.Update(obj);

        }
        public void Delete(CandidateProfile obj)
        {
            repo.Delete(obj);

        }
   
    }
}
