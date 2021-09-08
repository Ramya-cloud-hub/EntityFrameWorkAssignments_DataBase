using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.Repo
{
    public class CountryRepo : ICountryRepo
    {

        //Dependency injection Dbclass
        private readonly ExDbContext _exDbcontext;

        public CountryRepo(ExDbContext exDbcontext)
        {
            _exDbcontext = exDbcontext;
        }
        public City AddCityToCountry(int id, City city)
        {
            Country country = Read(id);
            country.ListOfCities.Add(city);

            _exDbcontext.Countries.Update(country);
            _exDbcontext.SaveChanges();

            return city;
        }

        public Country Create(string name)
        {
            Country country = new Country(name);

            _exDbcontext.Countries.Add(country);
            _exDbcontext.SaveChanges();

            return country;
        }


        public bool Delete(Country country)
        {
            _exDbcontext.Countries.Remove(country);
            int deletedNoOfCountry = _exDbcontext.SaveChanges();

            bool isdDeleted;

            if (deletedNoOfCountry == 1)
            {
                isdDeleted = true;
            }
            else
            {
                isdDeleted = false;
            }
            return isdDeleted; 
        }

        public List<Country> Read()
        {
            List<Country> countries = _exDbcontext.Countries.ToList();

            return countries;
        }

        public Country Read(int id)
        {
            Country country = _exDbcontext.Countries.Find(id);

            return country;
        }

        public Country Update(Country country)
        {
            _exDbcontext.Countries.Update(country);
            _exDbcontext.SaveChanges();

            return country;
        }
    }
}
