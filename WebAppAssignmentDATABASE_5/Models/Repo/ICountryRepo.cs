using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.Repo
{
    interface ICountryRepo
    {
        City AddCityToCountry(int id, City city);

        Country CreateCountry(string name);
        List<Country> ReadCountry();

        Country ReadCountry(int id);

        Country UpdateCountry(Country country);

        bool Delete(Country country);
    }
}
