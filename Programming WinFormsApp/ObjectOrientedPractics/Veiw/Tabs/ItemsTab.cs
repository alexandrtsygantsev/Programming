using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.Veiw.Tabs
{
    /// <summary>
    /// Пользовательский элемент управления для работы со списком товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Флаг, блокирующий реакцию на изменение текста во время
        /// программной подстановки значений.
        /// </summary>
        private bool _isUpdating;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            ItmesListBox.Items.Clear();
        }

        /// <summary>
        /// Приводит поля ввода в исходное (пустое) состояние.
        /// </summary>
        private void ClearFields()
        {
            _isUpdating = true;
            IdTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            DescriptionLTextBox.Text = string.Empty;
            _isUpdating = false;

            CostTextBox.BackColor = Color.White;
            NameTextBox.BackColor = Color.White;
            DescriptionLTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обработчик нажатия кнопки Add. Создаёт новый товар.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(CostTextBox.Text, out double cost))
            {
                CostTextBox.BackColor = Color.LightPink;
                return;
            }

            string name = NameTextBox.Text;
            string info = DescriptionLTextBox.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                NameTextBox.BackColor = Color.LightPink;
                return;
            }

            if (string.IsNullOrWhiteSpace(info))
            {
                DescriptionLTextBox.BackColor = Color.LightPink;
                return;
            }

            try
            {
                var item = new Item(name, info, cost);
                _items.Add(item);
                ItmesListBox.Items.Add(item.Name);

                _isUpdating = true;
                ItmesListBox.SelectedIndex = _items.Count - 1;
                IdTextBox.Text = item.Id.ToString();
                CostTextBox.Text = item.Cost.ToString();
                NameTextBox.Text = item.Name;
                DescriptionLTextBox.Text = item.Info;
                _isUpdating = false;

                CostTextBox.BackColor = Color.White;
                NameTextBox.BackColor = Color.White;
                DescriptionLTextBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                if (ex.Message.StartsWith("Name"))
                {
                    NameTextBox.BackColor = Color.LightPink;
                }
                else if (ex.Message.StartsWith("Info"))
                {
                    DescriptionLTextBox.BackColor = Color.LightPink;
                }
                else if (ex.Message.StartsWith("Cost"))
                {
                    CostTextBox.BackColor = Color.LightPink;
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки Remove. Удаляет выбранный товар.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItmesListBox.SelectedIndex;
            if (index < 0) return;

            _items.RemoveAt(index);
            ItmesListBox.Items.RemoveAt(index);

            if (ItmesListBox.Items.Count > 0)
            {
                ItmesListBox.SelectedIndex =
                    Math.Min(index, ItmesListBox.Items.Count - 1);
            }
            else
            {
                ClearFields();
            }
        }

        /// <summary>
        /// Обработчик смены выбранного элемента в ListBox.
        /// </summary>
        private void ItmesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItmesListBox.SelectedIndex;
            if (index < 0)
            {
                ClearFields();
                return;
            }

            Item item = _items[index];

            _isUpdating = true;
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionLTextBox.Text = item.Info;
            _isUpdating = false;

            CostTextBox.BackColor = Color.White;
            NameTextBox.BackColor = Color.White;
            DescriptionLTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обработчик изменения текста в поле Cost.
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            int index = ItmesListBox.SelectedIndex;
            if (index < 0) return;

            if (!double.TryParse(CostTextBox.Text, out double cost))
            {
                CostTextBox.BackColor = Color.LightPink;
                return;
            }

            try
            {
                _items[index].Cost = cost;
                CostTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле Name.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            int index = ItmesListBox.SelectedIndex;
            if (index < 0) return;

            try
            {
                _items[index].Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
                UpdateListBoxItem(index);
            }
            catch (ArgumentException)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле Info.
        /// </summary>
        private void DescriptionLTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            int index = ItmesListBox.SelectedIndex;
            if (index < 0) return;

            try
            {
                _items[index].Info = DescriptionLTextBox.Text;
                DescriptionLTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                DescriptionLTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обновляет текстовое представление товара в ListBox.
        /// </summary>
        /// <param name="index">Индекс товара.</param>
        private void UpdateListBoxItem(int index)
        {
            if (index < 0 || index >= _items.Count) return;

            int selected = ItmesListBox.SelectedIndex;
            ItmesListBox.Items[index] = _items[index].Name;
            ItmesListBox.SelectedIndex = selected;
        }
    }
}