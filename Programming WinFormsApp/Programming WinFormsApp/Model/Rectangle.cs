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
                if (Validator.AssertOnPositiveValue(value))
                {
                    length = value;
                }
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
                if (Validator.AssertOnPositiveValue(value))
                {
                    width = value;
                }
            }
        }
        public Rectangle() { }
        public Rectangle(double length, double width, string color)
        {
            Length = length; 
            Width = width;   
            Color = color;   
        }
    }
}