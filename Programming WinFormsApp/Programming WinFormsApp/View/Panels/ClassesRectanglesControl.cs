using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_WinFormsApp.View.Panels
{
    public partial class ClassesRectanglesControl : UserControl
    {
        private Model.Geometry.Rectangle[] _rectangles;
        private Model.Geometry.Rectangle _currentRectangle;

        public ClassesRectanglesControl()
        {
            InitializeComponent();

            InitializeRectangles();

            this.RecListBox.SelectedIndexChanged += RecListBox_SelectedIndexChanged;
            this.LenTextBox.TextChanged += LenTextBox_TextChanged;
            this.WithTextBox.TextChanged += WithTextBox_TextChanged;
            this.FindButton.Click += FindButton_Click;
        }

        /// <summary>
        /// Присвоение значений прямоугольникам и вывод обще списка в RecListBox
        /// </summary>
        private void InitializeRectangles()
        {
            Random rand = new Random();
            _rectangles = new Model.Geometry.Rectangle[5];
            string[] colors = { "Orange", "White", "Pink", "Black", "Red", "Blue", "Yellow" };

            for (int i = 0; i < _rectangles.Length; i++)
            {
                double length = rand.Next(1, 101);
                double width = rand.Next(1, 101);
                string color = colors[rand.Next(colors.Length)];
                double centerX = Math.Round(rand.NextDouble() * 100, 1);
                double centerY = Math.Round(rand.NextDouble() * 100, 1);

                _rectangles[i] = new Model.Geometry.Rectangle(length, width, color, centerX, centerY);

                RecListBox.Items.Add($"Rectangle {i + 1}");
            }
        }

        /// <summary>
        /// Поиск прямоугольника с наибольшей шириной
        /// </summary>
        /// <param name="rectangles"></param>
        /// <returns></returns>
        private int FindRectangleWithMaxWidth(Model.Geometry.Rectangle[] rectangles)
        {
            int maxWithIndex = 0;
            double maxWith = rectangles[0].Width;

            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWith)
                {
                    maxWith = rectangles[i].Width;
                    maxWithIndex = i;
                }
            }
            return maxWithIndex;
        }

        /// <summary>
        /// Показ значений выбранного прямоугольника в соответствующих полях приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RecListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];

            LenTextBox.Text = _currentRectangle.Length.ToString();
            WithTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            CenterTextBox.Text = $"{_currentRectangle.Center.X} ; {_currentRectangle.Center.Y}";
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// Изменение цвета поля при не правлином вводе значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LenTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int length = Convert.ToInt32(LenTextBox.Text);

                if (length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Высота должна быть положительным числом");
                }

                _currentRectangle.Length = length;
                LenTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                LenTextBox.BackColor = Color.LightPink;
            }
        }


        /// <summary>
        /// Изменение цвета поля при не правлином вводе значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WithTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int width = Convert.ToInt32(WithTextBox.Text);

                if (width <= 0)
                {
                    throw new ArgumentOutOfRangeException("Ширина должна быть положительным числом");
                }

                _currentRectangle.Width = width;
                WithTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                WithTextBox.BackColor = Color.LightPink;
            }
        }


        /// <summary>
        /// Работа кнопки поиска максимальной ширины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            int maxWidthIndex = FindRectangleWithMaxWidth(_rectangles);

            if (maxWidthIndex >= 0 && maxWidthIndex < RecListBox.Items.Count)
            {
                RecListBox.SelectedIndex = maxWidthIndex;
            }
        }
    }
}
