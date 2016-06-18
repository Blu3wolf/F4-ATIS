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
        // Create msgList List that holds ATIS msg
        List<string> msgList = new List<string>();

        // Declare meaning of msgList words
        // enum Words { Kunsan, information, alpha, bravo, zulu, weather, comma, wind, degrees, knots, visibility, unlimited, kilometers, few, scattered, feet, temperature, dewpoint, altimeter, departures, runway, one, two, three, four, five, six, seven, eight, niner, zero, hundred, thousand };

        // declare existing ATIS message
        StringBuilder msgATISString = new StringBuilder("This should import the value from msgList which in turn should import the value from the Server form");

        public EditATISForm()
        {
            InitializeComponent();
        }

        public void BuildATISString()
        {
            msgATISString.Clear();
            foreach (string word in msgList)
            {
                msgATISString.Append(word);
            }
            messageTextBox.Text = msgATISString.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearATISButton_Click(object sender, EventArgs e)
        {
            msgList.Clear();
            BuildATISString();
        }

        private void applyATISButton_Click(object sender, EventArgs e)
        {

        }

        private void kunsanButton_Click(object sender, EventArgs e)
        {
            msgList.Add("Kunsan");
            BuildATISString();
        }

        private void windButton_Click(object sender, EventArgs e)
        {
            msgList.Add("wind");
            BuildATISString();
        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            msgList.Add("information");
            BuildATISString();
        }

        private void alphaButton_Click(object sender, EventArgs e)
        {
            msgList.Add("alpha");
            BuildATISString();
        }

        private void bravoButton_Click(object sender, EventArgs e)
        {
            msgList.Add("bravo");
            BuildATISString();
        }

        private void zuluButton_Click(object sender, EventArgs e)
        {
            msgList.Add("zulu");
            BuildATISString();
        }

        private void weatherButton_Click(object sender, EventArgs e)
        {
            msgList.Add("weather");
            BuildATISString();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            msgList.Add("pause");
            BuildATISString();
        }

        private void degreesButton_Click(object sender, EventArgs e)
        {
            msgList.Add("degrees");
            BuildATISString();
        }

        private void knotsButton_Click(object sender, EventArgs e)
        {
            msgList.Add("knots");
            BuildATISString();
        }

        private void visibilityButton_Click(object sender, EventArgs e)
        {
            msgList.Add("visibility");
            BuildATISString();
        }

        private void unlimitedButton_Click(object sender, EventArgs e)
        {
            msgList.Add("unlimited");
            BuildATISString();
        }

        private void kilometersButton_Click(object sender, EventArgs e)
        {
            msgList.Add("kilometers");
            BuildATISString();
        }

        private void fewButton_Click(object sender, EventArgs e)
        {
            msgList.Add("few");
            BuildATISString();
        }

        private void scatteredButton_Click(object sender, EventArgs e)
        {
            msgList.Add("scattered");
            BuildATISString();
        }

        private void feetButton_Click(object sender, EventArgs e)
        {
            msgList.Add("feet");
            BuildATISString();
        }

        private void temperatureButton_Click(object sender, EventArgs e)
        {
            msgList.Add("temperature");
            BuildATISString();
        }

        private void dewpointButton_Click(object sender, EventArgs e)
        {
            msgList.Add("dewpoint");
            BuildATISString();
        }

        private void altimeterButton_Click(object sender, EventArgs e)
        {
            msgList.Add("altimeter");
            BuildATISString();
        }

        private void departuresButton_Click(object sender, EventArgs e)
        {
            msgList.Add("departures");
            BuildATISString();
        }

        private void runwayButton_Click(object sender, EventArgs e)
        {
            msgList.Add("runway");
            BuildATISString();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            msgList.Add("one");
            BuildATISString();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            msgList.Add("two");
            BuildATISString();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            msgList.Add("three");
            BuildATISString();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            msgList.Add("four");
            BuildATISString();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            msgList.Add("five");
            BuildATISString();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            msgList.Add("six");
            BuildATISString();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            msgList.Add("seven");
            BuildATISString();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            msgList.Add("eight");
            BuildATISString();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            msgList.Add("nine");
            BuildATISString();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            msgList.Add("zero");
            BuildATISString();
        }

        private void hundredButton_Click(object sender, EventArgs e)
        {
            msgList.Add("hundred");
            BuildATISString();
        }

        private void thousandButton_Click(object sender, EventArgs e)
        {
            msgList.Add("thousand");
            BuildATISString();
        }
    }
}
