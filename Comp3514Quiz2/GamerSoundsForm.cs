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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Comp3514Quiz2
{
    public partial class GamerSoundsForm : Form
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        private Dictionary<int, SoundPlayer> soundPlayers;
        private Dictionary<int, string> soundNames;

        public GamerSoundsForm()
        {
            InitializeComponent();
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10
            volumeBar.Value = CalcVol / (ushort.MaxValue / 10);
            soundPlayers = new Dictionary<int, SoundPlayer>();
            soundNames = new Dictionary<int, string>();

            deathButton.Click += Button_Click;
            boomButton.Click += Button_Click;
            birdButton.Click += Button_Click;
            ouchButton.Click += Button_Click;

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
                    string customSoundQuery = "SELECT name, file_path, id FROM sounds WHERE category_id = 1;";

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

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null) return;

            int buttonId = -1;

            if (clickedButton == deathButton) buttonId = 1;
            else if (clickedButton == boomButton) buttonId = 2;
            else if (clickedButton == birdButton) buttonId = 3;
            else if (clickedButton == ouchButton) buttonId = 4;

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

        private void UpdateButtonText(int buttonId, string soundName)
        {
            switch (buttonId)
            {
                case 1:
                    deathButton.Text = soundName;
                    break;
                case 2:
                    boomButton.Text = soundName;
                    break;
                case 3:
                    birdButton.Text = soundName;
                    break;
                case 4:
                    ouchButton.Text = soundName;
                    break;
                default:
                    break;
            }
        }

        private void deathBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.deathBox.Checked)
            {
                this.favBox.Items.Add(soundNames[1]);
            }
            else
            {
                this.favBox.Items.Remove(soundNames[1]);
            }
        }

        private void boomBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.boomBox.Checked)
            {
                this.favBox.Items.Add(soundNames[2]);
            }
            else
            {
                this.favBox.Items.Remove(soundNames[2]);
            }
        }

        private void birdBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.birdBox.Checked)
            {
                this.favBox.Items.Add(soundNames[3]);
            }
            else
            {
                this.favBox.Items.Remove(soundNames[3]);
            }
        }

        private void ouchBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ouchBox.Checked)
            {
                this.favBox.Items.Add(soundNames[4]);
            }
            else
            {
                this.favBox.Items.Remove(soundNames[4]);
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
