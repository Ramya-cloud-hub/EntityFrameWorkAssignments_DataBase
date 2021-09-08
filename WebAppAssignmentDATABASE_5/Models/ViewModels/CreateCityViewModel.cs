using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.ViewModels
{
    public class CreateCityViewModel
    {


        [Key]
        public int CityId { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string CityName { get; set; }

       

        public CreateCityViewModel()
        {

        }
    }
}
