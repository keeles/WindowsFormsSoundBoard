using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp3514Quiz2
{
    public partial class AddCustomSoundForm : Form
    {
        private List<string> customSoundButtonList;
        private string newSoundPath;
        private string newSoundButtonName;

        public List<string> getChangedSound()
        {
            return new List<string> { newSoundPath, newSoundButtonName };
        }
        public List<string> GetCustomSoundButtonList()
        {
            return customSoundButtonList;
        }
        public AddCustomSoundForm(List<string> customSoundList)
        {
            InitializeComponent();
            customSoundButtonList = customSoundList;
            this.customSoundChoiceComboBox.Items.Add(customSoundButtonList[0]);
            this.customSoundChoiceComboBox.Items.Add(customSoundButtonList[1]);
            this.customSoundChoiceComboBox.Items.Add(customSoundButtonList[2]);
            this.customSoundChoiceComboBox.Items.Add(customSoundButtonList[3]);
        }

        private void addSound_Click(object sender, EventArgs e)
        {
            if (this.soundTitleBox.Text.Length <= 2)
            {
                MessageBox.Show($"Sound title must be longer than 2 characters.");
                return; 
            }
            if (this.soundTitleBox.Text.Length > 12)
            {
                MessageBox.Show($"Sound title must be no longer than 12 characters.");
                return; 
            }
            if (this.customSoundChoiceComboBox.SelectedItem == null)
            {
                MessageBox.Show($"Please select a custom button title to replace with new sound.");
                return; 
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "WAV files (*.wav)|*.wav|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FileName = this.soundTitleBox.Text;

                string buttonToSaveSoundTo = this.customSoundChoiceComboBox.SelectedItem.ToString();
                int buttonIndex = customSoundButtonList.IndexOf(buttonToSaveSoundTo);

                if (openFileDialog.ShowDialog() == DialogResult.OK && buttonIndex >= 0)
                {
                    string originalFilePath = openFileDialog.FileName;

                    string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomAudioFiles");

                    Directory.CreateDirectory(binPath);

                    string saveFilePath = Path.Combine(binPath, Path.GetFileName(originalFilePath));

                    byte[] audioBytes = File.ReadAllBytes(originalFilePath);
                    File.WriteAllBytes(saveFilePath, audioBytes);
                    customSoundButtonList[buttonIndex] = saveFilePath;

                    MessageBox.Show($"Audio file saved successfully to {buttonToSaveSoundTo}!");
                    this.newSoundPath = originalFilePath;
                    this.newSoundButtonName = buttonToSaveSoundTo;
                    this.Close();
                }

            }
        }
    }
}
