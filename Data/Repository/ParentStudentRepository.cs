using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class ParentStudentRepository : IParentStudentRepository
    {
        private readonly DeltaSchoolContext _context;

        public ParentStudentRepository(DeltaSchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<ParentStudent> GetAll()
        {
            return _context.ParentStudents
                .Include(p => p.Students) // si tu affiches les enfants
                .AsNoTracking()   // if readonly -> better performance
                .ToList();
        }

        public ParentStudent GetById(int id)
        {
            return _context.ParentStudents.Find(id);
        }

        public void Add(ParentStudent parent)
        {
            _context.ParentStudents.Add(parent);
        }

        public void Update(ParentStudent parent)
        {
            _context.Entry(parent).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var p = _context.ParentStudents.Find(id);
            if (p != null)
                _context.ParentStudents.Remove(p);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
