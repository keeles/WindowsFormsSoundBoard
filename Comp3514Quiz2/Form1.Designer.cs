namespace Comp3514Quiz2
{
    partial class HomeForm
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
            OpenSoundboard = new Button();
            WelcomeLabel = new Label();
            loadingBar = new ProgressBar();
            SuspendLayout();
            // 
            // OpenSoundboard
            // 
            OpenSoundboard.Font = new Font("Too Much Opaque", 15.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenSoundboard.Location = new Point(339, 227);
            OpenSoundboard.Name = "OpenSoundboard";
            OpenSoundboard.Size = new Size(423, 60);
            OpenSoundboard.TabIndex = 0;
            OpenSoundboard.Text = "Open Soundboard";
            OpenSoundboard.UseVisualStyleBackColor = true;
            OpenSoundboard.UseWaitCursor = true;
            OpenSoundboard.Click += OpenSoundboard_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.BorderStyle = BorderStyle.Fixed3D;
            WelcomeLabel.Cursor = Cursors.No;
            WelcomeLabel.Font = new Font("Too Much Opaque", 15.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = Color.LimeGreen;
            WelcomeLabel.Location = new Point(281, 86);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(530, 44);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Welcome to Soundboard";
            WelcomeLabel.UseWaitCursor = true;
            // 
            // loadingBar
            // 
            loadingBar.BackColor = SystemColors.InactiveCaptionText;
            loadingBar.Location = new Point(399, 428);
            loadingBar.Name = "loadingBar";
            loadingBar.Size = new Size(280, 34);
            loadingBar.TabIndex = 2;
            loadingBar.UseWaitCursor = true;
            loadingBar.Visible = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(14F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1090, 530);
            Controls.Add(loadingBar);
            Controls.Add(WelcomeLabel);
            Controls.Add(OpenSoundboard);
            Font = new Font("Too Much Opaque", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.LimeGreen;
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeForm";
            Text = "Soundboard";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenSoundboard;
        private Label WelcomeLabel;
        private ProgressBar loadingBar;
    }
}
