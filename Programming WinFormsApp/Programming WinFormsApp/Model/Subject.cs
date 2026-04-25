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

        // Свойство для колличества часов
        public int NumHours
        {
            get { return numHours; }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(NumHours)))
                {
                    numHours = value;
                }
            }
        }

        // Свойство для оценки
        public int Grade
        {
            get { return grade; }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(Grade)))
                {
                    grade = value;
                }
            }
        }
        public Subject() { }

        /// <summary>
        /// Инициализирует новый экземпляр класса Subject с указанными параметрами учебного предмета.
        /// </summary>
        /// <param name="name">Название предмета.</param>
        /// <param name="numHours">Количество часов на изучение предмета.</param>
        /// <param name="teachers">Преподаватель(и) предмета.</param>
        /// <param name="grade">Оценка по предмету.</param>
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
