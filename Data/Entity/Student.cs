using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace DeltaSchool.Data.Entity
{
    [Table("student")]
    public class Student
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(200, ErrorMessage = "Le nom ne peut dépasser 200 caractères")]
        [Column("lastname")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Le prénom est requis")]
        [StringLength(200, ErrorMessage = "Le prénom ne peut dépasser 200 caractères")]
        [Column("firstname")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Le genre est requis")]
        [RegularExpression("MALE|FEMALE", ErrorMessage = "Le genre doit être 'MALE' ou 'FEMALE'")]
        [Column("gender")]
        [StringLength(6)]
        public string Gender { get; set; } = "MALE";

        [Required(ErrorMessage = "L'adresse est requise")]
        [StringLength(200, ErrorMessage = "L'adresse ne peut dépasser 200 caractères")]
        [Column("address")]
        public string Address { get; set; }

        [Column("birthday")]
        public DateTime? Birthday { get; set; }

        [StringLength(100)]
        [Column("birthplace")]
        public string Birthplace { get; set; }

        [StringLength(100)]
        [Column("nationality")]
        public string Nationality { get; set; }

        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Email invalide")]
        [Column("email")]
        public string Email { get; set; }

        [StringLength(30, ErrorMessage = "Le N° Tel doit avoir un maximum de 30 caractères")]
        [Phone(ErrorMessage = "N° de téléphone invalide")]
        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("is_orphan")]
        public bool IsOrphan { get; set; } = false;

        [StringLength(255)]
        [Column("home_institution")]
        public string HomeInstitution { get; set; }

        [Column("observations")]
        public string Observations { get; set; }

        [Column("classe_id")]
        public int? ClasseId { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("school_year_id")]
        public int? SchoolYearId { get; set; }

        [Column("location_id")]
        public int? LocationId { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        [ForeignKey("ClasseId")]
        public virtual Classe Classe { get; set; }

        [ForeignKey("ParentId")]
        public virtual ParentStudent Parent { get; set; }

        [ForeignKey("SchoolYearId")]
        public virtual SchoolYear SchoolYear { get; set; }

        [ForeignKey("LocationId")]
        public virtual Sites Location { get; set; }
    }
}
