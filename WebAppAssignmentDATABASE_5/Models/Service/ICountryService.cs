using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models.ViewModels;

namespace WebAppAssignmentDATABASE_5.Models.Service
{
  public interface ICountryService
    {
        //Dependency Injection 
        Country Add(CreateCountryViewModel country);

        City AddCityToTheCountry(int id, City city);

        CountryViewModel All();

        CountryViewModel FindBy(CountryViewModel search);

        Country Findby(int id);

        Country Edit(int id, Country country);

        bool Remove(int id);
    }
}
