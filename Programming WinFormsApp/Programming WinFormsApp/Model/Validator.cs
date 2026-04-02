using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Validator
    {
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
