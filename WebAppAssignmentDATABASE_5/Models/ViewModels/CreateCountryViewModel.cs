using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.ViewModels
{
    public class CreateCountryViewModel
    {

        [Key]
        public int CountryId { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string CountryName { get; set; }

     
        public CreateCountryViewModel()
        {

        }
    }
}
