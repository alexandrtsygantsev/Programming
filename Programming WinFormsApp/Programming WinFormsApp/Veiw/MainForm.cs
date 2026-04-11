using Programming_WinFormsApp.Model;
using Programming_WinFormsApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming_WinFormsApp
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Type> enumTypes;

        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;

        private Model.Film[] _film;
        private Model.Film _currentFilm;

        private List<Panel> _rectanglePanels;


        public MainForm()
        {


            InitializeComponent();

            this.ButtPlus.Click += ButtPlus_Click;
            this.ButtMinus.Click += ButtMinus_Click;
            this.RectanListBox.SelectedIndexChanged += RectanListBox_SelectedIndexChanged;
            this.YBox.TextChanged += YBox_TextChanged;
            this.XBox.TextChanged += XBox_TextChanged;



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
                double centerX = Math.Round(rand.NextDouble() * 100, 1);
                double centerY = Math.Round(rand.NextDouble() * 100, 1);
                Point2D center = new Point2D(centerX,centerY);

                _rectangles[i] = new Model.Rectangle(length, width, color, centerX, centerY);

                RecListBox.Items.Add($"Rectangle {i + 1}");
                RectanListBox.Items.Add($"{i + 1}: (X={centerX}; Y={centerY}; W={width}; H={length})");


            }
            //SyncAllLists();
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
            int selectedIndex = RecListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];

            LenTextBox.Text = _currentRectangle.Length.ToString();
            WithTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            CenterTextBox.Text = $"{_currentRectangle.Center.X} ; {_currentRectangle.Center.Y}";
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void RectanListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRect = RectanListBox.SelectedItem.ToString();

            int selectedIndex = RectanListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];

            HeightBox.Text = _currentRectangle.Length.ToString();
            WidthBox.Text = _currentRectangle.Width.ToString();
            XBox.Text = _currentRectangle.Center.X.ToString();
            YBox.Text = _currentRectangle.Center.Y.ToString();
            IdBox.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// Добавление нового прямоугольника
        /// </summary>
        private void ButtPlus_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] colors = { "Orange", "White", "Pink", "Black", "Red", "Blue", "Yellow" };

            // Генерируем случайные параметры для нового прямоугольника
            double length = rand.Next(1, 101);
            double width = rand.Next(1, 101);
            string color = colors[rand.Next(colors.Length)];
            double centerX = Math.Round(rand.NextDouble() * 100, 1);
            double centerY = Math.Round(rand.NextDouble() * 100, 1);

            // Создаем новый массив с увеличенным размером
            Model.Rectangle[] newRectangles = new Model.Rectangle[_rectangles.Length + 1];

            // Копируем существующие прямоугольники
            for (int i = 0; i < _rectangles.Length; i++)
            {
                newRectangles[i] = _rectangles[i];
            }

            // Добавляем новый прямоугольник
            newRectangles[_rectangles.Length] = new Model.Rectangle(length, width, color, centerX, centerY);

            // Заменяем старый массив новым
            _rectangles = newRectangles;

            // Добавляем элемент в ListBox
            RectanListBox.Items.Add($"{_rectangles.Length}: (X={centerX}; Y={centerY}; W={width}; H={length})");

            // Автоматически выбираем новый прямоугольник
            if (RectanListBox.Items.Count > 0)
            {
                RectanListBox.SelectedIndex = RectanListBox.Items.Count - 1;
            }

            // ========== СОЗДАНИЕ PANEL В ПРЕДЕЛАХ КАНВЫ ==========

            // Определяем область канвы (где можно рисовать прямоугольники)
            // Например, область справа от ListBox'а
            int canvasX = RectanListBox.Right + 20;  // Начало канвы по X (правее ListBox'а)
            int canvasY = 50;                         // Начало канвы по Y
            int canvasWidth = this.ClientSize.Width - canvasX - 20;  // Ширина канвы
            int canvasHeight = this.ClientSize.Height - canvasY - 20; // Высота канвы

            // Если канва еще не определена (форма только загружена), используем значения по умолчанию
            if (canvasWidth <= 0) canvasWidth = 500;
            if (canvasHeight <= 0) canvasHeight = 400;

            // Масштабируем координаты (0-100) в границы канвы
            int panelX = canvasX + (int)((centerX / 100.0) * (canvasWidth - 100)); // -100 чтобы не выходить за границы
            int panelY = canvasY + (int)((centerY / 100.0) * (canvasHeight - 100));

            // Размеры панели (с ограничением, чтобы не выходила за границы канвы)
            int panelWidth = Math.Min((int)width, canvasWidth - 50);
            int panelHeight = Math.Min((int)length, canvasHeight - 50);

            // Гарантируем минимальный размер
            panelWidth = Math.Max(20, panelWidth);
            panelHeight = Math.Max(20, panelHeight);

            // Корректируем позицию, чтобы панель не выходила за границы канвы
            if (panelX + panelWidth > canvasX + canvasWidth)
                panelX = canvasX + canvasWidth - panelWidth;
            if (panelY + panelHeight > canvasY + canvasHeight)
                panelY = canvasY + canvasHeight - panelHeight;
            if (panelX < canvasX)
                panelX = canvasX;
            if (panelY < canvasY)
                panelY = canvasY;

            // Создаем новую панель
            Panel newPanel = new Panel();
            newPanel.Location = new System.Drawing.Point(panelX, panelY);
            newPanel.Width = panelWidth;
            newPanel.Height = panelHeight;
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            newPanel.BorderStyle = BorderStyle.FixedSingle;

            // Добавляем подпись на панель
            Label panelLabel = new Label
            {
                Text = $"{_rectangles.Length}",
                Location = new System.Drawing.Point(3, 3),
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Arial", 7, FontStyle.Bold)
            };
            newPanel.Controls.Add(panelLabel);

            // Добавляем обработчик для перемещения (опционально)
            newPanel.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Left)
                {
                    // Можно добавить логику перемещения панели
                    newPanel.DoDragDrop(newPanel, DragDropEffects.Move);
                }
            };

            // Инициализируем список если null
            if (_rectanglePanels == null)
            {
                _rectanglePanels = new List<Panel>();
            }

            // Добавляем панель в список
            _rectanglePanels.Add(newPanel);

            // Добавляем панель на форму
            this.Controls.Add(newPanel);

            // Делаем панель видимой
            newPanel.BringToFront();
        }
        private void ButtMinus_Click(object sender, EventArgs e)
        {

            int selectedIndex = RectanListBox.SelectedIndex;

            if (selectedIndex < 5)
            {
                MessageBox.Show("Нельзя удалять исходные прямоугольники!");
                return;
            }

            // ВРЕМЕННО ОТКЛЮЧАЕМ СОБЫТИЕ
            RectanListBox.SelectedIndexChanged -= RectanListBox_SelectedIndexChanged;

            try
            {
                // Удаляем из массива
                Model.Rectangle[] newRectangles = new Model.Rectangle[_rectangles.Length - 1];
                int newIndex = 0;

                for (int i = 0; i < _rectangles.Length; i++)
                {
                    if (i != selectedIndex)
                    {
                        newRectangles[newIndex] = _rectangles[i];
                        newIndex++;
                    }
                }

                _rectangles = newRectangles;

                // Удаляем из списка
                RectanListBox.Items.RemoveAt(selectedIndex);

                // Очищаем поля
                HeightBox.Text = "";
                WidthBox.Text = "";
                XBox.Text = "";
                YBox.Text = "";
                IdBox.Text = "";

                _currentRectangle = null;

                // Выбираем новый элемент
                if (RectanListBox.Items.Count > 0)
                {
                    int newSelectedIndex = selectedIndex - 1;
                    if (newSelectedIndex < 0) newSelectedIndex = 0;
                    RectanListBox.SelectedIndex = newSelectedIndex;
                }
            }
            finally
            {
                // ВКЛЮЧАЕМ СОБЫТИЕ ОБРАТНО
                RectanListBox.SelectedIndexChanged += RectanListBox_SelectedIndexChanged;
            }
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

        private void XBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(XBox.Text))
            {
                XBox.BackColor = Color.White;
                return;
            }

            if (double.TryParse(XBox.Text, out double x) && x > 0)
            {
                _currentRectangle.Center = new Point2D(x, _currentRectangle.Center.Y);
                XBox.BackColor = Color.White;
            }
            else
            {
                XBox.BackColor = Color.LightPink;
            }
        }

        private void YBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(YBox.Text))
            {
                YBox.BackColor = Color.White;
                return;
            }

            if (double.TryParse(YBox.Text, out double y) && y > 0)
            {
                _currentRectangle.Center = new Point2D(_currentRectangle.Center.X, y);
                YBox.BackColor = Color.White;
            }
            else
            {
                YBox.BackColor = Color.LightPink;
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