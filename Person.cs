﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Pull_request
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
        public string Greeting(string name)
        {
            return $"Hello, {name}";
        }
        public string HowAreYouDoing(string name)
        {
            return $"How are you doing, {name}?";
        }


    }
}
