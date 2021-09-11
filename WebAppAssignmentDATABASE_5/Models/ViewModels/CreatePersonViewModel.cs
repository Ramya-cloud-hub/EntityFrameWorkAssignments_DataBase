using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAppAssignmentDATABASE_5.Models.ViewModel
{
    public class CreatePersonViewModel
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength =1)]
        [Required(ErrorMessage = "* Please enter name"), MaxLength(50)]
        [Display(Name = "Name")]
        public string PersonName { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "* Please enter phonenumber"), MaxLength(30)]
        [Display(Name = "PhoneNumber")]
        public string PersonPhoneNumber { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "* Please enter city"), MaxLength(50)]
        [Display(Name = "City")]
        [StringLength(15,MinimumLength =1)]
        public string PersonCity { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "* Please enter city"), MaxLength(50)]
        [Display(Name = "Language")]
        [StringLength(15, MinimumLength = 1)]
        public string PersonLanguage { get; set; }

        public SelectList selectList { get; set; }

        public SelectList selectLanguageList { get; set; }
        public CreatePersonViewModel()
        {

        }
    }

}
