using Programming_WinFormsApp.Model.Enums;
using Programming_WinFormsApp.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming_WinFormsApp
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Type> enumTypes;

        private Model.Geometry.Rectangle[] _rectangles; 
        private Model.Geometry.Rectangle[] _rectanglesTab; 
        private Model.Geometry.Rectangle _currentRectangle;
        private Model.Geometry.Rectangle _currentRectangleTab; 

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

            this.WidthBox.TextChanged += WidthBox_TextChanged;
            this.HeightBox.TextChanged += HeightBox_TextChanged;

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
            InitializeRectanglesTab();   
            InitializeFilms();
        }

        //================== Classes Functions ==================

        /// <summary>
        /// Поиск пересекающихся прямоугольников и изменение их цвета
        /// </summary>
        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectanglesTab.Length; i++)
            {
                for (int j = 0; j < _rectanglesTab.Length; j++)
                {
                    if (i == j) continue;

                    if (CollisionManager.IsCollision(_rectanglesTab[i], _rectanglesTab[j]))
                    {
                        if (i < _rectanglePanels.Count)
                            _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127); 

                        if (j < _rectanglePanels.Count)
                            _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
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
        /// Создание прямоугольников для вкладки Rectangles
        /// </summary>
        private void InitializeRectanglesTab()
        {
            // Сбрасываем счетчик для вкладки Rectangles
            Model.Geometry.Rectangle.ResetRectanglesTabCount();

            _rectanglesTab = new Model.Geometry.Rectangle[0];

            RectanListBox.Items.Clear();

            if (_rectanglePanels != null)
            {
                foreach (var panel in _rectanglePanels)
                {
                    if (RecPanel.Controls.Contains(panel))
                        RecPanel.Controls.Remove(panel);
                    panel.Dispose();
                }
                _rectanglePanels.Clear();
            }
            else
            {
                _rectanglePanels = new List<Panel>();
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

        private void RectanListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_rectanglesTab == null || _rectanglesTab.Length == 0)
            {
                RectanListBox.Items.Clear();

                // Очищаем поля
                HeightBox.Text = "";
                WidthBox.Text = "";
                XBox.Text = "";
                YBox.Text = "";
                IdBox.Text = "";
                _currentRectangleTab = null;
                return;
            }

            // Проверка индекса
            if (RectanListBox.SelectedIndex < 0 || RectanListBox.SelectedIndex >= _rectanglesTab.Length)
            {
                HeightBox.Text = "";
                WidthBox.Text = "";
                XBox.Text = "";
                YBox.Text = "";
                IdBox.Text = "";
                _currentRectangleTab = null;
                return;
            }

            int selectedIndex = RectanListBox.SelectedIndex;
            _currentRectangleTab = _rectanglesTab[selectedIndex];

            HeightBox.Text = _currentRectangleTab.Length.ToString();
            WidthBox.Text = _currentRectangleTab.Width.ToString();
            XBox.Text = _currentRectangleTab.Center.X.ToString();
            YBox.Text = _currentRectangleTab.Center.Y.ToString();
            IdBox.Text = (selectedIndex + 1).ToString();
        }

        /// <summary>
        /// Создание панели в канве
        /// </summary>
        /// <param name="rectangleIndex"></param>
        private void CreatePanelForRectangle(int rectangleIndex)
        {
            var rect = _rectanglesTab[rectangleIndex];

            // Размеры канвы
            int canvasWidth = RecPanel.Width;    // 522
            int canvasHeight = RecPanel.Height;  // 548

            float scaleX = canvasWidth / 400f;   
            float scaleY = canvasHeight / 400f;

            int panelX = (int)((rect.Center.X - rect.Width / 2) * scaleX);
            int panelY = (int)((rect.Center.Y - rect.Length / 2) * scaleY);

            int panelWidth = Math.Max(5, (int)(rect.Width * scaleX));
            int panelHeight = Math.Max(5, (int)(rect.Length * scaleY));

            if (panelX < 0) panelX = 0;
            if (panelY < 0) panelY = 0;
            if (panelX + panelWidth > canvasWidth) panelX = canvasWidth - panelWidth;
            if (panelY + panelHeight > canvasHeight) panelY = canvasHeight - panelHeight;

            Panel newPanel = new Panel();
            newPanel.Location = new Point(panelX, panelY);
            newPanel.Size = new Size(panelWidth, panelHeight);
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.Tag = rectangleIndex;

            Label panelLabel = new Label
            {
                Text = $"#{rectangleIndex + 1}",
                Location = new Point(2, 2),
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Arial", 6, FontStyle.Bold)
            };
            newPanel.Controls.Add(panelLabel);

            // Добавляем на канву
            RecPanel.Controls.Add(newPanel);
            _rectanglePanels.Add(newPanel);
            newPanel.BringToFront();

            FindCollisions();
        }

        /// <summary>
        /// Обновление позиций прямоугольников на панели
        /// </summary>
        /// <param name="index"></param>
        private void UpdatePanelPosition(int index)
        {
            if (index >= _rectanglePanels.Count || index >= _rectanglesTab.Length) return;

            var rect = _rectanglesTab[index];
            var panel = _rectanglePanels[index];

            int canvasWidth = RecPanel.Width;
            int canvasHeight = RecPanel.Height;

            // Масштабируем координаты с коэффициентом 0.25
            float scaleX = canvasWidth / 400f;
            float scaleY = canvasHeight / 400f;

            int panelX = (int)((rect.Center.X - rect.Width / 2) * scaleX);
            int panelY = (int)((rect.Center.Y - rect.Length / 2) * scaleY);
            int panelWidth = Math.Max(5, (int)(rect.Width * scaleX));
            int panelHeight = Math.Max(5, (int)(rect.Length * scaleY));

            if (panelX < 0) panelX = 0;
            if (panelY < 0) panelY = 0;
            if (panelX + panelWidth > canvasWidth) panelX = canvasWidth - panelWidth;
            if (panelY + panelHeight > canvasHeight) panelY = canvasHeight - panelHeight;

            panel.Location = new Point(panelX, panelY);
            panel.Size = new Size(panelWidth, panelHeight);

            if (panel.Controls.Count > 0 && panel.Controls[0] is Label label)
            {
                if (!label.Text.StartsWith($"#{index + 1}"))
                {
                    label.Text = $"#{index + 1}";
                }
            }
        }

        /// <summary>
        /// Добавление нового прямоугольника
        /// </summary>
        private void ButtPlus_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] colors = { "Orange", "White", "Pink", "Black", "Red", "Blue", "Yellow" };

            double length = rand.Next(1, 101);
            double width = rand.Next(1, 101);
            string color = colors[rand.Next(colors.Length)];
            double centerX = Math.Round(rand.NextDouble() * 350, 1);
            double centerY = Math.Round(rand.NextDouble() * 350, 1);

            Model.Geometry.Rectangle[] newRectangles = new Model.Geometry.Rectangle[_rectanglesTab.Length + 1];

            for (int i = 0; i < _rectanglesTab.Length; i++)
            {
                newRectangles[i] = _rectanglesTab[i];
            }

            newRectangles[_rectanglesTab.Length] = new Model.Geometry.Rectangle(length, width, color, centerX, centerY, true);

            _rectanglesTab = newRectangles;

            RectanListBox.Items.Add($"{_rectanglesTab.Length}: (X={centerX}; Y={centerY}; W={width}; H={length})");

            if (RectanListBox.Items.Count > 0)
            {
                RectanListBox.SelectedIndex = RectanListBox.Items.Count - 1;
            }

            // Создаем панель на канве
            CreatePanelForRectangle(_rectanglesTab.Length - 1);

            FindCollisions();
        }

        /// <summary>
        /// Удаление прямоугольников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtMinus_Click(object sender, EventArgs e)
        {
            int selectedIndex = RectanListBox.SelectedIndex;

            RectanListBox.SelectedIndexChanged -= RectanListBox_SelectedIndexChanged;

            try
            {
                // Удаляем панель
                if (_rectanglePanels != null && selectedIndex < _rectanglePanels.Count)
                {
                    Panel panelToRemove = _rectanglePanels[selectedIndex];
                    if (RecPanel.Controls.Contains(panelToRemove))
                        RecPanel.Controls.Remove(panelToRemove);
                    panelToRemove.Dispose();
                    _rectanglePanels.RemoveAt(selectedIndex);
                }

                // Удаляем из массива
                Model.Geometry.Rectangle[] newRectangles = new Model.Geometry.Rectangle[_rectanglesTab.Length - 1];
                int newIndex = 0;

                for (int i = 0; i < _rectanglesTab.Length; i++)
                {
                    if (i != selectedIndex)
                    {
                        newRectangles[newIndex] = _rectanglesTab[i];
                        newIndex++;
                    }
                }

                _rectanglesTab = newRectangles;

                RectanListBox.Items.Clear();
                for (int i = 0; i < _rectanglesTab.Length; i++)
                {
                    var rect = _rectanglesTab[i];
                    RectanListBox.Items.Add($"{i + 1}: (X={rect.Center.X}; Y={rect.Center.Y}; W={rect.Width}; H={rect.Length})");
                }

                // Обновляем номера на панелях
                for (int i = 0; i < _rectanglePanels.Count; i++)
                {
                    _rectanglePanels[i].Tag = i;
                    if (_rectanglePanels[i].Controls.Count > 0 && _rectanglePanels[i].Controls[0] is Label label)
                    {
                        label.Text = $"#{i + 1}";
                    }
                }

                FindCollisions();

                HeightBox.Text = WidthBox.Text = XBox.Text = YBox.Text = IdBox.Text = "";
                _currentRectangleTab = null;

                if (RectanListBox.Items.Count > 0)
                {
                    int newSelectedIndex = selectedIndex - 1;
                    if (newSelectedIndex < 0) newSelectedIndex = 0;
                    if (newSelectedIndex >= RectanListBox.Items.Count)
                        newSelectedIndex = RectanListBox.Items.Count - 1;
                    RectanListBox.SelectedIndex = newSelectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
            finally
            {
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

        /// <summary>
        /// Функциональность поля X во вкладке Rectangles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(XBox.Text) || _currentRectangleTab == null)
            {
                XBox.BackColor = Color.White;
                return;
            }

            if (double.TryParse(XBox.Text, out double x) && x >= 0 && x <= 350)
            {
                _currentRectangleTab.Center = new Point2D(x, _currentRectangleTab.Center.Y);
                XBox.BackColor = Color.White;

                // Обновляем позицию панели на канве
                int index = Array.IndexOf(_rectanglesTab, _currentRectangleTab);
                if (index != -1 && index < _rectanglePanels.Count)
                {
                    UpdatePanelPosition(index);
                }

                if (RectanListBox.SelectedIndex != -1)
                {
                    RectanListBox.Items[RectanListBox.SelectedIndex] =
                        $"{RectanListBox.SelectedIndex + 1}: (X={_currentRectangleTab.Center.X}; Y={_currentRectangleTab.Center.Y}; W={_currentRectangleTab.Width}; H={_currentRectangleTab.Length})";
                }

                FindCollisions();
            }

            else
            {
                XBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Функциональность поля Y во вкладке Rectangles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(YBox.Text) || _currentRectangleTab == null)
            {
                YBox.BackColor = Color.White;
                return;
            }

            if (double.TryParse(YBox.Text, out double y) && y >= 0 && y <= 350)
            {
                _currentRectangleTab.Center = new Point2D(_currentRectangleTab.Center.X, y);
                YBox.BackColor = Color.White;

                int index = Array.IndexOf(_rectanglesTab, _currentRectangleTab);
                if (index != -1 && index < _rectanglePanels.Count)
                {
                    UpdatePanelPosition(index);
                }

                if (RectanListBox.SelectedIndex != -1)
                {
                    RectanListBox.Items[RectanListBox.SelectedIndex] =
                        $"{RectanListBox.SelectedIndex + 1}: (X={_currentRectangleTab.Center.X}; Y={_currentRectangleTab.Center.Y}; W={_currentRectangleTab.Width}; H={_currentRectangleTab.Length})";
                }

                FindCollisions();
            }
            else
            {
                YBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Функциональность поля Width во вкладке Rectangles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(WidthBox.Text) || _currentRectangleTab == null)
            {
                WidthBox.BackColor = Color.White;
                return;
            }

            if (double.TryParse(WidthBox.Text, out double width) && width >= 1 && width <= 100)
            {
                _currentRectangleTab.Width = width;
                WidthBox.BackColor = Color.White;

                int index = Array.IndexOf(_rectanglesTab, _currentRectangleTab);
                if (index != -1 && index < _rectanglePanels.Count)
                {
                    UpdatePanelPosition(index);
                }

                if (RectanListBox.SelectedIndex != -1)
                {
                    RectanListBox.Items[RectanListBox.SelectedIndex] =
                        $"{RectanListBox.SelectedIndex + 1}: (X={_currentRectangleTab.Center.X}; Y={_currentRectangleTab.Center.Y}; W={_currentRectangleTab.Width}; H={_currentRectangleTab.Length})";
                }

                FindCollisions();
            }
            else
            {
                WidthBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Функциональность поля X во вкладке Rectangles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(HeightBox.Text) || _currentRectangleTab == null)
            {
                HeightBox.BackColor = Color.White;
                return;
            }

            if (double.TryParse(HeightBox.Text, out double height) && height >= 1 && height <= 100)
            {
                _currentRectangleTab.Length = height;
                HeightBox.BackColor = Color.White;

                int index = Array.IndexOf(_rectanglesTab, _currentRectangleTab);
                if (index != -1 && index < _rectanglePanels.Count)
                {
                    UpdatePanelPosition(index);
                }

                if (RectanListBox.SelectedIndex != -1)
                {
                    RectanListBox.Items[RectanListBox.SelectedIndex] =
                        $"{RectanListBox.SelectedIndex + 1}: (X={_currentRectangleTab.Center.X}; Y={_currentRectangleTab.Center.Y}; W={_currentRectangleTab.Width}; H={_currentRectangleTab.Length})";
                }

                FindCollisions();
            }
            else
            {
                HeightBox.BackColor = Color.LightPink;
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