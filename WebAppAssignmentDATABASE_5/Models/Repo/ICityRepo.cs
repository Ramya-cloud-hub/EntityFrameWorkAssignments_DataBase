﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.Repo
{
    interface ICityRepo
    {

        Person AddPersonCity(int id, Person person);
        City Create(string name);
        List<City> Read();

        City Read(int id);

        City Update(City city);

        bool Delete(City city);
    }
}
