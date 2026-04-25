namespace Programming_WinFormsApp.View.Panels
{
    partial class SeasonsHandleControl
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
            SeasHandleBox = new GroupBox();
            SeasonDropList = new ComboBox();
            GoButton = new Button();
            ChooseLabel = new Label();
            SeasHandleBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeasHandleBox
            // 
            SeasHandleBox.Controls.Add(SeasonDropList);
            SeasHandleBox.Controls.Add(GoButton);
            SeasHandleBox.Controls.Add(ChooseLabel);
            SeasHandleBox.Dock = DockStyle.Fill;
            SeasHandleBox.Location = new Point(0, 0);
            SeasHandleBox.Margin = new Padding(3, 4, 3, 4);
            SeasHandleBox.Name = "SeasHandleBox";
            SeasHandleBox.Padding = new Padding(3, 4, 3, 4);
            SeasHandleBox.Size = new Size(541, 234);
            SeasHandleBox.TabIndex = 8;
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
            // 
            // ChooseLabel
            // 
            ChooseLabel.AutoSize = true;
            ChooseLabel.Location = new Point(22, 38);
            ChooseLabel.Name = "ChooseLabel";
            ChooseLabel.Size = new Size(110, 20);
            ChooseLabel.TabIndex = 1;
            ChooseLabel.Text = "Choose season:";
            // 
            // SeasonsHandleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasHandleBox);
            Name = "SeasonsHandleControl";
            Size = new Size(541, 234);
            SeasHandleBox.ResumeLayout(false);
            SeasHandleBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasHandleBox;
        private ComboBox SeasonDropList;
        private Button GoButton;
        private Label ChooseLabel;
    }
}
