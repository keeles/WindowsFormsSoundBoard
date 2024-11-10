using System.Media;

namespace Comp3514Quiz2
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void OpenSoundboard_Click(object sender, EventArgs e)
        {
            var landingForm = new LandingForm();
            this.loadingBar.Visible = true;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                this.loadingBar.Value = 10 + (i * 10);
            }
            landingForm.Show();
            this.loadingBar.Visible = false;
            this.loadingBar.Value = 0;
        }
    }
}
