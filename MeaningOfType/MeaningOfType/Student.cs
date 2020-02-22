using System;
using System.Collections.Generic;
using System.Text;

namespace Meaning_of_Type
{
    public class Student
    {
        public string Name { get; set; }
        int Age { get; }
        protected double GPA { get;}
        public Student(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            GPA = gpa;
        }

        private List<Teacher> _listofTeachers { get; set; }

        public void SetAssociatedListofTeachers(List<Teacher> listTeachers)
        {
            _listofTeachers = listTeachers;
        }
    }
}
