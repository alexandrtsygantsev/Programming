using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс описания товара
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Уникальный номер товара
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Название товара
        /// </summary>
        private string _name;
        /// <summary>
        /// Описание товара
        /// </summary>
        private string _info;
        /// <summary>
        /// Стоимость товара
        /// </summary>
        private double _cost;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 200)
                {
                    throw new ArgumentException("value");
                }
                _name = value;
            }
        }
        public string Info
        {
            get { return _info; }
            set
            {
                if (value.Length > 1000)
                {
                    throw new ArgumentException("value");
                }
                _info = value;
            }
        }
        public double Cost
        {
            get { return _cost; }
            set
            {
                if(value < 0 && value > 100000)
                {
                    throw new ArgumentException("value");
                }
                _cost = value;
            }
        }

        public int Id
        {
            get { return _id; }
        }

        public Item(string name, string info, double cost)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
