﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmsEntity
{
    public class Doctor
    {
        [Required(ErrorMessage = "FirstName is requried")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is requried")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Qulification is requried")]
        public string Qulification { get; set; }
        [Required(ErrorMessage = "RegNo is requried")]
        public string RegNo { get; set; }
        [Required(ErrorMessage = "ExpartArea is requried")]
        public string ExpartArea { get; set; }
        [Required(ErrorMessage = "Address is requried")]
        public string Address { get; set; }
        [Required(ErrorMessage = "BloodGroup is requried")]
        public string BloodGroup { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Nid is required")]
        public string Nid { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Key]
        [Required(ErrorMessage = "Contact is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}