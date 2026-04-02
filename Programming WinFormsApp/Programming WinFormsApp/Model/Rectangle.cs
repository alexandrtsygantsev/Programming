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
        public Point2D Center {  get; set; }
        private static int _allRectanglesCount;
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }
        private readonly int _id;

        public int Id
        {
            get { return _id; }
        }


        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(Length)))
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
                if (Validator.AssertOnPositiveValue(value, nameof(Width)))
                {
                    width = value;
                }
            }
        }
        public Rectangle()
        {
            Center = new Point2D(0, 0);
            _id = ++_allRectanglesCount;

        }
        public Rectangle(double length, double width, string color, double centerX, double centerY)
        {
            Length = length; 
            Width = width;   
            Color = color;
            Center = new Point2D(centerX,centerY);
            _id = ++_allRectanglesCount; 
        }
    }
}