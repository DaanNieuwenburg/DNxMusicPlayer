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
        public MediaPlayer()
        {
            InitializeComponent();
            
        }

        private void btnPausePlay_Click(object sender, EventArgs e)
        {
            if (pauze == false)
            {
                pauze = true;
                btnPausePlay.Text = "Play";
            }
            else
            {
                pauze = false;
                btnPausePlay.Text = "Pause";
            }
        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
