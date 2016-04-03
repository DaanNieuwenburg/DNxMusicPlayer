using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNxMediaPlayer
{
    public partial class MediaPlayer : Form
    {
        private bool pauze { get; set; }
        private Functie _function { get; set; }
        public string SelectedSong { get; set; }
        private bool[] isprinted { get; set; }
        public bool shuffleisoff { get; set; }
        public MediaPlayer()
        {
            InitializeComponent();
            
            btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Blue;
            _function = new Functie(SelectedSong);
            for (int i = 0; i < _function.file.Count; i++)
            {
                isprinted[i] = false;
            }

        }

        private void btnPausePlay_Click(object sender, EventArgs e)
        {
            if (pauze == false)
            {
                pauze = true;
                btnPausePlay.BackgroundImage = Properties.Resources.button_Pause_Blue;
                SelectedSong = _function.path[SongList.SelectedIndex];
                _function.Play(SelectedSong);
            }
            else
            {
                pauze = false;
                btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Blue;
                _function.Pause();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _function.AddSong();
            int vorige;
            int j = 0;
            for (int i = 0; i <= _function.file.Count; i++)
            {
                if (i == _function.file.Count)
                {
                    j = i - 1;
                    SongList.Items.Add(_function.path[j]);
                }
            }
        }

        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int song = SongList.SelectedIndex;
            SelectedSong = _function.path[song];
            pauze = false;*/
        }

        private void SongList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectedSong = _function.path[SongList.SelectedIndex];
            _function.Play(SelectedSong);
            pauze = true;
            btnPausePlay.BackgroundImage = Properties.Resources.button_Pause_Blue;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _function.Next();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (shuffleisoff == true)
            {
                shuffleisoff = false;
            }
            else
            {
                shuffleisoff = true;
            }
        }
    }
}
