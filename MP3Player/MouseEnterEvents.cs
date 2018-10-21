using System;
using System.Windows.Forms;

namespace MP3Player
{
    public partial class MP3Player : Form
    {
        private void MP3Player_MouseEnter(object sender, EventArgs e)
        {
            volumeTimer.Start();
            helpTx.Visible = false;
        }

        private void chooseSongBT_MouseEnter(object sender, EventArgs e)
        {
            helpTx.Visible = true;
            helpTx.Text = "Choose your single song and click PLAY";
        }

        private void volumeSlider_MouseEnter(object sender, EventArgs e)
        {
            helpTx.Visible = true;
            helpTx.Text = "Slide to change the volume";
        }

        private void playListPathTxt_MouseEnter(object sender, EventArgs e)
        {
            helpTx.Visible = true;
            helpTx.Text = "Set your path to playlist";
        }

        private void confirmBT_MouseEnter(object sender, EventArgs e)
        {
            helpTx.Visible = true;
            helpTx.Text = "Confirm the path";
        }

        private void nextSong_MouseEnter(object sender, EventArgs e)
        {
            helpTx.Visible = true;
            helpTx.Text = "Go to next song";
        }

        private void prevSong_MouseEnter(object sender, EventArgs e)
        {
            helpTx.Visible = true;
            helpTx.Text = "Go to previous song";
        }
    }
}
