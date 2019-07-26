using System;
using System.ComponentModel.DataAnnotations;


namespace TestApi.Models{
     public class Contact{
         public int Id { get; set;}
        
        [Required]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set;}
        
        [Required]
        [StringLength(255)]
        [Display(Name = "Last Name")]
         public string LastName { get; set;}
         
         [Required]
         [EmailAddress]
         public string Email { get; set;}
     }
}
