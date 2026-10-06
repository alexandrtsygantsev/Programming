using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс описания покупателя
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Уникальный номер товара
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// ФИО пользователя
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адрес доставки
        /// </summary>
        public Address Address
        { get; set; }

        public string FullName
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                ValueValidator.AssertStringOnWords(value, nameof(FullName));
                _fullname = value;
            }
        }

        public int Id
        {
            get { return _id; }
        }
        public Customer (string fullname, Address address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullname;
            Address = address;
        }
    }
}
