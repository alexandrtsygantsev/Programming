using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Time
    {
        private int hour;
        private int min;
        private int sec;

        public int Hour
        {
            get {  return hour; }
            set
            {
                if (value >= 24)
                {
                    hour = 0;
                    min = 0;
                    sec = 0;
                }
                if (Validator.AssertOnPositiveValue(value))
                {
                    hour = value;
                }
            }
            
        }
        public int Min
        {
            get { return min; }
            set
            {
                if (value >= 60)
                {
                    hour += 1;
                    min = 0;
                    sec = 0;
                }
                if (Validator.AssertOnPositiveValue(value))
                {
                    min = value;
                }
            }
        }
        public int Second
        {
            get { return sec; }
            set
            {
                if (value >= 60)
                {
                    min += 1;
                    sec = 0;
                }
                if (Validator.AssertOnPositiveValue(value))
                {
                    sec = value;
                }
            }
        }
        public Time() { }
        public Time(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
    }
}
