using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolApp.Validation;

namespace SchoolApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        // Student Number
        [Display(Name = "Student No.")]
        [Required(ErrorMessage = "Please enter the student number.")]
        [RegularExpression(@"^\d{4}-\d{4}$",
            ErrorMessage = "Use the format 2026-0001.")]
        public string? StudentNo { get; set; }

        // Name
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please enter the student's name. - Julia")]
        [StringLength(100,
            ErrorMessage = "The name can't be longer than 100 characters.")]
        public string? Name { get; set; }

        // Email
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress(
            ErrorMessage = "Please enter a valid email, like ana@example.com.")]
        public string? Email { get; set; }

        // Confirm Email
        [Display(Name = "Confirm Email")]
        [Required(ErrorMessage = "Please type the email again.")]
        [NotMapped]
        [Compare("Email", ErrorMessage = "Emails do not match.")]
        public string? ConfirmEmail { get; set; }

        // Phone
        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string? Phone { get; set; }

        // Age
        [Range(16, 60, ErrorMessage = "Age must be from 16 to 60.")]
        public int? Age { get; set; }

        // Birth Date
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [NotFutureDate(
            ErrorMessage = "Birth date can't be in the future.")]
        public DateTime? BirthDate { get; set; }
    }
}