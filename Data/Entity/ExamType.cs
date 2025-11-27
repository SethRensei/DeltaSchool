using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("exam_type")]
    public class ExamType
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom du type d'examen est requis")]
        [StringLength(100, ErrorMessage = "Le nom du type d'examen ne peut dépasser 50 caractères")]
        [Column("name")]
        public string Name { get; set; }

        [StringLength(250, ErrorMessage = "La description ne peut dépasser 200 caractères")]
        [Column("description")]
        public string Description { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
