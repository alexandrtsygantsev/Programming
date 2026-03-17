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
        private string color { get; set; }

        public double Lenght
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Значение не может быть отрицательным");
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
                    MessageBox.Show("Значение не может быть отрицательным");
                }
                width = value;
            }
        }

    }
}
