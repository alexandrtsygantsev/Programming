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
            EnumGroupBox = new GroupBox();
            EnumsListBox = new ListBox();
            ChooseLabel = new Label();
            EnumListBox = new TabControl();
            ValueListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            tabPage1.SuspendLayout();
            EnumGroupBox.SuspendLayout();
            EnumListBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(EnumGroupBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enum";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // EnumGroupBox
            // 
            EnumGroupBox.Controls.Add(textBox1);
            EnumGroupBox.Controls.Add(label2);
            EnumGroupBox.Controls.Add(ValueListBox);
            EnumGroupBox.Controls.Add(label1);
            EnumGroupBox.Controls.Add(EnumsListBox);
            EnumGroupBox.Controls.Add(ChooseLabel);
            EnumGroupBox.Dock = DockStyle.Fill;
            EnumGroupBox.Location = new Point(3, 3);
            EnumGroupBox.Name = "EnumGroupBox";
            EnumGroupBox.Size = new Size(786, 416);
            EnumGroupBox.TabIndex = 0;
            EnumGroupBox.TabStop = false;
            EnumGroupBox.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(7, 59);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(161, 334);
            EnumsListBox.TabIndex = 1;
            // 
            // ChooseLabel
            // 
            ChooseLabel.AutoSize = true;
            ChooseLabel.Location = new Point(6, 30);
            ChooseLabel.Name = "ChooseLabel";
            ChooseLabel.Size = new Size(121, 15);
            ChooseLabel.TabIndex = 0;
            ChooseLabel.Text = "Choose enumaration:";
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
            // ValueListBox
            // 
            ValueListBox.FormattingEnabled = true;
            ValueListBox.Location = new Point(204, 59);
            ValueListBox.Name = "ValueListBox";
            ValueListBox.ScrollAlwaysVisible = true;
            ValueListBox.Size = new Size(161, 334);
            ValueListBox.TabIndex = 3;
            ValueListBox.SelectedIndexChanged += this.listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "Choose value:";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 30);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Int value:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(391, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
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
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            EnumListBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private TabControl EnumListBox;
        private GroupBox EnumGroupBox;
        private Label ChooseLabel;
        private ListBox EnumsListBox;
        private ListBox ValueListBox;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}
