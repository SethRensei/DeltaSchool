using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("expense_category")]
    public class ExpenseCategory
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom de la catégorie est requis")]
        [StringLength(125, ErrorMessage = "Le nom de la catégorie ne peut dépasser 125 caractères")]
        [Column("name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Une description est requise")]
        [StringLength(490, ErrorMessage = "La description ne peut dépasser 490 caractères")]
        [Column("description")]
        public string Description { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
