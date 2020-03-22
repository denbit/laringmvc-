using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace learningmvc.Models
{
    public class Passwords
    {
        [Key]
        public Int16 Id { get; set; }  
        public string login { get; set; }
        public string site { get; set; }
    }  
}