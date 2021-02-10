using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_04.Models
{
    public class Suggestions
    {
        //A blank constructor --> nothing is being instantiated when the instance is created
        public Suggestions()
        {
        }
        public string Name { get; set; }
        public string Restaurant { get; set; }
        public string FavDish { get; set; }

        //Data validation. This makes sure that the phone number is only digits and is exactly 10 digits
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

    }
}
