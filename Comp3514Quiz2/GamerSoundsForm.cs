using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Comp3514Quiz2
{
    public partial class GamerSoundsForm : Form
    {
        private Dictionary<int, SoundPlayer> soundPlayers;
        private Dictionary<int, string> soundNames;

        public GamerSoundsForm()
        {
            InitializeComponent();
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
                    string customSoundQuery = "SELECT name, file_path, sound_id FROM gamer_sounds;";

                    using (MySqlCommand cmd = new MySqlCommand(customSoundQuery, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string soundName = reader.GetString("name");
                            string soundPath = reader.GetString("file_path");
                            int buttonId = reader.GetInt32("sound_id");

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
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null) return;

            int buttonId = -1;

            if (clickedButton == deathButton) buttonId = 9;
            else if (clickedButton == boomButton) buttonId = 10;
            else if (clickedButton == birdButton) buttonId = 11;
            else if (clickedButton == ouchButton) buttonId = 12;

            if (buttonId != -1 && soundPlayers.ContainsKey(buttonId))
            {
                var soundPlayer = soundPlayers[buttonId];
                var soundName = soundNames[buttonId];
                if (clickedButton.Text == soundName)
                {
                    soundPlayer.Play();
                    clickedButton.Text = "Stop";
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
                this.favBox.Items.Add(soundNames[9]);
            }
            else
            {
                this.favBox.Items.Remove(soundNames[9]);
            }
        }

        private void boomBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.boomBox.Checked)
            {
                this.favBox.Items.Add(soundNames[10]);
            }
            else
            {
                this.favBox.Items.Remove(soundNames[10]);
            }
        }

        private void birdBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.birdBox.Checked)
            {
                this.favBox.Items.Add(soundNames[11]);
            }
            else
            {
                this.favBox.Items.Remove(soundNames[11]);
            }
        }

        private void ouchBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ouchBox.Checked)
            {
                this.favBox.Items.Add(soundNames[12]);
            }
            else
            {
                this.favBox.Items.Remove(soundNames[12]);
            }
        }
    }
}
