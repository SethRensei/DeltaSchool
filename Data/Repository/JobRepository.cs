using System;
using System.Collections.Generic;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly DeltaSchoolContext _context;

        public JobRepository(DeltaSchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Job> GetAll()
        {
            return _context.Jobs
                .OrderBy(j => j.Name)
                .ToList();
        }

        public Job GetById(int id)
        {
            return _context.Jobs.Find(id);
        }

        public void Add(Job job) =>_context.Jobs.Add(job);

        public void Update(Job job)
        {
            _context.Entry(job).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var job = _context.Jobs.Find(id);
            if (job != null)
                _context.Jobs.Remove(job);
        }

        public void Save() =>_context.SaveChanges();
    }
}
