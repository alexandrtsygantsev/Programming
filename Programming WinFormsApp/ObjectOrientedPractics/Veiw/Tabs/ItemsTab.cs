using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
        /// Последнее значение Cost, по которому уже показали сообщение.
        /// </summary>
        private double _lastReportedCost = double.NaN;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            ItmesListBox.Items.Clear();
        }

        /// <summary>
        /// Отписывает обработчики от событий TextChanged.
        /// </summary>
        private void DetachTextHandlers()
        {
            CostTextBox.TextChanged -= CostTextBox_TextChanged;
            NameTextBox.TextChanged -= NameTextBox_TextChanged;
            DescriptionLTextBox.TextChanged -= DescriptionLTextBox_TextChanged;
        }

        /// <summary>
        /// Подписывает обработчики на события TextChanged.
        /// </summary>
        private void AttachTextHandlers()
        {
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            DescriptionLTextBox.TextChanged += DescriptionLTextBox_TextChanged;
        }

        /// <summary>
        /// Заполняет поля значениями товара без реакции обработчиков.
        /// </summary>
        private void FillFields(Item item)
        {
            DetachTextHandlers();
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionLTextBox.Text = item.Info;
            AttachTextHandlers();
        }

        /// <summary>
        /// Приводит поля ввода в исходное (пустое) состояние.
        /// </summary>
        private void ClearFields()
        {
            DetachTextHandlers();
            IdTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            DescriptionLTextBox.Text = string.Empty;
            AttachTextHandlers();

            _lastReportedCost = double.NaN;
        }

        /// <summary>
        /// Обработчик нажатия кнопки Add. Создаёт новый товар.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(CostTextBox.Text, out double cost) ||
                cost < 0 || cost > 100000)
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

            var item = new Item(name, info, cost);
            _items.Add(item);
            ItmesListBox.Items.Add(item.Name);

            ItmesListBox.SelectedIndex = _items.Count - 1;
            FillFields(item);
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

            FillFields(_items[index]);
        }

        /// <summary>
        /// Обработчик изменения текста в поле Cost.
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItmesListBox.SelectedIndex;
            if (index < 0) return;

            if (!double.TryParse(CostTextBox.Text, out double cost))
            {
                CostTextBox.BackColor = Color.LightPink;
                return;
            }

            if (cost < 0 || cost > 100000)
            {
                CostTextBox.BackColor = Color.LightPink;

                if (cost != _lastReportedCost)
                {
                    _lastReportedCost = cost;
                    MessageBox.Show("Стоимость должна быть в диапазоне от 0 до 100000.");
                }
                return;
            }

            _items[index].Cost = cost;
            CostTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обработчик изменения текста в поле Name.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItmesListBox.SelectedIndex;
            if (index < 0) return;

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                NameTextBox.BackColor = Color.LightPink;
                return;
            }

            _items[index].Name = NameTextBox.Text;
            NameTextBox.BackColor = Color.White;
            UpdateListBoxItem(index);
        }

        /// <summary>
        /// Обработчик изменения текста в поле Info.
        /// </summary>
        private void DescriptionLTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItmesListBox.SelectedIndex;
            if (index < 0) return;

            if (string.IsNullOrWhiteSpace(DescriptionLTextBox.Text))
            {
                DescriptionLTextBox.BackColor = Color.LightPink;
                return;
            }

            _items[index].Info = DescriptionLTextBox.Text;
            DescriptionLTextBox.BackColor = Color.White;
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