using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $rootnamespace$
{
    public partial class $safeitemname$ : Form
    {
        string boxWord = "Yes";

        string playerNameOne;
        string playerNameTwo;

        string dragNameOne;
        string dragNameTwo;

        string dragTypeOne;
        string dragTypeTwo;

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

        public $safeitemname$()
        {
            InitializeComponent();
        }

        private void PlayerNametbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

                StatTextBox1.Text = "Hit Points: " + hpOne + "\r\n" + "Attack: "+ attackOne + "\r\n" + "Special Attack: " + spAttackOne + "\r\n" + "Block: "+ blockOne;
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

                textBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
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

                textBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
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

                textBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
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

                textBox2.Text = "Hit Points: " + hpTwo + "\r\n" + "Attack: " + attackTwo + "\r\n" + "Special Attack: " + spAttackTwo + "\r\n" + "Block: " + blockTwo;
            }
        }

        private void StatTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void SaveCharButton_Click(object sender, EventArgs e)
        {
            playerNameOne = PlayerNametbx.Text;
            dragNameOne = DragonNametbx.Text;
        }

        private void SaveCharButton2_Click(object sender, EventArgs e)
        {
            playerNameTwo = PlayerNametbx2.Text;
            dragNameTwo = DragonNametbx2.Text;
        }



        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void DragonNametbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//int hp = 0;
//int attack = 0;
//int spAttack = 0;
//int block = 0;