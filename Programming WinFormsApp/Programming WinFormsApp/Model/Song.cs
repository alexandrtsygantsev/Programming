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

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Длина песни не может быть отрицательной");
                }
                duration = value;
            }
        }

        public Song(string  title, string author, int duration)
        {
            Title = title;
            Author = author;
            Duration = duration;
        }
    }
}
