using System;

namespace MusicManager.Services
{
    internal class Validator
    {
        /// <summary>
        /// Проверяет, что длина строки не превышает 50 символов
        /// </summary>
        public static bool LengthTitle(string text, string propertyName)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException($"{propertyName} не может быть пустым", propertyName);
            }

            if (text.Length > 50)  // ← Исправлено: если больше 50 - ошибка
            {
                throw new ArgumentException(
                    $"Значение свойства {propertyName} должно быть не более 50 символов. Получено: {text.Length} символов",
                    propertyName);
            }

            return true;  // ← Всё хорошо, возвращаем true
        }

        /// <summary>
        /// Проверяет, что продолжительность в диапазоне от 1 до 7200 секунд
        /// </summary>
        public static bool LenghtTime(int value)
        {
            if (value < 1 || value > 7200)
            {
                throw new ArgumentException(
                    $"Продолжительность должна быть от 1 до 7200 секунд. Получено: {value} секунд");
            }

            return true;
        }
    }
}