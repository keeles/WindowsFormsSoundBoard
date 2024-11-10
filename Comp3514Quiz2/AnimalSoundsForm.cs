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
        private SoundPlayer woofSoundPlayer;
        private SoundPlayer meowSoundPlayer;
        private SoundPlayer oinkSoundPlayer;
        private SoundPlayer mooSoundPlayer;
        public AnimalSoundsForm()
        {
            InitializeComponent();
            woofSoundPlayer = new SoundPlayer("woof.wav");
            meowSoundPlayer = new SoundPlayer("meow.wav");
            oinkSoundPlayer = new SoundPlayer("oink.wav");
            mooSoundPlayer = new SoundPlayer("moo.wav");
        }

        private void woofButton_Click(object sender, EventArgs e)
        {
            if (woofButton.Text == "Dog")
            {
                woofSoundPlayer.Play();
                woofButton.Text = "Stop";
            }
            else
            {
                woofSoundPlayer.Stop();
                woofButton.Text = "Dog";
            }
        }

        private void meowButton_Click(object sender, EventArgs e)
        {
            if (meowButton.Text == "Cat")
            {
                meowSoundPlayer.Play();
                meowButton.Text = "Stop";
            }
            else
            {
                meowSoundPlayer.Stop();
                meowButton.Text = "Cat";
            }
        }

        private void oinkButton_Click(object sender, EventArgs e)
        {
            if (oinkButton.Text == "Pig")
            {
                oinkSoundPlayer.Play();
                oinkButton.Text = "Stop";
            }
            else
            {
                oinkSoundPlayer.Stop();
                oinkButton.Text = "Pig";
            }
        }

        private void mooButton_Click(object sender, EventArgs e)
        {
            if (mooButton.Text == "Cow")
            {
                mooSoundPlayer.Play();
                mooButton.Text = "Stop";
            }
            else
            {
                mooSoundPlayer.Stop();
                mooButton.Text = "Cow";
            }
        }

        private void woofBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.woofBox.Checked)
            {
                this.animalFavBox.Items.Add("Dog");
            }
            else
            {
                this.animalFavBox.Items.Remove("Dog");
            }
        }

        private void meowBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.meowBox.Checked)
            {
                this.animalFavBox.Items.Add("Cat");
            }
            else
            {
                this.animalFavBox.Items.Remove("Cat");
            }
        }

        private void oinkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.oinkBox.Checked)
            {
                this.animalFavBox.Items.Add("Pig");
            }
            else
            {
                this.animalFavBox.Items.Remove("Pig");
            }
        }

        private void mooBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.mooBox.Checked)
            {
                this.animalFavBox.Items.Add("Cow");
            }
            else
            {
                this.animalFavBox.Items.Remove("Cow");
            }
        }
    }
}
