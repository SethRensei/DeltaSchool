using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("note")]
    public class Note
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Une note doit appartenir à un élève")]
        [Column("student_id")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Le choix de la classe est obligatoire")]
        [Column("classe_id")]
        public int ClasseId { get; set; }

        [Required(ErrorMessage = "Année scolaire obligatoire")]
        [Column("school_year_id")]
        public int SchoolYearId { get; set; }

        [Required(ErrorMessage = "Le type d'examen est obligatoire")]
        [Column("exam_id")]
        public int ExamId { get; set; }

        [Required(ErrorMessage = "Les évaluations ne doivent pas être nul")]
        [Column("designation")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Le calcul de la moyenne obligatoire")]
        [Column("average")]
        public decimal Average { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        // Relations EF
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [ForeignKey("ClasseId")]
        public virtual Classe Classe { get; set; }

        [ForeignKey("SchoolYearId")]
        public virtual SchoolYear SchoolYear { get; set; }

        [ForeignKey("ExamId")]
        public virtual ExamType ExamType { get; set; }
    }
}
