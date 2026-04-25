namespace Programming_WinFormsApp.Veiw.Panels
{
    partial class MoviesControl
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
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(576, 283);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movie";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(245, 32);
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 30);
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
            label3.Location = new Point(177, 158);
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
            label1.Location = new Point(281, 244);
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
            YeardTextBox.Location = new Point(177, 94);
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
            label5.Location = new Point(177, 30);
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
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Name = "MoviesControl";
            Size = new Size(576, 283);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label6;
        private TextBox RatTextBox;
        private Label label4;
        private Button FindRutBut;
        private TextBox GenreTextBox;
        private Label label3;
        private Label label1;
        private TextBox YearTextBox;
        private Label YeardTextBox;
        private TextBox DurTextBox;
        private Label label5;
        private ListBox FilmTextBox;
    }
}
