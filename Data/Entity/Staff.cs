using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaSchool.Data.Entity
{
    [Table("staff")]
    public class Staff
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(200, ErrorMessage = "Le prénom ne peut dépasser 200 caractères")]
        [Column("firstname")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(200, ErrorMessage = "Le nom ne peut dépasser 200 caractères")]
        [Column("lastname")]
        public string Lastname { get; set; }

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

        [Column("hire_date")]
        public DateTime? HireDate { get; set; }

        [StringLength(10)]
        [Column("marital_status")]
        public string MaritalStatus { get; set; } = "SINGLE";

        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Email invalide")]
        [Column("email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le premier N° de téléphone est requis")]
        [StringLength(30)]
        [Phone(ErrorMessage = "N° de téléphone invalide")]
        [Column("phone_number_1")]
        public string PhoneNumber1 { get; set; }

        [StringLength(30)]
        [Column("phone_number_2")]
        [Phone(ErrorMessage = "N° de téléphone invalide")]
        public string PhoneNumber2 { get; set; }

        [StringLength(100)]
        [Column("emergency_contact")]
        public string EmergencyContact { get; set; }

        [StringLength(30)]
        [Column("emergency_phone")]
        [Phone(ErrorMessage = "N° de téléphone invalide")]
        public string EmergencyPhone { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; private set; }

        public virtual ICollection<ClasseSubject> ClasseSubjects { get; set; }
        public virtual ICollection<StaffJob> StaffJobs { get; set; }
    }
}
