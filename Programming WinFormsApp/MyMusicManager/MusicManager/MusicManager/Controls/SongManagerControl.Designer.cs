namespace MusicManager.Controls
{
    partial class SongManagerControl
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
            addGroup = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            genreBox = new ComboBox();
            durBox = new TextBox();
            authorBox = new TextBox();
            nameBox = new TextBox();
            musicList = new ListBox();
            delButton = new Button();
            editButton = new Button();
            addButton = new Button();
            addGroup.SuspendLayout();
            SuspendLayout();
            // 
            // addGroup
            // 
            addGroup.Controls.Add(label5);
            addGroup.Controls.Add(label4);
            addGroup.Controls.Add(label3);
            addGroup.Controls.Add(label2);
            addGroup.Controls.Add(label1);
            addGroup.Controls.Add(genreBox);
            addGroup.Controls.Add(durBox);
            addGroup.Controls.Add(authorBox);
            addGroup.Controls.Add(nameBox);
            addGroup.ForeColor = Color.Black;
            addGroup.Location = new Point(360, 13);
            addGroup.Name = "addGroup";
            addGroup.Size = new Size(432, 162);
            addGroup.TabIndex = 6;
            addGroup.TabStop = false;
            addGroup.Text = "Add a song";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(251, 102);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 8;
            label5.Text = "сек";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 131);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "Жанр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 102);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 6;
            label3.Text = "Продолжительность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 73);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Автор";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 4;
            label1.Text = "Название песни";
            // 
            // genreBox
            // 
            genreBox.FormattingEnabled = true;
            genreBox.Location = new Point(134, 128);
            genreBox.Name = "genreBox";
            genreBox.Size = new Size(173, 23);
            genreBox.TabIndex = 3;
            // 
            // durBox
            // 
            durBox.Location = new Point(134, 99);
            durBox.Name = "durBox";
            durBox.Size = new Size(111, 23);
            durBox.TabIndex = 2;
            // 
            // authorBox
            // 
            authorBox.Location = new Point(134, 70);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(261, 23);
            authorBox.TabIndex = 1;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(134, 41);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(261, 23);
            nameBox.TabIndex = 0;
            // 
            // musicList
            // 
            musicList.FormattingEnabled = true;
            musicList.Location = new Point(16, 13);
            musicList.Name = "musicList";
            musicList.Size = new Size(338, 424);
            musicList.TabIndex = 5;
            // 
            // delButton
            // 
            delButton.Location = new Point(564, 181);
            delButton.Name = "delButton";
            delButton.Size = new Size(96, 23);
            delButton.TabIndex = 9;
            delButton.Text = "Удалить";
            delButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(462, 181);
            editButton.Name = "editButton";
            editButton.Size = new Size(96, 23);
            editButton.TabIndex = 8;
            editButton.Text = "Сохранить";
            editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(360, 181);
            addButton.Name = "addButton";
            addButton.Size = new Size(96, 23);
            addButton.TabIndex = 7;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            // 
            // SongManagerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addGroup);
            Controls.Add(musicList);
            Controls.Add(delButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Name = "SongManagerControl";
            Size = new Size(808, 451);
            addGroup.ResumeLayout(false);
            addGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox addGroup;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox genreBox;
        private TextBox durBox;
        private TextBox authorBox;
        private TextBox nameBox;
        private ListBox musicList;
        private Button delButton;
        private Button editButton;
        private Button addButton;
    }
}
