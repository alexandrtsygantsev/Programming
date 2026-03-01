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
            tabPage1 = new TabPage();
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
            tabPage1.SuspendLayout();
            WeekParsBox.SuspendLayout();
            EnumGroupBox.SuspendLayout();
            EnumListBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(WeekParsBox);
            tabPage1.Controls.Add(EnumGroupBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enum";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // WeekParsBox
            // 
            WeekParsBox.Controls.Add(StatusParse);
            WeekParsBox.Controls.Add(ParseButton);
            WeekParsBox.Controls.Add(ParsingTextBox);
            WeekParsBox.Controls.Add(TypeLabel);
            WeekParsBox.Location = new Point(4, 269);
            WeekParsBox.Name = "WeekParsBox";
            WeekParsBox.Size = new Size(365, 146);
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
            StatusParse.Size = new Size(37, 15);
            StatusParse.TabIndex = 4;
            StatusParse.Text = "None";
            StatusParse.Click += StatusParse_Click;
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
            ParsingTextBox.Size = new Size(215, 23);
            ParsingTextBox.TabIndex = 2;
            ParsingTextBox.TextChanged += ParsingTextBox_TextChanged;
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
            IntValueBox.TextChanged += IntValueBox_TextChanged;
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
            EnumListBox.Controls.Add(tabPage1);
            EnumListBox.Dock = DockStyle.Fill;
            EnumListBox.Location = new Point(0, 0);
            EnumListBox.Name = "EnumListBox";
            EnumListBox.SelectedIndex = 0;
            EnumListBox.Size = new Size(800, 450);
            EnumListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EnumListBox);
            Name = "MainForm";
            Text = "Form1";
            tabPage1.ResumeLayout(false);
            WeekParsBox.ResumeLayout(false);
            WeekParsBox.PerformLayout();
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            EnumListBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
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
    }
}
