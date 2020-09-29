using System;
using System.Collections.Generic;

namespace Задание_1
{
    abstract class Person
    {
        protected string name { get; set; }
        protected string surname { get; set; }
        protected byte course { get; set; }
        protected byte bookNumber { get; set; }

        public byte Course
        {
            get
            {
                return course;
            }
            set
            {
                if (value <= 0)
                {
                    this.course = 1;
                }
                else
                {
                    course = value;
                }
            }
        }

        public Person() { }
        public Person(string _name, string _surname, byte _course, byte _bookNumber)
        {
            name = _name;
            surname = _surname;
            Course = _course;
            bookNumber = _bookNumber;
        }

        public abstract void Display();        
    }
}
