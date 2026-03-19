namespace Programming_WinFormsApp
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
            EnumPage = new TabPage();
            SeasHandleBox = new GroupBox();
            SeasonDropList = new ComboBox();
            GoButton = new Button();
            ChooseLabel = new Label();
            WeekParsBox = new GroupBox();
            StatusParse = new Label();
            ParseButton = new Button();
            ParsingTextBox = new TextBox();
            TypeLabel = new Label();
            EnumGroupBox = new GroupBox();
            IntValueBox = new TextBox();
            IntLabel = new Label();
            ValueListBox = new ListBox();
            ValueLabel = new Label();
            EnumsListBox = new ListBox();
            EnumLabel = new Label();
            EnumListBox = new TabControl();
            ClassPage = new TabPage();
            groupBox1 = new GroupBox();
            FindButton = new Button();
            ColorTextBox = new TextBox();
            ColorLabel = new Label();
            WithTextBox = new TextBox();
            WidthLabel = new Label();
            LenTextBox = new TextBox();
            LenLabel = new Label();
            RecListBox = new ListBox();
            EnumPage.SuspendLayout();
            SeasHandleBox.SuspendLayout();
            WeekParsBox.SuspendLayout();
            EnumGroupBox.SuspendLayout();
            EnumListBox.SuspendLayout();
            ClassPage.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // EnumPage
            // 
            EnumPage.Controls.Add(SeasHandleBox);
            EnumPage.Controls.Add(WeekParsBox);
            EnumPage.Controls.Add(EnumGroupBox);
            EnumPage.Location = new Point(4, 24);
            EnumPage.Name = "EnumPage";
            EnumPage.Padding = new Padding(3);
            EnumPage.Size = new Size(792, 422);
            EnumPage.TabIndex = 0;
            EnumPage.Text = "Enum";
            EnumPage.UseVisualStyleBackColor = true;
            // 
            // SeasHandleBox
            // 
            SeasHandleBox.Controls.Add(SeasonDropList);
            SeasHandleBox.Controls.Add(GoButton);
            SeasHandleBox.Controls.Add(ChooseLabel);
            SeasHandleBox.Location = new Point(403, 273);
            SeasHandleBox.Name = "SeasHandleBox";
            SeasHandleBox.Size = new Size(386, 141);
            SeasHandleBox.TabIndex = 7;
            SeasHandleBox.TabStop = false;
            SeasHandleBox.Text = "Season Handle";
            // 
            // SeasonDropList
            // 
            SeasonDropList.FormattingEnabled = true;
            SeasonDropList.Location = new Point(19, 57);
            SeasonDropList.Name = "SeasonDropList";
            SeasonDropList.Size = new Size(230, 23);
            SeasonDropList.TabIndex = 4;
            SeasonDropList.SelectedIndexChanged += SeasonDropList_SelectedIndexChanged;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(255, 57);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 23);
            GoButton.TabIndex = 3;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // ChooseLabel
            // 
            ChooseLabel.AutoSize = true;
            ChooseLabel.Location = new Point(19, 28);
            ChooseLabel.Name = "ChooseLabel";
            ChooseLabel.Size = new Size(89, 15);
            ChooseLabel.TabIndex = 1;
            ChooseLabel.Text = "Choose season:";
            // 
            // WeekParsBox
            // 
            WeekParsBox.Controls.Add(StatusParse);
            WeekParsBox.Controls.Add(ParseButton);
            WeekParsBox.Controls.Add(ParsingTextBox);
            WeekParsBox.Controls.Add(TypeLabel);
            WeekParsBox.Location = new Point(4, 269);
            WeekParsBox.Name = "WeekParsBox";
            WeekParsBox.Size = new Size(393, 146);
            WeekParsBox.TabIndex = 6;
            WeekParsBox.TabStop = false;
            WeekParsBox.Text = "Weekday Parsing";
            // 
            // StatusParse
            // 
            StatusParse.AutoSize = true;
            StatusParse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            StatusParse.ForeColor = SystemColors.ControlDark;
            StatusParse.Location = new Point(19, 95);
            StatusParse.Name = "StatusParse";
            StatusParse.Size = new Size(133, 15);
            StatusParse.TabIndex = 4;
            StatusParse.Text = "Введите день недели";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(255, 57);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(75, 23);
            ParseButton.TabIndex = 3;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParsingTextBox
            // 
            ParsingTextBox.BackColor = SystemColors.Window;
            ParsingTextBox.Location = new Point(19, 57);
            ParsingTextBox.Name = "ParsingTextBox";
            ParsingTextBox.Size = new Size(230, 23);
            ParsingTextBox.TabIndex = 2;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(19, 28);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(126, 15);
            TypeLabel.TabIndex = 1;
            TypeLabel.Text = "Type value fro parsing:";
            // 
            // EnumGroupBox
            // 
            EnumGroupBox.Controls.Add(IntValueBox);
            EnumGroupBox.Controls.Add(IntLabel);
            EnumGroupBox.Controls.Add(ValueListBox);
            EnumGroupBox.Controls.Add(ValueLabel);
            EnumGroupBox.Controls.Add(EnumsListBox);
            EnumGroupBox.Controls.Add(EnumLabel);
            EnumGroupBox.Location = new Point(3, 3);
            EnumGroupBox.Name = "EnumGroupBox";
            EnumGroupBox.Size = new Size(786, 259);
            EnumGroupBox.TabIndex = 0;
            EnumGroupBox.TabStop = false;
            EnumGroupBox.Text = "Enumerations";
            // 
            // IntValueBox
            // 
            IntValueBox.Location = new Point(391, 59);
            IntValueBox.Name = "IntValueBox";
            IntValueBox.Size = new Size(100, 23);
            IntValueBox.TabIndex = 5;
            // 
            // IntLabel
            // 
            IntLabel.AutoSize = true;
            IntLabel.Location = new Point(391, 30);
            IntLabel.Name = "IntLabel";
            IntLabel.Size = new Size(55, 15);
            IntLabel.TabIndex = 4;
            IntLabel.Text = "Int value:";
            // 
            // ValueListBox
            // 
            ValueListBox.FormattingEnabled = true;
            ValueListBox.Location = new Point(204, 59);
            ValueListBox.Name = "ValueListBox";
            ValueListBox.ScrollAlwaysVisible = true;
            ValueListBox.Size = new Size(161, 184);
            ValueListBox.TabIndex = 3;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(203, 30);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(81, 15);
            ValueLabel.TabIndex = 2;
            ValueLabel.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(7, 59);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(161, 184);
            EnumsListBox.TabIndex = 1;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumLabel
            // 
            EnumLabel.AutoSize = true;
            EnumLabel.Location = new Point(6, 30);
            EnumLabel.Name = "EnumLabel";
            EnumLabel.Size = new Size(121, 15);
            EnumLabel.TabIndex = 0;
            EnumLabel.Text = "Choose enumaration:";
            // 
            // EnumListBox
            // 
            EnumListBox.Controls.Add(EnumPage);
            EnumListBox.Controls.Add(ClassPage);
            EnumListBox.Dock = DockStyle.Fill;
            EnumListBox.Location = new Point(0, 0);
            EnumListBox.Name = "EnumListBox";
            EnumListBox.SelectedIndex = 0;
            EnumListBox.Size = new Size(800, 450);
            EnumListBox.TabIndex = 0;
            // 
            // ClassPage
            // 
            ClassPage.Controls.Add(groupBox1);
            ClassPage.Location = new Point(4, 24);
            ClassPage.Name = "ClassPage";
            ClassPage.Size = new Size(792, 422);
            ClassPage.TabIndex = 1;
            ClassPage.Text = "Classes";
            ClassPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FindButton);
            groupBox1.Controls.Add(ColorTextBox);
            groupBox1.Controls.Add(ColorLabel);
            groupBox1.Controls.Add(WithTextBox);
            groupBox1.Controls.Add(WidthLabel);
            groupBox1.Controls.Add(LenTextBox);
            groupBox1.Controls.Add(LenLabel);
            groupBox1.Controls.Add(RecListBox);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 259);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangles";
            // 
            // FindButton
            // 
            FindButton.Location = new Point(184, 183);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(75, 23);
            FindButton.TabIndex = 12;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(184, 142);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(100, 23);
            ColorTextBox.TabIndex = 11;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(184, 124);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(36, 15);
            ColorLabel.TabIndex = 10;
            ColorLabel.Text = "Color";
            // 
            // WithTextBox
            // 
            WithTextBox.Location = new Point(184, 88);
            WithTextBox.Name = "WithTextBox";
            WithTextBox.Size = new Size(100, 23);
            WithTextBox.TabIndex = 9;
            WithTextBox.TextChanged += WithTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(184, 70);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(39, 15);
            WidthLabel.TabIndex = 8;
            WidthLabel.Text = "Width";
            // 
            // LenTextBox
            // 
            LenTextBox.Location = new Point(184, 40);
            LenTextBox.Name = "LenTextBox";
            LenTextBox.Size = new Size(100, 23);
            LenTextBox.TabIndex = 7;
            LenTextBox.TextChanged += LenTextBox_TextChanged;
            // 
            // LenLabel
            // 
            LenLabel.AutoSize = true;
            LenLabel.Location = new Point(184, 22);
            LenLabel.Name = "LenLabel";
            LenLabel.Size = new Size(44, 15);
            LenLabel.TabIndex = 6;
            LenLabel.Text = "Lenght";
            // 
            // RecListBox
            // 
            RecListBox.FormattingEnabled = true;
            RecListBox.Location = new Point(6, 22);
            RecListBox.Name = "RecListBox";
            RecListBox.ScrollAlwaysVisible = true;
            RecListBox.Size = new Size(161, 184);
            RecListBox.TabIndex = 2;
            RecListBox.SelectedIndexChanged += RecListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EnumListBox);
            Name = "MainForm";
            Text = "Form1";
            EnumPage.ResumeLayout(false);
            SeasHandleBox.ResumeLayout(false);
            SeasHandleBox.PerformLayout();
            WeekParsBox.ResumeLayout(false);
            WeekParsBox.PerformLayout();
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            EnumListBox.ResumeLayout(false);
            ClassPage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage EnumPage;
        private TabControl EnumListBox;
        private GroupBox EnumGroupBox;
        private Label EnumLabel;
        private ListBox EnumsListBox;
        private ListBox ValueListBox;
        private Label ValueLabel;
        private TextBox IntValueBox;
        private Label IntLabel;
        private GroupBox WeekParsBox;
        private Button ParseButton;
        private TextBox ParsingTextBox;
        private Label TypeLabel;
        private Label StatusParse;
        private GroupBox SeasHandleBox;
        private Label LenLabel;
        private Button GoButton;
        private Label ChooseLabel;
        private ComboBox SeasonDropList;
        private TabPage ClassPage;
        private GroupBox groupBox1;
        private TextBox LenTextBox;
        private ListBox RecListBox;
        private Button FindButton;
        private TextBox ColorTextBox;
        private Label ColorLabel;
        private TextBox WithTextBox;
        private Label WidthLabel;
    }
}
