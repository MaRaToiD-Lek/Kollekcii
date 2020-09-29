using System;
using System.Collections.Generic;

namespace Задание_1
{
    class Student : Person
    {
        public Student() { }

        public Student(string name, string surname, byte course, byte bookNumber)
            : base(name, surname, course, bookNumber)
        {
            Display();
        }

        public override void Display()
        {
            Console.WriteLine($"\tСТУДЕНТ! \nИмя: {name} \nФамилия: {surname} \nКурс: {Course} \nНомер.книжки: {bookNumber}");
        }        
       
        public void Text()
        {
            Console.WriteLine();
            Console.WriteLine("\tИнфа о студенте!");
        }
    }
}
