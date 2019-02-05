using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormMultipleInsert.Models
{
    public class ViewModelUserEmail
    {
        [Required(ErrorMessage = "This field is requiered")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is requiered")]

        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "This field is requiered")]
        public string EmailAddress { get; set; }
        public bool IsAdmin { get; set; }



    }
}