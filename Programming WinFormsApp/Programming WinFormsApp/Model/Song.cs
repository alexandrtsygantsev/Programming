using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Song
    {
        public string Title { get; set; }
        public string Author { get; set; }
        private int duration;

        // Свойство для продолжительности
        public int Duration
        {
            get { return duration; }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(Duration)))
                {
                    duration = value;
                }
            }
        }

        public Song() { }

        /// <summary>
        /// Инициализирует новый экземпляр класса Song с указанными параметрами песни.
        /// </summary>
        /// <param name="title">Название песни.</param>
        /// <param name="author">Автор или исполнитель песни.</param>
        /// <param name="duration">Продолжительность песни в секундах.</param>
        public Song(string  title, string author, int duration)
        {
            Title = title;
            Author = author;
            Duration = duration;
        }
    }
}
