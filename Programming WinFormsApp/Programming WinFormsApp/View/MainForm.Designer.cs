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
            seasonsHandleControl1 = new Programming_WinFormsApp.View.Panels.SeasonsHandleControl();
            weekdayParsingControl1 = new Programming_WinFormsApp.View.Panels.WeekdayParsingControl();
            enumerationsControl1 = new EnumerationsControl();
            EnumListBox = new TabControl();
            ClassPage = new TabPage();
            classesRectanglesControl1 = new Programming_WinFormsApp.View.Panels.ClassesRectanglesControl();
            tabPage1 = new TabPage();
            rectanglesCollisionControl1 = new RectanglesCollisionControl();
            moviesControl1 = new MoviesControl();
            EnumPage.SuspendLayout();
            EnumListBox.SuspendLayout();
            ClassPage.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // EnumPage
            // 
            EnumPage.Controls.Add(seasonsHandleControl1);
            EnumPage.Controls.Add(weekdayParsingControl1);
            EnumPage.Controls.Add(enumerationsControl1);
            EnumPage.Location = new Point(4, 29);
            EnumPage.Margin = new Padding(3, 4, 3, 4);
            EnumPage.Name = "EnumPage";
            EnumPage.Padding = new Padding(3, 4, 3, 4);
            EnumPage.Size = new Size(906, 567);
            EnumPage.TabIndex = 0;
            EnumPage.Text = "Enum";
            EnumPage.UseVisualStyleBackColor = true;
            // 
            // seasonsHandleControl1
            // 
            seasonsHandleControl1.Location = new Point(461, 364);
            seasonsHandleControl1.Name = "seasonsHandleControl1";
            seasonsHandleControl1.Size = new Size(445, 188);
            seasonsHandleControl1.TabIndex = 10;
            // 
            // weekdayParsingControl1
            // 
            weekdayParsingControl1.Location = new Point(3, 364);
            weekdayParsingControl1.Name = "weekdayParsingControl1";
            weekdayParsingControl1.Size = new Size(452, 188);
            weekdayParsingControl1.TabIndex = 9;
            // 
            // enumerationsControl1
            // 
            enumerationsControl1.Location = new Point(3, 0);
            enumerationsControl1.Name = "enumerationsControl1";
            enumerationsControl1.Size = new Size(903, 352);
            enumerationsControl1.TabIndex = 8;
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
            ClassPage.Controls.Add(moviesControl1);
            ClassPage.Controls.Add(classesRectanglesControl1);
            ClassPage.Location = new Point(4, 29);
            ClassPage.Margin = new Padding(3, 4, 3, 4);
            ClassPage.Name = "ClassPage";
            ClassPage.Size = new Size(906, 567);
            ClassPage.TabIndex = 1;
            ClassPage.Text = "Classes";
            ClassPage.UseVisualStyleBackColor = true;
            // 
            // classesRectanglesControl1
            // 
            classesRectanglesControl1.Location = new Point(0, 3);
            classesRectanglesControl1.Name = "classesRectanglesControl1";
            classesRectanglesControl1.Size = new Size(459, 317);
            classesRectanglesControl1.TabIndex = 14;
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
            // moviesControl1
            // 
            moviesControl1.Location = new Point(465, 3);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(438, 317);
            moviesControl1.TabIndex = 15;
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
            EnumListBox.ResumeLayout(false);
            ClassPage.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage EnumPage;
        private TabControl EnumListBox;
        private TabPage ClassPage;
        private TabPage tabPage1;
        private RectanglesCollisionControl rectanglesCollisionControl1;
        private EnumerationsControl enumerationsControl1;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonsHandleControl seasonsHandleControl1;
        private View.Panels.ClassesRectanglesControl classesRectanglesControl1;
        private MoviesControl moviesControl1;
    }
}
