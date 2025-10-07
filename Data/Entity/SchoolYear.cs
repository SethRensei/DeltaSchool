using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("school_year")]
    public class SchoolYear
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "L'année scolaire est requise")]
        [StringLength(12, ErrorMessage = "Ne doit pas dépasser 12 caractères")]
        [Column("label")]
        public string Label { get; set; }

        [Column("ongoing")]
        public decimal Ongoing { get; set; } = 1.5m;

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Schooling> Schoolings { get; set; }
    }
}
