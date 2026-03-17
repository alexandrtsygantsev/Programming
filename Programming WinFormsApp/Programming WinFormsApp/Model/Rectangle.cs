using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Rectangle
    {
        private double length;
        private double width;
        public string Color { get; set; }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной");
                }
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ширина не может быть отрицательной");
                }
                width = value;
            }
        }

        public Rectangle(double length, double width, string color)
        {
            Length = length; 
            Width = width;   
            Color = color;   
        }
    }
}