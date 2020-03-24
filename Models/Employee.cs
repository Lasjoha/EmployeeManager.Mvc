using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManager.Mvc.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Column("EmployeeID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Ansattnr er påkrevet")]
        [Display(Name = "Ansatt nr")]
        public int EmployeeID { get; set; }

        [Column("FirstName")]
        [Display(Name = "Fornavn")]
        [Required(ErrorMessage = "Fornavn er påkrevet")]
        [StringLength(10, ErrorMessage = "Fornavn må være kortere enn 10 tegn")]
        public string FirstName { get; set; }

        [Column("LastName")]
        [Display(Name = "Etternavn")]
        [Required(ErrorMessage = "Navn er påkrevet")]
        [StringLength(10, ErrorMessage = "Etternavn må være kortere enn 20 tegn")]
        public string LastName { get; set; }

        [Column("Title")]
        [Display(Name = "Tittel")]
        [Required(ErrorMessage = "Tittel er påkrevet")]
        [StringLength(30, ErrorMessage = "Maks 30 tegn i tittel")]
        public string Title { get; set; }

        [Column("BirthDate")]
        [Display(Name = "Fødselsdato")]
        [Required(ErrorMessage = "Du må angi fødselsdato")]
        public DateTime BirthDate { get; set; }
        
        [Column("HireDate")]
        [Display(Name ="Ansatt dato")]
        [Required(ErrorMessage ="Du må angi ansatt dato")]
        public DateTime HireDate { get; set; }

        [Column("Country")]
        [Display(Name ="Land")]
        [Required(ErrorMessage ="Du må angi land")]
        [StringLength(15,ErrorMessage ="Maks 15 tegn")]
        public string Country { get; set; }

        [Column("Notes")]
        [Display(Name ="Notater")]
        [StringLength(500, ErrorMessage ="Maks 500 tegn")]
        public string Notes { get; set; }
    }
}
