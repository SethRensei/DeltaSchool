using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("location")]
    public class Sites
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom du site est obligatoire")]
        [StringLength(50, ErrorMessage = "Le nom du site a une longueur max de 50 caractères")]
        [Column("name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Le code du site est obligatoire")]
        [StringLength(5, ErrorMessage = "Le code du site ne doit pas depasser 5 caractères")]
        [Column("code")]
        public string Code { get; set; }

        [Required(ErrorMessage = "L'addresse du site est requise")]
        [StringLength(100, ErrorMessage = "L'addresse a 100 caractères max autorisés")]
        [Column("address")]
        public string Address { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
