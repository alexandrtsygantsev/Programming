namespace ObjectOrientedPractics.Veiw.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            IndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            StreetTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            label6 = new Label();
            CityTextBox = new TextBox();
            label7 = new Label();
            ApartmentTextBox = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Delivery Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 45);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Post Index:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 72);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Country: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 101);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Street:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 130);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Building:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(85, 42);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(100, 23);
            IndexTextBox.TabIndex = 5;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(85, 69);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(183, 23);
            CountryTextBox.TabIndex = 6;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(85, 98);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(419, 23);
            StreetTextBox.TabIndex = 7;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(85, 127);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(100, 23);
            BuildingTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 72);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 9;
            label6.Text = "City:";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(321, 69);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(183, 23);
            CityTextBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 130);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 11;
            label7.Text = "Apartment:";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(284, 127);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(100, 23);
            ApartmentTextBox.TabIndex = 12;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApartmentTextBox);
            Controls.Add(label7);
            Controls.Add(CityTextBox);
            Controls.Add(label6);
            Controls.Add(BuildingTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(IndexTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddressControl";
            Size = new Size(520, 161);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox IndexTextBox;
        private TextBox CountryTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private Label label6;
        private TextBox CityTextBox;
        private Label label7;
        private TextBox ApartmentTextBox;
        private ErrorProvider errorProvider;
    }
}
