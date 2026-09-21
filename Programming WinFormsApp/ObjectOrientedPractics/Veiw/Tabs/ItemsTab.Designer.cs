namespace ObjectOrientedPractics.Veiw.Tabs
{
    partial class ItemsTab
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
            splitContainer1 = new SplitContainer();
            LabelItems = new Label();
            ItmesListBox = new ListBox();
            ButtonLayoutPanel = new TableLayoutPanel();
            RemoveButton = new Button();
            AddButton = new Button();
            DescriptionLTextBox = new TextBox();
            label5 = new Label();
            NameTextBox = new TextBox();
            label4 = new Label();
            IdTextBox = new TextBox();
            CostTextBox = new TextBox();
            CostLabel = new Label();
            IdLabel = new Label();
            LabelSelectedItem = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ButtonLayoutPanel.SuspendLayout();
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
            splitContainer1.Panel1.BackColor = SystemColors.ButtonHighlight;
            splitContainer1.Panel1.Controls.Add(LabelItems);
            splitContainer1.Panel1.Controls.Add(ItmesListBox);
            splitContainer1.Panel1.Controls.Add(ButtonLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ButtonHighlight;
            splitContainer1.Panel2.Controls.Add(DescriptionLTextBox);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(NameTextBox);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(IdTextBox);
            splitContainer1.Panel2.Controls.Add(CostTextBox);
            splitContainer1.Panel2.Controls.Add(CostLabel);
            splitContainer1.Panel2.Controls.Add(IdLabel);
            splitContainer1.Panel2.Controls.Add(LabelSelectedItem);
            splitContainer1.Size = new Size(590, 515);
            splitContainer1.SplitterDistance = 280;
            splitContainer1.TabIndex = 0;
            // 
            // LabelItems
            // 
            LabelItems.AutoSize = true;
            LabelItems.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelItems.Location = new Point(6, 0);
            LabelItems.Name = "LabelItems";
            LabelItems.Size = new Size(42, 17);
            LabelItems.TabIndex = 2;
            LabelItems.Text = "Items";
            // 
            // ItmesListBox
            // 
            ItmesListBox.FormattingEnabled = true;
            ItmesListBox.Location = new Point(6, 17);
            ItmesListBox.Name = "ItmesListBox";
            ItmesListBox.Size = new Size(271, 364);
            ItmesListBox.TabIndex = 1;
            ItmesListBox.SelectedIndexChanged += ItmesListBox_SelectedIndexChanged;
            // 
            // ButtonLayoutPanel
            // 
            ButtonLayoutPanel.ColumnCount = 3;
            ButtonLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            ButtonLayoutPanel.Controls.Add(RemoveButton, 1, 0);
            ButtonLayoutPanel.Controls.Add(AddButton, 0, 0);
            ButtonLayoutPanel.Location = new Point(3, 387);
            ButtonLayoutPanel.Name = "ButtonLayoutPanel";
            ButtonLayoutPanel.RowCount = 1;
            ButtonLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonLayoutPanel.Size = new Size(274, 41);
            ButtonLayoutPanel.TabIndex = 0;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Location = new Point(99, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(90, 35);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(90, 35);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DescriptionLTextBox
            // 
            DescriptionLTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionLTextBox.Location = new Point(3, 274);
            DescriptionLTextBox.Multiline = true;
            DescriptionLTextBox.Name = "DescriptionLTextBox";
            DescriptionLTextBox.Size = new Size(300, 154);
            DescriptionLTextBox.TabIndex = 11;
            DescriptionLTextBox.TextChanged += DescriptionLTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 253);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Description:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(3, 129);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(300, 111);
            NameTextBox.TabIndex = 9;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 111);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Name:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(43, 31);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(115, 23);
            IdTextBox.TabIndex = 7;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(43, 65);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(115, 23);
            CostTextBox.TabIndex = 6;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(3, 68);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 5;
            CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 34);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 4;
            IdLabel.Text = "ID:";
            // 
            // LabelSelectedItem
            // 
            LabelSelectedItem.AutoSize = true;
            LabelSelectedItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelSelectedItem.Location = new Point(3, 0);
            LabelSelectedItem.Name = "LabelSelectedItem";
            LabelSelectedItem.Size = new Size(91, 17);
            LabelSelectedItem.TabIndex = 3;
            LabelSelectedItem.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ItemsTab";
            Size = new Size(590, 515);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ButtonLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label LabelItems;
        private ListBox ItmesListBox;
        private TableLayoutPanel ButtonLayoutPanel;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox NameTextBox;
        private Label label4;
        private TextBox IdTextBox;
        private TextBox CostTextBox;
        private Label CostLabel;
        private Label IdLabel;
        private Label LabelSelectedItem;
        private TextBox DescriptionLTextBox;
        private Label label5;
    }
}