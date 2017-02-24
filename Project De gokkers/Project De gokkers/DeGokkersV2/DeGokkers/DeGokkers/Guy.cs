using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeGokkers
{
    public class Guy
    {
        public string playerName;  // De naam van de gokker
        public int playerNumber;     
        public int cash;     // Het saldo van de gokker 

        public Label myLabel;
        public RadioButton myRadioButton;

        Bet myBet = new Bet();    // Een instantie van Bet() 
        public Guy(int playerNumber, int cash, string playerName, Label myLabel, RadioButton myRadioButton)
        {
            this.playerName = playerName;
            this.playerNumber = playerNumber;
            this.cash = cash;
            this.myLabel = myLabel;
            this.myRadioButton = myRadioButton;
        }

        public void UpdateLabels()
        {
            if (myBet != null)
            {
                this.myLabel.Text = this.myBet.GetDescription();
            }
            else
            {
                this.myLabel.Text = this.myBet.GetDescription();
            }
        }

        public bool PlaceBet()
        {

            return true;
        }

        public void ClearBet()
        {

        }

        public void Collect(int winner)
        {
            if (winner == playerNumber)
            {

            }
        }
        public string GetName()
        {
            return this.playerName;
        }
        public int GetCash()
        {
            return this.cash;
        }
    }
}
