using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.Repo
{
    public class CityRepo : ICityRepo
    {
        //Dependency injection of database
        private readonly ExDbContext _exDbContext;

        public CityRepo(ExDbContext exDbContext)
        {
            _exDbContext = exDbContext;
        }

        public Person AddPersonCity(int id, Person person)
        {
            City city = Read(id);
            city.PeopleListInCity.Add(person);
            _exDbContext.Cities.Update(city);
            _exDbContext.SaveChanges();

            return person;
        }
        

        public City Create(string name)
        {
            City city = new City(name);

            _exDbContext.Cities.Add(city);
            _exDbContext.SaveChanges();

            return city;
        }

        public bool Delete(City city)
        {
            _exDbContext.Cities.Remove(city);
            int deletedNoOfCities = _exDbContext.SaveChanges(); // going to return 1 if deleted

            bool deletedCity = false;
            if (deletedNoOfCities == 1)
            {
                deletedCity = true;
            }
            else
            {
                deletedCity = false;
            }

            return deletedCity;
        }

        public List<City> Read()
        {
            List<City> cities = _exDbContext.Cities.ToList();

            return cities;
        }

        public City Read(int id)
        {
            City city = _exDbContext.Cities.Find(id);

            return city;
        }

        public City Update(City city)
        {
            _exDbContext.Cities.Update(city);
            _exDbContext.SaveChanges();

            return city;
        }
    }
}
