using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий адрес доставки.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс. Целое шестизначное число.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион. Не более 50 символов.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населённый пункт). Не более 50 символов.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица. Не более 100 символов.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома. Не более 10 символов.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения. Не более 10 символов.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт почтовый индекс. Должен быть шестизначным числом.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new ArgumentException(
                        "Индекс должен быть шестизначным числом (от 100000 до 999999).",
                        nameof(value));
                }
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт страну/регион. Не более 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                if (value == null || value.Length > 50)
                {
                    throw new ArgumentException(
                        "Название страны не должно превышать 50 символов.",
                        nameof(value));
                }
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт город. Не более 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                if (value == null || value.Length > 50)
                {
                    throw new ArgumentException(
                        "Название города не должно превышать 50 символов.",
                        nameof(value));
                }
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт улицу. Не более 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                if (value == null || value.Length > 100)
                {
                    throw new ArgumentException(
                        "Название улицы не должно превышать 100 символов.",
                        nameof(value));
                }
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома. Не более 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                if (value == null || value.Length > 10)
                {
                    throw new ArgumentException(
                        "Номер дома не должен превышать 10 символов.",
                        nameof(value));
                }
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения. Не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                if (value == null || value.Length > 10)
                {
                    throw new ArgumentException(
                        "Номер квартиры не должен превышать 10 символов.",
                        nameof(value));
                }
                _apartment = value;
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

        /// <summary>
        /// Создаёт экземпляр класса
        /// </summary>
        /// <param name="index">Почтовый индекс (шестизначное число).</param>
        /// <param name="country">Страна/регион (до 50 символов).</param>
        /// <param name="city">Город (до 50 символов).</param>
        /// <param name="street">Улица (до 100 символов).</param>
        /// <param name="building">Номер дома (до 10 символов).</param>
        /// <param name="apartment">Номер квартиры (до 10 символов).</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}