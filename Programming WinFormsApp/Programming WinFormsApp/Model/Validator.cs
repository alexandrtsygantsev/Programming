using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Validator
    {

        /// <summary>
        /// Проверяет, является ли целочисленное значение положительным.
        /// </summary>
        /// <param name="value">Проверяемое целочисленное значение.</param>
        /// <param name="propertyName">Имя свойства для отображения в сообщении об ошибке.</param>
        /// <returns>true, если значение положительное; в противном случае выбрасывает исключение.</returns>
        public static bool AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"Значение свойства {propertyName} должно быть положительным. Получено: {value}",
                    propertyName);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Проверяет, является ли вещественное значение положительным.
        /// </summary>
        /// <param name="value">Проверяемое вещественное значение.</param>
        /// <param name="propertyName">Имя свойства для отображения в сообщении об ошибке.</param>
        /// <returns>true, если значение положительное; в противном случае выбрасывает исключение.</returns>
        public static bool AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0.0)
            {
                throw new ArgumentException(
                    $"Значение свойства {propertyName} должно быть положительным. Получено: {value}",
                    propertyName);
                return false;

            }
            return true;
        }

        /// <summary>
        /// Проверяет, входит ли целочисленное значение в указанный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое целочисленное значение.</param>
        /// <param name="min">Минимальное допустимое значение (включительно).</param>
        /// <param name="max">Максимальное допустимое значение (включительно).</param>
        /// <param name="propertyName">Имя свойства для отображения в сообщении об ошибке.</param>
        /// <returns>true, если значение входит в диапазон; в противном случае выбрасывает исключение.</returns>
        public static bool AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"Значение свойства {propertyName} должно быть в диапазоне от {min} до {max}. Получено: {value}",
                    propertyName);
            }
            return true;
        }

        /// <summary>
        /// Проверяет, входит ли вещественное значение в указанный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое вещественное значение.</param>
        /// <param name="min">Минимальное допустимое значение (включительно).</param>
        /// <param name="max">Максимальное допустимое значение (включительно).</param>
        /// <param name="propertyName">Имя свойства для отображения в сообщении об ошибке.</param>
        /// <returns>true, если значение входит в диапазон; в противном случае выбрасывает исключение.</returns>
        public static bool AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"Значение свойства {propertyName} должно быть в диапазоне от {min} до {max}. Получено: {value}",
                    propertyName);
            }
            return true;
        }
    }
}
