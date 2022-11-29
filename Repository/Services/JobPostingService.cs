using Repository.Models;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class JobPostingService
    {
        JobPostingRepo repo;
        public JobPostingService()
        {
            repo = new JobPostingRepo();
        }
        public List<JobPosting> GetAll()
        {
            return repo.GetAll().ToList();
        }
        public void Create(JobPosting obj)
        {
            repo.Create(obj);
        }
        public void Delete(JobPosting obj)
        {
            repo.Delete(obj);
        }
        public void Update(JobPosting obj)
        {
            repo.Update(obj);
        }
    }
}
