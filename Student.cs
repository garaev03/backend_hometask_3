using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_3
{
    internal class Student
    {
        public string name;
        public string surname;
        public string group;
        public int point;
        public bool isGraduated;

        public Student(string name, string surname, string group, int point, bool isGraduated)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.point = point;
            this.isGraduated = isGraduated;
        }

        public void getFullname()
            => Console.WriteLine("Student's name and surname: "+name+" "+surname);

        public void getDetails()
        {
            getFullname();
            Console.WriteLine("Student's group: "+group);
            Console.WriteLine("Student's point: "+point);
            if(isGraduated)
                Console.WriteLine("This student is GRADUATED");
            else
                Console.WriteLine("This student is NOT GRADUATED");
        }
        public void secondExam()
        {
            if (!isGraduated)
            {
                Console.WriteLine("For participating in second exam students must have at least 80 points and this student has " + point + " points which means ");
                if (point >= 80)
                    Console.WriteLine("this student can participate in second exam!");
                else
                    Console.WriteLine("this student can NOT participate in second exam!");
            }
            else
                Console.WriteLine("This student is GRADUATED and cannot participate in exams!");
                  
        }
    }
}
