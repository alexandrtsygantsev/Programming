namespace Programming_WinFormsApp.Veiw.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
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
            SuspendLayout();
            // 
            // ButtMinus
            // 
            ButtMinus.Anchor = AnchorStyles.Left;
            ButtMinus.BackgroundImage = (Image)resources.GetObject("ButtMinus.BackgroundImage");
            ButtMinus.BackgroundImageLayout = ImageLayout.Stretch;
            ButtMinus.FlatStyle = FlatStyle.Flat;
            ButtMinus.ForeColor = Color.Transparent;
            ButtMinus.Location = new Point(292, 298);
            ButtMinus.Margin = new Padding(3, 4, 3, 4);
            ButtMinus.Name = "ButtMinus";
            ButtMinus.Size = new Size(40, 40);
            ButtMinus.TabIndex = 45;
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
            ButtPlus.Location = new Point(215, 298);
            ButtPlus.Margin = new Padding(3, 4, 3, 4);
            ButtPlus.Name = "ButtPlus";
            ButtPlus.Size = new Size(40, 40);
            ButtPlus.TabIndex = 44;
            ButtPlus.TabStop = false;
            ButtPlus.UseVisualStyleBackColor = true;
            // 
            // RecPanel
            // 
            RecPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RecPanel.BorderStyle = BorderStyle.FixedSingle;
            RecPanel.Location = new Point(361, 40);
            RecPanel.Margin = new Padding(3, 4, 3, 4);
            RecPanel.Name = "RecPanel";
            RecPanel.Size = new Size(493, 495);
            RecPanel.TabIndex = 43;
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(82, 508);
            HeightBox.Margin = new Padding(3, 4, 3, 4);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(131, 27);
            HeightBox.TabIndex = 42;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 512);
            label13.Name = "label13";
            label13.Size = new Size(57, 20);
            label13.TabIndex = 41;
            label13.Text = "Height:";
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(82, 470);
            WidthBox.Margin = new Padding(3, 4, 3, 4);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(131, 27);
            WidthBox.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 474);
            label12.Name = "label12";
            label12.Size = new Size(52, 20);
            label12.TabIndex = 39;
            label12.Text = "Width:";
            // 
            // YBox
            // 
            YBox.Location = new Point(82, 431);
            YBox.Margin = new Padding(3, 4, 3, 4);
            YBox.Name = "YBox";
            YBox.Size = new Size(131, 27);
            YBox.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 435);
            label11.Name = "label11";
            label11.Size = new Size(20, 20);
            label11.TabIndex = 37;
            label11.Text = "Y:";
            // 
            // XBox
            // 
            XBox.Location = new Point(82, 392);
            XBox.Margin = new Padding(3, 4, 3, 4);
            XBox.Name = "XBox";
            XBox.Size = new Size(131, 27);
            XBox.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 396);
            label10.Name = "label10";
            label10.Size = new Size(21, 20);
            label10.TabIndex = 35;
            label10.Text = "X:";
            // 
            // IdBox
            // 
            IdBox.Location = new Point(82, 354);
            IdBox.Margin = new Padding(3, 4, 3, 4);
            IdBox.Name = "IdBox";
            IdBox.ReadOnly = true;
            IdBox.Size = new Size(131, 27);
            IdBox.TabIndex = 34;
            IdBox.TextChanged += IdBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 358);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 33;
            label9.Text = "Id:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(18, 315);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 32;
            label8.Text = "Selected Rectangle:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 16);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 31;
            label7.Text = "Rectangles:";
            // 
            // RectanListBox
            // 
            RectanListBox.FormattingEnabled = true;
            RectanListBox.Location = new Point(18, 40);
            RectanListBox.Margin = new Padding(3, 4, 3, 4);
            RectanListBox.Name = "RectanListBox";
            RectanListBox.ScrollAlwaysVisible = true;
            RectanListBox.Size = new Size(337, 204);
            RectanListBox.TabIndex = 30;
            RectanListBox.SelectedIndexChanged += RectanListBox_SelectedIndexChanged;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtMinus);
            Controls.Add(ButtPlus);
            Controls.Add(RecPanel);
            Controls.Add(HeightBox);
            Controls.Add(label13);
            Controls.Add(WidthBox);
            Controls.Add(label12);
            Controls.Add(YBox);
            Controls.Add(label11);
            Controls.Add(XBox);
            Controls.Add(label10);
            Controls.Add(IdBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(RectanListBox);
            Name = "RectanglesCollisionControl";
            Size = new Size(872, 557);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtMinus;
        private Button ButtPlus;
        private Panel RecPanel;
        private TextBox HeightBox;
        private Label label13;
        private TextBox WidthBox;
        private Label label12;
        private TextBox YBox;
        private Label label11;
        private TextBox XBox;
        private Label label10;
        private TextBox IdBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private ListBox RectanListBox;
    }
}
