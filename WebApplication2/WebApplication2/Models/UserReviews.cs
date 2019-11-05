using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Пространство имен с правилом преверки достоверности
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class UserReviews
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your text")]
        public string Text { get; set; }
    }
}
