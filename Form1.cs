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
            if (choinhac.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (choinhac.currentMedia != null)
                {
                    double dur = choinhac.currentMedia.duration;
                    double pos = choinhac.Ctlcontrols.currentPosition;

                    if (dur > 0)
                    {
                        pBar.Maximum = (int)dur;
                        pBar.Value = (int)pos;
                    }
                    start.Text = choinhac.Ctlcontrols.currentPositionString ?? "00:00";
                    end.Text = choinhac.currentMedia.durationString ?? "00:00";
                }
            }
            else
            {
                start.Text = "00:00";
                end.Text = "00:00";
            }
        }

    }
}
