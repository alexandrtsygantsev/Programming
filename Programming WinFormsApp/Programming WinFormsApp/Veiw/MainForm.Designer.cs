using Programming_WinFormsApp.Veiw.Panels;

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
            groupBox2 = new GroupBox();
            label6 = new Label();
            RatTextBox = new TextBox();
            label4 = new Label();
            FindRutBut = new Button();
            GenreTextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            YearTextBox = new TextBox();
            YeardTextBox = new Label();
            DurTextBox = new TextBox();
            label5 = new Label();
            FilmTextBox = new ListBox();
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
            tabPage1 = new TabPage();
            rectanglesCollisionControl1 = new RectanglesCollisionControl();
            EnumPage.SuspendLayout();
            SeasHandleBox.SuspendLayout();
            WeekParsBox.SuspendLayout();
            EnumGroupBox.SuspendLayout();
            EnumListBox.SuspendLayout();
            ClassPage.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // EnumPage
            // 
            EnumPage.Controls.Add(SeasHandleBox);
            EnumPage.Controls.Add(WeekParsBox);
            EnumPage.Controls.Add(EnumGroupBox);
            EnumPage.Location = new Point(4, 29);
            EnumPage.Margin = new Padding(3, 4, 3, 4);
            EnumPage.Name = "EnumPage";
            EnumPage.Padding = new Padding(3, 4, 3, 4);
            EnumPage.Size = new Size(906, 567);
            EnumPage.TabIndex = 0;
            EnumPage.Text = "Enum";
            EnumPage.UseVisualStyleBackColor = true;
            // 
            // SeasHandleBox
            // 
            SeasHandleBox.Controls.Add(SeasonDropList);
            SeasHandleBox.Controls.Add(GoButton);
            SeasHandleBox.Controls.Add(ChooseLabel);
            SeasHandleBox.Location = new Point(461, 364);
            SeasHandleBox.Margin = new Padding(3, 4, 3, 4);
            SeasHandleBox.Name = "SeasHandleBox";
            SeasHandleBox.Padding = new Padding(3, 4, 3, 4);
            SeasHandleBox.Size = new Size(441, 188);
            SeasHandleBox.TabIndex = 7;
            SeasHandleBox.TabStop = false;
            SeasHandleBox.Text = "Season Handle";
            // 
            // SeasonDropList
            // 
            SeasonDropList.FormattingEnabled = true;
            SeasonDropList.Location = new Point(22, 76);
            SeasonDropList.Margin = new Padding(3, 4, 3, 4);
            SeasonDropList.Name = "SeasonDropList";
            SeasonDropList.Size = new Size(262, 28);
            SeasonDropList.TabIndex = 4;
            SeasonDropList.SelectedIndexChanged += SeasonDropList_SelectedIndexChanged;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(291, 76);
            GoButton.Margin = new Padding(3, 4, 3, 4);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(86, 31);
            GoButton.TabIndex = 3;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // ChooseLabel
            // 
            ChooseLabel.AutoSize = true;
            ChooseLabel.Location = new Point(22, 37);
            ChooseLabel.Name = "ChooseLabel";
            ChooseLabel.Size = new Size(110, 20);
            ChooseLabel.TabIndex = 1;
            ChooseLabel.Text = "Choose season:";
            // 
            // WeekParsBox
            // 
            WeekParsBox.Controls.Add(StatusParse);
            WeekParsBox.Controls.Add(ParseButton);
            WeekParsBox.Controls.Add(ParsingTextBox);
            WeekParsBox.Controls.Add(TypeLabel);
            WeekParsBox.Location = new Point(5, 359);
            WeekParsBox.Margin = new Padding(3, 4, 3, 4);
            WeekParsBox.Name = "WeekParsBox";
            WeekParsBox.Padding = new Padding(3, 4, 3, 4);
            WeekParsBox.Size = new Size(449, 195);
            WeekParsBox.TabIndex = 6;
            WeekParsBox.TabStop = false;
            WeekParsBox.Text = "Weekday Parsing";
            // 
            // StatusParse
            // 
            StatusParse.AutoSize = true;
            StatusParse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            StatusParse.ForeColor = SystemColors.ControlDark;
            StatusParse.Location = new Point(22, 127);
            StatusParse.Name = "StatusParse";
            StatusParse.Size = new Size(163, 20);
            StatusParse.TabIndex = 4;
            StatusParse.Text = "Введите день недели";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(291, 76);
            ParseButton.Margin = new Padding(3, 4, 3, 4);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(86, 31);
            ParseButton.TabIndex = 3;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParsingTextBox
            // 
            ParsingTextBox.BackColor = SystemColors.Window;
            ParsingTextBox.Location = new Point(22, 76);
            ParsingTextBox.Margin = new Padding(3, 4, 3, 4);
            ParsingTextBox.Name = "ParsingTextBox";
            ParsingTextBox.Size = new Size(262, 27);
            ParsingTextBox.TabIndex = 2;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(22, 37);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(158, 20);
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
            EnumGroupBox.Location = new Point(3, 4);
            EnumGroupBox.Margin = new Padding(3, 4, 3, 4);
            EnumGroupBox.Name = "EnumGroupBox";
            EnumGroupBox.Padding = new Padding(3, 4, 3, 4);
            EnumGroupBox.Size = new Size(898, 345);
            EnumGroupBox.TabIndex = 0;
            EnumGroupBox.TabStop = false;
            EnumGroupBox.Text = "Enumerations";
            // 
            // IntValueBox
            // 
            IntValueBox.Location = new Point(447, 79);
            IntValueBox.Margin = new Padding(3, 4, 3, 4);
            IntValueBox.Name = "IntValueBox";
            IntValueBox.Size = new Size(114, 27);
            IntValueBox.TabIndex = 5;
            // 
            // IntLabel
            // 
            IntLabel.AutoSize = true;
            IntLabel.Location = new Point(447, 40);
            IntLabel.Name = "IntLabel";
            IntLabel.Size = new Size(68, 20);
            IntLabel.TabIndex = 4;
            IntLabel.Text = "Int value:";
            // 
            // ValueListBox
            // 
            ValueListBox.FormattingEnabled = true;
            ValueListBox.Location = new Point(233, 79);
            ValueListBox.Margin = new Padding(3, 4, 3, 4);
            ValueListBox.Name = "ValueListBox";
            ValueListBox.ScrollAlwaysVisible = true;
            ValueListBox.Size = new Size(183, 244);
            ValueListBox.TabIndex = 3;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(232, 40);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(100, 20);
            ValueLabel.TabIndex = 2;
            ValueLabel.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(8, 79);
            EnumsListBox.Margin = new Padding(3, 4, 3, 4);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(183, 244);
            EnumsListBox.TabIndex = 1;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumLabel
            // 
            EnumLabel.AutoSize = true;
            EnumLabel.Location = new Point(7, 40);
            EnumLabel.Name = "EnumLabel";
            EnumLabel.Size = new Size(149, 20);
            EnumLabel.TabIndex = 0;
            EnumLabel.Text = "Choose enumaration:";
            // 
            // EnumListBox
            // 
            EnumListBox.Controls.Add(EnumPage);
            EnumListBox.Controls.Add(ClassPage);
            EnumListBox.Controls.Add(tabPage1);
            EnumListBox.Dock = DockStyle.Fill;
            EnumListBox.Location = new Point(0, 0);
            EnumListBox.Margin = new Padding(3, 4, 3, 4);
            EnumListBox.Name = "EnumListBox";
            EnumListBox.SelectedIndex = 0;
            EnumListBox.Size = new Size(914, 600);
            EnumListBox.TabIndex = 0;
            // 
            // ClassPage
            // 
            ClassPage.Controls.Add(groupBox2);
            ClassPage.Controls.Add(groupBox1);
            ClassPage.Location = new Point(4, 29);
            ClassPage.Margin = new Padding(3, 4, 3, 4);
            ClassPage.Name = "ClassPage";
            ClassPage.Size = new Size(906, 567);
            ClassPage.TabIndex = 1;
            ClassPage.Text = "Classes";
            ClassPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(RatTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(FindRutBut);
            groupBox2.Controls.Add(GenreTextBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(YearTextBox);
            groupBox2.Controls.Add(YeardTextBox);
            groupBox2.Controls.Add(DurTextBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(FilmTextBox);
            groupBox2.Location = new Point(462, 4);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(434, 296);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movie";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(245, 31);
            label6.Name = "label6";
            label6.Size = new Size(32, 19);
            label6.TabIndex = 18;
            label6.Text = "min";
            // 
            // RatTextBox
            // 
            RatTextBox.Location = new Point(306, 53);
            RatTextBox.Margin = new Padding(3, 4, 3, 4);
            RatTextBox.Name = "RatTextBox";
            RatTextBox.Size = new Size(97, 27);
            RatTextBox.TabIndex = 17;
            RatTextBox.TextChanged += RatTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 29);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 16;
            label4.Text = "Rating";
            // 
            // FindRutBut
            // 
            FindRutBut.Location = new Point(177, 233);
            FindRutBut.Margin = new Padding(3, 4, 3, 4);
            FindRutBut.Name = "FindRutBut";
            FindRutBut.Size = new Size(97, 41);
            FindRutBut.TabIndex = 15;
            FindRutBut.Text = "Find";
            FindRutBut.UseVisualStyleBackColor = true;
            FindRutBut.Click += FindRutBut_Click;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(177, 181);
            GenreTextBox.Margin = new Padding(3, 4, 3, 4);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.ReadOnly = true;
            GenreTextBox.Size = new Size(97, 27);
            GenreTextBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 157);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 13;
            label3.Text = "Genre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(281, 243);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 12;
            label1.Text = "Поиск фильма\r\nс наивысшым рейтингом";
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(177, 117);
            YearTextBox.Margin = new Padding(3, 4, 3, 4);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.ReadOnly = true;
            YearTextBox.Size = new Size(97, 27);
            YearTextBox.TabIndex = 9;
            // 
            // YeardTextBox
            // 
            YeardTextBox.AutoSize = true;
            YeardTextBox.Location = new Point(177, 93);
            YeardTextBox.Name = "YeardTextBox";
            YeardTextBox.Size = new Size(106, 20);
            YeardTextBox.TabIndex = 8;
            YeardTextBox.Text = "Year of release";
            // 
            // DurTextBox
            // 
            DurTextBox.Location = new Point(177, 53);
            DurTextBox.Margin = new Padding(3, 4, 3, 4);
            DurTextBox.Name = "DurTextBox";
            DurTextBox.ReadOnly = true;
            DurTextBox.Size = new Size(97, 27);
            DurTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 29);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 6;
            label5.Text = "Duration";
            // 
            // FilmTextBox
            // 
            FilmTextBox.FormattingEnabled = true;
            FilmTextBox.Location = new Point(7, 29);
            FilmTextBox.Margin = new Padding(3, 4, 3, 4);
            FilmTextBox.Name = "FilmTextBox";
            FilmTextBox.ScrollAlwaysVisible = true;
            FilmTextBox.Size = new Size(150, 244);
            FilmTextBox.TabIndex = 2;
            FilmTextBox.SelectedIndexChanged += FilmTextBox_SelectedIndexChanged;
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
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(453, 296);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangles";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(286, 93);
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
            CentLabel.Location = new Point(286, 29);
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
            label2.Location = new Point(286, 243);
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
            FindButton.Click += FindButton_Click;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(177, 181);
            ColorTextBox.Margin = new Padding(3, 4, 3, 4);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.ReadOnly = true;
            ColorTextBox.Size = new Size(97, 27);
            ColorTextBox.TabIndex = 11;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(177, 157);
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
            WithTextBox.TextChanged += WithTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(177, 93);
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
            LenTextBox.TextChanged += LenTextBox_TextChanged;
            // 
            // LenLabel
            // 
            LenLabel.AutoSize = true;
            LenLabel.Location = new Point(177, 29);
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
            RecListBox.SelectedIndexChanged += RecListBox_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rectanglesCollisionControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(906, 567);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Rectangles";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(0, 0);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(906, 567);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(EnumListBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Programming";
            EnumPage.ResumeLayout(false);
            SeasHandleBox.ResumeLayout(false);
            SeasHandleBox.PerformLayout();
            WeekParsBox.ResumeLayout(false);
            WeekParsBox.PerformLayout();
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            EnumListBox.ResumeLayout(false);
            ClassPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage1.ResumeLayout(false);
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
        private Label label2;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox YearTextBox;
        private Label YeardTextBox;
        private TextBox DurTextBox;
        private Label label5;
        private ListBox FilmTextBox;
        private Button FindRutBut;
        private TextBox GenreTextBox;
        private Label label3;
        private TextBox RatTextBox;
        private Label label4;
        private Label label6;
        private Label CentLabel;
        private TextBox CenterTextBox;
        private Label IdLabel;
        private TextBox IdTextBox;
        private TabPage tabPage1;
        private RectanglesCollisionControl rectanglesCollisionControl1;
    }
}
