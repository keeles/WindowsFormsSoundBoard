namespace Comp3514Quiz2
{
    partial class LandingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            LandingMessage = new Label();
            gameSounds = new Button();
            animalButton = new Button();
            landingLoadingBar = new ProgressBar();
            customButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LandingMessage
            // 
            LandingMessage.AutoSize = true;
            LandingMessage.BorderStyle = BorderStyle.Fixed3D;
            LandingMessage.ForeColor = Color.LimeGreen;
            LandingMessage.Location = new Point(296, 77);
            LandingMessage.Name = "LandingMessage";
            LandingMessage.Size = new Size(623, 34);
            LandingMessage.TabIndex = 0;
            LandingMessage.Text = "Choose a Category to Explore Sounds";
            // 
            // gameSounds
            // 
            gameSounds.ForeColor = Color.FromArgb(40, 40, 40);
            gameSounds.Location = new Point(108, 233);
            gameSounds.Name = "gameSounds";
            gameSounds.Size = new Size(273, 55);
            gameSounds.TabIndex = 1;
            gameSounds.Text = "Gamer Sounds";
            gameSounds.UseVisualStyleBackColor = true;
            gameSounds.Click += gameSounds_Click;
            // 
            // animalButton
            // 
            animalButton.ForeColor = Color.FromArgb(40, 40, 40);
            animalButton.Location = new Point(108, 325);
            animalButton.Name = "animalButton";
            animalButton.Size = new Size(273, 55);
            animalButton.TabIndex = 2;
            animalButton.Text = "Animal Sounds";
            animalButton.UseVisualStyleBackColor = true;
            animalButton.Click += animalButton_Click;
            // 
            // landingLoadingBar
            // 
            landingLoadingBar.Location = new Point(454, 588);
            landingLoadingBar.Name = "landingLoadingBar";
            landingLoadingBar.Size = new Size(308, 34);
            landingLoadingBar.TabIndex = 3;
            landingLoadingBar.Visible = false;
            // 
            // customButton
            // 
            customButton.ForeColor = Color.FromArgb(40, 40, 40);
            customButton.Location = new Point(108, 416);
            customButton.Name = "customButton";
            customButton.Size = new Size(273, 55);
            customButton.TabIndex = 4;
            customButton.Text = "Custom Sounds";
            customButton.UseVisualStyleBackColor = true;
            customButton.Click += customButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(494, 311);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(677, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(556, 202);
            label1.Name = "label1";
            label1.Size = new Size(554, 32);
            label1.TabIndex = 6;
            label1.Text = "Choose a Category on the left to";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(556, 244);
            label2.Name = "label2";
            label2.Size = new Size(550, 32);
            label2.TabIndex = 7;
            label2.Text = "explore sounds, or add your own!";
            // 
            // LandingForm
            // 
            AutoScaleDimensions = new SizeF(18F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1220, 686);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(customButton);
            Controls.Add(landingLoadingBar);
            Controls.Add(animalButton);
            Controls.Add(gameSounds);
            Controls.Add(LandingMessage);
            Font = new Font("Too Much Opaque", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.LimeGreen;
            Margin = new Padding(5, 4, 5, 4);
            Name = "LandingForm";
            Text = "LandingForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LandingMessage;
        private Button gameSounds;
        private Button animalButton;
        private ProgressBar landingLoadingBar;
        private Button customButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}