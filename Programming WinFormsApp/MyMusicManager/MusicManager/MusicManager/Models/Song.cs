using MusicManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManager.Models
{
    /// <summary>
    /// Класс, представляющий песню в информационной системе
    /// </summary>
    public class Song
    {
        private string _name;
        private string _artist;
        private int _durationSeconds;
        private MusicGenre _genre;

        /// <summary>
        /// Уникальный идентификатор песни
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название песни (не более 50 символов)
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (Validator.LengthTitle(value, "Название"))
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Исполнитель песни (не более 50 символов)
        /// </summary>
        public string Artist
        {
            get { return _artist; }
            set
            {
                if (Validator.LengthTitle(value, "Исполнитель"))
                {
                    _artist = value;
                }
            }
        }

        /// <summary>
        /// Продолжительность песни в секундах (1-7200)
        /// </summary>
        public int DurationSeconds
        {
            get { return _durationSeconds; }
            set
            {
                if (Validator.LenghtTime(value))
                {
                    _durationSeconds = value;
                }
            }
        }

        /// <summary>
        /// Жанр песни
        /// </summary>
        public MusicGenre Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Song()
        {
            Id = 0;
            _name = string.Empty;
            _artist = string.Empty;
            _durationSeconds = 180;
            _genre = MusicGenre.Рок;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        public Song(string name, string artist, int durationSeconds, MusicGenre genre)
        {
            Name = name;
            Artist = artist;
            DurationSeconds = durationSeconds;
            Genre = genre;
        }

        /// <summary>
        /// Возвращает форматированную продолжительность (ММ:СС)
        /// </summary>
        public string GetFormattedDuration()
        {
            int minutes = _durationSeconds / 60;
            int seconds = _durationSeconds % 60;
            return $"{minutes}:{seconds:D2}";
        }

        /// <summary>
        /// Для отображения в списке: "Исполнитель - Название"
        /// </summary>
        public override string ToString()
        {
            return $"{Artist} - {Name}";
        }
    }

    /// <summary>
    /// Перечисление жанров песен
    /// </summary>
    public enum MusicGenre
    {
        Рок,
        Поп,
        ХипХоп,
        Джаз,
        Классика,
        Электроника,
        Металл,
        Блюз,
        Кантри,
        RAndB,
        Регги
    }
}