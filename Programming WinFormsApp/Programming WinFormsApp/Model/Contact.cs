using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Contact
    {
        public string Surname {  get; set; }
        public string Name {  get; set; }
        private int phone;

        public int Phone
        {
            get { return phone; }
            set
            {
                if(value <= 0){ throw new ArgumentException("Значение не может быть отрицательным или равным нулю"); } 
                phone = value;
            }

        }
        public Contact(string surname, string name, int phone)
        {
            Surname = surname;
            Name = name;
            Phone = phone;
        }
    }
}
