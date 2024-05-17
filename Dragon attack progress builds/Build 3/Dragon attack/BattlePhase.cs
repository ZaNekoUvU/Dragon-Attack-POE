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

        bool playerOneTurn = true;//Riy Added
        bool deadDrag = false;

        int hpTwo;
        int attackTwo;
        int spAttackTwo;
        int blockAttackTwo;
        bool blockBoolTwo; //bool that will be used to determine if player two's dragon is defending
        
        //turn variable is used to keep track of which players turn it is
        int turn = 1; //turn is initialised to one so that player one may start the first turn
        int count = 0;

        string battleLog = ""; //battle log is a string that will be added to after each player's turn

        public BattlePhase(string[] p1Data, int[] p1Values , string[] p2Data, int[] p2Values)
        {
            InitializeComponent();
            
            //Riy added
            playerNameOne = p1Data[0];
            dragNameOne = p1Data[1];
            dragTypeOne = p1Data[2];

            hpOne = p1Values[0];
            attackOne = p1Values[1];
            spAttackOne = p1Values[2];
            blockAttackOne = p1Values[3];

            playerNameTwo = p2Data[0];
            dragNameTwo = p2Data[1];
            dragTypeTwo = p2Data[2];

            hpTwo = p2Values[0];
            attackTwo = p2Values[1];
            spAttackTwo = p2Values[2];
            blockAttackTwo = p2Values[3];

            initiative();
        }
        


        //the attack button is pressed and it ditermines which dragon attacks and ditermines if the other dragon is defending  
        private void attackBtn_Click(object sender, EventArgs e)
        {   //Riy added this
            playerTurn();
            if (playerOneTurn) 
            {
                if (blockBoolTwo) //true if player two's dragon is defending
                {
                    //attack is nullified if attack is less than the block stat of player two's dragon
                    if (blockAttackTwo >= attackOne)
                    {
                        battleLog += "The attack was nullified\r\n"; //saves string to battle log to be output into the battleLogTxt
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

                //outputs the data from the code ,onto the gui, after calculations have been made 
                hpLbl.Text = "Hp:" + hpTwo; //player two's dragon's hp stat is displayed
                playerTurnLbl.Text = dragNameTwo + "'s turn"; //displays that it is player two's turn
                opponentLbl.Text = playerNameOne + "'s details"; //displays player one's dragon's name into the opponentTxtbox area
                opponentDragLbl.Text = dragNameOne + "\r\nHp:" + hpOne; //displays player two's dragon's hp underneath its name

                //checks if player two's dragon is dead
                if (hpTwo <= 0)
                {
                    //adds the damage calculation and explains the event of this player's turn which results in player two's dragon's death. This is then added to the battleLog string variable
                    battleLog += dragNameOne + " attacks " + dragNameTwo + " for " + attackOne + " damage. " + dragNameTwo + " has 0 hp left\r\n" + dragNameTwo + " is dead. " + playerNameOne + " is the winner";
                    deadDrag = true;
                }
                else
                {
                    //adds the damage calculation and explains the event of this player's turn which is saved to the battleLog variable
                    battleLog += dragNameOne + " attacks " + dragNameTwo + " for " + attackOne + " damage. " + dragNameTwo + " has " + hpTwo + " hp left\r\n";
                }

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                turn++; // turn is incremented so that it is now player two's turn
                count++;
                turnChecker.Text = Convert.ToString(turn);
            }

            //Riy added this
            else if (!playerOneTurn)
            {
                if (blockBoolOne) //true if player one's dragon is defending
                {
                    //attack is nullified if attack is less than the block stat of player one's dragon
                    if (blockAttackOne >= attackTwo)
                    {
                        battleLog += "The attack was nullified\r\n"; //saves string to battle log to be output into the battleLogTxt
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

                //outputs the data from the code ,onto the gui, after calculations have been made 
                hpLbl.Text = "Hp:" + hpOne;//player one's dragon's hp stat is displayed
                playerTurnLbl.Text = dragNameOne + "'s turn"; //displays that it is player one's turn
                opponentLbl.Text = playerNameTwo + "'s details"; //displays player two's dragon's name into the opponentTxtbox area
                opponentDragLbl.Text = dragNameTwo + "\r\nHp:" + hpTwo; //displays player two's dragon's hp underneath its name

                //checks if player one's dragon is dead
                if (hpOne <= 0)
                {
                    //adds the damage calculation and explains the event of this player's turn which results in player one's dragon's death. This is then added to the battleLog string variable
                    battleLog += dragNameTwo + " attacks " + dragNameOne + " for " + attackTwo + " damage. " + dragNameOne + " has 0 hp left\r\n" + dragNameOne + " is dead. " + playerNameTwo + " is the winner";
                    deadDrag = true;
                }
                else
                {
                    //adds the damage calculation and explains the event of this player's turn which is saved to the battleLog variable
                    battleLog += dragNameTwo + " attacks " + dragNameOne + " for " + attackTwo + " damage. " + dragNameOne + " has " + hpOne + " hp left\r\n";
                }
                
                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt 

                turn--; // turn is decremented so that it is now player one's turn
                count++;
                turnChecker.Text = Convert.ToString(turn);
            }

            //Angus made the original roll checker things and Riyaad turned into the method.
            if (turn == 1 || turn == 2)
            {
                rollChecker();
            }
        }

        private void specialAttackBtn_Click(object sender, EventArgs e)
        {   
            //Riy added this
            playerTurn();

            if (playerOneTurn) 
            {
                if (blockBoolTwo) //true if player two's dragon is defending
                {
                    //special attack is nullified if special attack is less than the block stat of player two's dragon
                    if (blockAttackTwo >= spAttackOne)
                    {
                        battleLog += "The attack was nullified\r\n"; //saves string to battle log to be output into the battleLogTxt
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

                //outputs the data from the code ,onto the gui, after calculations have been made 
                hpLbl.Text = "Hp:" + hpTwo; //player two's dragon's hp stat is displayed
                playerTurnLbl.Text = dragNameTwo + "'s turn"; //displays that it is player two's turn
                opponentLbl.Text = playerNameOne + "'s details"; //displays player one's dragon's name into the opponentTxtbox area
                opponentDragLbl.Text = dragNameOne + "\r\nHp:" + hpOne; //displays player two's dragon's hp underneath its name

                //checks if player two's dragon is dead
                if (hpTwo <= 0)
                {
                    //adds the damage calculation and explains the event of this player's turn which results in player two's dragon's death. This is then added to the battleLog string variable
                    battleLog += dragNameOne + " special attacks " + dragNameTwo + ", for " + spAttackOne + " damage, paralyzing themself for the next turn. " + dragNameTwo + " has 0 hp left\r\n" + dragNameTwo + " is dead. " + playerNameOne +  " is the winner";
                    deadDrag = true;
                }
                else
                {
                    //adds the damage calculation and explains the event of this player's turn which is saved to the battleLog variable
                    battleLog += dragNameOne + " special attacks " + dragNameTwo + ", for " + spAttackOne + " damage, paralyzing themself for the next turn. " + dragNameTwo + " has " + hpTwo + " hp left\r\n";
                }

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                turn = turn + 3; //turn is incremented by 2 so that player two can have 2 turns
                count++;
                turnChecker.Text = Convert.ToString(turn);
            }

            //turn = 2 so it is player two's turn and thus uses players two's dragon's stats
            else if (!playerOneTurn)// turn is set to >= 2 because the turn variable can be set to 3 which gives player two a second turn
            {
                if (blockBoolOne) //true if player one's dragon is defending
                {
                    //special attack is nullified if special attack is less than the block stat of player one's dragon
                    if (blockAttackOne >= spAttackTwo)
                    {
                        battleLog += "The attack was nullified\r\n"; //saves string to battle log to be output into the battleLogTxt
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

                //outputs the data from the code ,onto the gui, after calculations have been made 
                hpLbl.Text = "Hp:" + hpOne;//player one's dragon's hp stat is displayed
                playerTurnLbl.Text = dragNameOne + "'s turn"; //displays that it is player one's turn
                opponentLbl.Text = playerNameTwo + "'s details"; //displays player two's dragon's name into the opponentTxtbox area
                opponentDragLbl.Text = dragNameTwo + "\r\nHp:" + hpTwo; //displays player two's dragon's hp underneath its name

                //checks if player one's dragon is dead
                if (hpOne <= 0)
                {
                    //adds the damage calculation and explains the event of this player's turn which results in player one's dragon's death. This is then added to the battleLog string variable
                    battleLog += dragNameTwo + " special attacks " + dragNameOne + ", for " + spAttackTwo + " damage, paralyzing themself for the next turn. " + dragNameOne + " has 0 hp left\r\n" + dragNameOne + " is dead. " + playerNameTwo + " is the winner"; ;
                    deadDrag = true;
                }
                else
                {
                    //adds the damage calculation and explains the event of this player's turn which is saved to the battleLog variable
                    battleLog += dragNameTwo + " special attacks " + dragNameOne + ", for " + spAttackTwo + " damage, paralyzing themself for the next turn. " + dragNameOne + " has " + hpOne + " hp left\r\n";
                }

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                turn = turn - 3; //turn is decremented by 2 so that player one can have 2 turns
                count++;
                turnChecker.Text = Convert.ToString(turn);
            }

            //Angus made the original roll checker things and Riyaad turned into the method.
            if (turn == 1 || turn == 2)
            {
                rollChecker();
            }
        }

        private void defendBtn_Click(object sender, EventArgs e)
        {
            //Riy added this
            playerTurn();

            if (playerOneTurn)
            {
                blockBoolOne = true; //this indicates that player one is defending
                blockBoolTwo = false;//this is in place so that player two's block wears off

                //outputs the data from the code ,onto the gui, after calculations have been made 
                hpLbl.Text = "Hp:" + hpTwo; //player two's dragon's hp stat is displayed
                playerTurnLbl.Text = dragNameTwo + "'s turn"; //displays that it is player two's turn
                opponentLbl.Text = playerNameOne + "'s details"; //displays player one's dragon's name into the opponentTxtbox area
                opponentDragLbl.Text = dragNameOne + "\r\nHp:" + hpOne; //displays player two's dragon's hp underneath its name

                //explains the event of this player's turn which is saved to the battleLog variable
                battleLog += dragNameOne + " defends against " + dragNameTwo + "\r\n";

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                turn++; // turn is incremented so that it is now player two's turn
                count++;
            }

            else if (!playerOneTurn)
            {
                blockBoolTwo = true; //this indicates that player two is defending
                blockBoolOne = false;//this is in place so that player one's block wears off

                //outputs the data from the code ,onto the gui, after calculations have been made 
                hpLbl.Text = "Hp:" + hpOne;//player one's dragon's hp stat is displayed
                playerTurnLbl.Text = dragNameOne + "'s turn"; //displays that it is player one's turn
                opponentLbl.Text = playerNameTwo + "'s details"; //displays player two's dragon's name into the opponentTxtbox area
                opponentDragLbl.Text = dragNameTwo + "\r\nHp:" + hpTwo; //displays player two's dragon's hp underneath its name

                //explains the event of this player's turn which is saved to the battleLog variable
                battleLog += dragNameTwo + " defends against " + dragNameOne + "\r\n";

                battleLogTxt.Text = battleLog; //the string that was saved to the battle log is ouputed to battleLogTxt

                turn--; // turn is decremented so that it is now player one's turn
                count++;
            }

            //Angus made the original roll checker things and Riyaad turned into the method.
            if (turn == 1 || turn == 2)
            {
                rollChecker();
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GADE5121_POE_Riyaad_Angus1 form1 = new GADE5121_POE_Riyaad_Angus1();
            form1.ShowDialog();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            //Riy added this
            if (deadDrag)
            {
                MessageBox.Show("Game Over");
            }

            else
            {
                initiative();
            }
        }

        public void rollChecker()
        {
            if (count >= 2)
            {
                rollBtn.Enabled = true;

                attackBtn.Enabled = false;
                spAttackBtn.Enabled = false;
                blockBtn.Enabled = false;
                count = 0;
            }
        }
        
        public void initiative()
        {
            //Angus made majority with some changes by Riyaad
            int rollCount = 0;
            int initiativeRollOne = 0;
            int initiativeRollTwo = 0;

            if (rollCount == 0)
            {
                Random rollOne = new Random();
                initiativeRollOne = rollOne.Next(1, 7);
                rollCount++;
                rollLbl.Text = "Player 2";
                battleLogTxt.Text += "Player One rolls for: " + initiativeRollOne + "\r\n"; //this clears after we start ao
            }

            if (rollCount == 1)
            {
                Random rollTwo = new Random();
                initiativeRollTwo = rollTwo.Next(1, 7);
                rollCount--;
                rollLbl.Text = "Player 1";
                battleLogTxt.Text += "Player Two rolls for: " + initiativeRollTwo + "\r\n";
            }

            if (initiativeRollOne > initiativeRollTwo)
            {
                turn = 1;
                rollBtn.Enabled = false;

                battleLogTxt.Text = "It is player 1's turn"; //Riy added 

                attackBtn.Enabled = true;
                spAttackBtn.Enabled = true;
                blockBtn.Enabled = true;
            }

            if (initiativeRollOne < initiativeRollTwo)
            {
                turn = 2;
                rollBtn.Enabled = false;

                battleLogTxt.Text = "It is player 2's turn"; //Riy added 

                attackBtn.Enabled = true;
                spAttackBtn.Enabled = true;
                blockBtn.Enabled = true;
            }
        }
        
        //Riy added this
        public void playerTurn()
        {   
            //turn = 1 so it is player one's turn and thus uses players one's dragon's stats
            if (turn <= 1) // turn is set to <= 1 because the turn variable can be set to 0 which gives player one a second turn
            {
                playerOneTurn = true;
            }
            else
            {
                playerOneTurn = false;
            }
        }
    }
}


//blockBool = true;
//if(block)
//{
//if (defense > attack)
//{
// textBox.text = "The attack was nullified";
//}
//else if (attack > defense)
//{
//(defense + hp) - attack;  
//}
//else
//{
//hp - attack;
//}
//
//}





//this.Hide();
//Form2 form2 = new Form2();
//form2.ShowDialog();