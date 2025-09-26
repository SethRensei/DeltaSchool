using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("job")]
    public class Job
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom de classe est requis")]
        [StringLength(50, ErrorMessage = "Le nom de classe ne peut dépasser 50 caractères")]
        [Column("name")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "La description ne peut dépasser 200 caractères")]
        [Column("description")]
        public string Description { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        public virtual ICollection<StaffJob> StaffJobs { get; set; }
    }
}
