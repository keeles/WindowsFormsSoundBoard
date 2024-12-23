﻿using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Comp3514Quiz2
{
    public partial class CustomSoundsForm : Form
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        private List<string> sounds;
        private Dictionary<string, string> soundFilePaths;
        public CustomSoundsForm()
        {
            InitializeComponent();
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10
            volumeBar.Value = CalcVol / (ushort.MaxValue / 10);
            sounds = new List<string>();
            soundFilePaths = new Dictionary<string, string>();
        }

        private void SetSoundButtonClick(Button button, string soundName)
        {
            button.Click += (sender, e) =>
            {
                if (soundFilePaths.ContainsKey(soundName))
                {
                    string soundPath = soundFilePaths[soundName];

                    if (File.Exists(soundPath))
                    {
                        button.Text = Path.GetFileName(soundPath);
                        using (SoundPlayer player = new SoundPlayer(soundPath))
                        {
                            player.Play();
                        }
                        updatePlayCountInDatabase(soundName);
                    }
                    else
                    {
                        MessageBox.Show("No sound file has been saved to this button.");
                    }
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
                int indexOfButton = 0;
                foreach (Button button in allButtons)
                {
                    if (button.Text == newSounds[1])
                    {
                        // Check if a custom sound is being replaced and remove it from favourites list
                        this.customSoundFavBox.Items.Remove(button.Text);
                        button.Text = Path.GetFileName(newSounds[0]);
                        indexOfButton = allButtons.IndexOf(button);
                        SetSoundButtonClick(button, newSounds[0]);
                    }
                }
                string connString = Environment.GetEnvironmentVariable("MYSQL_CONNECTION_STRING");

                if (connString == null)
                {
                    MessageBox.Show("Error connecting to the database");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        string insertQuery = "INSERT INTO sounds (name, file_path, category_id, button_id) VALUES (@name, @file_path, @category_id, @button_id)";

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", Path.GetFileName(newSounds[0])); 
                            cmd.Parameters.AddWithValue("@file_path", newSounds[0]);
                            cmd.Parameters.AddWithValue("@category_id", 3); // Custom category is id 3
                            cmd.Parameters.AddWithValue("@button_id", indexOfButton); 

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New sound added to the database!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving sound to database: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
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

        private void CustomSoundsForm_Load(object sender, EventArgs e)
        {
            string connString = Environment.GetEnvironmentVariable("MYSQL_CONNECTION_STRING");

            if (connString == null)
            {
                MessageBox.Show("Error connecting to database");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string customSoundQuery = "SELECT name, file_path, button_id FROM sounds WHERE category_id = 3;";

                    using (MySqlCommand cmd = new MySqlCommand(customSoundQuery, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string soundName = reader.GetString("name");
                            string soundPath = reader.GetString("file_path");
                            sounds.Add(soundName);
                            soundFilePaths[soundName] = soundPath;
                        }

                        if (sounds.Count > 0)
                        {
                            customSound1.Text = sounds[0];
                            SetSoundButtonClick(customSound1, sounds[0]);
                        }
                        if (sounds.Count > 1)
                        {
                            customSound2.Text = sounds[1];
                            SetSoundButtonClick(customSound2, sounds[1]);
                        }
                        if (sounds.Count > 2)
                        {
                            customSound3.Text = sounds[2];
                            SetSoundButtonClick(customSound3, sounds[2]);
                        }
                        if (sounds.Count > 3)
                        {
                            customSound4.Text = sounds[3];
                            SetSoundButtonClick(customSound4, sounds[3]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            int NewVolume = ((ushort.MaxValue / 10) * volumeBar.Value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void updatePlayCountInDatabase(string soundName)
        {
            string connString = Environment.GetEnvironmentVariable("MYSQL_CONNECTION_STRING");

            if (connString == null)
            {
                MessageBox.Show("Error connecting to database");
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string updateQuery = "UPDATE sounds SET play_count = play_count + 1 WHERE name = @soundName";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@soundName", soundName);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating play count: {ex.Message}");
            }
        }
    }
}
