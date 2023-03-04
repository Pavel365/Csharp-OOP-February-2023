﻿using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations.Models
{
    public class Citizen : IBirthable, INameable, IIdentifiable
    {
        public Citizen(string id, string name, int age, string birthdate)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }

        public string Id {get; private set;}

        public string Name { get; private set; }
        
        public int Age { get; private set; }

        public string Birthdate { get; private set; }
    }
}
