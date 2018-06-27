using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class Person
    {
        public int Age { get; }
        public Person(int age)
        {
            if (age < 0) throw new InvalidAgeException();
           Age = age;
        }
    }
}
