using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class Person
    { 

        [Required]
        public int PersonId { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string PersonName { get; set; }
  

        [Required]
        [Range(10,12)]
        public string PersonPhoneNumber { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(1)]
        public City PersonCity { get; set; }
      //  public object City { get;  set; }

        [Required]
        public List<PersonLanguage> KnownLanguageList { get; set; }

        public Person(string PersonName, string PersonPhoneNumber)
        {
            this.PersonName = PersonName;
            this.PersonPhoneNumber = PersonPhoneNumber;
            KnownLanguageList = new List<PersonLanguage>();

        }
        public Person(int PersonId, string PersonName, string PersonPhoneNumber)
        {
           this.PersonId = PersonId;
            this.PersonName = PersonName;
           this.PersonPhoneNumber = PersonPhoneNumber;
         //   PersonCity = PersonCity;
            KnownLanguageList = new List<PersonLanguage>();

        }

    }
}
