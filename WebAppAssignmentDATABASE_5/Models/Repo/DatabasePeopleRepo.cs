using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class DatabasePeopleRepo : IPeopleRepo
    {
        private static List<Person> _personList = new List<Person>();
        private static int idCounter = 0;

        //Dependency Injection
        private readonly ExDbContext _exDBontext;
        public DatabasePeopleRepo(ExDbContext exDbContext)
        {
            _exDBontext = exDbContext;

            if (_personList.Count == 0)
            {
                _personList = Read();
            }
        }

       
        

        //Extra Code Added Last
        public Person Create(Person person)
        {
            List<Person> persons = new List<Person>();

            foreach (var item in persons)
            {
                _exDBontext.Peoples.Add(item);
            }
            _exDBontext.Peoples.Add(person);

            int result = _exDBontext.SaveChanges();

            if (result == 0)
            {
                throw new Exception("Didn't try to change  save to database ");
            }

            return person;
        }



        public Person Create(string personName, string personPhoneNumber, string personCity)
        {
            List<City> cityList = _exDBontext.Cities.ToList();
            City selectedCity = null;

            // Define the query expression
            IEnumerable<City> cityQuery =
                from city in cityList
                where city.CityName == personCity
                select city;

            selectedCity = cityQuery.First();

            Person person = new Person(personName, personPhoneNumber);
            person.PersonCity = selectedCity;
            idCounter++;

            _personList.Add(person);
            _exDBontext.Peoples.Add(person);
            _exDBontext.SaveChanges();

            return person;
        }

        public bool Delete(Person person)
        {
            _personList.Remove(person);
            return true;
        }

        public List<Person> Read()
        {
            if (_personList.Count == 0)
            {
                _personList = _exDBontext.Peoples.ToList();
                if (_personList.Count != 0)
                    idCounter = _personList.Last().PersonId;
            }

            return _personList;
        }

        public Person Read(int id)
        {
            // Person findPersonById = _personList.Find(idNr => idNr.PersonId == id);

            // return findPersonById;

            if (_personList.Count == 0)
            {
                _personList = Read();
            }

                    IEnumerable<Person> personQuery =
            from person in _personList
            where person.PersonId == id
            select person;

            Person person1 = personQuery.First();

            return person1;
        }

        public Person Update(Person person)
        {
            foreach (Person item in _personList)
            {
                if (item.PersonId == person.PersonId)
                {
                    item.PersonName = person.PersonName;
                    item.PersonPhoneNumber = person.PersonPhoneNumber;
                    item.PersonCity = person.PersonCity;

                    _exDBontext.Peoples.Update(item);
                    _exDBontext.SaveChanges();
                }
            }

            return person;
        }
    }
    
}
