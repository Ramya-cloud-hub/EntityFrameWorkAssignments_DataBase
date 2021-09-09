using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models.ViewModels;

namespace WebAppAssignmentDATABASE_5.Models.Service
{
   public interface ILanguageService
    {
        Language Add(CreateLanguageViewModel language);
        PersonLanguage AddPersonToTheCity(int id, Person person);
        LanguageViewModel All();
        LanguageViewModel FindBy(LanguageViewModel search);
        Language Findby(int id);
        Language Edit(int id, Language language);
        bool Remove(int id);
    }
}
