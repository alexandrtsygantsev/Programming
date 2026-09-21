namespace ObjectOrientedPractics.Veiw.Tabs
{
    partial class CustomersTab
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            AddButton = new Button();
            RemoveButton = new Button();
            CustomersListBox = new ListBox();
            label2 = new Label();
            AddressTextBox = new TextBox();
            label4 = new Label();
            IdTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            CostLabel = new Label();
            IdLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(CustomersListBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(AddressTextBox);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(IdTextBox);
            splitContainer1.Panel2.Controls.Add(FullNameTextBox);
            splitContainer1.Panel2.Controls.Add(CostLabel);
            splitContainer1.Panel2.Controls.Add(IdLabel);
            splitContainer1.Size = new Size(707, 470);
            splitContainer1.SplitterDistance = 294;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 12);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Customers";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.38806F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.61194F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel1.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 385);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(282, 42);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(83, 36);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(92, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(92, 36);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(0, 45);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(285, 334);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 3;
            label2.Text = "Selected Customer";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(79, 126);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(288, 111);
            AddressTextBox.TabIndex = 15;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 14;
            label4.Text = "Address:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(79, 46);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(115, 23);
            IdTextBox.TabIndex = 13;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(79, 80);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(115, 23);
            FullNameTextBox.TabIndex = 12;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(12, 83);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(64, 15);
            CostLabel.TabIndex = 11;
            CostLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(12, 49);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 10;
            IdLabel.Text = "ID:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CustomersTab";
            Size = new Size(707, 470);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox CustomersListBox;
        private Button AddButton;
        private Button RemoveButton;
        private TextBox AddressTextBox;
        private Label label4;
        private TextBox IdTextBox;
        private TextBox FullNameTextBox;
        private Label CostLabel;
        private Label IdLabel;
        private Label label2;
    }
}