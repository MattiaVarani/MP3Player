using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.CompilerServices;
using System.IO;

namespace MusicPlayer
{
    public partial class Display : Form
    {

        //lists necessary for saving files

        WMPLib.WindowsMediaPlayer MP3player = new WMPLib.WindowsMediaPlayer();

        List<string> files = new List<string>();
        List<string> path = new List<string>();
        List<string> saved = new List<string>();

        //variables for list management
        int index = 0;
        string[] filePaths;
        bool playing = false;
        
        private void Display_Load(object sender, EventArgs e)
        {
            //filling list
            Form form1 = new Form();
            listBoxAll.Items.Clear();
            filePaths = Directory.GetFiles(@"Music\", "*.mp3*");
            RdbRandom.Checked = true;
            for (int i = 0; i < filePaths.Length; i++)
            {
                Console.WriteLine(filePaths[i]);
            }
            Check.Start();
            
            foreach (var item in filePaths)
            {
                listBoxAll.Items.Add(Path.GetFileName(item));
            }
            foreach (var item in listBoxAll.Items)
            {
                saved.Add((string)item);
            }
        }
        public Display()
        {
            InitializeComponent();
        }
        
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            //play and pause
            if (playing)
            {
                MP3player.controls.pause();
                playing = false;
                BtnPlay.Text = "Resume";
            }
            else if (!playing)
            {
                MP3player.controls.play();
                playing = true;
                BtnPlay.Text = "Pause";
            }
            
        }
        private void BtnRandom_Click(object sender, EventArgs e)
        {
            //random song play
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, listBoxAll.Items.Count);
            TxtSong.Text = listBoxAll.Items[randomIndex].ToString();
            listBoxAll.SetSelected(randomIndex, true);
            MP3player.URL = @"Music\" + TxtSong.Text;
            MP3player.controls.play();
            BtnPlay.Text = "Pause";
            playing = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //play precedent song
            if (index > 0)
            {
                index--;
            }
            TxtSong.Text = listBoxAll.Items[index].ToString();
            listBoxAll.SetSelected(index, true);
            MP3player.URL = @"Music\" + TxtSong.Text;
            MP3player.controls.play();
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            //play next song
            if (index < listBoxAll.Items.Count)
            {
                index++;
            }
            TxtSong.Text = listBoxAll.Items[index].ToString();
            listBoxAll.SetSelected(index, true);
            MP3player.URL = @"Music\" + TxtSong.Text;
            MP3player.controls.play();
            
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            //stop
            MP3player.controls.stop();

        }

        //adding mp3 files
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.FileDialog.ShowDialog();
            
            foreach (String item in FileDialog.FileNames)
            {
                string filePath = item;
                path.Add(filePath);
                string fileName = Path.GetFileName(filePath);
                files.Add(fileName);
                Console.WriteLine(filePath);
                Console.WriteLine(fileName);
                File.Copy(filePath, "Music\\" + fileName, true);
                Console.WriteLine("copied");
                
            }

            saved.Clear();
            
            listBoxAll.Items.Clear();
            filePaths = Directory.GetFiles(@"Music\", "*.mp3*");
            foreach (var item in filePaths)
            {
                listBoxAll.Items.Add(Path.GetFileName(item));
            }
            foreach (var item in listBoxAll.Items)
            {
                saved.Add((string)item);
            }

            for (int i = 0; i < filePaths.Length; i++)
            {
                listBoxAll.Items[i] = filePaths[i];
                Console.WriteLine(listBoxAll.Items[i]);
            }
            
            Application.Restart();  //help to fix a problem
        }

        //play song from list
        private void listBoxAll_DoubleClick(object sender, EventArgs e)
        {
            TxtSong.Text = listBoxAll.SelectedItem.ToString();
            
            MP3player.URL = @"Music\" + TxtSong.Text;
            index = listBoxAll.Items.IndexOf(TxtSong.Text);
            MP3player.controls.play();
            playing = true;
            BtnPlay.Text = "Pause";

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Check_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");
            if (3 != (int)MP3player.playState)
            {
                Console.WriteLine("ended");
                if (RdbDown.Checked)
                {
                    if (index < listBoxAll.Items.Count)
                    {
                        index++;
                        TxtSong.Text = listBoxAll.Items[index].ToString();
                        listBoxAll.SetSelected(index, true);
                        MP3player.URL = @"Music\" + TxtSong.Text;
                        MP3player.controls.play();
                    }
                    else
                    {
                        TxtSong.Text = listBoxAll.Items[listBoxAll.Items.Count].ToString();
                        listBoxAll.SetSelected(index, true);
                        MP3player.URL = @"Music\" + TxtSong.Text;
                        MP3player.controls.play();
                    }
                }
                else if (RdbUp.Checked)
                {
                    if (index > 0)
                    {
                        index--;
                        TxtSong.Text = listBoxAll.Items[index].ToString();
                        listBoxAll.SetSelected(index, true);
                        MP3player.URL = @"Music\" + TxtSong.Text;
                        MP3player.controls.play();
                    }
                    else
                    {
                        TxtSong.Text = listBoxAll.Items[0].ToString();
                        listBoxAll.SetSelected(index, true);
                        MP3player.URL = @"Music\" + TxtSong.Text;
                        MP3player.controls.play();
                    }
                    
                }
                else if (RdbRandom.Checked)
                {
                    Random rnd = new Random();
                    int randomIndex = rnd.Next(0, listBoxAll.Items.Count);
                    TxtSong.Text = listBoxAll.Items[randomIndex].ToString();
                    listBoxAll.SetSelected(randomIndex, true);
                    MP3player.URL = @"Music\" + TxtSong.Text;
                    MP3player.controls.play();
                    BtnPlay.Text = "Pause";
                    playing = true;
                }
            }
        }
    }
}
