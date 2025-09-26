using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("classe_subject")]
    public class ClasseSubject
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("classe_id")]
        public int ClasseId { get; set; }

        [Column("subject_id")]
        public int SubjectId { get; set; }

        [Column("staff_id")]
        public int? StaffId { get; set; }

        [Column("coeff")]
        public int Coeff { get; set; } = 1;

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        [ForeignKey("ClasseId")]
        public virtual Classe Classe { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        [ForeignKey("StaffId")]
        public virtual Staff Staff { get; set; }
    }
}
