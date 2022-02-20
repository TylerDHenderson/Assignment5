using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace customerapp.Models
{
    public class Customer
    {
        [Required]
        public string customerID {get; set;}
        [Required]
        [Display(Name="First Name")]
        public string firstName {get; set;}
        [Required]
        [Display(Name="Last Name")]
        public string lastName {get; set;}
        [Required]
        [Display(Name="Email")]
        public string email {get; set;}
        [Required]
        [Display(Name="Phone Number")]
        public int phoneNum {get; set;}
        [Required]
        [Display(Name="Password")]
        public string password {get; set;}
        [Required]
        [Display(Name="Address")]
        public string address {get; set;}
    }
}