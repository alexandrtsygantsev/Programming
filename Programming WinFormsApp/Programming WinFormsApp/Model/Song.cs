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
                if (Validator.AssertOnPositiveValue(value, nameof(Duration)))
                {
                    duration = value;
                }
            }
        }

        public Song() { }
        public Song(string  title, string author, int duration)
        {
            Title = title;
            Author = author;
            Duration = duration;
        }
    }
}
