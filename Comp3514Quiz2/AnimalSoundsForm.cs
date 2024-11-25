using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp3514Quiz2
{
    public partial class AnimalSoundsForm : Form
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        private Dictionary<int, SoundPlayer> soundPlayers;
        private Dictionary<int, string> soundNames;
        public AnimalSoundsForm()
        {
            InitializeComponent();
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10
            volumeBar.Value = CalcVol / (ushort.MaxValue / 10);
            soundPlayers = new Dictionary<int, SoundPlayer>();
            soundNames = new Dictionary<int, string>();

            woofButton.Click += Button_Click;
            meowButton.Click += Button_Click;
            oinkButton.Click += Button_Click;
            mooButton.Click += Button_Click;

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
                    string customSoundQuery = "SELECT name, file_path, id FROM sounds WHERE category_id = 2;";

                    using (MySqlCommand cmd = new MySqlCommand(customSoundQuery, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string soundName = reader.GetString("name");
                            string soundPath = reader.GetString("file_path");
                            int buttonId = reader.GetInt32("id");

                            soundPlayers[buttonId] = new SoundPlayer(soundPath);
                            soundNames[buttonId] = soundName;

                            UpdateButtonText(buttonId, soundName);
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

        private void UpdateButtonText(int buttonId, string soundName)
        {
            switch (buttonId)
            {
                case 1:
                    woofButton.Text = soundName;
                    break;
                case 2:
                    meowButton.Text = soundName;
                    break;
                case 3:
                    oinkButton.Text = soundName;
                    break;
                case 4:
                    mooButton.Text = soundName;
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null) return;

            int buttonId = -1;

            if (clickedButton == woofButton) buttonId = 5;
            else if (clickedButton == meowButton) buttonId = 6;
            else if (clickedButton == oinkButton) buttonId = 7;
            else if (clickedButton == mooButton) buttonId = 8;

            if (buttonId != -1 && soundPlayers.ContainsKey(buttonId))
            {
                var soundPlayer = soundPlayers[buttonId];
                var soundName = soundNames[buttonId];
                if (clickedButton.Text == soundName)
                {
                    soundPlayer.Play();
                    clickedButton.Text = "Stop";
                    updatePlayCountInDatabase(soundName);
                }
                else
                {
                    soundPlayer.Stop();
                    clickedButton.Text = soundName;
                }
            }
        }
        private void woofBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.woofBox.Checked)
            {
                this.animalFavBox.Items.Add(soundNames[5]);
            }
            else
            {
                this.animalFavBox.Items.Remove(soundNames[5]);
            }
        }

        private void meowBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.meowBox.Checked)
            {
                this.animalFavBox.Items.Add(soundNames[6]);
            }
            else
            {
                this.animalFavBox.Items.Remove(soundNames[6]);
            }
        }

        private void oinkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.oinkBox.Checked)
            {
                this.animalFavBox.Items.Add(soundNames[7]);
            }
            else
            {
                this.animalFavBox.Items.Remove(soundNames[7]);
            }
        }

        private void mooBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.mooBox.Checked)
            {
                this.animalFavBox.Items.Add(soundNames[8]);
            }
            else
            {
                this.animalFavBox.Items.Remove(soundNames[8]);
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
