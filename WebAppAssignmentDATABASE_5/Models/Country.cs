using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class Country
    {

        [Key]
        public int CityId { get; set; }


        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string CountryName { get; set; }

        //List of City from City class
        public List<City>  ListOfCities{ get; set; }

        public Country(string CountryName)
        {
            this.CountryName = CountryName;
            ListOfCities = new List<City>();  //Gives List of Cities present inside selected country
        }
    }
}
