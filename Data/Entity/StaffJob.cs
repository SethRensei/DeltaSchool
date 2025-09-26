using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("staff_job")]
    public class StaffJob
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("staff_id")]
        public int StaffId { get; set; }

        [Column("job_id")]
        public int JobId { get; set; }

        [Required(ErrorMessage = "Le salaire à payer est requis")]
        [Column("salary")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "La periodicité de paiement est requis")]
        [StringLength(50, ErrorMessage = "La periodicité de paiement ne peut dépasser 50 caractères")]
        [Column("periodicity")]
        public string Periodicity { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        [ForeignKey("StaffId")]
        public virtual Staff Staff { get; set; }

        [ForeignKey("JobId")]
        public virtual Job Job { get; set; }
    }
}
