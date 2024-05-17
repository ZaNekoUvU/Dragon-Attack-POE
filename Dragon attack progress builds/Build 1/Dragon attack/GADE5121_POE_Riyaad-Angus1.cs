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

        string fireDrag = "Fire Dragon";
        string iceDrag = "Ice Dragon";
        string windDrag = "Wind Dragon";
        string earthDrag = "Earth Dragon";

        int hpOne = 0;
        int attackOne = 0;
        int spAttackOne = 0;
        int blockOne = 0;

        int hpTwo = 0;
        int attackTwo = 0;
        int spAttackTwo = 0;
        int blockTwo = 0;

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
        {
            if (FireDragonCheck.Checked)
            {
                dragTypeOne = fireDrag;
                //textBox1.Text = fireDrag;

                hpOne = 20;
                attackOne = 5;
                spAttackOne = 12;
                blockOne = 4;

                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
                IceDragonCheck.Checked = false;
            }
        }

        private void IceDragonCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (IceDragonCheck.Checked)
            {
                dragTypeOne = iceDrag;
                hpOne = 30;
                attackOne = 4;
                spAttackOne = 9;
                blockOne = 5;

                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
        }

        private void WindDragonCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WindDragonCheck.Checked)
            {
                dragTypeOne = windDrag;
                hpOne = 40;
                attackOne = 3;
                spAttackOne = 7;
                blockOne = 5;

                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
        }

        private void EarthDragonCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (EarthDragonCheck.Checked)
            {
                dragTypeOne = earthDrag;
                hpOne = 50;
                attackOne = 2;
                spAttackOne = 5;
                blockOne = 6;

                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: " + attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: " + blockOne;
            }
        }

        private void PlayerNametbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DragonNametbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void IceDragonCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (IceDragonCheck2.Checked)
            {
                dragTypeTwo = iceDrag;
                hpTwo = 30;
                attackTwo = 4;
                spAttackTwo = 9;
                blockTwo = 5;

                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }

        private void WindDragonCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (WindDragonCheck2.Checked)
            {
                dragTypeTwo = windDrag;
                hpTwo = 40;
                attackTwo = 3;
                spAttackTwo = 7;
                blockTwo = 5;

                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }

        private void FireDragonCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (FireDragonCheck2.Checked)
            {
                dragTypeTwo = fireDrag;
                hpTwo = 20;
                attackTwo = 5;
                spAttackTwo = 12;
                blockTwo = 4;

                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }

        private void EarthDragonCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (EarthDragonCheck2.Checked)
            {
                dragTypeTwo = earthDrag;
                hpTwo = 50;
                attackTwo = 2;
                spAttackTwo = 5;
                blockTwo = 6;

                StatTextBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }

        private void StatTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveCharButton_Click(object sender, EventArgs e)
        {
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

        private void SaveCharButton2_Click(object sender, EventArgs e)
        {
            playerNameTwo = PlayerNametbx2.Text;
            dragNameTwo = DragonNametbx2.Text;
            SaveCharButton2.Enabled = false;
            playerTwoInfo = true;
            saveValues(playerNameTwo, dragNameTwo, dragTypeTwo, hpTwo, attackTwo, spAttackTwo, blockTwo);
            enableStartTwo = true;
            
            if (enableStartOne && enableStartTwo)
            {
                StartButton.Enabled = true;
                StartButton.Text = "Start";
            }
        }

        public void saveValues(string playerName, string dragName, string dragType, int hp, int attack, int spAttack, int block)
        {
            if (playerOneInfo == true)
            {
                p1Data[0] = playerName;
                p1Data[1] = dragName;
                p1Data[2] = dragTypeOne;

                p1Values[0] = hpOne;
                p1Values[1] = attackOne;
                p1Values[2] = spAttackOne;
                p1Values[3] = blockOne;
                playerOneInfo = false;
            }

            if (playerTwoInfo == true)
            {
                p2Data[0] = playerName;
                p2Data[1] = dragName;
                p2Data[2] = dragTypeTwo;

                p2Values[0] = hpTwo;
                p2Values[1] = attackTwo;
                p2Values[2] = spAttackTwo;
                p2Values[3] = blockTwo;
                playerTwoInfo = false;
            }

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BattlePhase form2 = new BattlePhase(p1Data, p1Values , p2Data, p2Values);
            form2.ShowDialog();
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