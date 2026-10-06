using ObjectOrientedPractics.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Veiw.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        private bool _isUpdating;

        public AddressControl()
        {
            InitializeComponent();
            UpdateFieldsFromAddress();
        }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public Address Address
        {
            get
            {
                SaveFieldsToAddress();
                return _address;
            }
            set
            {
                if (value == null)
                {
                    _address = new Address();
                }
                else
                {

                    _address = value;
                }

                UpdateFieldsFromAddress();
            }
        }

        private void UpdateFieldsFromAddress()
        {
            _isUpdating = true;

            IndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country ?? string.Empty;
            CityTextBox.Text = _address.City ?? string.Empty;
            StreetTextBox.Text = _address.Street ?? string.Empty;
            BuildingTextBox.Text = _address.Building ?? string.Empty;
            ApartmentTextBox.Text = _address.Apartment ?? string.Empty;

            _isUpdating = false;
        }

        private void SaveFieldsToAddress()
        {
            if (_isUpdating) return;

            TrySetIndex();
            TrySetString(CountryTextBox, v => _address.Country = v, _address.Country);
            TrySetString(CityTextBox, v => _address.City = v, _address.City);
            TrySetString(StreetTextBox, v => _address.Street = v, _address.Street);
            TrySetString(BuildingTextBox, v => _address.Building = v, _address.Building);
            TrySetString(ApartmentTextBox, v => _address.Apartment = v, _address.Apartment);
        }

        private void TrySetIndex()
        {
            if (!int.TryParse(IndexTextBox.Text, out int index))
            {
                IndexTextBox.BackColor = Color.LightPink;
                return;
            }

            try
            {
                _address.Index = index;
                IndexTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                IndexTextBox.BackColor = Color.LightPink;
            }
        }

        private void TrySetString(TextBox textBox, Action<string> setter, string previousValue)
        {
            try
            {
                setter(textBox.Text ?? string.Empty);
                textBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            SaveFieldsToAddress();
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            string error = GetErrorFor(textBox);

            if (error != null)
            {
                textBox.BackColor = Color.LightPink;
                errorProvider.SetError(textBox, error);
                e.Cancel = true; // Отменяем уход фокуса, если есть ошибка
            }
            else
            {
                textBox.BackColor = Color.White;
                errorProvider.SetError(textBox, string.Empty);
            }
        }

        private string GetErrorFor(TextBox textBox)
        {
            if (textBox == IndexTextBox)
            {
                if (!int.TryParse(textBox.Text, out int index) || index < 100000 || index > 999999)
                {
                    return "Индекс должен быть шестизначным числом (100000–999999).";
                }
                return null;
            }

            string value = textBox.Text ?? string.Empty;

            if (textBox == CountryTextBox && value.Length > 50) return "Страна не должна превышать 50 символов.";
            if (textBox == CityTextBox && value.Length > 50) return "Город не должен превышать 50 символов.";
            if (textBox == StreetTextBox && value.Length > 100) return "Улица не должна превышать 100 символов.";
            if (textBox == BuildingTextBox && value.Length > 10) return "Номер дома не должен превышать 10 символов.";
            if (textBox == ApartmentTextBox && value.Length > 10) return "Номер квартиры не должен превышать 10 символов.";

            return null;
        }
    }
}