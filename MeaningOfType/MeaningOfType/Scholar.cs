using System;
using System.Collections.Generic;
using System.Text;
using Meaning_of_Type;

namespace MeaningOfType
{
    class Scholar:Student

    {
        public Scholar(string name, int age, double gpa) : base(name, age, gpa){ }
        private ScholarShip scship;
        double Calculate_Scholarship(ScholarShip s)
        {
            scship = s;
            return s.Value*GPA * 10.7;
        }
    }
}
