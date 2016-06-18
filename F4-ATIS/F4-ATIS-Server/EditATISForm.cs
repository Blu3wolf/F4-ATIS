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
        internal List<int> msgList;
        
        // declare ATIS message string
        StringBuilder msgATISString = new StringBuilder("This should import the value from msgList which in turn should import the value from the Server form");
        
        public EditATISForm(List<int> mainMsgList)
        {
            InitializeComponent();

            // instantiate msgList
            msgList = new List<int>(mainMsgList);

            // Build the msgATISString based on the new msgList
            BuildATISString(msgList, msgATISString, messageTextBox);
        }
        
        public void BuildATISString(List<int> msgList, StringBuilder msgATISString, TextBox messageTextBox)
        {
            // Clear the existing string, add each word in the msgList to the string, put the string in the messagebox.
            msgATISString.Clear();
            foreach (int number in msgList)
            {
                Form1.words word = (Form1.words)number;
                msgATISString.Append(word);
                msgATISString.Append(" ");
            }
            messageTextBox.Text = msgATISString.ToString();
        }

        internal void addWord(int word)
        {
            // append a new number to the message, then rebuild the message string
            msgList.Add(word);
            BuildATISString(msgList, msgATISString, messageTextBox);
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
            int number = (int)Form1.words.Kunsan;
            addWord(number);
        }

        private void windButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.wind;
            addWord(number);
        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.information;
            addWord(number);
        }

        private void alphaButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.alpha;
            addWord(number);
        }

        private void bravoButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.bravo;
            addWord(number);
        }

        private void zuluButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.zulu;
            addWord(number);
        }

        private void weatherButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.weather;
            addWord(number);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.pause;
            addWord(number);
        }

        private void degreesButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.degrees;
            addWord(number);
        }

        private void knotsButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.knots;
            addWord(number);
        }

        private void visibilityButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.visibility;
            addWord(number);
        }

        private void unlimitedButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.unlimited;
            addWord(number);
        }

        private void kilometersButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.kilometers;
            addWord(number);
        }

        private void fewButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.few;
            addWord(number);
        }

        private void scatteredButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.scattered;
            addWord(number);
        }

        private void feetButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.feet;
            addWord(number);
        }

        private void temperatureButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.temperature;
            addWord(number);
        }

        private void dewpointButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.dewpoint;
            addWord(number);
        }

        private void altimeterButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.altimeter;
            addWord(number);
        }

        private void departuresButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.departures;
            addWord(number);
        }

        private void runwayButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.runway;
            addWord(number);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.one;
            addWord(number);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.two;
            addWord(number);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.three;
            addWord(number);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.four;
            addWord(number);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.five;
            addWord(number);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.six;
            addWord(number);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.seven;
            addWord(number);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.eight;
            addWord(number);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.niner;
            addWord(number);
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.zero;
            addWord(number);
        }

        private void hundredButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.hundred;
            addWord(number);
        }

        private void thousandButton_Click(object sender, EventArgs e)
        {
            int number = (int)Form1.words.thousand;
            addWord(number);
        }
    }
}
