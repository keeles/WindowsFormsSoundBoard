using MySql.Data.MySqlClient;


namespace Comp3514Quiz2
{
    partial class CustomSoundsForm
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
            customSound1 = new Button();
            customSound2 = new Button();
            customSound3 = new Button();
            customSound4 = new Button();
            customSoundBox1 = new CheckBox();
            customSoundBox2 = new CheckBox();
            customSoundBox3 = new CheckBox();
            customSoundBox4 = new CheckBox();
            customSoundFavBox = new ListBox();
            customFavLabel = new Label();
            addCustomSoundButton = new Button();
            label2 = new Label();
            volumeBar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)volumeBar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(597, 91);
            label1.Name = "label1";
            label1.Size = new Size(250, 34);
            label1.TabIndex = 0;
            label1.Text = "Custom Sounds";
            // 
            // customSound1
            // 
            customSound1.ForeColor = Color.FromArgb(40, 40, 40);
            customSound1.Location = new Point(133, 201);
            customSound1.Name = "customSound1";
            customSound1.Size = new Size(329, 46);
            customSound1.TabIndex = 1;
            customSound1.Text = "Custom Sound 1";
            customSound1.UseVisualStyleBackColor = true;
            customSound1.TextChanged += customSound1_TextChanged;
            // 
            // customSound2
            // 
            customSound2.ForeColor = Color.FromArgb(40, 40, 40);
            customSound2.Location = new Point(133, 297);
            customSound2.Name = "customSound2";
            customSound2.Size = new Size(329, 46);
            customSound2.TabIndex = 2;
            customSound2.Text = "Custom Sound 2";
            customSound2.UseVisualStyleBackColor = true;
            customSound2.TextChanged += customSound2_TextChanged;
            // 
            // customSound3
            // 
            customSound3.ForeColor = Color.FromArgb(40, 40, 40);
            customSound3.Location = new Point(133, 397);
            customSound3.Name = "customSound3";
            customSound3.Size = new Size(329, 46);
            customSound3.TabIndex = 3;
            customSound3.Text = "Custom Sound 3";
            customSound3.UseVisualStyleBackColor = true;
            customSound3.TextChanged += customSound3_TextChanged;
            // 
            // customSound4
            // 
            customSound4.ForeColor = Color.FromArgb(40, 40, 40);
            customSound4.Location = new Point(133, 494);
            customSound4.Name = "customSound4";
            customSound4.Size = new Size(329, 46);
            customSound4.TabIndex = 4;
            customSound4.Text = "Custom Sound 4";
            customSound4.UseVisualStyleBackColor = true;
            customSound4.TextChanged += customSound4_TextChanged;
            // 
            // customSoundBox1
            // 
            customSoundBox1.AutoSize = true;
            customSoundBox1.Location = new Point(514, 207);
            customSoundBox1.Name = "customSoundBox1";
            customSoundBox1.Size = new Size(333, 36);
            customSoundBox1.TabIndex = 5;
            customSoundBox1.Text = "Add to Favourites";
            customSoundBox1.UseVisualStyleBackColor = true;
            customSoundBox1.Visible = false;
            customSoundBox1.CheckedChanged += customSoundBox1_CheckedChanged;
            // 
            // customSoundBox2
            // 
            customSoundBox2.AutoSize = true;
            customSoundBox2.Location = new Point(514, 303);
            customSoundBox2.Name = "customSoundBox2";
            customSoundBox2.Size = new Size(333, 36);
            customSoundBox2.TabIndex = 6;
            customSoundBox2.Text = "Add to Favourites";
            customSoundBox2.UseVisualStyleBackColor = true;
            customSoundBox2.Visible = false;
            customSoundBox2.CheckedChanged += customSoundBox2_CheckedChanged;
            // 
            // customSoundBox3
            // 
            customSoundBox3.AutoSize = true;
            customSoundBox3.Location = new Point(514, 403);
            customSoundBox3.Name = "customSoundBox3";
            customSoundBox3.Size = new Size(333, 36);
            customSoundBox3.TabIndex = 7;
            customSoundBox3.Text = "Add to Favourites";
            customSoundBox3.UseVisualStyleBackColor = true;
            customSoundBox3.Visible = false;
            customSoundBox3.CheckedChanged += customSoundBox3_CheckedChanged;
            // 
            // customSoundBox4
            // 
            customSoundBox4.AutoSize = true;
            customSoundBox4.Location = new Point(514, 500);
            customSoundBox4.Name = "customSoundBox4";
            customSoundBox4.Size = new Size(333, 36);
            customSoundBox4.TabIndex = 8;
            customSoundBox4.Text = "Add to Favourites";
            customSoundBox4.UseVisualStyleBackColor = true;
            customSoundBox4.Visible = false;
            customSoundBox4.CheckedChanged += customSoundBox4_CheckedChanged;
            // 
            // customSoundFavBox
            // 
            customSoundFavBox.FormattingEnabled = true;
            customSoundFavBox.ItemHeight = 32;
            customSoundFavBox.Location = new Point(1055, 201);
            customSoundFavBox.Name = "customSoundFavBox";
            customSoundFavBox.Size = new Size(248, 356);
            customSoundFavBox.TabIndex = 9;
            // 
            // customFavLabel
            // 
            customFavLabel.AutoSize = true;
            customFavLabel.Location = new Point(1079, 151);
            customFavLabel.Name = "customFavLabel";
            customFavLabel.Size = new Size(189, 32);
            customFavLabel.TabIndex = 10;
            customFavLabel.Text = "Favourites";
            // 
            // addCustomSoundButton
            // 
            addCustomSoundButton.ForeColor = Color.FromArgb(40, 40, 40);
            addCustomSoundButton.Location = new Point(186, 101);
            addCustomSoundButton.Name = "addCustomSoundButton";
            addCustomSoundButton.Size = new Size(229, 58);
            addCustomSoundButton.TabIndex = 11;
            addCustomSoundButton.Text = "Add Sound";
            addCustomSoundButton.UseVisualStyleBackColor = true;
            addCustomSoundButton.Click += addCustomSoundButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(885, 431);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 16;
            label2.Text = "Volume";
            // 
            // volumeBar
            // 
            volumeBar.Location = new Point(871, 492);
            volumeBar.Name = "volumeBar";
            volumeBar.Size = new Size(156, 69);
            volumeBar.TabIndex = 15;
            volumeBar.Scroll += volumeBar_Scroll;
            // 
            // CustomSoundsForm
            // 
            AutoScaleDimensions = new SizeF(18F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1453, 727);
            Controls.Add(label2);
            Controls.Add(volumeBar);
            Controls.Add(addCustomSoundButton);
            Controls.Add(customFavLabel);
            Controls.Add(customSoundFavBox);
            Controls.Add(customSoundBox4);
            Controls.Add(customSoundBox3);
            Controls.Add(customSoundBox2);
            Controls.Add(customSoundBox1);
            Controls.Add(customSound4);
            Controls.Add(customSound3);
            Controls.Add(customSound2);
            Controls.Add(customSound1);
            Controls.Add(label1);
            Font = new Font("Too Much Opaque", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.LimeGreen;
            Margin = new Padding(5, 4, 5, 4);
            Name = "CustomSoundsForm";
            Text = "CustomSoundsForm";
            Load += CustomSoundsForm_Load;
            ((System.ComponentModel.ISupportInitialize)volumeBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button customSound1;
        private Button customSound2;
        private Button customSound3;
        private Button customSound4;
        private CheckBox customSoundBox1;
        private CheckBox customSoundBox2;
        private CheckBox customSoundBox3;
        private CheckBox customSoundBox4;
        private ListBox customSoundFavBox;
        private Label customFavLabel;
        private Button addCustomSoundButton;
        private Label label2;
        private TrackBar volumeBar;
    }
}