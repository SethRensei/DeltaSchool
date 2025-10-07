using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace DeltaSchool.Data.Entity
{
    [Table("schooling")]
    public class Schooling
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Une transaction doit appartenir à un élève")]
        [Column("student_id")]
        public int StudentId { get; set; }

        [Column("classe_id")]
        public int? ClasseId { get; set; }

        [Column("school_year_id")]
        public int? SchoolYearId { get; set; }

        [Required(ErrorMessage = "Type de transaction obligatoire")]
        [RegularExpression("SCHOOL_FEES|REGISTRATION|RE_REGISTRATION|TRANSFER")]
        [Column("type")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Montant obligatoire")]
        [Column("amount")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Veuillez selectionner le statut")]
        [RegularExpression("PENDING|PARTIAL|PAID")]
        [Column("status")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Date de paiment est obligatoire")]
        [Column("paid_at")]
        public DateTime PaidAt { get; set; }

        [Column("period")]
        public string Period { get; set; }

        [Column("paid_key")]
        [StringLength(255)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string PaidKey { get; private set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        [ForeignKey("ClasseId")]
        public virtual Classe Classe { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [ForeignKey("SchoolYearId")]
        public virtual SchoolYear SchoolYear { get; set; }
    }
}
