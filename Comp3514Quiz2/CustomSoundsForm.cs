using System.Media;
using System.Runtime.CompilerServices;

namespace Comp3514Quiz2
{
    public partial class CustomSoundsForm : Form
    {
        private List<string> sounds;
        public CustomSoundsForm()
        {
            InitializeComponent();
            sounds = new List<string> { customSound1.Text, customSound2.Text, customSound3.Text, customSound4.Text };

        }

        private void SetSoundButtonClick(Button button, string soundPath)
        {
            button.Click += (sender, e) =>
            {
                if (File.Exists(soundPath))
                {
                    var name = Path.GetFileName(soundPath);
                    button.Text = name;
                    using (SoundPlayer player = new SoundPlayer($"CustomAudioFiles/{name}"))
                    {
                        player.Play();
                    }
                }
                else
                {
                    MessageBox.Show("No sound file has been saved to this button.");
                }
            };
        }

        private void addCustomSoundButton_Click(object sender, EventArgs e)
        {
            sounds = new List<string> { customSound1.Text, customSound2.Text, customSound3.Text, customSound4.Text };
            var addCustomSoundForm = new AddCustomSoundForm(sounds);
            addCustomSoundForm.Show();

            addCustomSoundForm.FormClosed += (s, args) =>
            {
                List<string> newSounds = addCustomSoundForm.getChangedSound();
                if (newSounds[0] == null || newSounds[1] == null)
                { return; }
                List<Button> allButtons = this.Controls.OfType<Button>().ToList();
                foreach (Button button in allButtons)
                {
                    if (button.Text == newSounds[1])
                    {
                        // Check if a custom sound is being replaced and remove it from favourites list
                        this.customSoundFavBox.Items.Remove(button.Text);
                        button.Text = Path.GetFileName(newSounds[0]);
                        int indexOfButton = allButtons.IndexOf(button);
                        SetSoundButtonClick(button, newSounds[0]);
                    }
                }
            };
        }

        private void customSoundBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.customSoundBox1.Checked)
            {
                if (this.customSound1.Text == "Stop")
                {
                    return;
                }
                this.customSoundFavBox.Items.Add(this.customSound1.Text);
            }
            else
            {
                this.customSoundFavBox.Items.Remove(this.customSound1.Text);
            }
        }

        private void customSoundBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.customSoundBox2.Checked)
            {
                if (this.customSound2.Text == "Stop")
                {
                    return;
                }
                this.customSoundFavBox.Items.Add(this.customSound2.Text);
            }
            else
            {
                this.customSoundFavBox.Items.Remove(this.customSound2.Text);
            }
        }

        private void customSoundBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.customSoundBox3.Checked)
            {
                if (this.customSound3.Text == "Stop")
                {
                    return;
                }
                this.customSoundFavBox.Items.Add(this.customSound3.Text);
            }
            else
            {
                this.customSoundFavBox.Items.Remove(this.customSound3.Text);
            }
        }

        private void customSoundBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.customSoundBox4.Checked)
            {
                if (this.customSound4.Text == "Stop")
                {
                    return;
                }
                this.customSoundFavBox.Items.Add(this.customSound4.Text);
            }
            else
            {
                this.customSoundFavBox.Items.Remove(this.customSound4.Text);
            }
        }

        private void customSound1_TextChanged(object sender, EventArgs e)
        {
            if (this.customSound1.Text != "Custom Sound 1")
            {
                this.customSoundBox1.Visible = true;
            }
        }

        private void customSound2_TextChanged(object sender, EventArgs e)
        {
            if (this.customSound2.Text != "Custom Sound 2")
            {
                this.customSoundBox2.Visible = true;
            }
        }

        private void customSound3_TextChanged(object sender, EventArgs e)
        {
            if (this.customSound3.Text != "Custom Sound 3")
            {
                this.customSoundBox3.Visible = true;
            }
        }

        private void customSound4_TextChanged(object sender, EventArgs e)
        {
            if (this.customSound4.Text != "Custom Sound 4")
            {
                this.customSoundBox4.Visible = true;
            }
        }
    }
}
