namespace Comp3514Quiz2
{
    partial class GamerSoundsForm
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
            gamerWelcomeLabel = new Label();
            deathButton = new Button();
            boomButton = new Button();
            birdButton = new Button();
            ouchButton = new Button();
            deathBox = new CheckBox();
            boomBox = new CheckBox();
            birdBox = new CheckBox();
            ouchBox = new CheckBox();
            favBox = new ListBox();
            favBoxLabel = new Label();
            SuspendLayout();
            // 
            // gamerWelcomeLabel
            // 
            gamerWelcomeLabel.AutoSize = true;
            gamerWelcomeLabel.BorderStyle = BorderStyle.Fixed3D;
            gamerWelcomeLabel.Font = new Font("Too Much Opaque", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gamerWelcomeLabel.ForeColor = Color.LimeGreen;
            gamerWelcomeLabel.Location = new Point(509, 108);
            gamerWelcomeLabel.Margin = new Padding(5, 0, 5, 0);
            gamerWelcomeLabel.Name = "gamerWelcomeLabel";
            gamerWelcomeLabel.Size = new Size(232, 34);
            gamerWelcomeLabel.TabIndex = 0;
            gamerWelcomeLabel.Text = "Gamer Sounds";
            // 
            // deathButton
            // 
            deathButton.ForeColor = Color.FromArgb(40, 40, 40);
            deathButton.Location = new Point(169, 210);
            deathButton.Name = "deathButton";
            deathButton.Size = new Size(208, 48);
            deathButton.TabIndex = 1;
            deathButton.Text = "Death";
            deathButton.UseVisualStyleBackColor = true;
            // 
            // boomButton
            // 
            boomButton.ForeColor = Color.FromArgb(40, 40, 40);
            boomButton.Location = new Point(169, 302);
            boomButton.Name = "boomButton";
            boomButton.Size = new Size(208, 53);
            boomButton.TabIndex = 2;
            boomButton.Text = "Boom";
            boomButton.UseVisualStyleBackColor = true;
            // 
            // birdButton
            // 
            birdButton.ForeColor = Color.FromArgb(40, 40, 40);
            birdButton.Location = new Point(169, 395);
            birdButton.Name = "birdButton";
            birdButton.Size = new Size(208, 56);
            birdButton.TabIndex = 3;
            birdButton.Text = "Birdies";
            birdButton.UseVisualStyleBackColor = true;
            // 
            // ouchButton
            // 
            ouchButton.ForeColor = Color.FromArgb(40, 40, 40);
            ouchButton.Location = new Point(169, 491);
            ouchButton.Name = "ouchButton";
            ouchButton.Size = new Size(208, 55);
            ouchButton.TabIndex = 4;
            ouchButton.Text = "Ouchie";
            ouchButton.UseVisualStyleBackColor = true;
            // 
            // deathBox
            // 
            deathBox.AutoSize = true;
            deathBox.ForeColor = Color.LimeGreen;
            deathBox.Location = new Point(404, 217);
            deathBox.Name = "deathBox";
            deathBox.Size = new Size(317, 36);
            deathBox.TabIndex = 5;
            deathBox.Text = "Add to Favourite";
            deathBox.UseVisualStyleBackColor = true;
            deathBox.CheckedChanged += deathBox_CheckedChanged;
            // 
            // boomBox
            // 
            boomBox.AutoSize = true;
            boomBox.ForeColor = Color.LimeGreen;
            boomBox.Location = new Point(404, 311);
            boomBox.Name = "boomBox";
            boomBox.Size = new Size(317, 36);
            boomBox.TabIndex = 6;
            boomBox.Text = "Add to favourite";
            boomBox.UseVisualStyleBackColor = true;
            boomBox.CheckedChanged += boomBox_CheckedChanged;
            // 
            // birdBox
            // 
            birdBox.AutoSize = true;
            birdBox.ForeColor = Color.LimeGreen;
            birdBox.Location = new Point(404, 406);
            birdBox.Name = "birdBox";
            birdBox.Size = new Size(317, 36);
            birdBox.TabIndex = 7;
            birdBox.Text = "Add to favourite";
            birdBox.UseVisualStyleBackColor = true;
            birdBox.CheckedChanged += birdBox_CheckedChanged;
            // 
            // ouchBox
            // 
            ouchBox.AutoSize = true;
            ouchBox.ForeColor = Color.LimeGreen;
            ouchBox.Location = new Point(404, 501);
            ouchBox.Name = "ouchBox";
            ouchBox.Size = new Size(317, 36);
            ouchBox.TabIndex = 8;
            ouchBox.Text = "ADD TO FAVOURITE";
            ouchBox.UseVisualStyleBackColor = true;
            ouchBox.CheckedChanged += ouchBox_CheckedChanged;
            // 
            // favBox
            // 
            favBox.FormattingEnabled = true;
            favBox.ItemHeight = 32;
            favBox.Location = new Point(976, 210);
            favBox.Name = "favBox";
            favBox.Size = new Size(223, 356);
            favBox.TabIndex = 9;
            // 
            // favBoxLabel
            // 
            favBoxLabel.AutoSize = true;
            favBoxLabel.ForeColor = Color.LimeGreen;
            favBoxLabel.Location = new Point(995, 166);
            favBoxLabel.Name = "favBoxLabel";
            favBoxLabel.Size = new Size(189, 32);
            favBoxLabel.TabIndex = 10;
            favBoxLabel.Text = "Favourites";
            // 
            // GamerSoundsForm
            // 
            AutoScaleDimensions = new SizeF(18F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1314, 680);
            Controls.Add(favBoxLabel);
            Controls.Add(favBox);
            Controls.Add(ouchBox);
            Controls.Add(birdBox);
            Controls.Add(boomBox);
            Controls.Add(deathBox);
            Controls.Add(ouchButton);
            Controls.Add(birdButton);
            Controls.Add(boomButton);
            Controls.Add(deathButton);
            Controls.Add(gamerWelcomeLabel);
            Font = new Font("Too Much Opaque", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.LimeGreen;
            Margin = new Padding(5, 4, 5, 4);
            Name = "GamerSoundsForm";
            Text = "GamerSoundsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gamerWelcomeLabel;
        private Button deathButton;
        private Button boomButton;
        private Button birdButton;
        private Button ouchButton;
        private CheckBox deathBox;
        private CheckBox boomBox;
        private CheckBox birdBox;
        private CheckBox ouchBox;
        private ListBox favBox;
        private Label favBoxLabel;
    }
}