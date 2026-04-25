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

        // Свойство для времени полета
        public int TimeMin
        {
            get { return timeMin; }

            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(TimeMin)))
                {
                    timeMin = value;
                }
            }
        }
        public Flight() { }

        /// <summary>
        /// Инициализирует новый экземпляр класса Flight с указанными параметрами рейса.
        /// </summary>
        /// <param name="depPoint">Пункт отправления.</param>
        /// <param name="destPoint">Пункт назначения.</param>
        /// <param name="timeMin">Время полета в минутах.</param>
        public Flight(string depPoint, string destPoint, int timeMin)
        {
            DepPoint = depPoint;
            DestPoint = destPoint;
            TimeMin = timeMin;
        }
    }
}
