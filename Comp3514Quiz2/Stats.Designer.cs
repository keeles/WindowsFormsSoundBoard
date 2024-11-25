namespace Comp3514Quiz2
{
    partial class Stats
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
            label1 = new Label();
            totalSoundPlays = new DataGridView();
            customFavLabel = new Label();
            gamerButton = new RadioButton();
            animalButton = new RadioButton();
            customButton = new RadioButton();
            allButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)totalSoundPlays).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(555, 68);
            label1.Name = "label1";
            label1.Size = new Size(210, 34);
            label1.TabIndex = 1;
            label1.Text = "Sound Stats";
            // 
            // totalSoundPlays
            // 
            totalSoundPlays.AllowUserToAddRows = false;
            totalSoundPlays.AllowUserToDeleteRows = false;
            totalSoundPlays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            totalSoundPlays.Location = new Point(110, 221);
            totalSoundPlays.Name = "totalSoundPlays";
            totalSoundPlays.ReadOnly = true;
            totalSoundPlays.RowHeadersWidth = 62;
            totalSoundPlays.Size = new Size(655, 416);
            totalSoundPlays.TabIndex = 2;
            // 
            // customFavLabel
            // 
            customFavLabel.AutoSize = true;
            customFavLabel.Location = new Point(339, 166);
            customFavLabel.Name = "customFavLabel";
            customFavLabel.Size = new Size(206, 32);
            customFavLabel.TabIndex = 11;
            customFavLabel.Text = "Total Plays";
            // 
            // gamerButton
            // 
            gamerButton.AutoSize = true;
            gamerButton.Location = new Point(963, 267);
            gamerButton.Name = "gamerButton";
            gamerButton.Size = new Size(255, 36);
            gamerButton.TabIndex = 12;
            gamerButton.TabStop = true;
            gamerButton.Text = "Gamer Sounds";
            gamerButton.UseVisualStyleBackColor = true;
            gamerButton.CheckedChanged += gamerButton_CheckedChanged;
            // 
            // animalButton
            // 
            animalButton.AutoSize = true;
            animalButton.Location = new Point(963, 343);
            animalButton.Name = "animalButton";
            animalButton.Size = new Size(264, 36);
            animalButton.TabIndex = 13;
            animalButton.TabStop = true;
            animalButton.Text = "Animal Sounds";
            animalButton.UseVisualStyleBackColor = true;
            animalButton.CheckedChanged += animalButton_CheckedChanged;
            // 
            // customButton
            // 
            customButton.AutoSize = true;
            customButton.Location = new Point(963, 425);
            customButton.Name = "customButton";
            customButton.Size = new Size(273, 36);
            customButton.TabIndex = 14;
            customButton.TabStop = true;
            customButton.Text = "Custom Sounds";
            customButton.UseVisualStyleBackColor = true;
            customButton.CheckedChanged += customButton_CheckedChanged;
            // 
            // allButton
            // 
            allButton.AutoSize = true;
            allButton.Location = new Point(963, 504);
            allButton.Name = "allButton";
            allButton.Size = new Size(211, 36);
            allButton.TabIndex = 15;
            allButton.TabStop = true;
            allButton.Text = "All Sounds";
            allButton.UseVisualStyleBackColor = true;
            allButton.CheckedChanged += allButton_CheckedChanged;
            // 
            // Stats
            // 
            AutoScaleDimensions = new SizeF(18F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1362, 728);
            Controls.Add(allButton);
            Controls.Add(customButton);
            Controls.Add(animalButton);
            Controls.Add(gamerButton);
            Controls.Add(customFavLabel);
            Controls.Add(totalSoundPlays);
            Controls.Add(label1);
            Font = new Font("Too Much Opaque", 12F);
            ForeColor = Color.LimeGreen;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Stats";
            Text = "Stats";
            Load += Stats_Load;
            ((System.ComponentModel.ISupportInitialize)totalSoundPlays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView totalSoundPlays;
        private Label customFavLabel;
        private RadioButton gamerButton;
        private RadioButton animalButton;
        private RadioButton customButton;
        private RadioButton allButton;
    }
}