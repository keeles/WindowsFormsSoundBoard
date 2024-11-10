namespace Comp3514Quiz2
{
    partial class AddCustomSoundForm
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
            welcomeAddSoundLabel = new Label();
            soundTitleBox = new TextBox();
            customChoiceLabel = new Label();
            soundNameLabel = new Label();
            addSound = new Button();
            customSoundChoiceComboBox = new ComboBox();
            SuspendLayout();
            // 
            // welcomeAddSoundLabel
            // 
            welcomeAddSoundLabel.AutoSize = true;
            welcomeAddSoundLabel.BorderStyle = BorderStyle.Fixed3D;
            welcomeAddSoundLabel.Location = new Point(516, 53);
            welcomeAddSoundLabel.Name = "welcomeAddSoundLabel";
            welcomeAddSoundLabel.Size = new Size(387, 34);
            welcomeAddSoundLabel.TabIndex = 0;
            welcomeAddSoundLabel.Text = "Add Your Custom Sound";
            // 
            // soundTitleBox
            // 
            soundTitleBox.ForeColor = Color.FromArgb(40, 40, 40);
            soundTitleBox.Location = new Point(686, 254);
            soundTitleBox.Name = "soundTitleBox";
            soundTitleBox.Size = new Size(358, 39);
            soundTitleBox.TabIndex = 2;
            // 
            // customChoiceLabel
            // 
            customChoiceLabel.AutoSize = true;
            customChoiceLabel.Location = new Point(262, 175);
            customChoiceLabel.Name = "customChoiceLabel";
            customChoiceLabel.Size = new Size(361, 32);
            customChoiceLabel.TabIndex = 3;
            customChoiceLabel.Text = "Choose Custom Sound:";
            // 
            // soundNameLabel
            // 
            soundNameLabel.AutoSize = true;
            soundNameLabel.Location = new Point(416, 257);
            soundNameLabel.Name = "soundNameLabel";
            soundNameLabel.Size = new Size(207, 32);
            soundNameLabel.TabIndex = 4;
            soundNameLabel.Text = "Sound Title:";
            // 
            // addSound
            // 
            addSound.ForeColor = Color.FromArgb(40, 40, 40);
            addSound.Location = new Point(603, 371);
            addSound.Name = "addSound";
            addSound.Size = new Size(199, 56);
            addSound.TabIndex = 5;
            addSound.Text = "Add Sound";
            addSound.UseVisualStyleBackColor = true;
            addSound.Click += addSound_Click;
            // 
            // customSoundChoiceComboBox
            // 
            customSoundChoiceComboBox.ForeColor = Color.FromArgb(40, 40, 40);
            customSoundChoiceComboBox.FormattingEnabled = true;
            customSoundChoiceComboBox.Location = new Point(686, 175);
            customSoundChoiceComboBox.Name = "customSoundChoiceComboBox";
            customSoundChoiceComboBox.Size = new Size(544, 40);
            customSoundChoiceComboBox.TabIndex = 6;
            customSoundChoiceComboBox.Text = "Select Custom Sound to Replace";
            // 
            // AddCustomSoundForm
            // 
            AutoScaleDimensions = new SizeF(18F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1440, 576);
            Controls.Add(customSoundChoiceComboBox);
            Controls.Add(addSound);
            Controls.Add(soundNameLabel);
            Controls.Add(customChoiceLabel);
            Controls.Add(soundTitleBox);
            Controls.Add(welcomeAddSoundLabel);
            Font = new Font("Too Much Opaque", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.LimeGreen;
            Margin = new Padding(5, 4, 5, 4);
            Name = "AddCustomSoundForm";
            Text = "AddCustomSoundForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeAddSoundLabel;
        private TextBox filePathTextBox;
        private TextBox soundTitleBox;
        private Label customChoiceLabel;
        private Label soundNameLabel;
        private Button addSound;
        private ComboBox customSoundChoiceComboBox;
    }
}