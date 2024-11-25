namespace Comp3514Quiz2
{
    partial class AnimalSoundsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AnimalSoundsLabel = new Label();
            woofButton = new Button();
            meowButton = new Button();
            oinkButton = new Button();
            mooButton = new Button();
            woofBox = new CheckBox();
            meowBox = new CheckBox();
            oinkBox = new CheckBox();
            mooBox = new CheckBox();
            animalFavBox = new ListBox();
            favBox = new Label();
            volumeBar = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)volumeBar).BeginInit();
            SuspendLayout();
            // 
            // AnimalSoundsLabel
            // 
            AnimalSoundsLabel.AutoSize = true;
            AnimalSoundsLabel.BorderStyle = BorderStyle.Fixed3D;
            AnimalSoundsLabel.Location = new Point(587, 82);
            AnimalSoundsLabel.Name = "AnimalSoundsLabel";
            AnimalSoundsLabel.Size = new Size(241, 34);
            AnimalSoundsLabel.TabIndex = 0;
            AnimalSoundsLabel.Text = "Animal Sounds";
            // 
            // woofButton
            // 
            woofButton.ForeColor = Color.FromArgb(40, 40, 40);
            woofButton.Location = new Point(242, 195);
            woofButton.Name = "woofButton";
            woofButton.Size = new Size(182, 52);
            woofButton.TabIndex = 1;
            woofButton.Text = "Dog";
            woofButton.UseVisualStyleBackColor = true;
            // 
            // meowButton
            // 
            meowButton.ForeColor = Color.FromArgb(40, 40, 40);
            meowButton.Location = new Point(242, 283);
            meowButton.Name = "meowButton";
            meowButton.Size = new Size(182, 52);
            meowButton.TabIndex = 2;
            meowButton.Text = "Cat";
            meowButton.UseVisualStyleBackColor = true;
            // 
            // oinkButton
            // 
            oinkButton.ForeColor = Color.FromArgb(40, 40, 40);
            oinkButton.Location = new Point(242, 370);
            oinkButton.Name = "oinkButton";
            oinkButton.Size = new Size(182, 52);
            oinkButton.TabIndex = 3;
            oinkButton.Text = "Pig";
            oinkButton.UseVisualStyleBackColor = true;
            // 
            // mooButton
            // 
            mooButton.ForeColor = Color.FromArgb(40, 40, 40);
            mooButton.Location = new Point(242, 457);
            mooButton.Name = "mooButton";
            mooButton.Size = new Size(182, 52);
            mooButton.TabIndex = 4;
            mooButton.Text = "Cow";
            mooButton.UseVisualStyleBackColor = true;
            // 
            // woofBox
            // 
            woofBox.AutoSize = true;
            woofBox.Location = new Point(473, 204);
            woofBox.Name = "woofBox";
            woofBox.Size = new Size(333, 36);
            woofBox.TabIndex = 5;
            woofBox.Text = "ADD TO FAVOURITES";
            woofBox.UseVisualStyleBackColor = true;
            woofBox.CheckedChanged += woofBox_CheckedChanged;
            // 
            // meowBox
            // 
            meowBox.AutoSize = true;
            meowBox.Location = new Point(473, 292);
            meowBox.Name = "meowBox";
            meowBox.Size = new Size(333, 36);
            meowBox.TabIndex = 6;
            meowBox.Text = "ADD TO FAVOURITES";
            meowBox.UseVisualStyleBackColor = true;
            meowBox.CheckedChanged += meowBox_CheckedChanged;
            // 
            // oinkBox
            // 
            oinkBox.AutoSize = true;
            oinkBox.Location = new Point(473, 379);
            oinkBox.Name = "oinkBox";
            oinkBox.Size = new Size(333, 36);
            oinkBox.TabIndex = 7;
            oinkBox.Text = "ADD TO FAVOURITES";
            oinkBox.UseVisualStyleBackColor = true;
            oinkBox.CheckedChanged += oinkBox_CheckedChanged;
            // 
            // mooBox
            // 
            mooBox.AutoSize = true;
            mooBox.Location = new Point(473, 466);
            mooBox.Name = "mooBox";
            mooBox.Size = new Size(333, 36);
            mooBox.TabIndex = 8;
            mooBox.Text = "ADD TO FAVOURITES";
            mooBox.UseVisualStyleBackColor = true;
            mooBox.CheckedChanged += mooBox_CheckedChanged;
            // 
            // animalFavBox
            // 
            animalFavBox.FormattingEnabled = true;
            animalFavBox.ItemHeight = 32;
            animalFavBox.Location = new Point(1092, 195);
            animalFavBox.Name = "animalFavBox";
            animalFavBox.Size = new Size(222, 292);
            animalFavBox.TabIndex = 9;
            // 
            // favBox
            // 
            favBox.AutoSize = true;
            favBox.Location = new Point(1105, 146);
            favBox.Name = "favBox";
            favBox.Size = new Size(189, 32);
            favBox.TabIndex = 10;
            favBox.Text = "Favourites";
            // 
            // volumeBar
            // 
            volumeBar.Location = new Point(860, 418);
            volumeBar.Name = "volumeBar";
            volumeBar.Size = new Size(156, 69);
            volumeBar.TabIndex = 11;
            volumeBar.Scroll += volumeBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(874, 357);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 12;
            label1.Text = "Volume";
            // 
            // AnimalSoundsForm
            // 
            AutoScaleDimensions = new SizeF(18F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1440, 576);
            Controls.Add(label1);
            Controls.Add(volumeBar);
            Controls.Add(favBox);
            Controls.Add(animalFavBox);
            Controls.Add(mooBox);
            Controls.Add(oinkBox);
            Controls.Add(meowBox);
            Controls.Add(woofBox);
            Controls.Add(mooButton);
            Controls.Add(oinkButton);
            Controls.Add(meowButton);
            Controls.Add(woofButton);
            Controls.Add(AnimalSoundsLabel);
            Font = new Font("Too Much Opaque", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.LimeGreen;
            Margin = new Padding(5, 4, 5, 4);
            Name = "AnimalSoundsForm";
            Text = "AnimalSoundsForm";
            ((System.ComponentModel.ISupportInitialize)volumeBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AnimalSoundsLabel;
        private Button woofButton;
        private Button meowButton;
        private Button oinkButton;
        private Button mooButton;
        private CheckBox woofBox;
        private CheckBox meowBox;
        private CheckBox oinkBox;
        private CheckBox mooBox;
        private ListBox animalFavBox;
        private Label favBox;
        private TrackBar volumeBar;
        private Label label1;
    }
}