using Programming_WinFormsApp.Model.Enums;
using System;
using System.Collections.Generic; // Добавьте этот using
using System.Windows.Forms;

namespace Programming_WinFormsApp
{
    public partial class MainForm : Form
    {
        // Объявляем словарь на уровне класса, чтобы он был доступен во всех методах
        private Dictionary<string, Type> enumTypes;

        public MainForm()
        {
            InitializeComponent();

            enumTypes = new Dictionary<string, Type>
            {
                //{ "Color", typeof(Color) }, почему-то не работает
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

        }

        void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem != null)
            {
                string selectedEnum = EnumsListBox.SelectedItem.ToString();

                ValueListBox.Items.Clear();

                Type enumType = enumTypes[selectedEnum];
                string[] enumValues = Enum.GetNames(enumType);

                ValueListBox.Items.AddRange(enumValues);

            }
        }

        void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ValueListBox.SelectedItem.ToString();      
        }
    }
}