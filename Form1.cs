using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mp3_Player
{
    public partial class IronMP3 : Form
    {
        public IronMP3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = trackPaths[playList.SelectedIndex];
        }
        List<string> trackPaths = new List<string>();
        string[] paths,files;
        int counter = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectSongs = new OpenFileDialog();
            selectSongs.Multiselect = true;
            selectSongs.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            if (selectSongs.ShowDialog()==DialogResult.OK)
            {
                files = selectSongs.SafeFileNames;
                paths = selectSongs.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    playList.Items.Add($"{counter}.{files[i]}");
                    counter++;
                }
                for (int i = 0; i < paths.Length; i++)
                {
                    trackPaths.Add(paths[i]);
                }
            }

        }

        private void close_Click(object sender, EventArgs e)
        {

        }
    }
}
