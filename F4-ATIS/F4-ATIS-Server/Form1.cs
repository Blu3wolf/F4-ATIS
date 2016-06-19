using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace F4_ATIS_Server
{
    public partial class Form1 : Form
    {
        // Declare and instantiate ATIS message list
        internal List<int> msgList = new List<int>();

        // Declare and Instantiate ATIS message string
        StringBuilder msgATISString = new StringBuilder();

        // Declare EditATISForm class
        EditATISForm Edit;

        // Declare about class aboutbox
        AboutBox1 about;

        // Declare words enumeration
        internal enum words { Kunsan, information, alpha, bravo, zulu, weather, pause, wind, degrees, knots, visibility, unlimited, kilometers, few, scattered, feet, temperature, dewpoint, altimeter, departures, runway, one, two, three, four, five, six, seven, eight, niner, zero, hundred, thousand};

        internal IWMPPlaylist dictionary;

        internal IWMPPlaylist playlist;

        public Form1()
        {
            InitializeComponent();
            buildDictionary();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buildDictionary()
        {
            // Create playlists to hold Dictionary and message
            dictionary = Player.newPlaylist("Dictionary", null);

            playlist = Player.newPlaylist("ATIS", null);

            // For every word in enum words, create a corresponding IWMPMedia object

            int length = Enum.GetNames(typeof(words)).Length;
            for (int i = 0; i < length; i++)
            {
                words word = (words)i;
                string addr = @"Resources\" + word.ToString() + ".wav";
                if (File.Exists(addr))
                {
                    IWMPMedia clip = Player.newMedia(addr);
                    clip.name = word.ToString();
                    dictionary.appendItem(clip);
                }
                else
                {
                    MessageBox.Show("Could not find the file " + addr);
                    break;
                }
            }
            Player.settings.setMode("loop", true);
            Player.settings.autoStart = false;
        }

        private void buildPlaylist()
        {
            blankPlaylist();

            // For every number in the msgList, look up the corresponding word in enum words
            // if there is no IWMPMedia object with that name, create one and add it to the new playlist
            // else just add the one that already exists
            foreach (int number in msgList)
            {
                IWMPMedia clip;
                words word = (words)number;
                IWMPMedia dword = dictionary.get_Item(number);
                if (dword.name == word.ToString())
                {
                    playlist.appendItem(dword);
                }
                else
                {
                    string addr = @"Resources\" + word.ToString() + ".wav";
                    clip = Player.newMedia(addr);
                    clip.name = word.ToString();
                    playlist.appendItem(clip);
                }
            }
            Player.currentPlaylist = playlist;
        }

        private void blankPlaylist()
        {
            // Easiest way to blank the playlist is to rename the existing one
            // and just create a new one with the same name as the old one.
            playlist.name = "meh";
            playlist = Player.newPlaylist("ATIS", null);
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about = new AboutBox1();
            about.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Edit = new EditATISForm(msgList);
            DialogResult dr = Edit.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                Edit.Close();
            }
            else if (dr == DialogResult.OK)
            {
                msgList = Edit.msgList;
                buildPlaylist();
                Edit.BuildATISString(msgList, msgATISString, messageTextBox);
                Edit.Close();
            }
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startATISButton_Click(object sender, EventArgs e)
        {
            if (Player.currentPlaylist.count != 0)
            {
                IWMPMedia media = Player.currentPlaylist.get_Item(0);
                Player.Ctlcontrols.playItem(media);
            }
        }

        private void stopATISButton_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void WMPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            try
            // If the player encounters a corrupt or missing file, 
            // show the hexadecimal error code and URL.
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X") + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            }
        }

        internal void addWord(int word)
        {
            msgList.Add(word);
            Edit.BuildATISString(msgList, msgATISString, messageTextBox);
        }
    }
}
