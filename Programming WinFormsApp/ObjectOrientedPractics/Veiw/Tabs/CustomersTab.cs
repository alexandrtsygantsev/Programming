using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Veiw.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private bool _isUpdating;

        public CustomersTab()
        {
            InitializeComponent();
            CustomersListBox.Items.Clear();
            addressControl.Address = new Address();
        }

        private void ClearFields()
        {
            _isUpdating = true;
            IdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            addressControl.Address = new Address(); // Создаем новый пустой адрес для сброса
            _isUpdating = false;
            FullNameTextBox.BackColor = Color.White;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string fullName = FullNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(fullName))
            {
                FullNameTextBox.BackColor = Color.LightPink;
                return;
            }

            try
            {
                Address currentAddress = addressControl.Address;
                Address newCustomerAddress = new Address
                {
                    Index = currentAddress.Index,
                    Country = currentAddress.Country,
                    City = currentAddress.City,
                    Street = currentAddress.Street,
                    Building = currentAddress.Building,
                    Apartment = currentAddress.Apartment
                };

                var customer = new Customer(fullName, newCustomerAddress);
                _customers.Add(customer);
                CustomersListBox.Items.Add(customer.FullName);

                _isUpdating = true;
                CustomersListBox.SelectedIndex = _customers.Count - 1;

                IdTextBox.Text = customer.Id.ToString();
                FullNameTextBox.Text = customer.FullName;

                addressControl.Address = customer.Address;

                _isUpdating = false;
                FullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            if (CustomersListBox.Items.Count > 0)
            {
                CustomersListBox.SelectedIndex = Math.Min(index, CustomersListBox.Items.Count - 1);
            }
            else
            {
                ClearFields();
            }
        }

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

            addressControl.Address = customer.Address;

            _isUpdating = false;
            FullNameTextBox.BackColor = Color.White;
        }

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

        private void UpdateListBoxItem(int index)
        {
            if (index < 0 || index >= _customers.Count) return;
            int selected = CustomersListBox.SelectedIndex;
            CustomersListBox.Items[index] = _customers[index].FullName;
            CustomersListBox.SelectedIndex = selected;
        }
    }
}