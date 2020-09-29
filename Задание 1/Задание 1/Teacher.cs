using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1
{
    class Teacher
    {
        public string teacherName { get; set; }
        public string teacherSurname { get; set; }
        public string matter { get; set; }

        public void Display()
        {
            Console.WriteLine($"\tПРЕПОДОВАТЕЛЬ! \nИмя: {teacherName} \nФамилия: {teacherSurname} \nПредмет: {matter} ");
        }
    }
}
