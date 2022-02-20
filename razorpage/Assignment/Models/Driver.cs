using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_3_New.Models
{
    public class Driver
    {
        public string driverID {get; set;}
        [Required]
        [Display(Name="First Name")]
        public string firstName {get; set;}
        [Required]
        [Display(Name="Last Name")]
        public string lastName {get; set;}
        [Required]
        [Display(Name="Car Make")]
        public string carMake {get; set;}
        [Required]
        [Display(Name="Car Model")]
        public string carModel {get; set;}
    }
}