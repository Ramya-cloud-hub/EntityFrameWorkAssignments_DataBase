using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models.Repo;
using WebAppAssignmentDATABASE_5.Models.ViewModels;

namespace WebAppAssignmentDATABASE_5.Models.Service
{
    public class CountryService : ICountryService
    {

        ICountryRepo _countryRepo;

        public CountryService(ICountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }
        public Country Add(CreateCountryViewModel country)
        {
            return _countryRepo.Create(country.CountryName);
        }

        public City AddCityToTheCountry(int id, City city)
        {
            return _countryRepo.AddCityToCountry(id, city);
        }

        public CountryViewModel All()
        {
            CountryViewModel countryViewModel = new CountryViewModel();

            countryViewModel.CountryLists = _countryRepo.Read();

            return countryViewModel;
        }

        public Country Edit(int id, Country country)
        {
            return _countryRepo.Update(country);
        }

        public CountryViewModel FindBy(CountryViewModel search)
        {
            List<Country> foundCountryList = new List<Country>();

            foreach (Country item in _countryRepo.Read())
            {
                if (item.CountryName.Contains(search.FilterText, StringComparison.OrdinalIgnoreCase))
                {
                    foundCountryList.Add(item);
                }
            }
            search.CountryLists = foundCountryList;

            return search;
        }

        public Country Findby(int id)
        {
            return _countryRepo.Read(id);
        }

        public bool Remove(int id)
        {
            Country country = _countryRepo.Read(id);

            return _countryRepo.Delete(country);
        }
    }
}
