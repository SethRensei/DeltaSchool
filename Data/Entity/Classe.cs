using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("classe")]
    public class Classe
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom de classe est requis")]
        [StringLength(50, ErrorMessage = "Le nom de classe ne peut dépasser 50 caractères")]
        [Column("name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Le cycle de classe est requis")]
        [StringLength(100, ErrorMessage = "Le cycle de classe ne peut dépasser 100 caractères")]
        [Column("cycle")]
        public string Cycle { get; set; }

        [Required(ErrorMessage = "Le type de classe est requis")]
        [RegularExpression("PASS|EXAM", ErrorMessage = "Le type de classe doit être 'PASSAGE' ou 'EXAMEN'")]
        [StringLength(5)]
        [Column("category")]
        public string Category { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        public virtual ICollection<ClasseSubject> ClasseSubjects { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
