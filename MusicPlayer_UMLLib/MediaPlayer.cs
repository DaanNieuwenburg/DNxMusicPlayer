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
        public int Wachtrij { get; set; }
        private bool pauze { get; set; }
        private string _skin { get; set; }
        private Functie _function { get; set; }
        public string SelectedSong { get; set; }
        private bool[] isprinted { get; set; }
        public ListBox.ObjectCollection list { get; set; }
        private Color _BackgroundColor { get; set; }
        public bool shuffleisoff { get; set; }
        public MediaPlayer()
        {
            InitializeComponent();
            shuffleisoff = false;
            _skin = "Blue";
            btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Blue;
            _function = new Functie(SelectedSong, Wachtrij, list);
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
                if (_skin.Equals("Blue"))
                {
                    btnPausePlay.BackgroundImage = Properties.Resources.button_Pause_Blue;
                }
                else if (_skin.Equals("Pink"))
                {
                    btnPausePlay.BackgroundImage = Properties.Resources.button_Pause_Pink;
                }
                else if (_skin.Equals("Green"))
                {
                    btnPausePlay.BackgroundImage = Properties.Resources.button_Pause_Green;
                }
                else if (_skin.Equals("Cyan"))
                {
                    btnPausePlay.BackgroundImage = Properties.Resources.button_Pause_Cyan;
                }
                if (SongList.SelectedIndex == -1)
                {
                    SongList.SelectedIndex = 0;
                }
                SelectedSong = _function.path[SongList.SelectedIndex];

                _function.Play(SelectedSong);
            }
            else
            {
                pauze = false;
                if (_skin.Equals("Blue"))
                {
                    btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Blue;
                }
                else if (_skin.Equals("Pink"))
                {
                    btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Pink;
                }
                else if (_skin.Equals("Green"))
                {
                    btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Green;
                }
                else if (_skin.Equals("Cyan"))
                {
                    btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Cyan;
                }
                _function.Pause();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.btnAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); // Transparent
            int lastcount = SongList.Items.Count;
            _function.AddSong();
            int vorige;
            int j = 0;
            for (int i = 0; i <= _function.file.Count; i++)
            {
                if (i == _function.file.Count)
                {
                    j = i - 1;
                    SongList.Items.Add(_function.file[j]);
                    Wachtrij++;
                }
                else if (lastcount > SongList.Items.Count)
                {
                    SongList.Items.Add(_function.file[lastcount]);
                    Wachtrij++;
                }
            }
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
            int j = SongList.SelectedIndex;
            if (shuffleisoff == false)
            {

                if (SongList.SelectedIndex != SongList.Items.Count - 1)
                {
                    j++;
                }
                else
                {
                    j = 0;
                }
                SelectedSong = _function.path[j];
                SongList.SelectedIndex = j;
                _function.Play(SelectedSong);
            }
            else
            {

            }

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (shuffleisoff == true)
            {
                shuffleisoff = false;
                list = SongList.Items;
                if (_skin.Equals("Blue"))
                {
                    btnShuffle.BackgroundImage = Properties.Resources.button_shuffle_Blue;
                }
                else if (_skin.Equals("Pink"))
                {
                    btnShuffle.BackgroundImage = Properties.Resources.button_shuffle_Pink;
                }
                else if (_skin.Equals("Cyan"))
                {
                    btnShuffle.BackgroundImage = Properties.Resources.button_shuffle_Cyan;
                }
                else if (_skin.Equals("Green"))
                {
                    btnShuffle.BackgroundImage = Properties.Resources.button_shuffle_Green;
                }
                _function.Shuffle();

            }
            else
            {
                shuffleisoff = true;
                if (_skin.Equals("Cyan"))
                {
                    btnShuffle.BackgroundImage = Properties.Resources.button_shuffle_Blue;
                }
                else
                {
                    btnShuffle.BackgroundImage = Properties.Resources.button_shuffle_Cyan;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int j = SongList.SelectedIndex;
            if (shuffleisoff == false)
            {

                if (SongList.SelectedIndex - 1 != -1)
                {
                    j--;
                    SelectedSong = _function.path[j];
                    SongList.SelectedIndex = j;
                    _function.Play(SelectedSong);
                }
                else
                {
                    _function.Stop();
                    pauze = false;
                    if (_skin.Equals("Blue"))
                    {
                        btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Blue;
                    }
                    else if (_skin.Equals("Pink"))
                    {
                        btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Pink;
                    }
                    else if (_skin.Equals("Cyan"))
                    {
                        btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Cyan;
                    }
                }

            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _function.Stop();
            pauze = false;
            if (_skin.Equals("Blue"))
            {
                btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Blue;
            }
            else if (_skin.Equals("Cyan"))
            {
                btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Cyan;
            }
            else if (_skin.Equals("Pink"))
            {
                btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Pink;
            }
            else if (_skin.Equals("Green"))
            {
                btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Green;
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _skin = "Blue";
            btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Blue;
            btnNext.BackgroundImage = Properties.Resources.button_Next_Blue;
            btnPrevious.BackgroundImage = Properties.Resources.button_Previous_Blue;
            btnShuffle.BackgroundImage = Properties.Resources.button_shuffle_Blue;
            btnRepeat.BackgroundImage = Properties.Resources.button_Repeat_Blue;
            btnStop.BackgroundImage = Properties.Resources.button_Stop_Blue;
            btnAdd.BackgroundImage = Properties.Resources.button_Add_Blue;
            btnRemove.BackgroundImage = Properties.Resources.button_Remove_Blue;
            btnClear.BackgroundImage = Properties.Resources.button_Clear_Blue;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _skin = "Cyan";
            btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Cyan;
            btnNext.BackgroundImage = Properties.Resources.button_Next_Cyan;
            btnPrevious.BackgroundImage = Properties.Resources.button_Previous_Cyan;
            btnShuffle.BackgroundImage = Properties.Resources.button_shuffle_Cyan;
            btnRepeat.BackgroundImage = Properties.Resources.button_Repeat_Cyan;
            btnStop.BackgroundImage = Properties.Resources.button_Stop_Cyan;
            btnAdd.BackgroundImage = Properties.Resources.button_Add_Cyan;
            btnRemove.BackgroundImage = Properties.Resources.button_Remove_Cyan;
            btnClear.BackgroundImage = Properties.Resources.button_Clear_Cyan;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _skin = "Pink";
            btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Pink;
            btnNext.BackgroundImage = Properties.Resources.button_Next_Pink;
            btnPrevious.BackgroundImage = Properties.Resources.button_Previous_Pink;
            btnShuffle.BackgroundImage = Properties.Resources.button_shuffle_Pink;
            btnRepeat.BackgroundImage = Properties.Resources.button_Repeat_Pink;
            btnStop.BackgroundImage = Properties.Resources.button_Stop_Pink;
            btnAdd.BackgroundImage = Properties.Resources.button_Add_Pink;
            btnRemove.BackgroundImage = Properties.Resources.button_Remove_Pink;
            btnClear.BackgroundImage = Properties.Resources.button_Clear_Pink;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _skin = "Green";
            btnPausePlay.BackgroundImage = Properties.Resources.button_Play_Green;
            btnNext.BackgroundImage = Properties.Resources.button_Next_Green;
            btnPrevious.BackgroundImage = Properties.Resources.button_Previous_Green;
            btnShuffle.BackgroundImage = Properties.Resources.button_shuffle_Green;
            btnRepeat.BackgroundImage = Properties.Resources.button_Repeat_Green;
            btnStop.BackgroundImage = Properties.Resources.button_Stop_Green;
            btnAdd.BackgroundImage = Properties.Resources.button_Add_Green;
            btnRemove.BackgroundImage = Properties.Resources.button_Remove_Green;
            btnClear.BackgroundImage = Properties.Resources.button_Clear_Green;
        }

        private void addSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int lastcount = SongList.Items.Count;
            _function.AddSong();
            int vorige;
            int j = 0;
            for (int i = 0; i <= _function.file.Count; i++)
            {
                if (i == _function.file.Count)
                {
                    j = i - 1;
                    SongList.Items.Add(_function.file[j]);
                    Wachtrij++;
                }
                else if (lastcount > SongList.Items.Count)
                {
                    SongList.Items.Add(_function.file[lastcount]);
                    Wachtrij++;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnRemove.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); // Transparent
            while (SongList.SelectedItems.Count != 0)
            {

                SongList.Items.Remove(SongList.SelectedItems[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = SongList.Items.Count - 1;
            while (count != -1)
            {
                SongList.Items.Remove(SongList.Items[count]);
                count = SongList.Items.Count-1;
                
            }
        }

        private void customToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();

            // Kijk of gebruiker op OK drukt
            if (result == DialogResult.OK)
            {
                _BackgroundColor = colorDialog.Color;
            }
            UpdateBackground();
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _BackgroundColor = Color.Blue;
            UpdateBackground();
        }
        private void pinkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _BackgroundColor = Color.Pink;
            UpdateBackground();
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _BackgroundColor = Color.Red;
            UpdateBackground();
        }
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _BackgroundColor = Color.Black;
            UpdateBackground();
        }
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _BackgroundColor = Color.White;
            UpdateBackground();
        }
        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _BackgroundColor = Color.Yellow;
            UpdateBackground();
        }
        private void UpdateBackground()
        {
            this.BackColor = _BackgroundColor;
        }

        private void newPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playlist_Add _Melding = new Playlist_Add();
            _Melding.ShowDialog();
        }
    }
}

