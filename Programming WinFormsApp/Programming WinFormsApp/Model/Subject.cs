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
                if(value < 0)
                {
                    throw new ArgumentException("Часовой объем дисциплины не может быть меньше нуля");
                }
                numHours = value;
            }
        }
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Часовой объем дисциплины не может быть меньше нуля");
                }
                grade = value;
            }
        }
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
