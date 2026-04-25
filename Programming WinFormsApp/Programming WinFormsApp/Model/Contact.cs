using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Contact
    {
        private string surname {  get; set; }
        private string name {  get; set; }
        private int phone;

        // Свойство для номера телефона
        public int Phone
        {
            get { return phone; }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(Phone)))
                {
                    phone = value;
                }
            }

        }

        /// <summary>
        /// Проверяет, содержит ли строка только буквы латинского алфавита.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <returns>true, если строка содержит только буквы; в противном случае выбрасывает исключение.</returns>
        private bool AssertStringContainsOnlyLetters(string value)
        {
            string alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            if ((Regex.IsMatch(value, alf)) == false)
            {
                throw new ArgumentException("Некорректно введено значение");
            }
            else
            {
                return true;
            }
        }

        // Свойство для имени
        public string Name
        {
            get { return name; }
            set
            {
                if (AssertStringContainsOnlyLetters(value))
                {
                    name = value;
                }
            }
        }

        // Свойство для фамилии
        public string Surname
        {
            get { return surname; }
            set
            {
                if (AssertStringContainsOnlyLetters(value))
                {
                    surname = value;
                }
            }
        }
        public Contact() { }

        /// <summary>
        /// Инициализирует новый экземпляр класса Contact с указанными контактными данными.
        /// </summary>
        /// <param name="surname">Фамилия контакта.</param>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phone">Номер телефона контакта.</param>
        public Contact(string surname, string name, int phone)
        {
            Surname = surname;
            Name = name;
            Phone = phone;
        }
    }
}
