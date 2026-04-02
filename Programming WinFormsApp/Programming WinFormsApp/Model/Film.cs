using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Film
    {
        // Приватные поля
        private string name;
        private int durationMin;
        private int years;
        public string Genre {  get; set; }
        private double rating;

        // Свойство для названия (автосвойство - без ограничений)
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Название фильма не может быть пустым");
                }
                name = value;
            }
        }

        // Свойство для длительности
        public int DurationMin
        {
            get { return durationMin; }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(DurationMin)))
                {
                    durationMin = value;
                }
            }
        }

        public int Years
        {
            get { return years; }
            set
            {
                
                if(Validator.AssertValueInRange(value,1900,2026, "Years"))
                {
                    years = value;
                }
            }
        }

        public double Rating
        {
            get { return rating; }
            set
            {
                if (Validator.AssertValueInRange(value, 0, 10, "Rating"))
                {
                    rating = value;
                }
            }
        }

        public Film() { }

        public Film(string name, int durationMin, int years, string genre, double rating)
        {
            Name = name;
            DurationMin = durationMin;
            Years = years;
            Genre = genre;
            Rating = rating;
        }
    }
}