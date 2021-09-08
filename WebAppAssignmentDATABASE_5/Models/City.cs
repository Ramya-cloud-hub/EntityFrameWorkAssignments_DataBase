using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string CityName { get; set; }

        //list of Peoples from people class 
        public List<Person> PeopleListInCity { get; set; }

        public City(String CityName)
        {
            this.CityName = CityName;
            PeopleListInCity = new List<Person>(); //Gives list of peoples who lives inside the specific city
        }
    }
}
