using Programming_WinFormsApp.Model.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_WinFormsApp.Veiw.Panels
{
    public partial class MoviesControl : UserControl
    {

        private Model.Film[] _film;
        private Model.Film _currentFilm;
        public MoviesControl()
        {
            InitializeComponent();

            InitializeFilms();

            this.FilmTextBox.SelectedIndexChanged += FilmTextBox_SelectedIndexChanged;
            this.RatTextBox.TextChanged += RatTextBox_TextChanged;
            this.FindRutBut.Click += FindRutBut_Click;
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



            for (int i = 0; i < 5; i++)
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
    }
}
