using MusicManager.Models;
using System.Xml.Serialization;

namespace MusicManager.Controls
{
    /// <summary>
    /// Пользовательский элемент управления для управления списком песен
    /// </summary>
    public partial class SongManagerControl : UserControl
    {
        private List<Song> _songs;
        private Song? _currentSong;
        private readonly string _filePath;

        public SongManagerControl()
        {
            InitializeComponent();

            // Путь к файлу для сохранения данных
            _filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "MusicManager",
                "songs.xml");

            _songs = new List<Song>();
            InitializeGenreComboBox();
            LoadData();           // Загружаем данные из файла
            LoadSongsToList();    // Отображаем список
            SubscribeEvents();

            editButton.Enabled = false;
            delButton.Enabled = false;
        }

        /// <summary>
        /// Инициализация выпадающего списка жанров
        /// </summary>
        private void InitializeGenreComboBox()
        {
            genreBox.DataSource = Enum.GetValues(typeof(MusicGenre));
            genreBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genreBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Подписка на события элементов управления
        /// </summary>
        private void SubscribeEvents()
        {
            musicList.SelectedIndexChanged += MusicList_SelectedIndexChanged;
            addButton.Click += AddButton_Click;
            editButton.Click += EditButton_Click;
            delButton.Click += DelButton_Click;

            nameBox.TextChanged += OnTextChanged;
            authorBox.TextChanged += OnTextChanged;
            durBox.TextChanged += OnTextChanged;
        }

        /// <summary>
        /// Проверка заполнения полей и включение кнопки "Сохранить"
        /// </summary>
        private void OnTextChanged(object? sender, EventArgs e)
        {
            bool isFilled = !string.IsNullOrWhiteSpace(nameBox.Text) &&
                           !string.IsNullOrWhiteSpace(authorBox.Text) &&
                           !string.IsNullOrWhiteSpace(durBox.Text);

            editButton.Enabled = isFilled;
        }

        /// <summary>
        /// Загрузка данных из XML файла
        /// </summary>
        private void LoadData()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Song>));
                    using (StreamReader reader = new StreamReader(_filePath))
                    {
                        _songs = (List<Song>)serializer.Deserialize(reader) ?? new List<Song>();
                    }
                }
                else
                {
                    // Если файла нет, создаём тестовые данные
                    CreateTestData();
                    SaveData(); // Сохраняем тестовые данные
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка");
                _songs = new List<Song>();
                CreateTestData();
            }
        }

        /// <summary>
        /// Сохранение данных в XML файл
        /// </summary>
        private void SaveData()
        {
            try
            {
                // Создаём папку, если её нет
                string? directory = Path.GetDirectoryName(_filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Song>));
                using (StreamWriter writer = new StreamWriter(_filePath))
                {
                    serializer.Serialize(writer, _songs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка");
            }
        }

        /// <summary>
        /// Создание тестовых данных для первого запуска
        /// </summary>
        private void CreateTestData()
        {
            _songs = new List<Song>();
            _songs.Add(new Song("Bohemian Rhapsody", "Queen", 354, MusicGenre.Рок));
            _songs.Add(new Song("Imagine", "John Lennon", 183, MusicGenre.Рок));
            _songs.Add(new Song("Billie Jean", "Michael Jackson", 294, MusicGenre.Поп));
            _songs.Add(new Song("Lose Yourself", "Eminem", 326, MusicGenre.ХипХоп));
            _songs.Add(new Song("Take Five", "Dave Brubeck", 324, MusicGenre.Джаз));
        }

        /// <summary>
        /// Загрузка списка песен в ListBox с сортировкой по исполнителю, затем по названию
        /// </summary>
        private void LoadSongsToList()
        {
            musicList.Items.Clear();

            var sortedSongs = _songs
                .OrderBy(s => s.Artist)
                .ThenBy(s => s.Name)
                .ToList();

            foreach (var song in sortedSongs)
            {
                musicList.Items.Add(song);
            }
        }

        /// <summary>
        /// Обработчик выбора песни в списке
        /// </summary>
        private void MusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (musicList.SelectedItem != null)
            {
                _currentSong = (Song)musicList.SelectedItem;
                nameBox.Text = _currentSong.Name;
                authorBox.Text = _currentSong.Artist;
                durBox.Text = _currentSong.DurationSeconds.ToString();
                genreBox.SelectedItem = _currentSong.Genre;
                label5.Text = $"ID: {_currentSong.Id}";
                editButton.Enabled = true;
                delButton.Enabled = true;
            }
            else
            {
                ClearForm();
            }
        }

        /// <summary>
        /// Очистка всех полей ввода и сброс текущей выбранной песни
        /// </summary>
        private void ClearForm()
        {
            _currentSong = null;
            nameBox.Text = "";
            authorBox.Text = "";
            durBox.Text = "";
            genreBox.SelectedIndex = 0;
            label5.Text = "ID:";
            editButton.Enabled = false;
            delButton.Enabled = false;
        }

        /// <summary>
        /// Обработчик кнопки "Добавить"
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            musicList.ClearSelected();
            nameBox.Focus();
        }

        /// <summary>
        /// Обработчик кнопки "Сохранить"
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) ||
                string.IsNullOrWhiteSpace(authorBox.Text) ||
                string.IsNullOrWhiteSpace(durBox.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }

            if (!int.TryParse(durBox.Text, out int duration))
            {
                MessageBox.Show("Длительность должна быть числом", "Ошибка");
                return;
            }

            try
            {
                if (_currentSong != null)
                {
                    // Обновление существующей песни
                    _currentSong.Name = nameBox.Text.Trim();
                    _currentSong.Artist = authorBox.Text.Trim();
                    _currentSong.DurationSeconds = duration;
                    _currentSong.Genre = (MusicGenre)genreBox.SelectedItem;
                }
                else
                {
                    // Добавление новой песни
                    int newId = _songs.Any() ? _songs.Max(s => s.Id) + 1 : 1;
                    Song newSong = new Song(
                        nameBox.Text.Trim(),
                        authorBox.Text.Trim(),
                        duration,
                        (MusicGenre)genreBox.SelectedItem
                    );
                    newSong.Id = newId;
                    _songs.Add(newSong);
                }

                SaveData();           // Сохраняем в файл
                LoadSongsToList();    // Обновляем список
                ClearForm();
                MessageBox.Show("Сохранено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации");
            }
        }

        /// <summary>
        /// Обработчик кнопки "Удалить"
        /// </summary>
        private void DelButton_Click(object sender, EventArgs e)
        {
            if (_currentSong == null)
            {
                MessageBox.Show("Выберите песню для удаления", "Ошибка");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Удалить песню \"{_currentSong.Artist} - {_currentSong.Name}\"?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _songs.Remove(_currentSong);
                SaveData();           // Сохраняем в файл
                LoadSongsToList();    // Обновляем список
                ClearForm();
            }
        }
    }
}