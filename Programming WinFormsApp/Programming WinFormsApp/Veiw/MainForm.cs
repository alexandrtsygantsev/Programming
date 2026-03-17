using Programming_WinFormsApp.Model.Enums;
using System;
using System.Collections.Generic; // Добавьте этот using
using System.Windows.Forms;

namespace Programming_WinFormsApp
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Type> enumTypes;

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
    }
}