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

namespace Comp3514Quiz2
{
    public partial class AnimalSoundsForm : Form
    {
        private Dictionary<int, SoundPlayer> soundPlayers;
        private Dictionary<int, string> soundNames;
        public AnimalSoundsForm()
        {
            InitializeComponent();
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
                    string customSoundQuery = "SELECT name, file_path, sound_id FROM animal_sounds;";

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

            if (clickedButton == woofButton) buttonId = 9;
            else if (clickedButton == meowButton) buttonId = 10;
            else if (clickedButton == oinkButton) buttonId = 11;
            else if (clickedButton == mooButton) buttonId = 12;

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
        private void woofBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.woofBox.Checked)
            {
                this.animalFavBox.Items.Add(soundNames[9]);
            }
            else
            {
                this.animalFavBox.Items.Remove(soundNames[9]);
            }
        }

        private void meowBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.meowBox.Checked)
            {
                this.animalFavBox.Items.Add(soundNames[10]);
            }
            else
            {
                this.animalFavBox.Items.Remove(soundNames[10]);
            }
        }

        private void oinkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.oinkBox.Checked)
            {
                this.animalFavBox.Items.Add(soundNames[11]);
            }
            else
            {
                this.animalFavBox.Items.Remove(soundNames[11]);
            }
        }

        private void mooBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.mooBox.Checked)
            {
                this.animalFavBox.Items.Add(soundNames[12]);
            }
            else
            {
                this.animalFavBox.Items.Remove(soundNames[12]);
            }
        }
    }
}
