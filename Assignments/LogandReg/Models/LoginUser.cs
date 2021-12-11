using System;
using System.ComponentModel.DataAnnotations;

namespace LogandReg.Models
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        // email pattern A-Z0-9@A-Z0-9.com/net(A-Z)
        public string logEmail {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string logPassword{get;set;}
        // Don't forget to create at and update at
    }
}