using System;
using System.Collections.Generic;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class ParentStudentRepository : IParentStudentRepository, IDisposable
    {
        private readonly DeltaSchoolContext _context;
        private bool _disposed = false;

        public ParentStudentRepository(DeltaSchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<ParentStudent> GetAll()
        {
            return _context.ParentStudents.ToList();
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

        public void Dispose()
        {
            if (!_disposed)
            {
                _context.Dispose();
                _disposed = true;
            }
        }
    }
}
