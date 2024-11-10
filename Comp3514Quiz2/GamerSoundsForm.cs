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
    public partial class GamerSoundsForm : Form
    {
        private SoundPlayer deathSoundPlayer;
        private SoundPlayer ouchSoundPlayer;
        private SoundPlayer boomSoundPlayer;
        private SoundPlayer birdSoundPlayer;

        public GamerSoundsForm()
        {
            InitializeComponent();
            deathSoundPlayer = new SoundPlayer("death.wav");
            ouchSoundPlayer = new SoundPlayer("death_pain_grunts.wav");
            boomSoundPlayer = new SoundPlayer("explode.wav");
            birdSoundPlayer = new SoundPlayer("koertes-ccby-birdsongloop16s.wav");
        }

        private void deathButton_Click(object sender, EventArgs e)
        {
            if (deathButton.Text == "Death")
            {
                deathSoundPlayer.Play();
                deathButton.Text = "Stop";
            }
            else
            {
                deathSoundPlayer.Stop();
                deathButton.Text = "Death";
            }
        }

        private void boomButtonClick(object sender, EventArgs e)
        {
            if (boomButton.Text == "Boom")
            {
                boomSoundPlayer.Play();
                boomButton.Text = "Stop";
            }
            else
            {
                boomSoundPlayer.Stop();
                boomButton.Text = "Boom";
            }
        }

        private void birdButton_Click(object sender, EventArgs e)
        {
            if (birdButton.Text == "Birdies")
            {
                birdSoundPlayer.Play();
                birdButton.Text = "Stop";
            }
            else
            {
                birdSoundPlayer.Stop();
                birdButton.Text = "Birdies";
            }
        }

        private void ouchButton_Click(object sender, EventArgs e)
        {
            if (ouchButton.Text == "Ouchie")
            {
                ouchSoundPlayer.Play();
                ouchButton.Text = "Stop";
            }
            else
            {
                ouchSoundPlayer.Stop();
                ouchButton.Text = "Ouchie";
            }
        }

        private void deathBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.deathBox.Checked)
            {
                this.favBox.Items.Add("Death");
            }
            else
            {
                this.favBox.Items.Remove("Death");
            }
        }

        private void boomBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.boomBox.Checked)
            {
                this.favBox.Items.Add("Boom");
            }
            else
            {
                this.favBox.Items.Remove("Boom");
            }
        }

        private void birdBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.birdBox.Checked)
            {
                this.favBox.Items.Add("Birdies");
            }
            else
            {
                this.favBox.Items.Remove("Birdies");
            }
        }

        private void ouchBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ouchBox.Checked)
            {
                this.favBox.Items.Add("Ouchie");
            }
            else
            {
                this.favBox.Items.Remove("Ouchie");
            }
        }
    }
}
