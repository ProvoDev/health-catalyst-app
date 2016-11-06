using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace HealthCatalystApp.Models
{
    public class PeopleModel
    {
        /// <summary>
        /// Person model holds information about people including:
        /// first name, last name, address, city, state, zip
        /// </summary>
        public class People
        {
            [Key]
            public int person_id { get; set; }

            [Required(ErrorMessage = "Your must provide a First Name")]
            [Display(Name = "First Name")]
            public string first_name { get; set; }

            [Required(ErrorMessage = "Your must provide a Last Name")]
            [Display(Name = "Last Name")]
            public string last_name { get; set; }
            [Display(Name = "Company")]
            public string company { get; set; }

            [Required(ErrorMessage = "Your must provide an Address")]
            [Display(Name = "Address")]
            public string address { get; set; }

            [Required(ErrorMessage = "Your must provide a City")]
            [Display(Name = "City")]
            public string city { get; set; }

            [Required(ErrorMessage = "Your must provide a State")]
            [Display(Name = "State")]
            public string state { get; set; }

            [Required(ErrorMessage = "Your must provide a Zip Code")]
            [Display(Name = "Zip Code")]
            public string zip { get; set; }

            [Required(ErrorMessage = "Your must provide a Phone Number")]
            [DataType(DataType.PhoneNumber)]
            [Display(Name = "Phone")]
            public string phone { get; set; }

            [Required(ErrorMessage = "Your must provide an Email Address")]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "Email")]
            public string email { get; set; }

            [Display(Name = "Website")]
            [DataType(DataType.Url)]
            public string website { get; set; }
        }
    }
}