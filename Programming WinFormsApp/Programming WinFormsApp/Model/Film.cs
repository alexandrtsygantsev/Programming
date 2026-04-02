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
        private string genre;
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
                if (Validator.AssertOnPositiveValue(value))
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
                if (value >= 1900 && value <= 2026)
                {
                    years = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Фильм должен быть от 1900 до 2026 года выпуска");
                }
            }
        }

        public string Genre
        {
            get { return genre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Жанр не может быть пустым");
                }
                genre = value;
            }
        }

        public double Rating
        {
            get { return rating; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    rating = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Рейтинг должен быть от 0 до 10");
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