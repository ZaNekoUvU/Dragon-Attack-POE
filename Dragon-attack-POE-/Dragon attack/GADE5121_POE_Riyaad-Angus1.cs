using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dragon_attack
{
    public partial class GADE5121_POE_Riyaad_Angus1 : Form
    {
        //Variables to name players in the textboxes and are saved to the array p1data[]
        string playerNameOne;
        string playerNameTwo;

        //Variables to name players' dragons in the textboxes and are saved to the array p1data[]
        string dragNameOne;
        string dragNameTwo;

        //Variables to call what type of dragon is chosen and they are saved to the array p1data[]
        string dragTypeOne;
        string dragTypeTwo;

        //variables to call the sizes of the arrays p1Data, p2Data and the arrays p1Values, p2Values 
        static int sizeData = 3;
        static int sizeValues = 4;

        string[] p1Data = new string[sizeData]; //array to store the player one's data
        int[] p1Values = new int[sizeValues]; //array to store the player one's dragon's stats

        string[] p2Data = new string[sizeData]; //array to store the player two's data
        int[] p2Values = new int[sizeValues]; //array to store the player two's dragon's stats

        //Declared constants for the types of dragons
        const string fireDrag = "Fire Dragon";
        const string iceDrag = "Ice Dragon";
        const string windDrag = "Wind Dragon";
        const string earthDrag = "Earth Dragon";

        //Region used to keep things organized
        #region Dragon Stats Const

        //the variables for player one's dragon's stats all declared to 0 to be changed depending on the dragon type
        int hpOne = 0;
        int attackOne = 0;
        int spAttackOne = 0;
        int blockOne = 0;

        //the variables for player two's dragon's stats all declared to 0 to be changed depending on the dragon type
        int hpTwo = 0;
        int attackTwo = 0;
        int spAttackTwo = 0;
        int blockTwo = 0;
        
        //Constants of each individual dragon types' stats
        const int iceDragHp = 30;
        const int iceDragAttack = 4;
        const int iceDragSPAttack = 9;
        const int iceDragBlock = 5;

        const int fireDragHp = 20;
        const int fireDragAttack = 5;
        const int fireDragSPAttack = 12;
        const int fireDragBlock = 4;

        const int windDragHp = 40;
        const int windDragAttack = 3;
        const int windDragSPAttack = 7;
        const int windDragBlock = 5;

        const int earthDragHp = 50;
        const int earthDragAttack = 2;
        const int earthDragSPAttack = 5;
        const int earthDragBlock = 6;
        #endregion

        //boolean variables used later to check if information is there for the players. If true it assigns those values to the arrays
        bool playerOneInfo = false;
        bool playerTwoInfo = false;

        //Boolean variables used to check if both save buttons have been clicked. This then allows the start button to be enabled
        bool enableStartOne = false;
        bool enableStartTwo = false;

        public GADE5121_POE_Riyaad_Angus1()
        {
            InitializeComponent();
        }

        //This runs if the fire dragon checkbox, from player one's set of checkboxes, is checked
        private void FireDragonCheck_CheckedChanged(object sender, EventArgs e)
        #region FireDragonCheck1
        {
            if (FireDragonCheck.Checked) //this checks the first check box set for an option fire dragon and compares if it is checked or not 
            {
                //assigns the varaible for the dragon type of player one
                dragTypeOne = fireDrag;

                //assigning the stats that will be passed to the array based on which dragon type it is
                hpOne = fireDragHp;
                attackOne = fireDragAttack;
                spAttackOne = fireDragSPAttack;
                blockOne = fireDragBlock;

                //Ensures that none of the other dragons information is true. This deselects the previous dragon's checkbox that the user may have chosen. This ensures that no information overlaps and that no confusion is caused for the player.
                WindDragonCheck.Checked = false;
                IceDragonCheck.Checked = false;
                EarthDragonCheck.Checked = false;

                SaveCharButton.Enabled = true; //Enables the save button so that the player can save all the information entered as well as their dragon type.

                //shows the stats of the fire dragon in the stats text box below.
                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
        }
        #endregion

        //This runs if the ice dragon checkbox, from player one's set of checkboxes, is checked
        private void IceDragonCheck_CheckedChanged(object sender, EventArgs e)
        #region IceDragonCheck1
        {
            if (IceDragonCheck.Checked) //this checks the first check box set for an option ice dragon and compares if it is checked or not 
            {
                //assigns the varaible for the dragon type of player one
                dragTypeOne = iceDrag;

                //assigning the stats that will be passed to the array based on which dragon type it is
                hpOne = iceDragHp;
                attackOne = iceDragAttack;
                spAttackOne = iceDragSPAttack;
                blockOne = iceDragBlock;

                //Ensures that none of the other dragons information is true. This deselects the previous dragon's checkbox that the user may have chosen. This ensures that no information overlaps and that no confusion is caused for the player.
                WindDragonCheck.Checked = false;
                EarthDragonCheck.Checked = false;
                FireDragonCheck.Checked = false;

                SaveCharButton.Enabled = true; //Enables the save button so that the player can save all the information entered as well as their dragon type.

                //shows the stats of the ice dragon in the stat text box below.
                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
        }
        #endregion

        //This runs if the wind dragon checkbox, from player one's set of checkboxes, is checked
        private void WindDragonCheck_CheckedChanged(object sender, EventArgs e)
        #region WindDragonCheck1
        {
            if (WindDragonCheck.Checked) //this checks the first check box set for an option wind dragon and compares if it is checked or not 
            {
                //assigns the varaible for the dragon type of player one
                dragTypeOne = windDrag;

                //assigning the stats that will be passed to the array based on which dragon type it is
                hpOne = windDragHp;
                attackOne = windDragAttack;
                spAttackOne = windDragSPAttack;
                blockOne = windDragBlock;

                //Ensures that none of the other dragons information is true. This deselects the previous dragon's checkbox that the user may have chosen. This ensures that no information overlaps and that no confusion is caused for the player.
                EarthDragonCheck.Checked = false;
                IceDragonCheck.Checked = false;
                FireDragonCheck.Checked = false;

                SaveCharButton.Enabled = true; //Enables the save button so that the player can save all the information entered as well as their dragon type.

                //shows the stats of the wind dragon in the stat text box below.
                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
        }
        #endregion

        //This runs if the earth dragon checkbox, from player one's set of checkboxes, is checked
        private void EarthDragonCheck_CheckedChanged(object sender, EventArgs e)
        #region EarthDragonCheck1
        {
            if (EarthDragonCheck.Checked) //this checks the first check box set for an option earth dragon and compares if it is checked or not 
            {
                //assigns the varaible for the dragon type of player one
                dragTypeOne = earthDrag;

                //assigning the stats that will be passed to the array based on which dragon type it is
                hpOne = earthDragHp;
                attackOne = earthDragAttack;
                spAttackOne = earthDragSPAttack;
                blockOne = earthDragBlock;

                //Ensures that none of the other dragons information is true. This deselects the previous dragon's checkbox that the user may have chosen. This ensures that no information overlaps and that no confusion is caused for the player.
                WindDragonCheck.Checked = false;
                IceDragonCheck.Checked = false;
                FireDragonCheck.Checked = false;

                SaveCharButton.Enabled = true; //Enables the save button so that the player can save all the information entered as well as their dragon type.

                //shows the stats of the earth dragon in the stat text box below.
                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
            
        }
        #endregion

        //This runs if the ice dragon checkbox, from player two's set of checkboxes, is checked
        private void IceDragonCheck2_CheckedChanged(object sender, EventArgs e)
        #region IceDragonCheck2
        {
            if (IceDragonCheck2.Checked) //this checks the second check box set for an option ice dragon and compares if it is checked or not 
            {
                //assigns the varaible for the dragon type of player two
                dragTypeTwo = iceDrag;

                //assigning the stats that will be passed to the array based on which dragon type it is
                hpTwo = iceDragHp;
                attackTwo = iceDragAttack;
                spAttackTwo = iceDragSPAttack;
                blockTwo = iceDragBlock;

                //Ensures that none of the other dragons information is true. This deselects the previous dragon that the user may have chosen. This ensures that no information overlaps and that no confusion is caused for the player.
                WindDragonCheck2.Checked = false;
                EarthDragonCheck2.Checked = false;
                FireDragonCheck2.Checked = false;

                SaveCharButton2.Enabled = true; //Enables the save button so that the player can save all the information entered as well as their dragon type.

                //shows the stats of the ice dragon in the stat text box below.
                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }
        #endregion

        //This runs if the wind dragon checkbox, from player two's set of checkboxes, is checked
        private void WindDragonCheck2_CheckedChanged(object sender, EventArgs e)
        #region WindDragonCheck2
        {
            if (WindDragonCheck2.Checked) //this checks the second check box set for an option wind dragon and compares if it is checked or not
            {   
                //assigns the varaible for the dragon type of player two
                dragTypeTwo = windDrag;

                //assigning the stats that will be passed to the array based on which dragon type it is
                hpTwo = windDragHp;
                attackTwo = windDragAttack;
                spAttackTwo = windDragSPAttack;
                blockTwo = windDragBlock;

                //Ensures that none of the other dragons information is true. This deselects the previous dragon that the user may have chosen. This ensures that no information overlaps and that no confusion is caused for the player.
                IceDragonCheck2.Checked = false;
                EarthDragonCheck2.Checked = false;
                FireDragonCheck2.Checked = false;

                SaveCharButton2.Enabled = true; //Enables the save button so that the player can save all the information entered as well as their dragon type.

                //shows the stats of the wind dragon in the stat text box below.
                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }
        #endregion

        //This runs if the fire dragon checkbox, from player two's set of checkboxes, is checked
        private void FireDragonCheck2_CheckedChanged(object sender, EventArgs e)
        #region FireDragonCheck2
        {
            if (FireDragonCheck2.Checked) //this checks the second check box set for an option fire dragon and compares if it is checked or not
            {
                //assigns the varaible for the dragon type of player two
                dragTypeTwo = fireDrag;

                //assigning the stats that will be passed to the array based on which dragon type it is
                hpTwo = fireDragHp;
                attackTwo = fireDragAttack;
                spAttackTwo = fireDragSPAttack;
                blockTwo = fireDragBlock;

                //Ensures that none of the other dragons information is true. This deselects the previous dragon that the user may have chosen. This ensures that no information overlaps and that no confusion is caused for the player.
                IceDragonCheck2.Checked = false;
                EarthDragonCheck2.Checked = false;
                WindDragonCheck2.Checked = false;

                SaveCharButton2.Enabled = true; //Enables the save button so that the player can save all the information entered as well as their dragon type.

                //shows the stats of the fire dragon in the stat text box below.
                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }
        #endregion

        //This runs if the earth dragon checkbox, from player two's set of checkboxes, is checked
        private void EarthDragonCheck2_CheckedChanged(object sender, EventArgs e)
        #region EarthDragonCheck2
        {
            if (EarthDragonCheck2.Checked) //this checks the second check box set for an option Earth dragon and compares if it is checked or not
            {
                //assigns the varaible for the dragon type of player two
                dragTypeTwo = earthDrag;

                //assigning the stats that will be passed to the array based on which dragon type it is
                hpTwo = earthDragHp;
                attackTwo = earthDragAttack;
                spAttackTwo = earthDragSPAttack;
                blockTwo = earthDragBlock;

                //Ensures that none of the other dragons information is true. This deselects the previous dragon that the user may have chosen. This ensures that no information overlaps and that no confusion is caused for the player.
                IceDragonCheck2.Checked = false;
                WindDragonCheck2.Checked = false;
                FireDragonCheck2.Checked = false;

                SaveCharButton2.Enabled = true; //Enables the save button so that the player can save all the information entered as well as their dragon type.

                //shows the stats of the earth dragon in the stat text box below.
                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }
        #endregion

        private void StatTextBox2_TextChanged(object sender, EventArgs e)
        #region StatTextBox2
        {

        }
        #endregion

        //This runs when the first save button is clicked
        private void SaveCharButton_Click(object sender, EventArgs e)
        #region SaveButton1
        {

            playerNameOne = PlayerNametbx.Text; //text in player one's textbox, which will be their chosen name, is saved to this variable
            dragNameOne = DragonNametbx.Text; //text in player one's textbox, which will be their chosen dragon's name, is saved to this variable

            //if statement to check if player one has inserted a name for themself and their dragon
            if (playerNameOne == "" || dragNameOne == "")
            {
                //display message box to prompt the player to fill in empty textboxes
                MessageBox.Show("Please enter your name and a name for your dragon");
                return;
            }

            // this runs if the player has filled in their name and dragon's name
            else
            {
                SaveCharButton.Enabled = false; //This disables the save button
                playerOneInfo = true; //This boolean allows the player's information to be saved to an array

                //passes the variables to the saveValues method 
                saveValues(playerNameOne, dragNameOne, dragTypeOne, hpOne, attackOne, spAttackOne, blockOne);
                enableStartOne = true; //boolean becomes true so that later the start button may become active
            }

            //if both boolean variables for the save buttons are true the start button becomes enabled
            if (enableStartOne && enableStartTwo)
            {
                StartButton.Enabled = true;
                StartButton.Text = "Start";
            }
        }
        #endregion

        //This runs when the second save button is clicked
        private void SaveCharButton2_Click(object sender, EventArgs e)
        #region SaveButton2
        {
            playerNameTwo = PlayerNametbx2.Text; //text in player two's textbox, which will be their chosen name, is saved to this variable
            dragNameTwo = DragonNametbx2.Text; //text in player one's textbox, which will be their chosen dragon's name, is saved to this variable

            //if statement to check if player two has inserted a name for themself and their dragon
            if (playerNameTwo == "" || dragNameTwo == "")
            {
                //display message box to prompt the player to fill in empty textboxes
                MessageBox.Show("Please enter your name and a name for your dragon");
                return;
            }

            // this runs if the player has filled in their name and dragon's name
            else
            {
                SaveCharButton2.Enabled = false; //This disables the save button
                playerTwoInfo = true; //This boolean allows the player's information to be saved to an array

                saveValues(playerNameTwo, dragNameTwo, dragTypeTwo, hpTwo, attackTwo, spAttackTwo, blockTwo);
                enableStartTwo = true; //boolean becomes true so that later the start button may become active
            }

            //if both boolean variables for the save buttons are true the start button becomes enabled
            if (enableStartOne && enableStartTwo)
            {
                StartButton.Enabled = true;
                StartButton.Text = "Start";
            }
        }
        #endregion

        public void saveValues(string playerName, string dragName, string dragType, int hp, int attack, int spAttack, int block)
        #region SaveValues()
        {
            //This boolean becomes true if the first save button is pressed
            if (playerOneInfo)
            {
                //populates array with the information the player entered for their name and their dragon's info 
                p1Data[0] = playerName;
                p1Data[1] = dragName;
                p1Data[2] = dragType;

                //populates array with the dragon's stats
                p1Values[0] = hp;
                p1Values[1] = attack;
                p1Values[2] = spAttack;
                p1Values[3] = block;

                //This becomes false so that the second time this method is called, this ensures that the if statement will not run
                playerOneInfo = false;
            }

            if (playerTwoInfo)
            {
                //populates array with the information the player entered for their name and their dragon's info
                p2Data[0] = playerName;
                p2Data[1] = dragName;
                p2Data[2] = dragType;

                //populates array with the dragon's stats
                p2Values[0] = hp;
                p2Values[1] = attack;
                p2Values[2] = spAttack;
                p2Values[3] = block;

                //This becomes false so that the second time this method is called, this ensures that the if statement will not run
                playerTwoInfo = false;
            }

        }
        #endregion

        //This runs when the start button is clicked
        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides this form 
            BattlePhase form2 = new BattlePhase(p1Data , p1Values , p2Data , p2Values); //creates a new instance of the form
            form2.ShowDialog(); //shows the new form
        }

        #region textBox&Btn&Lbl

        private void PlayerNametbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DragonNametbx2_TextChanged(object sender, EventArgs e)
        {

        }


        private void PlayerNametbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void DragonNametbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FireDragonPng_Click_1(object sender, EventArgs e)
        {

        }

        private void EarthDragonLabel_Click(object sender, EventArgs e)
        {

        }

        private void IceDragonLabel_Click(object sender, EventArgs e)
        {

        }

        private void WindDragonPng_Click(object sender, EventArgs e)
        {

        }

        private void PlayerNameLabel2_Click(object sender, EventArgs e)
        {

        }

        private void DragonNameLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void DragonNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void WindDragonLabel_Click(object sender, EventArgs e)
        {

        }

        private void IceDragonPng_Click(object sender, EventArgs e)
        {

        }

        private void EarthDragonPng_Click(object sender, EventArgs e)
        {

        }

        private void FireDragonLabel_Click(object sender, EventArgs e)
        {

        }

        private void TestBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
