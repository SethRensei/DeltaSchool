using MySql.Data.EntityFramework;
using System.Data.Entity;

using DeltaSchool.Data.Entity;

namespace DeltaSchool.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DeltaSchoolContext : DbContext
    {
        public DeltaSchoolContext() : base("name=DeltaSchoolDB")
        {
            // Configuration par défaut
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<ParentStudent> ParentStudents { get; set; }
    } 
}
