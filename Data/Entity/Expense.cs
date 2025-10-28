using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("expense")]
    public class Expense
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("category_id")]
        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "Montant obligatoire")]
        [Column("amount")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Date de paiment est obligatoire")]
        [Column("incurred_at")]
        public DateTime IncurredAt { get; set; }

        [Required(ErrorMessage = "Une description est requise")]
        [StringLength(255, ErrorMessage = "La description ne peut dépasser 255 caractères")]
        [Column("description")]
        public string Description { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        [ForeignKey("ExpenseId")]
        public virtual ExpenseCategory ExpenseCategory { get; set; }
    }
}
