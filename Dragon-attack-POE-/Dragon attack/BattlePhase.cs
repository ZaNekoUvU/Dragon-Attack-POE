using Dragon_attack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dragon_attack
{
    public partial class BattlePhase : Form
    {
        //variables for players' names and their dragons' names 
        string playerNameOne;
        string playerNameTwo;
        string dragNameOne;
        string dragNameTwo;

        string dragTypeOne;
        string dragTypeTwo;

        //stats for player one
        int hpOne;
        int attackOne;
        int spAttackOne;
        int blockAttackOne;
        bool blockBoolOne; //bool that will be used to determine if player one's dragon is defending

        //boolean variables to check which players turn it is
        bool playerOneTurn = false;
        bool playerTwoTurn = false;
        bool deadDrag = false;

        //stats for player two
        int hpTwo;
        int attackTwo;
        int spAttackTwo;
        int blockAttackTwo;
        bool blockBoolTwo; //bool that will be used to determine if player two's dragon is defending

        bool rollButtonOne = true;
        bool rollButtonTwo = true;

        //boolean variables to check if a dragon needs to rest after a special attack
        bool playerOneRest = false;
        bool playerTwoRest = false;

        int turn = 1; //turn variable helps to keep track of which players turn it is
        int count = 0; //count variable is used to keep track of the amount plays that have occured within a turn

        //these are global variables to allow the initiative method to compare the two initiative rolls without re-declaring them each time the user clicks the roll buttons
        int compareCount1 = 0;
        int compareCount2 = 0;

        //these are global variables that are used for when the player clicks the roll buttons, when they are clicked they will roll for a random number from 1 to 6
        int initiativeRollOne = 0;
        int initiativeRollTwo = 0;

        string battleLog = "------------------------------------------------------------------\r\n"; //battle log is a string that will be added to after each player's turn. It will be displayed in the battle log text box area

        //this method runs the moment the form loads
        public BattlePhase(string[] p1Data, int[] p1Values, string[] p2Data, int[] p2Values) //previous data from the first form is being passed to this form 
        {
            InitializeComponent();

            //assigning passed data to store player one's information inside of global variables
            playerNameOne = p1Data[0];
            dragNameOne = p1Data[1];
            dragTypeOne = p1Data[2];

            //assigning passed data to store player one's dragon's stats inside of global variables
            hpOne = p1Values[0];
            attackOne = p1Values[1];
            spAttackOne = p1Values[2];
            blockAttackOne = p1Values[3];

            //assigning passed data to store player two's information inside of global variables
            playerNameTwo = p2Data[0];
            dragNameTwo = p2Data[1];
            dragTypeTwo = p2Data[2];

            //assigning passed data to store player two's dragon's stats inside of global variables
            hpTwo = p2Values[0];
            attackTwo = p2Values[1];
            spAttackTwo = p2Values[2];
            blockAttackTwo = p2Values[3];

            initiative(); //calls the initiative method which will then roll the initiative roll variables on start, and if both initiative rolls are the same it the players will need to reroll by themselves
   
        }

        //this method runs if the attack button is clicked and it determines which dragon attacks and determines if the other dragon is defending  
        private void attackBtn_Click(object sender, EventArgs e)
        {

            if (playerOneTurn) //determines if it is player one's turn
            {
                if (blockBoolTwo) //true if player two's dragon is defending
                {
                    //attack is nullified if attack is less than the block stat of player two's dragon
                    if (blockAttackTwo >= attackOne)
                    {
                        battleLog += "\r\nThe attack was nullified\r\n------------------------------------------------------------------\r\n"; //saves string to battle log to be output into the battleLogTxt
                    }
                    //attack will be reduced by the block stat of player two's dragon
                    else if (attackOne > blockAttackTwo)
                    {
                        hpTwo = hpTwo - (attackOne - blockAttackTwo);
                    }
                }
                //if player two's dragon is not defending
                else
                {
                    hpTwo = hpTwo - attackOne; //player two's dragon's health is reduced by the attack stat
                }

                blockBoolTwo = false; //set to false to indicate that player two's dragon is no longer defending

                //checks if player two's dragon is dead
                if (hpTwo <= 0)
                {
                    //adds the damage calculation and explains the event of this player's turn which results in player two's dragon's death. This is then added to the battleLog string variable
                    battleLog += dragNameOne + " attacks " + dragNameTwo + " for " + attackOne + " damage. " + dragNameTwo + " has 0 hp left\r\n" + dragNameTwo + " is dead. " + playerNameOne + " is the winner\r\n------------------------------------------------------------------\r\n";
                    deadDrag = true; //boolean becomes true so that play will no longer continue once a dragon is dead 
                }
                else
                {
                    //adds the damage calculation and explains the event of this player's turn which is saved to the battleLog variable
                    battleLog += dragNameOne + " attacks " + dragNameTwo + " for " + attackOne + " damage. " + dragNameTwo + " has " + hpTwo + " hp left\r\n------------------------------------------------------------------\r\n";
                }

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                turn = 2; // turn is set to 2 so that it is now player two's turn
                count++; //count is incremented for the roll checker method
                informationSwitch(); //calls the informationSwitch method in order to swap players turn as well their information on the GUI
            }


            else if (playerTwoTurn) //determines if it is player two's turn
            {
                if (blockBoolOne) //true if player one's dragon is defending
                {
                    //attack is nullified if attack is less than the block stat of player one's dragon
                    if (blockAttackOne >= attackTwo)
                    {
                        battleLog += "\r\nThe attack was nullified\r\n------------------------------------------------------------------\r\n"; //saves string to battle log to be output into the battleLogTxt
                    }
                    //attack will be reduced by the block stat of player one's dragon
                    else if (attackTwo > blockAttackOne)
                    {
                        hpOne = (hpOne + blockAttackOne) - attackTwo;
                    }
                }
                //if player one's dragon is not defending
                else
                {
                    hpOne = hpOne - attackTwo; //player one's dragon's health is reduced by the attack stat
                }

                blockBoolOne = false;//set to false to indicate that player one's dragon is no longer defending

                //checks if player one's dragon is dead
                if (hpOne <= 0)
                {
                    //adds the damage calculation and explains the event of this player's turn which results in player one's dragon's death. This is then added to the battleLog string variable
                    battleLog += dragNameTwo + " attacks " + dragNameOne + " for " + attackTwo + " damage. " + dragNameOne + " has 0 hp left\r\n" + dragNameOne + " is dead. " + playerNameTwo + " is the winner\r\n------------------------------------------------------------------\r\n";
                    deadDrag = true; //boolean becomes true so that play will no longer continue once a dragon is dead
                }
                else
                {
                    //adds the damage calculation and explains the event of this player's turn which is saved to the battleLog variable
                    battleLog += dragNameTwo + " attacks " + dragNameOne + " for " + attackTwo + " damage. " + dragNameOne + " has " + hpOne + " hp left\r\n------------------------------------------------------------------\r\n";
                }

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt 

                turn = 1; // turn is set to 1 so that it is now player one's turn
                count++; //count is incremented for the roll checker method
                informationSwitch(); //calls the informationSwitch method in order to swap players turn as well their information on the GUI
            }

            //checks if either player needs to rest, else it will end the round
            if (playerOneRest || playerTwoRest)
            {
                Rest(playerTwoRest, playerOneRest); //Passes the rest variables to the rest method
            }
            else if (turn == 1 || turn == 2) //checks against the turn variable due to turn being able to be either 2 or 1
            {
                rollChecker(); //calls the roll checker method to check against count whether or not it should disable parts of the GUI
            }
        
        }

        //this method runs if the special attack button is clicked and it determines which dragon attacks and determines if the other dragon is defending
        private void specialAttackBtn_Click(object sender, EventArgs e)
        {

            if (playerOneTurn) //determines if it is player one's turn
            {
                playerOneRest = true; //sets boolean to true so that player one will rest next turn

                if (blockBoolTwo) //true if player two's dragon is defending
                {
                    //special attack is nullified if special attack is less than the block stat of player two's dragon
                    if (blockAttackTwo >= spAttackOne)
                    {
                        battleLog += "The attack was nullified\r\n------------------------------------------------------------------\r\n"; //saves string to battle log to be output into the battleLogTxt
                    }
                    //special attack will be reduced by the block stat of player two's dragon
                    else if (spAttackOne > blockAttackTwo)
                    {
                        hpTwo = (hpTwo + blockAttackTwo) - spAttackOne;
                    }
                }
                //if player two's dragon is not defending
                else
                {
                    hpTwo = hpTwo - spAttackOne; //player two's dragon's health is reduced by the special attack stat
                }

                blockBoolTwo = false; //set to false to indicate that player two's dragon is no longer defending

                //checks if player two's dragon is dead
                if (hpTwo <= 0)
                {
                    //adds the damage calculation and explains the event of this player's turn which results in player two's dragon's death. This is then added to the battleLog string variable
                    battleLog += dragNameOne + " special attacks " + dragNameTwo + ", for " + spAttackOne + " damage, paralyzing themself for the next turn. " + dragNameTwo + " has 0 hp left\r\n" + dragNameTwo + " is dead. " + playerNameOne + " is the winner\r\n------------------------------------------------------------------\r\n";
                    deadDrag = true; //boolean becomes true so that play will no longer continue once a dragon is dead
                }
                else
                {
                    //adds the damage calculation and explains the event of this player's turn which is saved to the battleLog variable
                    battleLog += dragNameOne + " special attacks " + dragNameTwo + ", for " + spAttackOne + " damage, paralyzing themself for the next turn. " + dragNameTwo + " has " + hpTwo + " hp left\r\n------------------------------------------------------------------\r\n";
                }

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                turn = 2; //turn is set to 2 so that it is player two's turn
                count++; //count is incremented for the roll checker method
                informationSwitch(); //calls the informationSwitch method in order to swap players turn as well their information on the GUI
            }


            else if (playerTwoTurn) //determines if it is player two's turn
            {
                playerTwoRest = true; //sets boolean to true so that player two will rest next turn

                if (blockBoolOne) //true if player one's dragon is defending
                {
                    //special attack is nullified if special attack is less than the block stat of player one's dragon
                    if (blockAttackOne >= spAttackTwo)
                    {
                        battleLog += "The attack was nullified\r\n------------------------------------------------------------------\r\n"; //saves string to battle log to be output into the battleLogTxt
                    }
                    //special attack will be reduced by the block stat of player two's dragon
                    else if (spAttackTwo > blockAttackOne)
                    {
                        hpOne = (hpOne + blockAttackOne) - spAttackTwo;
                    }
                }
                //if player one's dragon is not defending
                else
                {
                    hpOne = hpOne - spAttackTwo; //player one's dragon's health is reduced by the special attack stat
                }

                blockBoolOne = false; //set to false to indicate that player one's dragon is no longer defending

                //checks if player one's dragon is dead
                if (hpOne <= 0)
                {
                    //adds the damage calculation and explains the event of this player's turn which results in player one's dragon's death. This is then added to the battleLog string variable
                    battleLog += dragNameTwo + " special attacks " + dragNameOne + ", for " + spAttackTwo + " damage, paralyzing themself for the next turn. " + dragNameOne + " has 0 hp left\r\n" + dragNameOne + " is dead. " + playerNameTwo + " is the winner\r\n------------------------------------------------------------------\r\n";
                    deadDrag = true; //boolean becomes true so that play will no longer continue once a dragon is dead
                }
                else
                {
                    //adds the damage calculation and explains the event of this player's turn which is saved to the battleLog variable
                    battleLog += dragNameTwo + " special attacks " + dragNameOne + ", for " + spAttackTwo + " damage, paralyzing themself for the next turn. " + dragNameOne + " has " + hpOne + " hp left\r\n------------------------------------------------------------------\r\n";
                }

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                turn = 1; //turn is set to 1 so that it is player one's turn 
                count++; //count is incremented for the roll checker method
                informationSwitch(); //calls the informationSwitch method in order to swap players turn as well their information on the GUI
            }

            //checks if either player needs to rest, else it will end the round
            if (playerOneRest || playerTwoRest)
            {
                Rest(playerTwoRest, playerOneRest); //Passes the rest variables to the rest method
            }
            else if (turn == 1 || turn == 2) //checks against the turn variable due to turn being able to be either 2 or 1
            {
                rollChecker(); //calls the roll checker method to check against count whether or not it should disable parts of the GUI
            }
                      
        }

        //this method runs if the defend button is clicked and it determines if a dragon is defends
        private void defendBtn_Click(object sender, EventArgs e)
        {
            if (playerOneTurn) //determines if it is player one's turn
            {
                blockBoolOne = true; //this indicates that player one is defending
                blockBoolTwo = false;//this is in place so that player two's block wears off

                //explains the event of this player's turn which is saved to the battleLog variable
                battleLog += dragNameOne + " defends against " + dragNameTwo + "\r\n------------------------------------------------------------------\r\n";

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                turn = 2; // turn is set to 2 so that it is now player two's turn
                count++; //count is incremented for the roll checker method
                informationSwitch(); //calls the informationSwitch method in order to swap players turn as well their information on the GUI
            }

            else if (playerTwoTurn) //determines if it is player two's turn
            {
                blockBoolTwo = true; //this indicates that player two is defending
                blockBoolOne = false;//this is in place so that player one's block wears off

                //explains the event of this player's turn which is saved to the battleLog variable
                battleLog += dragNameTwo + " defends against " + dragNameOne + "\r\n------------------------------------------------------------------\r\n";

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                turn = 1; // turn is set to 1 so that it is now player one's turn
                count++; //count is incremented for the roll checker method
                informationSwitch(); //calls the informationSwitch method in order to swap players turn as well their information on the GUI
            }

            //checks if either player needs to rest, else it will end the round
            if (playerOneRest || playerTwoRest)
            {
                Rest(playerTwoRest, playerOneRest); //Passes the rest variables to the rest method
            }

            else if (turn == 1 || turn == 2) //checks against the turn variable due to turn being able to be either 1 or 2
            {
                rollChecker(); //calls the roll checker method to check against count whether or not it should disable parts of the GUI
            }
               
            
        }

        #region emptyVoidBtnsAndLbls

        private void opponentDetailsArea(object sender, EventArgs e)
        {

        }

        private void battleLogArea(object sender, EventArgs e)
        {

        }

        private void playersTurnLbl(object sender, EventArgs e)
        {

        }

        private void battlePhase_Load(object sender, EventArgs e)
        {

        }

        private void playerOneHp(object sender, EventArgs e)
        {

        }

        private void opponentName(object sender, EventArgs e)
        {

        }

        private void opponentDragonDetails(object sender, EventArgs e)
        {

        }

        private void BattleLogLbl_Click(object sender, EventArgs e)
        {

        }

        private void Background2_Click(object sender, EventArgs e)
        {

        }

        private void rollLbl_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //This runs when the back button is clicked
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides this form 
            GADE5121_POE_Riyaad_Angus1 form1 = new GADE5121_POE_Riyaad_Angus1(); //creates a new instance of the form
            form1.ShowDialog(); //shows the new form
        }

        //this methods runs if the first roll button is clicked 
        private void rollBtn_Click(object sender, EventArgs e)
        {
            if (deadDrag) //this checks to see if the deadDrag bool is true or not, if it is, it will display a message box
            {
                MessageBox.Show("Game Over"); //this is to create a closeable message box to say "Game Over"
            }

            else //if the deadDrag bool is false, then the following code will play
            {
                rollButtonOne = true; //this is a bool to allow the specific 
                initiative(); //this calls the initiative method
            }
        }

        //this methods runs if the second roll button is clicked 
        private void rollBtn2_Click(object sender, EventArgs e)
        {

            if (deadDrag) //this checks to see if the deadDrag bool is true or not, if it is, it will display a message box
            {
                MessageBox.Show("Game Over"); //this is to create a closeable message box to say "Game Over"
            }

            else //if the deadDrag bool is false, then the following code will play
            {
                rollButtonTwo = true; //this is a bool to allow the specific 
                initiative(); //this calls the initiative method
            }
        }

        //this method checks the count number to see whether its time to roll for initiative or not
        public void rollChecker()
        {
            if (count >= 2) //if count is bigger than or equal to 2 it will proceed with the following code.
            {
                //this set of code will hide the various labels and buttons to clean the space for when it is time to roll for initiative
                playerTurnLbl.Hide();
                hpLbl.Hide();
                opponentLbl.Hide();
                opponentTxtBox.Hide();
                attackBtn.Hide();
                spAttackBtn.Hide();
                blockBtn.Hide();

                //this disables the action buttons just to prevent any errors when hiding the buttons
                attackBtn.Enabled = false;
                spAttackBtn.Enabled = false;
                blockBtn.Enabled = false;

                //these will enable and show the roll buttons and labels for initiative which will then be used later to roll for who goes first
                rollBtn.Enabled = true;
                rollBtn2.Enabled = true;
                rollBtn.Show();
                rollBtn2.Show();
                rollLbl.Show();
                rollLbl2.Show();

                count = 0; //this resets the count back to 0 so that we can restart the cycle
            }
        }

        //this method is used to roll for who goes first
        public void initiative()
        {
            //this checks if the rollButtonOne bool is true, if it is, it will play the following code
            if (rollButtonOne)
            {
                //this causes the initiativeRollOne variable to be assigned a number from 1 to 6 when the if requirements are true.
                Random rollOne = new Random();
                initiativeRollOne = rollOne.Next(1, 7);

                battleLogTxt.Text += "Player One rolls for: " + initiativeRollOne + "\r\n------------------------------------------------------------------\r\n"; //this displays the player's roll
                compareCount1++; //this variable is incremented to be the requirement for the next few steps

                //these disable the roll buttons ability to be rolled so that we can only have 1 roll per attempt at rolling
                rollButtonOne = false;
                rollBtn.Enabled = false;
            }

            //this checks if the rollButtonTwo bool is true, if it is, it will play the following code
            if (rollButtonTwo)
            {
                Task.Delay(10).Wait(); //this causes the second roll to be slightly delayed, this helps not cause duplicate rolls as much as it would otherwise.

                //this causes the initiativeRollTwo variable to be assigned a number from 1 to 6 when the if requirements are true.
                Random rollTwo = new Random();
                initiativeRollTwo = rollTwo.Next(1, 7);

                battleLogTxt.Text += "Player Two rolls for: " + initiativeRollTwo + "\r\n------------------------------------------------------------------\r\n"; //this displays the player's roll
                compareCount2++; //this variable is incremented to be the requirement for the next few steps

                //these disable the roll buttons ability to be rolled so that we can only have 1 roll per attempt at rolling
                rollButtonTwo = false;
                rollBtn2.Enabled = false;

            }

            //this checks if both initiative rolls are the same, if they are the following code plays
            if (initiativeRollOne == initiativeRollTwo)
            {
                //this re-enables the buttons so that we can roll again for different results
                rollBtn.Enabled = true;
                rollBtn2.Enabled = true;

                //this resets the counters so that we don't muddle up our comparing part of the method.
                compareCount1 = 0;
                compareCount2 = 0;
            }

            //this is where we check the compare counters, if both equal to one the following code will run
            if (compareCount1 == 1 && compareCount2 == 1)
            {
                //this will check if the player Ones initiative roll is higher than the player Ones initiative roll, if it is then the following code will play
                if (initiativeRollOne > initiativeRollTwo)
                {
                    //this sets the turn order so that player One will go first
                    turn = 1;
                    playerOneTurn = true;
                    informationSwitch(); //calls the informationSwitch method in order to show players turn as well their information on the GUI

                    //this disables and hides the rollbuttons so that the player turns can take place without interfearence
                    rollBtn.Enabled = false;
                    rollBtn2.Enabled = false;
                    rollBtn.Hide();
                    rollBtn2.Hide();
                    rollLbl.Hide();
                    rollLbl2.Hide();

                    battleLogTxt.Text += "It is player 1's turn\r\n------------------------------------------------------------------\r\n"; //This indicates whose turn it is

                    //these enable and show the attack buttons and labels so that the player turns can take place properly and not cause confusion of the missing features
                    attackBtn.Enabled = true;
                    spAttackBtn.Enabled = true;
                    blockBtn.Enabled = true;

                    attackBtn.Show();
                    spAttackBtn.Show();
                    blockBtn.Show();

                    playerTurnLbl.Show();
                    hpLbl.Show();
                    opponentLbl.Show();
                    opponentTxtBox.Show();

                    //resets the compare counts to 0 for future instances where we need to compare the initiative rolls again
                    compareCount1 = 0;
                    compareCount2 = 0;
                }

                //this will check if the player Twos initiative roll is higher than the player Ones initiative roll, if it is then the following code will play
                else if (initiativeRollOne < initiativeRollTwo)
                {
                    //this sets the turn order so that player Two will go first
                    turn = 2;
                    playerTwoTurn = true;
                    informationSwitch(); //calls the informationSwitch method in order to show players turn as well their information on the GUI

                    //this disables and hides the rollbuttons so that the player turns can take place without interfearence
                    rollBtn.Enabled = false;
                    rollBtn2.Enabled = false;
                    rollBtn.Hide();
                    rollBtn2.Hide();
                    rollLbl.Hide();
                    rollLbl2.Hide();

                    battleLogTxt.Text += "It is player 2's turn\r\n------------------------------------------------------------------\r\n"; //This indicates whose turn it is

                    //these enable and show the attack buttons and labels so that the player turns can take place properly and not cause confusion of the missing features
                    attackBtn.Enabled = true;
                    spAttackBtn.Enabled = true;
                    blockBtn.Enabled = true;

                    attackBtn.Show();
                    spAttackBtn.Show();
                    blockBtn.Show();

                    playerTurnLbl.Show();
                    hpLbl.Show();
                    opponentLbl.Show();
                    opponentTxtBox.Show();

                    //resets the compare counts to 0 for future instances where we need to compare the initiative rolls again
                    compareCount1 = 0;
                    compareCount2 = 0;
                }
            }

        }

        //This method checks if it is the turn of the player who needs to rest and if they need to rest
        public void Rest(bool playerTwoRest, bool playerOneRest)
        {
            if ((playerTwoTurn && playerTwoRest) || (playerOneTurn && playerOneRest)) 
            {
                RestBtn.Show(); //shows the rest button if condition is true
            }

        }

        //this method swaps player information as well as enables which player's turn it is
        public void informationSwitch()
        {
            //true if the run variable is less than one indicating player one's turn
            if (turn <= 1)
            {
                //enables player one's turn and disables player two's turn
                playerOneTurn = true;
                playerTwoTurn = false;
            }

            //true if the run variable is more than two indicating player two's turn
            else
            {
                //enables player two's turn and disables player one's turn
                playerTwoTurn = true;
                playerOneTurn = false;
            }

            if (playerOneTurn) //true if player one's turn
            {
                //outputs the data from the code ,onto the gui, after calculations have been made 
                hpLbl.Text = "Hp:" + hpOne;//player one's dragon's hp stat is displayed
                playerTurnLbl.Text = dragNameOne + "'s turn"; //displays that it is player one's turn
                opponentLbl.Text = playerNameTwo + "'s details"; //displays player two's dragon's name into the opponentTxtbox area
                opponentTxtBox.Text = dragNameTwo + "\r\nHp:" + hpTwo; //displays player two's dragon's hp underneath its name
            }

            if (!playerOneTurn) //true if not player one's turn
            {
                //outputs the data from the code ,onto the gui, after calculations have been made 
                hpLbl.Text = "Hp:" + hpTwo;//player one's dragon's hp stat is displayed
                playerTurnLbl.Text = dragNameTwo + "'s turn"; //displays that it is player one's turn
                opponentLbl.Text = playerNameOne + "'s details"; //displays player two's dragon's name into the opponentTxtbox area
                opponentTxtBox.Text = dragNameOne + "\r\nHp:" + hpOne; //displays player two's dragon's hp underneath its name
            }
        }

        private void rollLbl2_Click(object sender, EventArgs e)
        {

        }

        //This runs when the Rest button is clicked
        private void RestBtn_Click(object sender, EventArgs e)
        {
            if (playerTwoTurn && playerTwoRest) //checks if it is player two's turn and if they need to rest
            {
                battleLog += dragNameTwo + " is too tired to fight and rests a while\r\n------------------------------------------------------------------\r\n";
                playerTwoRest = false; //sets boolean to false so that it may later be set to true 

                turn = 1; // turn is set to 1 so that it is now player one's turn
                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                informationSwitch(); //calls the informationSwitch method in order to swap players turn as well their information on the GUI

                //Hides the rest button if neither player needs to rest
                if (!playerOneRest && !playerTwoRest)
                {
                    RestBtn.Hide(); 
                }
            }

            else if (playerOneTurn && playerOneRest) //checks if it is player one's turn and if they need to rest
            {
                battleLog += dragNameOne + " is too tired to fight and rests a while\r\n------------------------------------------------------------------\r\n";
                playerOneRest = false; //sets boolean to false so that it may later be set to true 

                turn = 2; //turn is set to 2 so that it is player two's turn
                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                informationSwitch(); //calls the informationSwitch method in order to swap players turn as well their information on the GUI

                //Hides the rest button if neither player needs to rest
                if (!playerOneRest && !playerTwoRest)
                {
                    RestBtn.Hide(); 
                }
            }
        }
    }
}