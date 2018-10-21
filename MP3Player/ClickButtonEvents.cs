using System;
using System.Windows.Forms;

namespace MP3Player
{
    public partial class MP3Player : Form
    {
        private void PlayBT_Click(object sender, EventArgs e)
        {
            player.controls.play();
            setPrevAndNextSongEnable();
            PlayBT.Text = "PLAY";
            songTimeTimer.Start();
            PauseBT.Enabled = true;
            PlayBT.Enabled = false;
            confirmBT.Enabled = false;
        }

        private void PauseBT_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            setPrevAndNextSongUnattainable();
            PauseBT.Text = "PAUSE";
            songTimeTimer.Stop();
            PlayBT.Enabled = true;
            PauseBT.Enabled = false;
            confirmBT.Enabled = true;
            chooseSongBT.Enabled = true;
        }

        private void chooseSongBT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = createOpenFileDialog();
            dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                player.controls.stop();
                playListStatus = false;
                player.URL = dlg.FileName;
                player.controls.stop();
                songTitleTxt.Text = dlg.FileName.Remove(0, dlg.FileName.LastIndexOf('\\') + 1);
                resetSongDurationAndTimeBar();
                setButtonsAfterChooseSongBTclick();
            }
        }

        private void playlistCB_CheckedChanged(object sender, EventArgs e)
        {
            if (playlistCB.Checked)
                showAllPlaylistElements();
            else
                hideAllPlaylistElements();
        }

        private void confirmBT_Click(object sender, EventArgs e)
        {
            currentSong = 0;
            playListStatus = true;
            player.controls.stop();
            getAllSongsFromThePath();
            player.URL = songs[0];
            player.controls.stop();
            setButtonsAfterConfirmBTClick();
            resetSongDurationAndTimeBar();
        }

        private void nextSong_Click(object sender, EventArgs e)
        {
            if (currentSong + 1 < songs.Count)
            {
                player.URL = songs[++currentSong];
                resetSongDurationAndTimeBar();
            }
        }

        private void prevSong_Click(object sender, EventArgs e)
        {
            if (currentSong - 1 >= 0)
            {
                player.URL = songs[--currentSong];
                resetSongDurationAndTimeBar();
            }
        }

        private void setPrevAndNextSongEnable()
        {
            prevSong.Enabled = true;
            nextSong.Enabled = true;
        }

        private void setPrevAndNextSongUnattainable()
        {
            prevSong.Enabled = false;
            nextSong.Enabled = false;
        }

        private void showAllPlaylistElements()
        {
            playListPathTxt.Visible = true;
            confirmBT.Visible = true;
            prevSong.Visible = true;
            nextSong.Visible = true;
        }

        private void hideAllPlaylistElements()
        {
            playListPathTxt.Visible = false;
            confirmBT.Visible = false;
            prevSong.Visible = false;
            nextSong.Visible = false;
        }

        private void setButtonsAfterConfirmBTClick()
        {
            PlayBT.Enabled = true;
            PauseBT.Enabled = false;
            chooseSongBT.Enabled = false;
            setPrevAndNextSongEnable();
        }

        private void setButtonsAfterChooseSongBTclick()
        {
            confirmBT.Enabled = false;
            PlayBT.Enabled = true;
            setPrevAndNextSongUnattainable();
            playlistCB.Checked = false;
        }
    }
}
