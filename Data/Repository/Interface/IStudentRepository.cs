using System.Collections.Generic;
using System.Linq;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IStudentRepository
    {
        IQueryable<Student> GetAll();
        IEnumerable<Student> GetByLocaton(int location);
        Student GetById(int id);
        Student GetByLocationCodeLastnameFirstname(string code, string lastname, string firstname);
        void Add(Student student);
        void Update(Student student);
        void Save();
    }
}
