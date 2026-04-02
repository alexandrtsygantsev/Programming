using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Subject
    {
        public string Name { get; set; }
        private int numHours;
        public string Teachers { get; set; }
        private int grade;

        public int NumHours
        {
            get { return numHours; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                {
                    numHours = value;
                }
            }
        }
        public int Grade
        {
            get { return grade; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                {
                    grade = value;
                }
            }
        }
        public Subject() { }
        public Subject(string name, int numHours, string teachers, int grade)
        {
            Name = name;
            NumHours = numHours;
            Teachers = teachers;
            Grade = grade;
            NumHours = numHours;
            Grade = grade;
        }
    }
}
