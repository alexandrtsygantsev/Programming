using Programming_WinFormsApp.Model.Enums;
using Programming_WinFormsApp.Model;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming_WinFormsApp
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Type> enumTypes;

        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;

        private Model.Film[] _film;
        private Model.Film _currentFilm;

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
            InitializeFilms();
        }

        //================== Classes Functions ==================

        /// <summary>
        /// Присвоение значений прямоугольникам и вывод обще списка в RecListBox
        /// </summary>
        private void InitializeRectangles()
        {
            Random rand = new Random();
            _rectangles = new Model.Rectangle[5];
            string[] colors = { "Orange", "White", "Pink", "Black", "Red", "Blue", "Yellow" };


            for (int i = 0; i < _rectangles.Length; i++)
            {
                double length = rand.Next(1, 101);
                double width = rand.Next(1, 101);
                string color = colors[rand.Next(colors.Length)];
                ;

                _rectangles[i] = new Model.Rectangle(length, width, color);

                RecListBox.Items.Add($"Rectangle {i + 1}");
            }
        }

        /// <summary>
        /// Поиск прямоугольника с наибольшей шириной
        /// </summary>
        /// <param name="rectangles"></param>
        /// <returns></returns>
        private int FindRectangleWithMaxWidth(Model.Rectangle[] rectangles)
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
            string selectedRec = RecListBox.SelectedItem.ToString();

            int selectedIndex = RecListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];

            LenTextBox.Text = _currentRectangle.Length.ToString();
            WithTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
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

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {

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




        /// <summary>
        /// Присвоение значений фильмам и вывод общего списка в FilmTextBox
        /// </summary>
        private void InitializeFilms()
        {
            Random rand = new Random();
            _film = new Model.Film[5];
            string[] names = { "Фильм 1", "Фильм 2", "Фильм 3", "Фильм 4", "Фильм 5", "Фильм 6", "Фильм 7" };
            string[] genres = { "Драма", "Комедия", "Боевик", "Детектив", "Хоррор", "Фантастика" };



            for (int i = 0; i < _rectangles.Length; i++)
            {
                string name = names[rand.Next(names.Length)];
                int durationMin = rand.Next(60, 121);
                int years = rand.Next(1901, 2027);
                string genre = genres[rand.Next(genres.Length)];
                double rating = Math.Round(rand.NextDouble() * 10, 1);
                _film[i] = new Model.Film(name, durationMin, years, genre, rating);

                FilmTextBox.Items.Add(names[i]);
            }
        }

        /// <summary>
        /// Показ значений выбранного фильма в соответствующих полях приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilmTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilm = FilmTextBox.SelectedItem.ToString();

            int selectedIndex = FilmTextBox.SelectedIndex;
            _currentFilm = _film[selectedIndex];

            DurTextBox.Text = _currentFilm.DurationMin.ToString();
            YearTextBox.Text = _currentFilm.Years.ToString();
            GenreTextBox.Text = _currentFilm.Genre.ToString();
            RatTextBox.Text = _currentFilm.Rating.ToString();
        }

        /// <summary>
        /// Поиска фильма с наивысшим рейтингом
        /// </summary>
        /// <param name="films"></param>
        /// <returns></returns>
        private int FindWithRatingMax(Model.Film[] films)
        {
            int maxRatingIndex = 0;
            double maxRating = films[0].Rating;

            for (int i = 0; i < films.Length; i++)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = films[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        /// <summary>
        /// Работа кнопки поиска наивысшего рейтинга
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindRutBut_Click(object sender, EventArgs e)
        {
            int maxRating = FindWithRatingMax(_film);

            if (maxRating >= 0 && maxRating < FilmTextBox.Items.Count)
            {
                FilmTextBox.SelectedIndex = maxRating;
            }
        }

        /// <summary>
        /// Измнение цвета поля рейтинга при неправильном вводе значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RatTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double rating = Convert.ToDouble(RatTextBox.Text);

                if (rating < 0)
                {
                    throw new ArgumentOutOfRangeException("Рейтинг не должен быть отрицательным");
                }

                _currentFilm.Rating = rating;
                RatTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                RatTextBox.BackColor = Color.LightPink;
            }
        }


        //================== Enum Functions ==================

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


    }
}