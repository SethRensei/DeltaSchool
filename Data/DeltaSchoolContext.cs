using DeltaSchool.Data.Entity;
using MySql.Data.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

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
            //this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

        }

        public DbSet<Sites> Locations { get; set; }
        public DbSet<SchoolYear> SchoolYears { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<ClasseSubject> ClasseSubjects { get; set; }
        public DbSet<StaffJob> StaffJobs { get; set; }
        public DbSet<ParentStudent> ParentStudents { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Table names (s'assurer que EF n'ajoute pas 's' ou modifie)
            
            modelBuilder.Entity<Sites>().ToTable("location");
            modelBuilder.Entity<SchoolYear>().ToTable("school_year");
            modelBuilder.Entity<Classe>().ToTable("classe");
            modelBuilder.Entity<Subject>().ToTable("subject");
            modelBuilder.Entity<Job>().ToTable("job");
            modelBuilder.Entity<Staff>().ToTable("staff");
            modelBuilder.Entity<ClasseSubject>().ToTable("classe_subject");
            modelBuilder.Entity<StaffJob>().ToTable("staff_job");
            modelBuilder.Entity<ParentStudent>().ToTable("parent_student");
            modelBuilder.Entity<Student>().ToTable("student");

            #endregion

            #region Indexes / contraintes uniques (via IndexAnnotation - EF6)
            // location.name unique and location.code unique
            modelBuilder.Entity<Sites>()
                .Property(l => l.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Location_Name") { IsUnique = true }));

            modelBuilder.Entity<Sites>()
                .Property(l => l.Code)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Location_Code") { IsUnique = true }));

            // school_year.label unique
            modelBuilder.Entity<SchoolYear>()
                .Property(sy => sy.Label)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_SchoolYear_Label") { IsUnique = true }));

            // classe.name unique
            modelBuilder.Entity<Classe>()
                .Property(c => c.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Classe_Name") { IsUnique = true }));

            // subject.name unique
            modelBuilder.Entity<Subject>()
                .Property(s => s.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Subject_Name") { IsUnique = true }));

            // job.name unique
            modelBuilder.Entity<Job>()
                .Property(j => j.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Job_Name") { IsUnique = true }));

            // staff.phone_number_1 unique
            modelBuilder.Entity<Staff>()
                .Property(s => s.PhoneNumber1)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Staff_Phone1") { IsUnique = true }));

            // staff.email unique (nullable)
            modelBuilder.Entity<Staff>()
                .Property(s => s.Email)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Staff_Email") { IsUnique = true }));

            // parent_student.phone_number unique
            modelBuilder.Entity<ParentStudent>()
                .Property(p => p.Email)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_ParentStudent_Email") { IsUnique = true }));

            modelBuilder.Entity<ParentStudent>()
                .Property(p => p.PhoneNumber)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Parent_Phone") { IsUnique = true }));

            // student.email and student.phone_number unique (nullable)
            modelBuilder.Entity<Student>()
                .Property(s => s.Email)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Student_Email") { IsUnique = true }));

            modelBuilder.Entity<Student>()
                .Property(s => s.PhoneNumber)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Student_Phone") { IsUnique = true }));

            // Unique composite Contraints — handled via IndexAnnotation on multiple properties if needed:
            // classe_subject unique(classe_id, subject_id)
            modelBuilder.Entity<ClasseSubject>()
                .Property(cs => cs.ClasseId)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_ClasseSubject_Unique", 1) { IsUnique = true }));
            modelBuilder.Entity<ClasseSubject>()
                .Property(cs => cs.SubjectId)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_ClasseSubject_Unique", 2) { IsUnique = true }));

            // staff_job unique(staff_id, job_id)
            modelBuilder.Entity<StaffJob>()
                .Property(sj => sj.StaffId)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_StaffJob_Unique", 1) { IsUnique = true }));
            modelBuilder.Entity<StaffJob>()
                .Property(sj => sj.JobId)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_StaffJob_Unique", 2) { IsUnique = true }));

            #endregion

            #region Relations (s'assurer du comportement ON DELETE/UPDATE)
            modelBuilder.Entity<Student>()
                .HasOptional(s => s.Parent)
                .WithMany(p => p.Students)
                .HasForeignKey(s => s.ParentId)
                .WillCascadeOnDelete(false); // SQL had ON DELETE SET NULL

            modelBuilder.Entity<Student>()
                .HasOptional(s => s.Classe)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClasseId)
                .WillCascadeOnDelete(false); // ON DELETE SET NULL

            modelBuilder.Entity<Student>()
                .HasOptional(s => s.SchoolYear)
                .WithMany(sy => sy.Students)
                .HasForeignKey(s => s.SchoolYearId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasOptional(s => s.Location)
                .WithMany(l => l.Students)
                .HasForeignKey(s => s.LocationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClasseSubject>()
                .HasRequired(cs => cs.Classe)
                .WithMany(c => c.ClasseSubjects)
                .HasForeignKey(cs => cs.ClasseId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ClasseSubject>()
                .HasRequired(cs => cs.Subject)
                .WithMany(su => su.ClasseSubjects)
                .HasForeignKey(cs => cs.SubjectId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ClasseSubject>()
                .HasOptional(cs => cs.Staff)
                .WithMany(st => st.ClasseSubjects)
                .HasForeignKey(cs => cs.StaffId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StaffJob>()
                .HasRequired(sj => sj.Staff)
                .WithMany(st => st.StaffJobs)
                .HasForeignKey(sj => sj.StaffId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<StaffJob>()
                .HasRequired(sj => sj.Job)
                .WithMany(j => j.StaffJobs)
                .HasForeignKey(sj => sj.JobId)
                .WillCascadeOnDelete(true);

            #endregion
        }
    } 
}
