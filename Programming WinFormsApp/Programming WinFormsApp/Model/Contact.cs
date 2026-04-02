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

        public int Phone
        {
            get { return phone; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                {
                    phone = value;
                }
            }

        }
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

        public Contact(string surname, string name, int phone)
        {
            Surname = surname;
            Name = name;
            Phone = phone;
        }
    }
}
