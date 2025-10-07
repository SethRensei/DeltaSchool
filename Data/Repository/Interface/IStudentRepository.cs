using System.Collections.Generic;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data.Repository.Interface
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        IEnumerable<Student> GetByLocaton(int location);
        Student GetById(int id);
        Student GetByLocationCodeLastnameFirstname(string code, string lastname, string firstname);
        void Add(Student student);
        void Update(Student student);
        void Save();
    }
}
