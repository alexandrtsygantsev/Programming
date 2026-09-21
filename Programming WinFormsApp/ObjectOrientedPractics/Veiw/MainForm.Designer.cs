namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            itemsTab1 = new ObjectOrientedPractics.Veiw.Tabs.ItemsTab();
            Customers = new TabPage();
            customersTab1 = new ObjectOrientedPractics.Veiw.Tabs.CustomersTab();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            Customers.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(Customers);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(706, 555);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemsTab1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(698, 527);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(692, 521);
            itemsTab1.TabIndex = 0;
            // 
            // Customers
            // 
            Customers.Controls.Add(customersTab1);
            Customers.Location = new Point(4, 24);
            Customers.Name = "Customers";
            Customers.Padding = new Padding(3);
            Customers.Size = new Size(698, 527);
            Customers.TabIndex = 1;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Left;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(692, 521);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 555);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Object Oriented Preactics";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            Customers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage Customers;
        private Veiw.Tabs.ItemsTab itemsTab1;
        private Veiw.Tabs.CustomersTab customersTab1;
    }
}
