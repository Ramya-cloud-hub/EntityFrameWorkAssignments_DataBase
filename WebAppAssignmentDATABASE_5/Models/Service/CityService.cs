using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models.Repo;
using WebAppAssignmentDATABASE_5.Models.ViewModels;

namespace WebAppAssignmentDATABASE_5.Models.Service
{
    public class CityService : ICityService
    {
        //Dependency Injection
        ICityRepo _cityRepo;

        public CityService(ICityRepo cityRepo)
        {
            _cityRepo = cityRepo;
        }
        public City Add(CreateCityViewModel city)
        {
            return _cityRepo.Create(city.CityName);
        }

        public Person AddPersonToTheCity(int id, Person person)
        {
            return _cityRepo.AddPersonCity(id, person);
        }

        public CityViewModel All()
        {
            CityViewModel cityViewModel = new CityViewModel();

            cityViewModel.CityLists = _cityRepo.Read();

            return cityViewModel;
        }

        public City Edit(int id, City city)
        {
            return _cityRepo.Update(city);
        }

        public CityViewModel FindBy(CityViewModel search)
        {
            List<City> foundCityList = new List<City>();

            foreach (City item in _cityRepo.Read())
            {
                if (item.CityName.Contains(search.FilterText, StringComparison.OrdinalIgnoreCase))
                {
                    foundCityList.Add(item);
                }
            }
            search.CityLists = foundCityList;

            return search;
        }

        public City Findby(int id)
        {
            return _cityRepo.Read(id);
        }

        public bool Remove(int id)
        {
            City city = _cityRepo.Read(id);

            return _cityRepo.Delete(city); ;
        }
    }
}
