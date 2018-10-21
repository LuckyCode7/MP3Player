using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MP3Player
{
    public partial class MP3Player : Form
    {
        private bool isDurationSet = false;
        private WMPLib.WindowsMediaPlayer player;
        private List<string> songs;
        private int songTime;
        private int songMinute;
        private int songSecund;
        private int currentSong = 0;
        private bool playListStatus = false;

        public MP3Player()
        {
            player = new WMPLib.WindowsMediaPlayer();
            songs = new List<string>();
            InitializeComponent();
        }

        private OpenFileDialog createOpenFileDialog()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose your song";
            dlg.Filter = "MP3|*.mp3";
            return dlg;
        }

        private void getAllSongsFromThePath()
        {
            string[] files = Directory.GetFiles(playListPathTxt.Text);
            foreach (string song in files)
            {
                songs.Add(song);
            }
        }
    }
}
