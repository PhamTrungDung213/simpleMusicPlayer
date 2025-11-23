using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackVolume.Value = 50;
            volumeLabel.Text="50%";
        }

        string[] paths, files;

        private void opb_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for(int i=0;i<files.Length; i++)
                {
                    trackList.Items.Add(files[i]);
                }
            }
        }

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            choinhac.URL = paths[trackList.SelectedIndex];
            choinhac.Ctlcontrols.play();
        }

        private void pauseButton_Click_1(object sender, EventArgs e)
        {
            choinhac.Ctlcontrols.pause();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            choinhac.Ctlcontrols.play();
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex < trackList.Items.Count - 1)
            {
                trackList.SelectedIndex = trackList.SelectedIndex + 1;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex >0)
            {
                trackList.SelectedIndex = trackList.SelectedIndex -1;
            }
        }

        private void stopButton_Click_1(object sender, EventArgs e)
        {
            choinhac.Ctlcontrols.stop();
            pBar.Value = 0;
        }

        private void pBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            choinhac.Ctlcontrols.currentPosition = choinhac.currentMedia.duration*e.X/pBar.Width;
        }

        private void trackVolume_Scroll_1(object sender, EventArgs e)
        {
            choinhac.settings.volume = trackVolume.Value;
            volumeLabel.Text = trackVolume.Value.ToString() + "%";
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if(choinhac.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                pBar.Maximum = (int)choinhac.currentMedia.duration;
                pBar.Value = (int)choinhac.Ctlcontrols.currentPosition;
            }
            //pBar:
            try
            {
                start.Text = choinhac.Ctlcontrols.currentPositionString.ToString();
                end.Text = choinhac.currentMedia.durationString.ToString();
            }
            catch(Exception)
            {

            }
        }

    }
}
