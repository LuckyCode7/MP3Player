using System;
using System.Windows.Forms;

namespace MP3Player
{
    public partial class MP3Player : Form
    {
        private void changeTimeComponent()
        {
            if (songSecund > 0 && songMinute >= 0)
                songSecund--;
            if (songSecund == 0 && songMinute != 0)
            {
                songMinute--;
                songSecund = 60;
            }
        }

        private void setSongTimeLbl()
        {
            if (songSecund <= 9)
                songTimeLbl.Text = "0" + songMinute + ":0" + songSecund;
            else
                songTimeLbl.Text = "0" + songMinute + ":" + songSecund;
        }

        private void setTimeBar()
        {
            if (timeBar.Value < timeBar.Maximum)
                timeBar.Value++;
            else
                timeBar.Value = 0;
        }

        private bool checkEndOfTheSong()
        {
            if (songMinute == 0 && songSecund == 0)
                return true;
            else
                return false;
        }

        private void setInitialSettings()
        {
            if (checkEndOfTheSong())
                setPlaylistsettings();
        }

        private void setPlaylistsettings()
        {
            if (playListStatus)
                isDurationSet = false;
            else
            {
                songTimeTimer.Stop();
                PlayBT.Enabled = true;
                PauseBT.Enabled = false;
                confirmBT.Enabled = true;
            }
        }

        private void setTimeComponent()
        {
            if (isDurationSet == false)
                initializeTimeComponent();
            else
                changeTimeComponent();
        }

        private void songTimeTimer_Tick(object sender, EventArgs e)
        {
            setTimeComponent();
            setSongTimeLbl();
            setTimeBar();
            automaticChangeOfSong();
            setInitialSettings();
        }

        private void resetSongDurationAndTimeBar()
        {
            isDurationSet = false;
            timeBar.Value = 0;
        }

        private void automaticChangeOfSong()
        {
            if (playListStatus == true)
            {
                songTitleTxt.Text = songs[currentSong].Remove(0, songs[currentSong].LastIndexOf('\\') + 1);
                if (checkEndOfTheSong())
                {
                    if (currentSong + 1 < songs.Count)
                        player.URL = songs[++currentSong];
                    else
                    {
                        currentSong = 0;
                        player.URL = songs[0];
                    }
                }
            }
        }

        private void volumeTimer_Tick(object sender, EventArgs e)
        {
            player.settings.volume = volumeSlider.Value;
            volumeCounter.Text = volumeSlider.Value + "%";
        }

        private void initializeTimeComponent()
        {
            songTime = (int)player.currentMedia.duration;
            timeBar.Maximum = songTime;
            songMinute = songTime / 60;
            songSecund = songTime % 60;
            isDurationSet = true;
        }
    }
}
