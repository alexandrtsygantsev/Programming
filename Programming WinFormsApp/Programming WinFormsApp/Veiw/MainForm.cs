using Programming_WinFormsApp.Model.Enums;
using Programming_WinFormsApp.Model;

using System;
using System.Collections.Generic; // Добавьте этот using
using System.Windows.Forms;

namespace Programming_WinFormsApp
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Type> enumTypes;

        private Model.Rectangle[] _rectangles;

        private Model.Rectangle _currentRectangle;

        public MainForm()
        {


            InitializeComponent();


            SeasonDropList.DataSource = Enum.GetValues(typeof(Season));

            enumTypes = new Dictionary<string, Type>
            {
                { "Color", typeof(Colorix) },
                { "Genre", typeof(Genre) },
                { "Season", typeof(Season) },
                { "SmartManufac", typeof(SmartManufac) },
                { "StudFormEdu", typeof(StudFormEdu) },
                { "Weekday", typeof(Weekday) }
            };

            foreach (string enumName in enumTypes.Keys)
            {
                EnumsListBox.Items.Add(enumName);
            }
            EnumsListBox.SelectedIndexChanged += new EventHandler(EnumsListBox_SelectedIndexChanged);
            ValueListBox.SelectedIndexChanged += new EventHandler(ValueListBox_SelectedIndexChanged);
            RecListBox.SelectedIndexChanged += new EventHandler(RecListBox_SelectedIndexChanged);

            InitializeRectangles();
        }


        private void InitializeRectangles()
        {
            Random rand = new Random();
            _rectangles = new Model.Rectangle[5];


            for (int i = 0; i < _rectangles.Length; i++)
            {
                double length = rand.Next(1, 101);
                double width = rand.Next(1, 101);
                string color = "color" + i;

                _rectangles[i] = new Model.Rectangle(length, width, color);
            }


            for (int i = 0; i < _rectangles.Length; i++)
            {
                RecListBox.Items.Add($"Rectangle {i + 1}");
            }
        }
       

        /// <summary>
        /// Наполнение списка с названиями перечислений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEnum = EnumsListBox.SelectedItem.ToString();

            ValueListBox.Items.Clear();

            Type enumType = enumTypes[selectedEnum];
            string[] enumValues = Enum.GetNames(enumType);

            ValueListBox.Items.AddRange(enumValues);


        }

        /// <summary>
        /// Наполенение списка перечисленний по их названиям.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValueListBox.SelectedItem == null) return;

            string selectedValue = ValueListBox.SelectedItem.ToString();
            string selectedEnum = EnumsListBox.SelectedItem.ToString();

            Type enumType = enumTypes[selectedEnum];

            object enumObject = Enum.Parse(enumType, selectedValue);

            int numericValue = Convert.ToInt32(enumObject);

            IntValueBox.Text = numericValue.ToString();
        }

        /// <summary>
        /// Функция поиска дня недели и его числового значения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            string userText = ParsingTextBox.Text.Trim();

            Weekday parseDay;
            bool parseOkey = Enum.TryParse<Weekday>(userText, ignoreCase: true, out parseDay);

            if (parseOkey)
            {
                bool isNumber = true;
                foreach (char c in userText)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }
                if (isNumber)
                {
                    StatusParse.Text = "Нет такого дня недели";
                }
                else
                {
                    int numberDay = (int)parseDay;
                    StatusParse.Text = $"Это день недели ({parseDay} = {numberDay + 1})";
                    return;
                }
            }
            StatusParse.Text = "Нет такого дня недели";
        }

        /// <summary>
        /// Фукнция выбора времени года и выполенение некоторых действий в зависимости от выбора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            Season chooseSeason = (Season)SeasonDropList.SelectedItem;

            switch (chooseSeason)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    EnumPage.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    EnumPage.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                default:
                    MessageBox.Show("Что-то пошло не так");
                    break;
            }
        }

        private void SeasonDropList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumPage.BackColor = Color.White;
        }

        private void RecListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RecListBox.SelectedItem == null) return;

            string selectedRec = RecListBox.SelectedItem.ToString();

            // Обновляем текущий прямоугольник при выборе в списке
            int selectedIndex = RecListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];

            LenTextBox.Text = _currentRectangle.Width.ToString();
            WithTextBox.Text = _currentRectangle.Length.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
        }

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

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}