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

namespace DeGokkers
{
    public partial class InputPanel : Form
    {
        Spaceship spaceshipRed;
        Spaceship spaceshipGreen;
        Spaceship spaceshipBlue;
        Spaceship spaceshipYellow;

        Guy sietse;
        Guy fer;
        Guy lidy;

        private bool isFinished;
        private bool start = false;

        public InputPanel()
        {
            InitializeComponent();
        }
        private void InputPanel_Load(object sender, EventArgs e)
        {
            ufoRed.Parent = worldMap;
            ufoGreen.Parent = worldMap;
            ufoBlue.Parent = worldMap;
            ufoYellow.Parent = worldMap;

            spaceshipRed = new Spaceship(ufoRed, "red");
            spaceshipGreen = new Spaceship(ufoBlue, "blue");
            spaceshipBlue = new Spaceship(ufoGreen, "green");
            spaceshipYellow = new Spaceship(ufoYellow, "yellow");
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            start = true;
            DecideBoost();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Play();

            if (spaceshipBlue.Finished() == true)
            {
                timer1.Stop();
                this.isFinished = true;
            }
            if (spaceshipGreen.Finished() == true)
            {
                timer1.Stop();
                this.isFinished = true;
            }
            if (spaceshipRed.Finished() == true)
            {
                timer1.Stop();
                this.isFinished = true;
            }
            if (spaceshipYellow.Finished() == true)
            {
                timer1.Stop();
                this.isFinished = true;
            }
        }
        private void Play()
        {
            if (start == true)
            {
                spaceshipRed.Run(true);
                spaceshipGreen.Run(true);
                spaceshipBlue.Run(true);
                spaceshipYellow.Run(true);
            }
        }
        public void DecideBoost()
        {
            Random rnd = new Random();
            int random = rnd.Next(1,4);
            if (random == 1)
            {
                spaceshipRed.Boost();
            }
            if (random == 2)
            {
                spaceshipGreen.Boost();
            }
            if (random == 3)
            {
                spaceshipBlue.Boost();
            }
            if (random == 4)
            {
                spaceshipYellow.Boost();
            }
        }
        public int GetMapWidth()
        {
            return worldMap.Width;
        }

        private void better1Bet_Click(object sender, EventArgs e)
        {
            if (better1.Checked)
            {
                sietse = new Guy(1, 50, "Sietse", better1Label, better1);
                sietse.UpdateLabels();
                int value = (int) better1Amount.Value;
                int spaceshipNumber = (int) spaceshipSelector1.Value;
            }
        }

        private void better2Bet_Click(object sender, EventArgs e)
        {
            if (better2.Checked)
            {
                fer = new Guy(2, 45, "Fer", better2Label, better2);
                fer.UpdateLabels();
                int value = (int)better2Amount.Value;
                int spaceshipNumber = (int)spaceshipSelector2.Value;
            }
        }

        private void better3Bet_Click(object sender, EventArgs e)
        {
            if (better3.Checked)
            {
                lidy = new Guy(3, 75, "Lidy", better3Label, better3);
                lidy.UpdateLabels();
                int value = (int)better3Amount.Value;
                int spaceshipNumber = (int)spaceshipSelector3.Value;
            }
        }
    }
}
