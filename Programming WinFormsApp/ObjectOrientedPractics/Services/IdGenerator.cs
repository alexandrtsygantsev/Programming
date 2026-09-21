using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class IdGenerator
    {
        /// <summary>
        /// Счётчик последнего выданного идентификатора.
        /// </summary>
        private static int _counter;

        /// <summary>
        /// Возвращает следующий уникальный идентификатор.
        /// </summary>
        /// <returns>Уникальный целочисленный идентификатор.</returns>
        public static int GetNextId()
        {
            return ++_counter;
        }
    }
}
