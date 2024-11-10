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
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void gameSounds_Click(object sender, EventArgs e)
        {
            var gamerSoundBoard = new GamerSoundsForm();
            this.landingLoadingBar.Visible = true;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                this.landingLoadingBar.Value = 10 + (i * 10);
            }
            this.landingLoadingBar.Visible = false;
            this.landingLoadingBar.Value = 0;
            gamerSoundBoard.Show();
        }

        private void animalButton_Click(object sender, EventArgs e)
        {
            var animalSoundsForm = new AnimalSoundsForm();
            this.landingLoadingBar.Visible = true;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                this.landingLoadingBar.Value = 10 + (i * 10);
            }
            this.landingLoadingBar.Visible = false;
            this.landingLoadingBar.Value = 0;
            animalSoundsForm.Show();
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            var customSoundsForm = new CustomSoundsForm();
            this.landingLoadingBar.Visible = true;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                this.landingLoadingBar.Value = 10 + (i * 10);
            }
            this.landingLoadingBar.Visible = false;
            this.landingLoadingBar.Value = 0;
            customSoundsForm.Show();
        }
    }
}
