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


        string playerNameOne;
        string playerNameTwo;

        string dragNameOne;
        string dragNameTwo;

        string dragTypeOne;
        string dragTypeTwo;

        string[] p1Data = new string[3];
        int[] p1Values = new int[4];

        string[] p2Data = new string[3];
        int[] p2Values = new int[4];

        const string fireDrag = "Fire Dragon";
        const string iceDrag = "Ice Dragon";
        const string windDrag = "Wind Dragon";
        const string earthDrag = "Earth Dragon";

        #region Dragon Stats Const
        int hpOne = 0;
        int attackOne = 0;
        int spAttackOne = 0;
        int blockOne = 0;

        int hpTwo = 0;
        int attackTwo = 0;
        int spAttackTwo = 0;
        int blockTwo = 0;
        
        //Angus added to create Constants
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

        bool playerOneInfo = false;
        bool playerTwoInfo = false;

        bool enableStartOne = false;
        bool enableStartTwo = false;

        public GADE5121_POE_Riyaad_Angus1()
        {
            InitializeComponent();
            
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

        private void FireDragonCheck_CheckedChanged(object sender, EventArgs e)
        #region FireDragonCheck1
        {
            //Angus Fixed since origianl instance
            if (FireDragonCheck.Checked)
            {
                dragTypeOne = fireDrag;
                //textBox1.Text = fireDrag;

                hpOne = fireDragHp;
                attackOne = fireDragAttack;
                spAttackOne = fireDragSPAttack;
                blockOne = fireDragBlock;

                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
        }
        #endregion

        private void IceDragonCheck_CheckedChanged(object sender, EventArgs e)
        #region IceDragonCheck1
        {
            //Angus Fixed since origianl instance
            if (IceDragonCheck.Checked)
            {
                dragTypeOne = iceDrag;
                hpOne = iceDragHp;
                attackOne = iceDragAttack;
                spAttackOne = iceDragSPAttack;
                blockOne = iceDragBlock;

                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
        }
        #endregion

        private void WindDragonCheck_CheckedChanged(object sender, EventArgs e)
        #region WindDragonCheck1
        {
            //Angus Fixed since origianl instance
            if (WindDragonCheck.Checked)
            {
                dragTypeOne = windDrag;
                hpOne = windDragHp;
                attackOne = windDragAttack;
                spAttackOne = windDragSPAttack;
                blockOne = windDragBlock;

                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
        }
        #endregion

        private void EarthDragonCheck_CheckedChanged(object sender, EventArgs e)
        #region EarthDragonCheck1
        {
            //Angus Fixed since origianl instance
            if (EarthDragonCheck.Checked)
            {
                dragTypeOne = earthDrag;
                hpOne = earthDragHp;
                attackOne = earthDragAttack;
                spAttackOne = earthDragSPAttack;
                blockOne = earthDragBlock;

                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
        }
        #endregion

        private void PlayerNametbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DragonNametbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void IceDragonCheck2_CheckedChanged(object sender, EventArgs e)
        #region IceDragonCheck2
        {
            //Angus Fixed since origianl instance
            if (IceDragonCheck2.Checked)
            {
                dragTypeTwo = iceDrag;

                hpTwo = iceDragHp;
                attackTwo = iceDragAttack;
                spAttackTwo = iceDragSPAttack;
                blockTwo = iceDragBlock;

                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }
        #endregion

        private void WindDragonCheck2_CheckedChanged(object sender, EventArgs e)
        #region WindDragonCheck2
        {
            //Angus Fixed since origianl instance
            if (WindDragonCheck2.Checked)
            {
                dragTypeTwo = windDrag;

                hpTwo = windDragHp;
                attackTwo = windDragAttack;
                spAttackTwo = windDragSPAttack;
                blockTwo = windDragBlock;

                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }
        #endregion

        private void FireDragonCheck2_CheckedChanged(object sender, EventArgs e)
        #region FireDragonCheck2
        {
            //Angus Fixed since origianl instance
            if (FireDragonCheck2.Checked)
            {
                dragTypeTwo = fireDrag;

                hpTwo = fireDragHp;
                attackTwo = fireDragAttack;
                spAttackTwo = fireDragSPAttack;
                blockTwo = fireDragBlock;

                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }
        #endregion

        private void EarthDragonCheck2_CheckedChanged(object sender, EventArgs e)
        #region EarthDragonCheck2
        {
            //Angus Fixed since origianl instance
            if (EarthDragonCheck2.Checked)
            {
                dragTypeTwo = earthDrag;

                hpTwo = earthDragHp;
                attackTwo = earthDragAttack;
                spAttackTwo = earthDragSPAttack;
                blockTwo = earthDragBlock;

                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }
        #endregion

        private void StatTextBox2_TextChanged(object sender, EventArgs e)
        #region StatTextBox2
        {

        }
        #endregion

        private void SaveCharButton_Click(object sender, EventArgs e)
        #region SaveButton1
        {
            //angus and riy worked on together
            playerNameOne = PlayerNametbx.Text;
            dragNameOne = DragonNametbx.Text;

            SaveCharButton.Enabled = false;
            playerOneInfo = true;

            saveValues(playerNameOne, dragNameOne, dragTypeOne, hpOne, attackOne, spAttackOne, blockOne);
            enableStartOne = true;

            if (enableStartOne && enableStartTwo)
            {
                StartButton.Enabled = true;
                StartButton.Text = "Start";
            }
        }
        #endregion

        private void SaveCharButton2_Click(object sender, EventArgs e)
        #region SaveButton2
        {
            //angus and riy worked on together
            playerNameTwo = PlayerNametbx2.Text;
            dragNameTwo = DragonNametbx2.Text;

            SaveCharButton2.Enabled = false;
            playerTwoInfo = true;

            saveValues(playerNameTwo, dragNameTwo, dragTypeTwo, hpTwo, attackTwo, spAttackTwo, blockTwo);
            enableStartTwo = true;
            
            //Riy added
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
            //Angus and Riyaad worked at the same time to make this
            if (playerOneInfo == true)
            {
                p1Data[0] = playerName;
                p1Data[1] = dragName;
                p1Data[2] = dragType;

                p1Values[0] = hp;
                p1Values[1] = attack;
                p1Values[2] = spAttack;
                p1Values[3] = block;

                playerOneInfo = false;
            }

            if (playerTwoInfo == true)
            {
                p2Data[0] = playerName;
                p2Data[1] = dragName;
                p2Data[2] = dragType;

                p2Values[0] = hp;
                p2Values[1] = attack;
                p2Values[2] = spAttack;
                p2Values[3] = block;

                playerTwoInfo = false;
            }

        }
        #endregion
        private void StartButton_Click(object sender, EventArgs e)
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
    }
}

//int hp = 0;
//int attack = 0;
//int spAttack = 0;
//int block = 0;