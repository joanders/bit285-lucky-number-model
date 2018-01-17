using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lucky_number_model.Models
{
    public class LuckyNumber
    {
        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Number must be between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number

        [Required]
        public decimal Balance { get; set; } // the balance for this game

        public Boolean isWinner { get; set; } // a flag for when the lucky number matches the spin
    }
}