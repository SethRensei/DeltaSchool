using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DeltaSchool.Data.Entity
{
    [Table("payroll")]
    public class Payroll
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("staff_id")]
        public int? StaffId { get; set; }

        [Required(ErrorMessage = "Montant obligatoire")]
        [Column("amount")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Le net à payé obligatoire")]
        [Column("net_pay")]
        public decimal NetPay { get; set; }

        [Required(ErrorMessage = "Veuillez selectionner le statut")]
        [RegularExpression("PARTIAL|PAID")]
        [Column("status")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Veuillez selectionner une période pour ce paiment")]
        [Column("period")]
        public string Period { get; set; }

        [Required(ErrorMessage = "Date de paiment est obligatoire")]
        [Column("paid_at")]
        public DateTime PaidAt { get; set; }

        [Column("residual_amount")]
        public decimal ResidualAmount { get; set; } = decimal.Zero;

        [Column("notes")]
        public string Notes { get; set; }

        [Column("paid_key")]
        [StringLength(255)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string PaidKey { get; private set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        [ForeignKey("StaffId")]
        public virtual Staff Staff { get; set; }
    }
}
