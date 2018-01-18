using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lucky_number_model.Models
{
    public class LuckyNumber
    {
        Random rnd = new Random();
        private decimal _balance;
        private Boolean _isWinner;
        private int[] _spinner = new int[3];

        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Number must be between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number

        [Required]
        public decimal Balance {
            get
            {
                if (_isWinner == true)
                {
                    Balance += 2;
                    isWinner = true;
                }
                return _balance;
            }

            set
            {
                _balance = value;
            }
        } // the balance for this game

        public Boolean isWinner { get; set; } // a flag for when the lucky number matches the spin

        public string GameMessage
        { //a message about what is happening in the game
            get
            {
                if(_balance <= 0)
                {
                    return "GAME OVER: Spin to try again";
                }
                return "";
            }
            set
            {

            }

        } 

        //TODO: make this a smart property that will set _isWinner to true when the spin matches the lucky number
        public int[] Spinner {

            get
            {
               for (int i = 0; i < _spinner.Length; i++)
                {
                    _spinner[i] = rnd.Next(0, 10);
                    if(_spinner[i] == Number)
                    {
                        _isWinner = true;
                    }
                }
                return _spinner;           }

            set
            {
               
            }
        }
    }
}