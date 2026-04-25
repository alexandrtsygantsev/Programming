namespace Programming_WinFormsApp.View.Panels
{
    partial class WeekdayParsingControl
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
            WeekParsBox = new GroupBox();
            StatusParse = new Label();
            ParseButton = new Button();
            ParsingTextBox = new TextBox();
            TypeLabel = new Label();
            WeekParsBox.SuspendLayout();
            SuspendLayout();
            // 
            // WeekParsBox
            // 
            WeekParsBox.Controls.Add(StatusParse);
            WeekParsBox.Controls.Add(ParseButton);
            WeekParsBox.Controls.Add(ParsingTextBox);
            WeekParsBox.Controls.Add(TypeLabel);
            WeekParsBox.Dock = DockStyle.Fill;
            WeekParsBox.Location = new Point(0, 0);
            WeekParsBox.Margin = new Padding(3, 4, 3, 4);
            WeekParsBox.Name = "WeekParsBox";
            WeekParsBox.Padding = new Padding(3, 4, 3, 4);
            WeekParsBox.Size = new Size(612, 310);
            WeekParsBox.TabIndex = 7;
            WeekParsBox.TabStop = false;
            WeekParsBox.Text = "Weekday Parsing";
            // 
            // StatusParse
            // 
            StatusParse.AutoSize = true;
            StatusParse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            StatusParse.ForeColor = SystemColors.ControlDark;
            StatusParse.Location = new Point(22, 128);
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
            TypeLabel.Location = new Point(22, 38);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(158, 20);
            TypeLabel.TabIndex = 1;
            TypeLabel.Text = "Type value fro parsing:";
            // 
            // WeekdayParsingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekParsBox);
            Name = "WeekdayParsingControl";
            Size = new Size(612, 310);
            WeekParsBox.ResumeLayout(false);
            WeekParsBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox WeekParsBox;
        private Label StatusParse;
        private Button ParseButton;
        private TextBox ParsingTextBox;
        private Label TypeLabel;
    }
}
