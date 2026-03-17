using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Flight
    {
        public string DepPoint { get; set; }
        public string DestPoint {  get; set; }
        private int timeMin;

        public int TimeMin
        {
            get { return timeMin; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Время полета не может быть отрицательным");
                }
                timeMin = value;
            }
        }

        public Flight(string depPoint, string destPoint, int timeMin)
        {
            DepPoint = depPoint;
            DestPoint = destPoint;
            TimeMin = timeMin;
        }
    }
}
