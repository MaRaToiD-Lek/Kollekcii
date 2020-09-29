using System;
using System.Collections;
using System.Collections.Generic;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Aspirant a = new Aspirant();

            //Инфа студента
            string studentName = null, studentSurname = null;
            byte studentCourse = 0, studentNumber = 0;

            //Инфа аспиранта
            string aspirantName = null, aspirantSurname = null, aspirantThesis = null;
            byte aspirantCourse = 0, aspirantNumber = 0;
           
            //Вывод студента на консоль
            StudentGet(ref studentName, ref studentSurname, ref studentCourse, ref studentNumber);
            s.Text();

            //Коллекции
            ArrayList listStudent = new ArrayList();
            listStudent.AddRange(new string[] {studentName, studentSurname });
            listStudent.AddRange(new byte[] { studentCourse, studentNumber });
            listStudent.Reverse();

            foreach (object ob in listStudent)
            {
                Console.WriteLine(ob);
            }                        

            Console.WriteLine();
            //Вывод аспиранта на консоль
            AspirantGet(ref aspirantName, ref aspirantSurname, ref aspirantCourse, ref aspirantNumber, ref aspirantThesis);

            //Коллекции
            ArrayList listAspirant = new ArrayList();
            listAspirant.AddRange(new string[] { aspirantName, aspirantSurname, aspirantThesis });
            listAspirant.AddRange(new byte[] { aspirantCourse, aspirantNumber });
            a.Text();

            foreach (object ob2 in listAspirant)
            {
                Console.WriteLine(ob2);
            }

            Console.WriteLine();
            Console.WriteLine("\tИнфа о преподователе!");

            LinkedList<Teacher> teachers = new LinkedList<Teacher>();

            LinkedListNode<Teacher> teacher = teachers.AddLast(new Teacher() { teacherName = "Давид", teacherSurname = "Ахундов", matter = "Химия" });
            teachers.AddLast(new Teacher() { teacherName = "Адиль", teacherSurname = "Гаджиев", matter = "Физика" });
            teachers.AddFirst(new Teacher() { teacherName = "Араз", teacherSurname = "Гамидов", matter = "Математика" });
            
            Console.WriteLine($"Имя: {teacher.Previous.Value.teacherSurname}, Фамилия: {teacher.Previous.Value.teacherName}, Предмет: {teacher.Previous.Value.matter}");
            Console.WriteLine($"Имя: {teacher.Next.Value.teacherSurname}, Фамилия: {teacher.Next.Value.teacherName}, Предмет:  {teacher.Next.Value.matter}");           
        }

        public static void VallidationNumbers(bool flag, ref byte temp)
        {
            flag = false;
            do
            {

                if (byte.TryParse(Console.ReadLine(), out temp))
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Введите число!");
                    Console.WriteLine("Введите курс студента!");
                    continue;
                }
            } while (flag == false);
        }

        public static void VallidationStringStudent(ref string name, ref string surname)
        {
            // Имя студента
            bool isContinueLoop;
            do
            {
                isContinueLoop = false;
                Console.WriteLine("Введите имя студента!");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Имя не должно быть пустой!");
                    isContinueLoop = true;
                }
                else
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!char.IsLetter(name[i]))
                        {
                            Console.WriteLine("В имени не должны присудствовать цифры!");
                            isContinueLoop = true;
                        }
                    }
                }
            } while (isContinueLoop);

            // Фамилия студента
            bool isContinueLoop2;
            do
            {
                isContinueLoop2 = false;
                Console.WriteLine("Введите фамилию студента!");
                surname = Console.ReadLine();
                if (string.IsNullOrEmpty(surname))
                {
                    Console.WriteLine("Имя не должно быть пустой!");
                    isContinueLoop2 = true;
                }
                else
                {
                    for (int i = 0; i < surname.Length; i++)
                    {
                        if (!char.IsLetter(surname[i]))
                        {
                            Console.WriteLine("В имени не должны присудствовать цифры!");
                            isContinueLoop2 = true;
                        }
                    }
                }
            } while (isContinueLoop2);
        }

        public static void VallidationStringAspirant(ref string name, ref string surname)
        {
            // Имя студента
            bool isContinueLoop;
            do
            {
                isContinueLoop = false;
                Console.WriteLine("Введите имя аспиранта!");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Имя не должно быть пустой");
                    isContinueLoop = true;
                }
                else
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!char.IsLetter(name[i]))
                        {
                            Console.WriteLine("В имени не должны присудствовать цифры!");
                            isContinueLoop = true;
                        }
                    }
                }
            } while (isContinueLoop);

            // Фамилия студента
            bool isContinueLoop2;
            do
            {
                isContinueLoop2 = false;
                Console.WriteLine("Введите фамилию аспиранта!");
                surname = Console.ReadLine();
                if (string.IsNullOrEmpty(surname))
                {
                    Console.WriteLine("Имя не должно быть пустой");
                    isContinueLoop2 = true;
                }
                else
                {
                    for (int i = 0; i < surname.Length; i++)
                    {
                        if (!char.IsLetter(surname[i]))
                        {
                            Console.WriteLine("В имени не должны присудствовать цифры!");
                            isContinueLoop2 = true;
                        }
                    }
                }
            } while (isContinueLoop2);
        }

        public static void StudentGet(ref string studentName, ref string studentSurname, ref byte studentCourse, ref byte studentNumber)
        {
            bool flag = false;
            VallidationStringStudent(ref studentName, ref studentSurname);
            Console.WriteLine("Введите курс студента!");
            VallidationNumbers(flag, ref studentCourse);
            Console.WriteLine("Введите номер зачетной книжки студента!");
            VallidationNumbers(flag, ref studentNumber);
        }

        public static void AspirantGet(ref string aspirantName, ref string aspirantSurname, ref byte aspirantCourse, ref byte aspirantNumber, ref string aspirantThesis)
        {
            bool flag = false;
            VallidationStringAspirant(ref aspirantName, ref aspirantSurname);
            Console.WriteLine("Введите курс студента!");
            VallidationNumbers(flag, ref aspirantCourse);
            Console.WriteLine("Введите номер зачетной книжки аспиранта!");
            VallidationNumbers(flag, ref aspirantNumber);
            Console.WriteLine("На какую тему пишите диссертацию?"); // Здесь я специально не сделал валидацию! 
            aspirantThesis = Console.ReadLine();
        }
    }
}
