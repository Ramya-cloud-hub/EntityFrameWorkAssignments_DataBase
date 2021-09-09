using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.Repo
{
    public class LanguageRepo :ILanguageRepo
    {
        private readonly ExDbContext _exDbContext;

        public LanguageRepo(ExDbContext exDbContext)
        {
            _exDbContext = exDbContext;
        }

        public Language Create(string languageName)
        {
            Language language = new Language(languageName);

            _exDbContext.Languages.Add(language);
            _exDbContext.SaveChanges();

            return language;
        }

        public List<Language> Read()
        {
            List<Language> language = _exDbContext.Languages.ToList();

            return language;
        }

        public Language Read(int id)
        {
            Language language = _exDbContext.Languages.Find(id);

            return language;
        }

        public Language Update(Language language)
        {

            _exDbContext.Languages.Update(language);
           _exDbContext.SaveChanges();
            return language;
        }

        public bool Delete(Language language)
        {
            _exDbContext.Languages.Remove(language);
            int noOfDeletedLanguage = _exDbContext.SaveChanges();
            bool isDeleated;
            if(noOfDeletedLanguage == 1)
            {
                isDeleated = true;
            }
            else
            {
                isDeleated = false;
            }

            return isDeleated;
        }

      public PersonLanguage AddingPersonToTheLanguage(int id, Person person)
        {
            Language language = Read(id);
            PersonLanguage personlanguage = new PersonLanguage();

            personlanguage.PersonId = person.PersonId;
            personlanguage.Person = person;

            personlanguage.LanguageId = language.LanguageId;
            personlanguage.PersonKnownLanguage = language;

            language.PersonKnownLaguageList.Add(personlanguage);

            _exDbContext.Languages.Update(language);
            _exDbContext.SaveChanges();

            return personlanguage;

            
            
        }
    }
}
