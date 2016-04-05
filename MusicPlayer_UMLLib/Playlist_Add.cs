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
    public partial class Playlist_Add : Form
    {
        public Playlist_Add()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            // Open folder dialog en select map met muziek
            // Geef ook door aan Mediaplayer dat er op Folder is geklikt
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            // Open file dialog met multiselect en selecteer de nummers
            // Geef ook door aan Mediaplayer dat er op Files is geklikt
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            // Maak van de huidige wachtrij een Playlist aan
            // Geef ook door aan Mediaplayer dat er op Queue is geklikt
        }
    }
}
