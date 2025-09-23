using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("parent_student")]
    public class ParentStudent
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

        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Email invalide")]
        [Column("email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le N° de téléphone est requis")]
        [StringLength(30)]
        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [StringLength(50, ErrorMessage = "La profession ne peut dépasser 50 caractères")]
        [Column("profession")]
        public string Profession { get; set; }

        [StringLength(100, ErrorMessage = "L'adresse ne peut dépasser 100 caractères")]
        [Column("emergency_contact")]
        public string EmerContact { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }
    }
}
