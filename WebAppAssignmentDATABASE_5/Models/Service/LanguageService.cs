using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models.Repo;
using WebAppAssignmentDATABASE_5.Models.ViewModels;

namespace WebAppAssignmentDATABASE_5.Models.Service
{
    public class LanguageService : ILanguageService
    {

        ILanguageRepo _languageRepo;

        public LanguageService(ILanguageRepo LanguageRepo)
        {
            _languageRepo = LanguageRepo;
        }

        public Language Add(CreateLanguageViewModel language)
        {

            return _languageRepo.Create(language.LanguageName);

        }

        public PersonLanguage AddPersonToTheCity(int id, Person person)
        {
            return _languageRepo.AddingPersonToTheLanguage(id, person);
        }

        public LanguageViewModel All()
        {
            LanguageViewModel languageViewModel = new LanguageViewModel();

            languageViewModel.LanguageList = _languageRepo.Read();

            return languageViewModel;
        }

        public Language Edit(int id, Language language)
        {
            return _languageRepo.Update(language);
        }

        public LanguageViewModel FindBy(LanguageViewModel search)
        {
            List<Language> foundLanguageList = new List<Language>();

            foreach (Language item in _languageRepo.Read())
            {
                if (item.LanguageName.Contains(search.FilterText, StringComparison.OrdinalIgnoreCase))
                {
                    foundLanguageList.Add(item);
                }
            }
            search.LanguageList = foundLanguageList;

            return search;
        }

        public Language Findby(int id)
        {
            return _languageRepo.Read(id);
        }

        public bool Remove(int id)
        {
            Language language = _languageRepo.Read(id);

            return _languageRepo.Delete(language);
        }
    }
}
