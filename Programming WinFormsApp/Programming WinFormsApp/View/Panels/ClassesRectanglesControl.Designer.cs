namespace Programming_WinFormsApp.View.Panels
{
    partial class ClassesRectanglesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            IdLabel = new Label();
            IdTextBox = new TextBox();
            CentLabel = new Label();
            CenterTextBox = new TextBox();
            label2 = new Label();
            FindButton = new Button();
            ColorTextBox = new TextBox();
            ColorLabel = new Label();
            WithTextBox = new TextBox();
            WidthLabel = new Label();
            LenTextBox = new TextBox();
            LenLabel = new Label();
            RecListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IdLabel);
            groupBox1.Controls.Add(IdTextBox);
            groupBox1.Controls.Add(CentLabel);
            groupBox1.Controls.Add(CenterTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(FindButton);
            groupBox1.Controls.Add(ColorTextBox);
            groupBox1.Controls.Add(ColorLabel);
            groupBox1.Controls.Add(WithTextBox);
            groupBox1.Controls.Add(WidthLabel);
            groupBox1.Controls.Add(LenTextBox);
            groupBox1.Controls.Add(LenLabel);
            groupBox1.Controls.Add(RecListBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(495, 389);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangles";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(286, 94);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(22, 20);
            IdLabel.TabIndex = 16;
            IdLabel.Text = "Id";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(286, 117);
            IdTextBox.Margin = new Padding(3, 4, 3, 4);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(97, 27);
            IdTextBox.TabIndex = 15;
            // 
            // CentLabel
            // 
            CentLabel.AutoSize = true;
            CentLabel.Location = new Point(286, 30);
            CentLabel.Name = "CentLabel";
            CentLabel.Size = new Size(52, 20);
            CentLabel.TabIndex = 14;
            CentLabel.Text = "Center";
            // 
            // CenterTextBox
            // 
            CenterTextBox.Location = new Point(286, 53);
            CenterTextBox.Margin = new Padding(3, 4, 3, 4);
            CenterTextBox.Name = "CenterTextBox";
            CenterTextBox.ReadOnly = true;
            CenterTextBox.Size = new Size(97, 27);
            CenterTextBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(286, 244);
            label2.Name = "label2";
            label2.Size = new Size(155, 30);
            label2.TabIndex = 12;
            label2.Text = "Поиск прямоугольника\r\nс максимальной шириной";
            // 
            // FindButton
            // 
            FindButton.Location = new Point(177, 233);
            FindButton.Margin = new Padding(3, 4, 3, 4);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(97, 41);
            FindButton.TabIndex = 12;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(177, 181);
            ColorTextBox.Margin = new Padding(3, 4, 3, 4);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.ReadOnly = true;
            ColorTextBox.Size = new Size(97, 27);
            ColorTextBox.TabIndex = 11;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(177, 158);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(45, 20);
            ColorLabel.TabIndex = 10;
            ColorLabel.Text = "Color";
            // 
            // WithTextBox
            // 
            WithTextBox.Location = new Point(177, 117);
            WithTextBox.Margin = new Padding(3, 4, 3, 4);
            WithTextBox.Name = "WithTextBox";
            WithTextBox.Size = new Size(97, 27);
            WithTextBox.TabIndex = 9;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(177, 94);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(49, 20);
            WidthLabel.TabIndex = 8;
            WidthLabel.Text = "Width";
            // 
            // LenTextBox
            // 
            LenTextBox.Location = new Point(177, 53);
            LenTextBox.Margin = new Padding(3, 4, 3, 4);
            LenTextBox.Name = "LenTextBox";
            LenTextBox.Size = new Size(97, 27);
            LenTextBox.TabIndex = 7;
            // 
            // LenLabel
            // 
            LenLabel.AutoSize = true;
            LenLabel.Location = new Point(177, 30);
            LenLabel.Name = "LenLabel";
            LenLabel.Size = new Size(54, 20);
            LenLabel.TabIndex = 6;
            LenLabel.Text = "Lenght";
            // 
            // RecListBox
            // 
            RecListBox.FormattingEnabled = true;
            RecListBox.Location = new Point(7, 29);
            RecListBox.Margin = new Padding(3, 4, 3, 4);
            RecListBox.Name = "RecListBox";
            RecListBox.ScrollAlwaysVisible = true;
            RecListBox.Size = new Size(150, 244);
            RecListBox.TabIndex = 2;
            // 
            // ClassesRectanglesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ClassesRectanglesControl";
            Size = new Size(495, 389);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label IdLabel;
        private TextBox IdTextBox;
        private Label CentLabel;
        private TextBox CenterTextBox;
        private Label label2;
        private Button FindButton;
        private TextBox ColorTextBox;
        private Label ColorLabel;
        private TextBox WithTextBox;
        private Label WidthLabel;
        private TextBox LenTextBox;
        private Label LenLabel;
        private ListBox RecListBox;
    }
}
