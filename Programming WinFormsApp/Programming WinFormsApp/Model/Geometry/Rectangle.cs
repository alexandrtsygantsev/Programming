using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model.Geometry
{
    internal class Rectangle
    {
        private double length;
        private double width;
        public string Color { get; set; }
        public Point2D Center { get; set; }

        // Счетчик для всех прямоугольников (включая первую вкладку)
        private static int _allRectanglesCount;
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        // Отдельный счетчик для прямоугольников вкладки Rectangles
        private static int _rectanglesTabCount;
        public static int RectanglesTabCount
        {
            get { return _rectanglesTabCount; }
        }

        private readonly int _id;
        public int Id
        {
            get { return _id; }
        }

        // Флаг, указывающий, для какой вкладки создается прямоугольник
        private readonly bool _isForTab;

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
            _isForTab = false;
            _id = ++_allRectanglesCount;
        }

        // Конструктор для первой вкладки (по умолчанию)
        public Rectangle(double length, double width, string color, double centerX, double centerY)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(centerX, centerY);
            _isForTab = false;
            _id = ++_allRectanglesCount;
        }

        // НОВЫЙ КОНСТРУКТОР для вкладки Rectangles с отдельным счетчиком
        public Rectangle(double length, double width, string color, double centerX, double centerY, bool isForRectanglesTab)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(centerX, centerY);
            _isForTab = isForRectanglesTab;

            if (_isForTab)
            {
                _id = ++_rectanglesTabCount;  // Используем отдельный счетчик
            }
            else
            {
                _id = ++_allRectanglesCount;   // Используем общий счетчик
            }
        }

        // Метод для сброса счетчика вкладки Rectangles (при инициализации)
        public static void ResetRectanglesTabCount()
        {
            _rectanglesTabCount = 0;
        }
    }
}