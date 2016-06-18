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

namespace F4_ATIS_Server
{
    public partial class Form1 : Form
    {
        // Declare and instantiate ATIS message list
        internal List<string> msgList = new List<string>();

        // Declare and Instantiate ATIS message string
        StringBuilder msgATISString = new StringBuilder();

        // Declare EditATISForm class
        EditATISForm Edit;

        // Declare about class aboutbox
        AboutBox1 about;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                Edit.BuildATISString(msgList, msgATISString, messageTextBox);
                Edit.Close();
            }
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startATISButton_Click(object sender, EventArgs e)
        {
            
        }

        private void stopATISButton_Click(object sender, EventArgs e)
        {
            WMPlayer.Ctlcontrols.stop();
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
    }
}
