using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp3514Quiz2
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            displayTotalPlayCount();
        }

        private void displayTotalPlayCount()
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
                    string customSoundQuery = "SELECT name, category, play_count FROM sounds JOIN sound_category on category_id = sound_category.id ORDER BY play_count DESC;";
                    DataTable dt = new DataTable();
                    using (MySqlCommand cmd = new MySqlCommand(customSoundQuery, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        dt.Load(reader);
                    }
                    totalSoundPlays.DataSource = dt;
                    totalSoundPlays.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void gamerButton_CheckedChanged(object sender, EventArgs e)
        {
            if (gamerButton.Checked)
            {
                animalButton.Checked = false;
                customButton.Checked = false;
                allButton.Checked = false;
                displayGamerPlayCount();
            }
        }

        private void displayGamerPlayCount()
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
                    string customSoundQuery = "SELECT name, category, play_count FROM sounds JOIN sound_category on category_id = sound_category.id WHERE category_id = 1 ORDER BY play_count DESC;";
                    DataTable dt = new DataTable();
                    using (MySqlCommand cmd = new MySqlCommand(customSoundQuery, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        dt.Load(reader);
                    }
                    totalSoundPlays.DataSource = dt;
                    totalSoundPlays.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void animalButton_CheckedChanged(object sender, EventArgs e)
        {
            if (animalButton.Checked)
            {
                gamerButton.Checked = false;
                customButton.Checked = false;
                allButton.Checked = false;
                displayAnimalPlayCount();
            }
        }

        private void displayAnimalPlayCount()
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
                    string customSoundQuery = "SELECT name, category, play_count FROM sounds JOIN sound_category on category_id = sound_category.id WHERE category_id = 2 ORDER BY play_count DESC;";
                    DataTable dt = new DataTable();
                    using (MySqlCommand cmd = new MySqlCommand(customSoundQuery, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        dt.Load(reader);
                    }
                    totalSoundPlays.DataSource = dt;
                    totalSoundPlays.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void customButton_CheckedChanged(object sender, EventArgs e)
        {
            if (customButton.Checked)
            {
                gamerButton.Checked = false;
                animalButton.Checked = false;
                allButton.Checked = false;
                displayCustomPlayCount();
            }
        }

        private void displayCustomPlayCount()
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
                    string customSoundQuery = "SELECT name, category, play_count FROM sounds JOIN sound_category on category_id = sound_category.id WHERE category_id = 3 ORDER BY play_count DESC;";
                    DataTable dt = new DataTable();
                    using (MySqlCommand cmd = new MySqlCommand(customSoundQuery, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        dt.Load(reader);
                    }
                    totalSoundPlays.DataSource = dt;
                    totalSoundPlays.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void allButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allButton.Checked)
            {
                gamerButton.Checked = false;
                animalButton.Checked = false;
                customButton.Checked = false;
                displayTotalPlayCount();
            }
        }
    }
}
