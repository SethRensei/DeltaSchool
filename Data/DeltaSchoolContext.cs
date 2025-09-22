using System.Data.Entity;

namespace DeltaSchool.Data
{
    public class DeltaSchoolContext : DbContext
    {
        public DeltaSchoolContext() : base("name=DeltaSchoolDB")
        { }
    }
}
