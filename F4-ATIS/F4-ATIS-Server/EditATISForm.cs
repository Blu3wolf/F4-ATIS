using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F4_ATIS_Server
{
    public partial class EditATISForm : Form
    {
        // Declare msgList List that holds ATIS msg
        internal List<string> msgList;
        
        // declare ATIS message string
        StringBuilder msgATISString = new StringBuilder("This should import the value from msgList which in turn should import the value from the Server form");
        
        public EditATISForm(List<string> mainMsgList)
        {
            InitializeComponent();
            PopulatemsgList(mainMsgList);
        }

        public void PopulatemsgList(List<string> mainMsgList)
        {
            // instantiate msgList
            msgList = new List<string>();

            foreach (string word in mainMsgList)
            {
                msgList.Add(word);
            }

            // Build the msgATISString based on the new msgList
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        public void BuildATISString(List<String> msgList, StringBuilder msgATISString, TextBox messageTextBox)
        {
            // Clear the existing string, add each word in the msgList to the string, put the string in the messagebox.
            msgATISString.Clear();
            foreach (string word in msgList)
            {
                msgATISString.Append(word);
                msgATISString.Append(" ");
            }
            messageTextBox.Text = msgATISString.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }

        private void clearATISButton_Click(object sender, EventArgs e)
        {
            msgList.Clear();
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void applyATISButton_Click(object sender, EventArgs e)
        {
            
        }

        private void kunsanButton_Click(object sender, EventArgs e)
        {
            msgList.Add("Kunsan");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void windButton_Click(object sender, EventArgs e)
        {
            msgList.Add("wind");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            msgList.Add("information");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void alphaButton_Click(object sender, EventArgs e)
        {
            msgList.Add("alpha");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void bravoButton_Click(object sender, EventArgs e)
        {
            msgList.Add("bravo");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void zuluButton_Click(object sender, EventArgs e)
        {
            msgList.Add("zulu");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void weatherButton_Click(object sender, EventArgs e)
        {
            msgList.Add("weather");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            msgList.Add("pause");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void degreesButton_Click(object sender, EventArgs e)
        {
            msgList.Add("degrees");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void knotsButton_Click(object sender, EventArgs e)
        {
            msgList.Add("knots");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void visibilityButton_Click(object sender, EventArgs e)
        {
            msgList.Add("visibility");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void unlimitedButton_Click(object sender, EventArgs e)
        {
            msgList.Add("unlimited");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void kilometersButton_Click(object sender, EventArgs e)
        {
            msgList.Add("kilometers");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void fewButton_Click(object sender, EventArgs e)
        {
            msgList.Add("few");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void scatteredButton_Click(object sender, EventArgs e)
        {
            msgList.Add("scattered");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void feetButton_Click(object sender, EventArgs e)
        {
            msgList.Add("feet");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void temperatureButton_Click(object sender, EventArgs e)
        {
            msgList.Add("temperature");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void dewpointButton_Click(object sender, EventArgs e)
        {
            msgList.Add("dewpoint");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void altimeterButton_Click(object sender, EventArgs e)
        {
            msgList.Add("altimeter");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void departuresButton_Click(object sender, EventArgs e)
        {
            msgList.Add("departures");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void runwayButton_Click(object sender, EventArgs e)
        {
            msgList.Add("runway");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            msgList.Add("one");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            msgList.Add("two");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            msgList.Add("three");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            msgList.Add("four");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            msgList.Add("five");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            msgList.Add("six");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            msgList.Add("seven");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            msgList.Add("eight");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            msgList.Add("nine");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            msgList.Add("zero");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void hundredButton_Click(object sender, EventArgs e)
        {
            msgList.Add("hundred");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }

        private void thousandButton_Click(object sender, EventArgs e)
        {
            msgList.Add("thousand");
            BuildATISString(msgList, msgATISString, messageTextBox);
        }
    }
}
