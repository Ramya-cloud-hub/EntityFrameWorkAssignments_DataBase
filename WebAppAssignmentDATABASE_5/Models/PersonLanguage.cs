using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class PersonLanguage
    {
        [Key]
        public int LanguageId { get; set; }

        [Required]
        public Language PersonKnownLanguage { get; set; }


        public int PersonId { get; set; }


        public Person Person { get; set; }
    }
}
