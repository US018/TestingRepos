using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class DataModel
    {
        [Key]
        public int StdID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Plesae enter your Fist Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Pleas enter only alphabets")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Must be 3 latters")]
        public string firstname { get; set; }
        [Column(TypeName = "varchar(20)")]

        [System.ComponentModel.DataAnnotations.Display(Name = "Last Name")]
        [Required(ErrorMessage = "Plesae enter your Last Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Pleas enter only alphabets")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Must be 3 latters")]
        public string lastname { get; set; }
        [Column(TypeName = "varchar(20)")]

        [System.ComponentModel.DataAnnotations.Display(Name = "Father Name")]
        [Required(ErrorMessage = "Plesae enter your Last Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Pleas enter only alphabets")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Must be 3 latters")]
        public string FatherName { get; set; }
        [Column(TypeName = "varchar(20)")]

        [Display(Name = "Parent Occupation")]
        public string occupation { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Plesae enter your Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Gender")]
        [Required(ErrorMessage = "Plesae enter your Gender")]
        public string gender { get; set; }

        [Required(ErrorMessage = "Plesae enter your email")]
        [System.ComponentModel.DataAnnotations.Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Pleas enter a valid email address")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Plesae enter a strong password")]
        [System.ComponentModel.DataAnnotations.Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Plesae confirm your password")]
        [Compare("Password", ErrorMessage = "Password dose not match")]
        [System.ComponentModel.DataAnnotations.Display(Name = "Confirm Password")]

        public string ConfirmPassword { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Permanent Address")]
        [Required(ErrorMessage = "Plesae enter your Address")]
        //[StringLength(100, MinimumLength = 4)]
        public string address { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "City")]
        [Required(ErrorMessage = "Plesae enter your City")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Pleas enter only alphabets")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Must be 3 latters")]
        public string city { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "State")]
        [Required(ErrorMessage = "Plesae enter your State")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Pleas enter only alphabets")]
        public string state { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Plesae enter your Zip Code")]
        //[StringLength(4, MinimumLength = 4, ErrorMessage = "Must be 4 digits")]

        public int zipcode { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Mobile")]
        [Required(ErrorMessage = "Plesae enter your Phone")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Pleas enter only intgers")]
        //[StringLength(11, MinimumLength = 11, ErrorMessage = "Must be 11 digits")]
        public string phone { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Collage Name")]
        [Required(ErrorMessage = "Plesae enter your Collage Name")]
        
        public string collage { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Board")]
        [Required(ErrorMessage = "Plesae enter your Board")]
        
        public string board { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Parcentage")]
        [Required(ErrorMessage = "Plesae enter your Parcentage")]


        public int Parcentage { get; set; }
    }
}
