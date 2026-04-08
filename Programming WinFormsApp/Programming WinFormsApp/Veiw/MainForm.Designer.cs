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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            ButtMinus = new Button();
            ButtPlus = new Button();
            RecPanel = new Panel();
            HeightBox = new TextBox();
            label13 = new Label();
            WidthBox = new TextBox();
            label12 = new Label();
            YBox = new TextBox();
            label11 = new Label();
            XBox = new TextBox();
            label10 = new Label();
            IdBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            RectanListBox = new ListBox();
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
            tabPage1.Controls.Add(ButtMinus);
            tabPage1.Controls.Add(ButtPlus);
            tabPage1.Controls.Add(RecPanel);
            tabPage1.Controls.Add(HeightBox);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(WidthBox);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(YBox);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(XBox);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(IdBox);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(RectanListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(906, 567);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Rectangles";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtMinus
            // 
            ButtMinus.Anchor = AnchorStyles.Left;
            ButtMinus.BackgroundImage = (Image)resources.GetObject("ButtMinus.BackgroundImage");
            ButtMinus.BackgroundImageLayout = ImageLayout.Stretch;
            ButtMinus.FlatStyle = FlatStyle.Flat;
            ButtMinus.ForeColor = Color.Transparent;
            ButtMinus.Location = new Point(304, 261);
            ButtMinus.Margin = new Padding(3, 4, 3, 4);
            ButtMinus.Name = "ButtMinus";
            ButtMinus.Size = new Size(40, 40);
            ButtMinus.TabIndex = 29;
            ButtMinus.TabStop = false;
            ButtMinus.UseVisualStyleBackColor = true;
            // 
            // ButtPlus
            // 
            ButtPlus.Anchor = AnchorStyles.Left;
            ButtPlus.BackgroundImage = (Image)resources.GetObject("ButtPlus.BackgroundImage");
            ButtPlus.BackgroundImageLayout = ImageLayout.Stretch;
            ButtPlus.FlatStyle = FlatStyle.Flat;
            ButtPlus.ForeColor = Color.Transparent;
            ButtPlus.Location = new Point(227, 261);
            ButtPlus.Margin = new Padding(3, 4, 3, 4);
            ButtPlus.Name = "ButtPlus";
            ButtPlus.Size = new Size(40, 40);
            ButtPlus.TabIndex = 28;
            ButtPlus.TabStop = false;
            ButtPlus.UseVisualStyleBackColor = true;
            // 
            // RecPanel
            // 
            RecPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RecPanel.BorderStyle = BorderStyle.FixedSingle;
            RecPanel.Location = new Point(374, 4);
            RecPanel.Margin = new Padding(3, 4, 3, 4);
            RecPanel.Name = "RecPanel";
            RecPanel.Size = new Size(522, 548);
            RecPanel.TabIndex = 27;
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(94, 505);
            HeightBox.Margin = new Padding(3, 4, 3, 4);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(131, 27);
            HeightBox.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(34, 509);
            label13.Name = "label13";
            label13.Size = new Size(57, 20);
            label13.TabIndex = 25;
            label13.Text = "Height:";
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(94, 467);
            WidthBox.Margin = new Padding(3, 4, 3, 4);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(131, 27);
            WidthBox.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 471);
            label12.Name = "label12";
            label12.Size = new Size(52, 20);
            label12.TabIndex = 23;
            label12.Text = "Width:";
            // 
            // YBox
            // 
            YBox.Location = new Point(94, 428);
            YBox.Margin = new Padding(3, 4, 3, 4);
            YBox.Name = "YBox";
            YBox.Size = new Size(131, 27);
            YBox.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(67, 432);
            label11.Name = "label11";
            label11.Size = new Size(20, 20);
            label11.TabIndex = 21;
            label11.Text = "Y:";
            // 
            // XBox
            // 
            XBox.Location = new Point(94, 389);
            XBox.Margin = new Padding(3, 4, 3, 4);
            XBox.Name = "XBox";
            XBox.Size = new Size(131, 27);
            XBox.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(67, 393);
            label10.Name = "label10";
            label10.Size = new Size(21, 20);
            label10.TabIndex = 19;
            label10.Text = "X:";
            // 
            // IdBox
            // 
            IdBox.Location = new Point(94, 351);
            IdBox.Margin = new Padding(3, 4, 3, 4);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(131, 27);
            IdBox.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 355);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 9;
            label9.Text = "Id:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(30, 312);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 8;
            label8.Text = "Selected Rectangle:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 13);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 7;
            label7.Text = "Rectangles:";
            // 
            // RectanListBox
            // 
            RectanListBox.FormattingEnabled = true;
            RectanListBox.Location = new Point(30, 37);
            RectanListBox.Margin = new Padding(3, 4, 3, 4);
            RectanListBox.Name = "RectanListBox";
            RectanListBox.ScrollAlwaysVisible = true;
            RectanListBox.Size = new Size(337, 204);
            RectanListBox.TabIndex = 3;
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
            tabPage1.PerformLayout();
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
        private Label label9;
        private Label label8;
        private Label label7;
        private ListBox RectanListBox;
        private TextBox IdBox;
        private TextBox HeightBox;
        private Label label13;
        private TextBox WidthBox;
        private Label label12;
        private TextBox YBox;
        private Label label11;
        private TextBox XBox;
        private Label label10;
        private Button ButtPlus;
        private Panel RecPanel;
        private Button ButtMinus;
    }
}
