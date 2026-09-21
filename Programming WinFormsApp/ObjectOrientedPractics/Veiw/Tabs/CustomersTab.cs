using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Veiw.Tabs
{
    /// <summary>
    /// Вкладка для работы со списком покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Флаг блокировки реакций на изменение текста.
        /// </summary>
        private bool _isUpdating;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            CustomersListBox.Items.Clear();
        }

        /// <summary>
        /// Очищает поля ввода.
        /// </summary>
        private void ClearFields()
        {
            _isUpdating = true;
            IdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            _isUpdating = false;

            FullNameTextBox.BackColor = Color.White;
            AddressTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обработчик кнопки Add.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            string fullName = FullNameTextBox.Text;
            string address = AddressTextBox.Text;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                FullNameTextBox.BackColor = Color.LightPink;
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                AddressTextBox.BackColor = Color.LightPink;
                return;
            }

            try
            {
                var customer = new Customer(fullName, address);
                _customers.Add(customer);
                CustomersListBox.Items.Add(customer.FullName);

                _isUpdating = true;
                CustomersListBox.SelectedIndex = _customers.Count - 1;
                IdTextBox.Text = customer.Id.ToString();
                FullNameTextBox.Text = customer.FullName;
                AddressTextBox.Text = customer.Address;
                _isUpdating = false;

                FullNameTextBox.BackColor = Color.White;
                AddressTextBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                if (ex.Message.StartsWith("FullName"))
                    FullNameTextBox.BackColor = Color.LightPink;
                else if (ex.Message.StartsWith("Address"))
                    AddressTextBox.BackColor = Color.LightPink;
                else
                    MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Обработчик кнопки Remove.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            if (CustomersListBox.Items.Count > 0)
            {
                CustomersListBox.SelectedIndex =
                    Math.Min(index, CustomersListBox.Items.Count - 1);
            }
            else
            {
                ClearFields();
            }
        }

        /// <summary>
        /// Обработчик смены выбранного покупателя.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index < 0)
            {
                ClearFields();
                return;
            }

            Customer customer = _customers[index];

            _isUpdating = true;
            IdTextBox.Text = customer.Id.ToString();
            FullNameTextBox.Text = customer.FullName;
            AddressTextBox.Text = customer.Address;
            _isUpdating = false;

            FullNameTextBox.BackColor = Color.White;
            AddressTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обработчик изменения Full Name.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            try
            {
                _customers[index].FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
                UpdateListBoxItem(index);
            }
            catch (ArgumentException)
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик изменения Address.
        /// </summary>
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            try
            {
                _customers[index].Address = AddressTextBox.Text;
                AddressTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                AddressTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обновляет отображение покупателя в списке.
        /// </summary>
        private void UpdateListBoxItem(int index)
        {
            if (index < 0 || index >= _customers.Count) return;

            int selected = CustomersListBox.SelectedIndex;
            CustomersListBox.Items[index] = _customers[index].FullName;
            CustomersListBox.SelectedIndex = selected;
        }
    }
}